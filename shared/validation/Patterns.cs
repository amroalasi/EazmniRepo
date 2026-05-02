using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Shared.validation
{
    public static class Patterns
    {
        public static readonly Regex Email = new Regex(
            @"^[^@\s]+@[^@\s]+.[^@\s]+$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        public static readonly Regex AlphaNumeric = new Regex(
            @"^[a-zA-Z0-9]+$",
            RegexOptions.Compiled
        );

        public static readonly Regex Url = new Regex(
            @"^https?://(www.)?[-a-zA-Z0-9@:%.+~#=]{1,256}.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%+.~#?&//=])$",
            RegexOptions.Compiled | RegexOptions.IgnoreCase
        );

        public static readonly Regex StrongPassword = new Regex(
            @"^(?=.[a-z])(?=.[A-Z])(?=.\d)(?=.[@$!%?&])[A-Za-z\d@$!%*?&]{8,}$",
            RegexOptions.Compiled
        );

        public static readonly Regex EnglishLetters = new Regex(
           @"^[A-Za-z -/,().]+$",
           RegexOptions.Compiled
       );

        public static readonly Regex ArabicLetters = new Regex(
            @"^[\u0600-\u06FF -/,()]+$",
            RegexOptions.Compiled
        );

        public static readonly Regex InternationalMobileNumbers = new Regex(
            @"^+\d{1,3}\d{4,14}$",
            RegexOptions.Compiled
        );

        public static readonly Regex AnyMobileNumbers = new Regex(
        @"^\d{7,15}$",
        RegexOptions.Compiled
    );


        public static readonly Regex SaudiNationalId = new Regex(
            @"^[123]\d{9}$",
            RegexOptions.Compiled
        );
        public static readonly Regex ShortAddress = new Regex(
        @"^[A-Za-z]{4}[0-9]{4}$",
        RegexOptions.Compiled
    );
    }
}
