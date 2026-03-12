// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties7Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties7Choice.Trustee))]
    [KnownType(typeof(AccountParties7Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties7Choice.Nominee))]
    [KnownType(typeof(AccountParties7Choice.JointOwner))]
    [JsonDerivedType(typeof(AccountParties7Choice.PrimaryOwner),nameof(AccountParties7Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties7Choice.Trustee),nameof(AccountParties7Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties7Choice.CustodianForMinor),nameof(AccountParties7Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties7Choice.Nominee),nameof(AccountParties7Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties7Choice.JointOwner),nameof(AccountParties7Choice.JointOwner))]
    [IsoId("_JYYKawhDEeSUPbC7DbLJpQ")]
    [DisplayName("Account Parties 7 Choice")]
    public abstract partial record AccountParties7Choice_
    {
    }
}
