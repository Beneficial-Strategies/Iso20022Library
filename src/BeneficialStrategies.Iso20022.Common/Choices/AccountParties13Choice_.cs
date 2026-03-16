// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties13Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties13Choice.Trustee))]
    [KnownType(typeof(AccountParties13Choice.Nominee))]
    [KnownType(typeof(AccountParties13Choice.JointOwner))]
    [JsonDerivedType(
        typeof(AccountParties13Choice.PrimaryOwner),
        nameof(AccountParties13Choice.PrimaryOwner)
    )]
    [JsonDerivedType(
        typeof(AccountParties13Choice.Trustee),
        nameof(AccountParties13Choice.Trustee)
    )]
    [JsonDerivedType(
        typeof(AccountParties13Choice.Nominee),
        nameof(AccountParties13Choice.Nominee)
    )]
    [JsonDerivedType(
        typeof(AccountParties13Choice.JointOwner),
        nameof(AccountParties13Choice.JointOwner)
    )]
    [IsoId("_oK88BZQ_EemqYPWMBuVawg")]
    [DisplayName("Account Parties 13 Choice")]
    public abstract record AccountParties13Choice_ { }
}
