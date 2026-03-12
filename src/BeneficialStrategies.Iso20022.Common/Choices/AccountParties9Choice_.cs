// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties9Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties9Choice.Trustee))]
    [KnownType(typeof(AccountParties9Choice.Nominee))]
    [KnownType(typeof(AccountParties9Choice.JointOwner))]
    [JsonDerivedType(typeof(AccountParties9Choice.PrimaryOwner),nameof(AccountParties9Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties9Choice.Trustee),nameof(AccountParties9Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties9Choice.Nominee),nameof(AccountParties9Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties9Choice.JointOwner),nameof(AccountParties9Choice.JointOwner))]
    [IsoId("_PD3vCSCBEeWhHbfCMWc1cw")]
    [DisplayName("Account Parties 9 Choice")]
    public abstract partial record AccountParties9Choice_
    {
    }
}
