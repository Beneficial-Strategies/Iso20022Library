// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party associated with the account.
    /// </summary>
    [KnownType(typeof(AccountParties4Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties4Choice.Trustee))]
    [KnownType(typeof(AccountParties4Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties4Choice.Nominee))]
    [KnownType(typeof(AccountParties4Choice.JointOwner))]
    [JsonDerivedType(typeof(AccountParties4Choice.PrimaryOwner),nameof(AccountParties4Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties4Choice.Trustee),nameof(AccountParties4Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties4Choice.CustodianForMinor),nameof(AccountParties4Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties4Choice.Nominee),nameof(AccountParties4Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties4Choice.JointOwner),nameof(AccountParties4Choice.JointOwner))]
    [IsoId("_sv2SwRRiEeOKWo1NF21OVw")]
    [DisplayName("Account Parties 4 Choice")]
    public abstract partial record AccountParties4Choice_
    {
    }
}
