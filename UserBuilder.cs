namespace sandbox
{
    public class UserBuilder
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        //Atributos que serão opcionais
        public bool CanWrite { get; private set; }
        public bool CanRead { get; private set; }
        public bool CanManage {get; private set; }
        public bool CanAccessPersonalSettings { get; private set; }
        public bool CanAccessAdminSettings { get; private set; }
        public bool CanAccessSiteSettings {get; private set; }

        public UserBuilder(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public UserBuilder CanWritePermission()
        {
            CanWrite = true;
            return this;
        }

        public UserBuilder CanReadPermission()
        {
            CanRead = true;
            return this;
        }

        public UserBuilder CanManagePermission()
        {
            CanManage = true;
            return this;
        }

        public UserBuilder CanAccessPersonalSettingsPermission()
        {
            CanAccessPersonalSettings = true;
            return this;
        }

        public UserBuilder CanAccessAdminSettingsPermission()
        {
            CanAccessAdminSettings = true;
            return this;
        }

        public UserBuilder CanAccessSiteSettingsPermission()
        {
            CanAccessSiteSettings = true;
            return this;
        }

        public BeautifulUser Build()
        {
            return new BeautifulUser(this);
        }
    }
}