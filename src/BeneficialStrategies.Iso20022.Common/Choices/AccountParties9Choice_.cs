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
    [KnownType(typeof(AccountParties9Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties9Choice.Trustee))]
    [KnownType(typeof(AccountParties9Choice.Nominee))]
    [KnownType(typeof(AccountParties9Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties9Choice.PrimaryOwner),nameof(AccountParties9Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties9Choice.Trustee),nameof(AccountParties9Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties9Choice.Nominee),nameof(AccountParties9Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties9Choice.JointOwner),nameof(AccountParties9Choice.JointOwner))]
    #endif
    [IsoId("_PD3vCSCBEeWhHbfCMWc1cw")]
    [DisplayName("Account Parties 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties9Choice_
    #else
    public abstract partial class AccountParties9Choice_
    #endif
    {
    }
}
