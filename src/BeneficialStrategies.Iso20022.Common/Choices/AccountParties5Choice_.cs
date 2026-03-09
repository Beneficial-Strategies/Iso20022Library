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
    [KnownType(typeof(AccountParties5Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties5Choice.Trustee))]
    [KnownType(typeof(AccountParties5Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties5Choice.Nominee))]
    [KnownType(typeof(AccountParties5Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties5Choice.PrimaryOwner),nameof(AccountParties5Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties5Choice.Trustee),nameof(AccountParties5Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties5Choice.CustodianForMinor),nameof(AccountParties5Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties5Choice.Nominee),nameof(AccountParties5Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties5Choice.JointOwner),nameof(AccountParties5Choice.JointOwner))]
    #endif
    [IsoId("_Ff6rBQhDEeSUPbC7DbLJpQ")]
    [DisplayName("Account Parties 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties5Choice_
    #else
    public abstract partial class AccountParties5Choice_
    #endif
    {
    }
}
