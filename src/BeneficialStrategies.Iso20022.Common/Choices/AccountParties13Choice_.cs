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
    [KnownType(typeof(AccountParties13Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties13Choice.Trustee))]
    [KnownType(typeof(AccountParties13Choice.Nominee))]
    [KnownType(typeof(AccountParties13Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties13Choice.PrimaryOwner),nameof(AccountParties13Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties13Choice.Trustee),nameof(AccountParties13Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties13Choice.Nominee),nameof(AccountParties13Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties13Choice.JointOwner),nameof(AccountParties13Choice.JointOwner))]
    #endif
    [IsoId("_oK88BZQ_EemqYPWMBuVawg")]
    [DisplayName("Account Parties 13 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties13Choice_
    #else
    public abstract partial class AccountParties13Choice_
    #endif
    {
    }
}
