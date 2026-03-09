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
    [KnownType(typeof(AccountParties11Choice.PrimaryOwner))]
    [KnownType(typeof(AccountParties11Choice.Trustee))]
    [KnownType(typeof(AccountParties11Choice.Nominee))]
    [KnownType(typeof(AccountParties11Choice.JointOwner))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountParties11Choice.PrimaryOwner),nameof(AccountParties11Choice.PrimaryOwner))]
    [JsonDerivedType(typeof(AccountParties11Choice.Trustee),nameof(AccountParties11Choice.Trustee))]
    [JsonDerivedType(typeof(AccountParties11Choice.Nominee),nameof(AccountParties11Choice.Nominee))]
    [JsonDerivedType(typeof(AccountParties11Choice.JointOwner),nameof(AccountParties11Choice.JointOwner))]
    #endif
    [IsoId("_tDYvUUzPEea8fovz_9xSTQ")]
    [DisplayName("Account Parties 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountParties11Choice_
    #else
    public abstract partial class AccountParties11Choice_
    #endif
    {
    }
}
