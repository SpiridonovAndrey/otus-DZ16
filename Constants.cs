﻿namespace DZ16
{
    internal class Constants
    {
        public const string Login = "postgres";
        public const string Password = "admin";
        public const string Host = "localhost";
        public const string Port = "5432";
        public const string DbName = "Shop";

        public static string ConnectionString { get; } = $"User ID={Login};Password={Password};Host={Host};Port={Port};Database={DbName};";
    }
}
