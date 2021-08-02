using System;

namespace sandbox
{
    public class BeautifulUser
    {
        public string Uid { get; }
        public string Name { get; }
        public string Email { get; }
        public bool CanWrite { get; }
        public bool CanRead { get; }
        public bool CanManage {get; }
        public bool CanAccessPersonalSettings { get; }
        public bool CanAccessAdminSettings { get; }
        public bool CanAccessSiteSettings { get; }

        public BeautifulUser(UserBuilder builder)
        {
            Uid = GenerateUid();
            Name = builder.Name;
            Email = builder.Email;
            CanWrite = builder.CanWrite;
            CanRead = builder.CanRead;
            CanManage = builder.CanManage;
            CanAccessPersonalSettings = builder.CanAccessPersonalSettings;
            CanAccessAdminSettings = builder.CanAccessAdminSettings;
            CanAccessSiteSettings = builder.CanAccessSiteSettings;
        }

        private string GenerateUid()
        {
            return Guid.NewGuid().ToString();
        }
    }
}