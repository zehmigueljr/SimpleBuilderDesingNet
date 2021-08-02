namespace sandbox
{
    public class User
    {
        //Atributos que serão obrigatórios
        public string Uid { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        //Atributos que serão opcionais
        public bool CanWrite { get; private set; }
        public bool CanRead { get; private set; }
        public bool CanManage {get; private set; }
        public bool CanAccessPersonalSettings { get; private set; }
        public bool CanAccessAdminSettings { get; private set; }
        public bool CanAccessSiteSettings {get; private set; }

        public User(string name, string email, bool canWrite = false, bool canRead = false, bool canManage = false, bool canAccessPersonalSettings = false, 
                    bool canAccessAdminSettings = false, bool canAccessSiteSettings = false)
        {
            //Implementação aqui
        }
    }
}