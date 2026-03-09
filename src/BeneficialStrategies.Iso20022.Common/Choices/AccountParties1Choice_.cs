// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
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
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties1Choice.PrimaryOwner),nameof(AccountParties1Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties1Choice.Trustee),nameof(AccountParties1Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties1Choice.CustodianForMinor),nameof(AccountParties1Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties1Choice.Nominee),nameof(AccountParties1Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties1Choice.JointOwner),nameof(AccountParties1Choice.JointOwner))]
    #endif
    [IsoId("_7vPYQxdAEeK5g-3oYI0_9Q")]
    [DisplayName("Account Parties 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties1Choice_
    #else
    public abstract partial class AccountParties1Choice_
    #endif
    {
    }
}
