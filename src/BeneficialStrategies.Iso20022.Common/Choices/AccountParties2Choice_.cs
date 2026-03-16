// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party associated with the account.
    /// </summary>
    [KnownType(typeof(AccountParties2Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties2Choice.Trustee))]
    [KnownType(typeof(AccountParties2Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties2Choice.Nominee))]
    [KnownType(typeof(AccountParties2Choice.JointOwner))]
    [JsonDerivedType(
        typeof(AccountParties2Choice.PrimaryOwner),
        nameof(AccountParties2Choice.PrimaryOwner)
    )]
    [JsonDerivedType(typeof(AccountParties2Choice.Trustee), nameof(AccountParties2Choice.Trustee))]
    [JsonDerivedType(
        typeof(AccountParties2Choice.CustodianForMinor),
        nameof(AccountParties2Choice.CustodianForMinor)
    )]
    [JsonDerivedType(typeof(AccountParties2Choice.Nominee), nameof(AccountParties2Choice.Nominee))]
    [JsonDerivedType(
        typeof(AccountParties2Choice.JointOwner),
        nameof(AccountParties2Choice.JointOwner)
    )]
    [IsoId("_eTBXkRdQEeK5g-3oYI0_9Q")]
    [DisplayName("Account Parties 2 Choice")]
    public abstract record AccountParties2Choice_ { }
}
