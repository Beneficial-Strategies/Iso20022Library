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
    [KnownType(typeof(AccountParties10Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties10Choice.Trustee))]
    [KnownType(typeof(AccountParties10Choice.Nominee))]
    [KnownType(typeof(AccountParties10Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties10Choice.PrimaryOwner),nameof(AccountParties10Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties10Choice.Trustee),nameof(AccountParties10Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties10Choice.Nominee),nameof(AccountParties10Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties10Choice.JointOwner),nameof(AccountParties10Choice.JointOwner))]
    #endif
    [IsoId("_wsxAU0NMEeamLdeYEZm56w")]
    [DisplayName("Account Parties 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties10Choice_
    #else
    public abstract partial class AccountParties10Choice_
    #endif
    {
    }
}
