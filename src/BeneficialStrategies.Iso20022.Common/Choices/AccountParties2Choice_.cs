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
    [KnownType(typeof(AccountParties2Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties2Choice.Trustee))]
    [KnownType(typeof(AccountParties2Choice.CustodianForMinor))]
    [KnownType(typeof(AccountParties2Choice.Nominee))]
    [KnownType(typeof(AccountParties2Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties2Choice.PrimaryOwner),nameof(AccountParties2Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties2Choice.Trustee),nameof(AccountParties2Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties2Choice.CustodianForMinor),nameof(AccountParties2Choice.CustodianForMinor))]
    [JsonDerivedType(typeof(AccountParties2Choice.Nominee),nameof(AccountParties2Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties2Choice.JointOwner),nameof(AccountParties2Choice.JointOwner))]
    #endif
    [IsoId("_eTBXkRdQEeK5g-3oYI0_9Q")]
    [DisplayName("Account Parties 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties2Choice_
    #else
    public abstract partial class AccountParties2Choice_
    #endif
    {
    }
}
