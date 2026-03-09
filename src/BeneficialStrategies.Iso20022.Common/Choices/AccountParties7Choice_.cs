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
    /// Information about a party&apos;s account.
    /// </summary>
    [KnownType(typeof(AccountParties7Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties7Choice.Trustee))]
    [KnownType(typeof(AccountParties7Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties7Choice.Nominee))]
    [KnownType(typeof(AccountParties7Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties7Choice.PrimaryOwner),nameof(AccountParties7Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties7Choice.Trustee),nameof(AccountParties7Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties7Choice.CustodianForMinor),nameof(AccountParties7Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties7Choice.Nominee),nameof(AccountParties7Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties7Choice.JointOwner),nameof(AccountParties7Choice.JointOwner))]
    #endif
    [IsoId("_JYYKawhDEeSUPbC7DbLJpQ")]
    [DisplayName("Account Parties 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties7Choice_
    #else
    public abstract partial class AccountParties7Choice_
    #endif
    {
    }
}
