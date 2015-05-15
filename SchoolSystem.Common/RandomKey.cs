namespace SchoolSystem.Common
{
    using System;

    public static class RandomKey
    {
        public static string Generate()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
