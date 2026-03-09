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
    [KnownType(typeof(AccountParties3Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties3Choice.Trustee))]
    [KnownType(typeof(AccountParties3Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties3Choice.Nominee))]
    [KnownType(typeof(AccountParties3Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties3Choice.PrimaryOwner),nameof(AccountParties3Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties3Choice.Trustee),nameof(AccountParties3Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties3Choice.CustodianForMinor),nameof(AccountParties3Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties3Choice.Nominee),nameof(AccountParties3Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties3Choice.JointOwner),nameof(AccountParties3Choice.JointOwner))]
    #endif
    [IsoId("_36UzsRRNEeOKWo1NF21OVw")]
    [DisplayName("Account Parties 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties3Choice_
    #else
    public abstract partial class AccountParties3Choice_
    #endif
    {
    }
}
