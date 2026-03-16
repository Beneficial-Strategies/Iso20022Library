// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties12Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties12Choice.Trustee))]
    [KnownType(typeof(AccountParties12Choice.Nominee))]
    [KnownType(typeof(AccountParties12Choice.JointOwner))]
    [JsonDerivedType(
        typeof(AccountParties12Choice.PrimaryOwner),
        nameof(AccountParties12Choice.PrimaryOwner)
    )]
    [JsonDerivedType(
        typeof(AccountParties12Choice.Trustee),
        nameof(AccountParties12Choice.Trustee)
    )]
    [JsonDerivedType(
        typeof(AccountParties12Choice.Nominee),
        nameof(AccountParties12Choice.Nominee)
    )]
    [JsonDerivedType(
        typeof(AccountParties12Choice.JointOwner),
        nameof(AccountParties12Choice.JointOwner)
    )]
    [IsoId("_mWdfp5Q_EemqYPWMBuVawg")]
    [DisplayName("Account Parties 12 Choice")]
    public abstract record AccountParties12Choice_ { }
}
