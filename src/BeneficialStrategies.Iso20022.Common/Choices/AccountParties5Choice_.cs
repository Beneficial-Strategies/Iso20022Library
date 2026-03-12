// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties5Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties5Choice.Trustee))]
    [KnownType(typeof(AccountParties5Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties5Choice.Nominee))]
    [KnownType(typeof(AccountParties5Choice.JointOwner))]
    [JsonDerivedType(typeof(AccountParties5Choice.PrimaryOwner),nameof(AccountParties5Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties5Choice.Trustee),nameof(AccountParties5Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties5Choice.CustodianForMinor),nameof(AccountParties5Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties5Choice.Nominee),nameof(AccountParties5Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties5Choice.JointOwner),nameof(AccountParties5Choice.JointOwner))]
    [IsoId("_Ff6rBQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Account Parties 5 Choice")]
    public abstract partial record AccountParties5Choice_
    {
    }
}
