namespace SchoolManagerApi.Security
{
    namespace Policies
    {
        public static class Store
        {
            public const string ManageStorePolicy = "ManageStorePolicy";
            public const string AccessStorePolicy = "AccessStorePolicy";
            public const string OrderFromStorePolicy = "OrderFromStorePolicy";
        }
        public static class RolesManagement
        {
            public const string ManageRolesPolicy = "ManageRolesPolicy";
        }
    }
}