// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties11Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties11Choice.Trustee))]
    [KnownType(typeof(AccountParties11Choice.Nominee))]
    [KnownType(typeof(AccountParties11Choice.JointOwner))]
    [JsonDerivedType(
        typeof(AccountParties11Choice.PrimaryOwner),
        nameof(AccountParties11Choice.PrimaryOwner)
    )]
    [JsonDerivedType(
        typeof(AccountParties11Choice.Trustee),
        nameof(AccountParties11Choice.Trustee)
    )]
    [JsonDerivedType(
        typeof(AccountParties11Choice.Nominee),
        nameof(AccountParties11Choice.Nominee)
    )]
    [JsonDerivedType(
        typeof(AccountParties11Choice.JointOwner),
        nameof(AccountParties11Choice.JointOwner)
    )]
    [IsoId("_tDYvUUzPEea8fovz_9xSTQ")]
    [DisplayName("Account Parties 11 Choice")]
    public abstract record AccountParties11Choice_ { }
}
