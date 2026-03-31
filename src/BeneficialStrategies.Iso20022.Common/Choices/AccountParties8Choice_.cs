// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties8Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties8Choice.Trustee))]
    [KnownType(typeof(AccountParties8Choice.Nominee))]
    [KnownType(typeof(AccountParties8Choice.JointOwner))]
    [JsonDerivedType(
        typeof(AccountParties8Choice.PrimaryOwner),
        nameof(AccountParties8Choice.PrimaryOwner)
    )]
    [JsonDerivedType(typeof(AccountParties8Choice.Trustee), nameof(AccountParties8Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties8Choice.Nominee), nameof(AccountParties8Choice.Nominee))]
    [JsonDerivedType(
        typeof(AccountParties8Choice.JointOwner),
        nameof(AccountParties8Choice.JointOwner)
    )]
    [IsoId("_JZdJ0SCBEeWhHbfCMWc1cw")]
    [DisplayName("Account Parties 8 Choice")]
    public abstract record AccountParties8Choice_ { }
}
