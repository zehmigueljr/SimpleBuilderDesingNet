namespace sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new UserBuilder("José Miguel", "josems@upflux.net")
                        .CanManagePermission()
                        .CanWritePermission()
                        .Build();

            var user2 = new UserBuilder("Marcos Piazera vulgo Penha", "marcos@upflux.net")
                        .CanAccessSiteSettingsPermission()
                        .CanAccessAdminSettingsPermission()
                        .CanWritePermission()
                        .CanReadPermission()
                        .Build();
        }
    }
}
