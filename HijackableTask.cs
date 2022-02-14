using System.Collections.Generic;
using Microsoft.Win32;


namespace SharpComHijack
{
    public sealed class HijackableTask : SharpSploitResult
    {
        public string Name { get; set; }
        public string Guid { get; set; }
        public string Trigger { get; set; }
        public string Path { get; set; }
        public string RegistryKey { get; set; }


        protected internal override IList<SharpSploitResultProperty> ResultProperties => new List<SharpSploitResultProperty>
        {
            new SharpSploitResultProperty{Name = nameof(Name),Value = Name},
            new SharpSploitResultProperty{Name = nameof(Guid),Value = Guid},
            //new SharpSploitResultProperty{Name = nameof(Trigger),Value = Trigger},
            new SharpSploitResultProperty{Name = nameof(Path),Value = Path},
            new SharpSploitResultProperty{Name = nameof(RegistryKey),Value = RegistryKey},

        };

        public bool CheckIfHijackable() 
        {
            string registryPath = $"SOFTWARE\\Classes\\CLSID\\{Guid}\\InProcServer32";
            RegistryKey comObjKey = Registry.CurrentUser.OpenSubKey(registryPath);
            if (comObjKey == null)
            {
                // get key from hklm to get dll path.
                RegistryKey LMcomObjKey = Registry.LocalMachine.OpenSubKey(registryPath);
                if (LMcomObjKey == null)
                    return false;
                if (LMcomObjKey.GetValue("") == null)
                    return false;
                // setting dll path
                Path = LMcomObjKey.GetValue("").ToString().Trim();
                RegistryKey = registryPath;
                return true;
            }
            return false;
        }
    }
}
