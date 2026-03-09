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
    [KnownType(typeof(AccountParties6Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties6Choice.Trustee))]
    [KnownType(typeof(AccountParties6Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties6Choice.Nominee))]
    [KnownType(typeof(AccountParties6Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties6Choice.PrimaryOwner),nameof(AccountParties6Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties6Choice.Trustee),nameof(AccountParties6Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties6Choice.CustodianForMinor),nameof(AccountParties6Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties6Choice.Nominee),nameof(AccountParties6Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties6Choice.JointOwner),nameof(AccountParties6Choice.JointOwner))]
    #endif
    [IsoId("_IhLclQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Account Parties 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties6Choice_
    #else
    public abstract partial class AccountParties6Choice_
    #endif
    {
    }
}
