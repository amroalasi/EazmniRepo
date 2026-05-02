using Shared.messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public record Error
    {
        public static readonly Error None = new(string.Empty, string.Empty, ErrorType.Failure);
        public static readonly Error NullValue = new(
            "General.Null",
            "Null value was provided",
            ErrorType.Failure);

        private readonly MessageCode? _messageCode;

        public string Code { get; }
        public string Description => _messageCode.HasValue ? Message.Get(_messageCode.Value) : _description;
        private readonly string _description;
        public ErrorType Type { get; }

        public Error(MessageCode code, ErrorType type)
        {
            _messageCode = code;
            Code = code.ToString();
            Type = type;
        }

        public Error(string code, string description, ErrorType type)
        {
            _description = description;
            Code = code;
            Type = type;
        }

        public static Error Failure(string code, string description) =>
            new(code, description, ErrorType.Failure);

        public static Error NotFound(string code, string description) =>
            new(code, description, ErrorType.NotFound);

        public static Error Validation(string code, string description) =>
            new(code, description, ErrorType.Validation);

        public static Error Problem(string code, string description) =>
            new(code, description, ErrorType.Problem);

        public static Error Conflict(string code, string description) =>
            new(code, description, ErrorType.Conflict);


        public static Error Failure(MessageCode code) =>
            new(code, ErrorType.Failure);

        public static Error NotFound(MessageCode code) =>
            new(code, ErrorType.NotFound);

        public static Error Validation(MessageCode code) =>
            new(code, ErrorType.Validation);

        public static Error Problem(MessageCode code) =>
            new(code, ErrorType.Problem);

        public static Error Conflict(MessageCode code) =>
            new(code, ErrorType.Conflict);


        public static Error Unauthorized(MessageCode code) =>
            new(code, ErrorType.Unauthorized);

        public static Error Forbidden(MessageCode code) =>
           new(code, ErrorType.Forbidden);



    }
}
