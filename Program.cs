using System.Collections.Generic;
using Microsoft.Win32.TaskScheduler;

namespace SharpComHijack
{
    public static class Program
    {
        public static List<Task> availableTasks = new List<Task>();

        public static void EnumAllTasks()
        {
            TaskFolder fld = TaskService.Instance.RootFolder;
            foreach (Task task in fld.Tasks)
                if (ActOnTask(task) == true)
                    availableTasks.Add(task);
            foreach (TaskFolder sfld in fld.SubFolders)
                EnumFolderTasks(sfld);
        }

        public static bool ActOnTask(Task t) {
            if(CheckIfComHandler(t) && CheckForTriggers(t))
                return true;
            return false;
        }

        public static bool CheckForTriggers(Task t)
        {
            foreach (Trigger tr in t.Definition.Triggers)
            {
                if (tr.TriggerType == TaskTriggerType.Logon)
                    return true;
            }
            return false;
        }
        public static bool CheckIfComHandler (Task t)
        {
            foreach (Microsoft.Win32.TaskScheduler.Action a in t.Definition.Actions)
            {
                if (a.ActionType == Microsoft.Win32.TaskScheduler.TaskActionType.ComHandler)
                    return true;
            }
            return false;
        }
        public static void EnumFolderTasks(TaskFolder fld)
        {
            foreach (Task task in fld.Tasks)
                if (ActOnTask(task))
                    availableTasks.Add(task);
            foreach (TaskFolder sfld in fld.SubFolders)
                EnumFolderTasks(sfld);
        }

        public static string GetPotentialTargets()
        {
            EnumAllTasks();
            var targets = new SharpSploitResultList<HijackableTask>();
            foreach (Task t in availableTasks)
            {
                HijackableTask hijack = new HijackableTask();
                hijack.Name = t.Name.Trim();
                string[] guidArray = t.Definition.XmlText.Split(new string[] { "<ClassId>" }, System.StringSplitOptions.None);
                string[] guidArrayBetter = guidArray[1].Split(new string[] { "</ClassId>" }, System.StringSplitOptions.None);
                hijack.Guid = guidArrayBetter[0];
                string triggers = "";
                foreach (Trigger tr in t.Definition.Triggers)
                {
                    triggers += tr.ToString().Trim();
                }
                hijack.Trigger = triggers;
                if (hijack.CheckIfHijackable())
                {
                    targets.Add(hijack);
                }
            }
            return targets.ToString();
        }
        public static void Main(string[] args)
        {
            string targets = GetPotentialTargets();
            System.Console.WriteLine(targets);
        }
    }
}
