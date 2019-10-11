namespace Rich_Editor
{
    enum UserType
    {
        ReadOnly,
        ReadWrite
    }

    class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public UserType Type { get; set; }
    }
}
