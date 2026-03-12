// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Party associated with the account.
    /// </summary>
    [KnownType(typeof(AccountParties1Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties1Choice.Trustee))]
    [KnownType(typeof(AccountParties1Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties1Choice.Nominee))]
    [KnownType(typeof(AccountParties1Choice.JointOwner))]
    [JsonDerivedType(typeof(AccountParties1Choice.PrimaryOwner),nameof(AccountParties1Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties1Choice.Trustee),nameof(AccountParties1Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties1Choice.CustodianForMinor),nameof(AccountParties1Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties1Choice.Nominee),nameof(AccountParties1Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties1Choice.JointOwner),nameof(AccountParties1Choice.JointOwner))]
    [IsoId("_7vPYQxdAEeK5g-3oYI0_9Q")]
    [DisplayName("Account Parties 1 Choice")]
    public abstract partial record AccountParties1Choice_
    {
    }
}
