namespace WebApp
{
    public static class Utils
    {
        public static bool IsStrongPassword(string password)
        {
            // Implement your password strength criteria here
            // For example, you could check length, presence of uppercase, lowercase, digits, and special characters
            if (password.Length < 8)
                return false;
            if (!ContainsUppercase(password))
                return false;
            if (!ContainsLowercase(password))
                return false;
            if (!ContainsDigit(password))
                return false;
            if (!ContainsSpecialCharacter(password))
                return false;

            return true;
        }

        private static bool ContainsUppercase(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        private static bool ContainsLowercase(string password)
        {
            foreach (char c in password)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }

        private static bool ContainsDigit(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        private static bool ContainsSpecialCharacter(string password)
        {
            foreach (char c in password)
            {
                if (!char.IsLetterOrDigit(c))
                    return true;
            }
            return false;
        }
    }
}
