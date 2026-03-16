// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party associated with the account.
    /// </summary>
    [KnownType(typeof(AccountParties3Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties3Choice.Trustee))]
    [KnownType(typeof(AccountParties3Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties3Choice.Nominee))]
    [KnownType(typeof(AccountParties3Choice.JointOwner))]
    [JsonDerivedType(
        typeof(AccountParties3Choice.PrimaryOwner),
        nameof(AccountParties3Choice.PrimaryOwner)
    )]
    [JsonDerivedType(typeof(AccountParties3Choice.Trustee), nameof(AccountParties3Choice.Trustee))]
    [JsonDerivedType(
        typeof(AccountParties3Choice.CustodianForMinor),
        nameof(AccountParties3Choice.CustodianForMinor)
    )]
    [JsonDerivedType(typeof(AccountParties3Choice.Nominee), nameof(AccountParties3Choice.Nominee))]
    [JsonDerivedType(
        typeof(AccountParties3Choice.JointOwner),
        nameof(AccountParties3Choice.JointOwner)
    )]
    [IsoId("_36UzsRRNEeOKWo1NF21OVw")]
    [DisplayName("Account Parties 3 Choice")]
    public abstract record AccountParties3Choice_ { }
}
