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
    [KnownType(typeof(AccountParties12Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties12Choice.Trustee))]
    [KnownType(typeof(AccountParties12Choice.Nominee))]
    [KnownType(typeof(AccountParties12Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties12Choice.PrimaryOwner),nameof(AccountParties12Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties12Choice.Trustee),nameof(AccountParties12Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties12Choice.Nominee),nameof(AccountParties12Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties12Choice.JointOwner),nameof(AccountParties12Choice.JointOwner))]
    #endif
    [IsoId("_mWdfp5Q_EemqYPWMBuVawg")]
    [DisplayName("Account Parties 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties12Choice_
    #else
    public abstract partial class AccountParties12Choice_
    #endif
    {
    }
}
