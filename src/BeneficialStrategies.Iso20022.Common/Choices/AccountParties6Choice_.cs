// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties6Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties6Choice.Trustee))]
    [KnownType(typeof(AccountParties6Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties6Choice.Nominee))]
    [KnownType(typeof(AccountParties6Choice.JointOwner))]
    [JsonDerivedType(typeof(AccountParties6Choice.PrimaryOwner),nameof(AccountParties6Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties6Choice.Trustee),nameof(AccountParties6Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties6Choice.CustodianForMinor),nameof(AccountParties6Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties6Choice.Nominee),nameof(AccountParties6Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties6Choice.JointOwner),nameof(AccountParties6Choice.JointOwner))]
    [IsoId("_IhLclQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Account Parties 6 Choice")]
    public abstract partial record AccountParties6Choice_
    {
    }
}
