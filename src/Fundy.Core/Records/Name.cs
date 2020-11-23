using Ardalis.GuardClauses;
using System;

namespace Fundy.Core.Records
{
    public record Name
    {
        private string? _firstName;
        public string FirstName
        {
            get => _firstName ?? throw new InvalidOperationException($"Uninitialised property: {nameof(_firstName)}");
            init
            {
                _firstName = Guard.Against.NullOrWhiteSpace(value, nameof(value));
            }
        }

        private string? _lastName;
        public string LastName
        {
            get => _lastName ?? throw new InvalidOperationException($"Uninitialised property: {nameof(_lastName)}");
            init
            {
                _lastName = Guard.Against.NullOrWhiteSpace(value, nameof(value));
            }
        }

        public string? Title { get; init; }
    }
}