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
    /// Choice of consent status.
    /// </summary>
    [KnownType(typeof(ConsentStatus4Choice.NoSpecifiedReason))]
    [KnownType(typeof(ConsentStatus4Choice.Reason))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ConsentStatus4Choice.NoSpecifiedReason),nameof(ConsentStatus4Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(ConsentStatus4Choice.Reason),nameof(ConsentStatus4Choice.Reason))]
    #endif
    [IsoId("_n--vUTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Consent Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ConsentStatus4Choice_
    #else
    public abstract partial class ConsentStatus4Choice_
    #endif
    {
    }
}
