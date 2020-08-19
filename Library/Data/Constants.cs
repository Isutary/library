namespace Library.Data
{
    public static class Constants
    {
        public static class Roles
        {
            public const string Admin = "Admin";
            public const string User = "User";
            public const string Guest = "Guest";
        }

        public static class Permissions
        {
            public static class Books
            {
                public const string Search = "Books.Search";
                public const string Add = "Books.Add";
                public const string Delete = "Books.Delete";
                public const string Edit = "Books.Edit";
            }

            public static class Authors
            {
                public const string Search = "Authors.Search";
                public const string Add = "Authors.Add";
                public const string Delete = "Authors.Delete";
                public const string Edit = "Authors.Edit";
            }

            public static class Users
            {
                public const string Search = "Users.Search";
                public const string Add = "Users.Add";
                public const string Delete = "Users.Delete";
                public const string Edit = "Users.Edit";
            }

            public static class Roles
            {
                public const string Search = "Roles.Search";
                public const string Add = "Roles.Add";
                public const string Delete = "Roles.Delete";
                public const string Edit = "Roles.Edit";
            }
        }
    }
}
