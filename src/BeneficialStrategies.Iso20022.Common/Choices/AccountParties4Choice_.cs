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
    [KnownType(typeof(AccountParties4Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties4Choice.Trustee))]
    [KnownType(typeof(AccountParties4Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties4Choice.Nominee))]
    [KnownType(typeof(AccountParties4Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties4Choice.PrimaryOwner),nameof(AccountParties4Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties4Choice.Trustee),nameof(AccountParties4Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties4Choice.CustodianForMinor),nameof(AccountParties4Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties4Choice.Nominee),nameof(AccountParties4Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties4Choice.JointOwner),nameof(AccountParties4Choice.JointOwner))]
    #endif
    [IsoId("_sv2SwRRiEeOKWo1NF21OVw")]
    [DisplayName("Account Parties 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties4Choice_
    #else
    public abstract partial class AccountParties4Choice_
    #endif
    {
    }
}
