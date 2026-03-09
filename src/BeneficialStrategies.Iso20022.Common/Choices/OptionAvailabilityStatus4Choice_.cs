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
    /// Choice between a standard code or proprietary code to specify the option availability status.
    /// </summary>
    [KnownType(typeof(OptionAvailabilityStatus4Choice.Code))]
    [KnownType(typeof(OptionAvailabilityStatus4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionAvailabilityStatus4Choice.Code),nameof(OptionAvailabilityStatus4Choice.Code))]
    [JsonDerivedType(typeof(OptionAvailabilityStatus4Choice.Proprietary),nameof(OptionAvailabilityStatus4Choice.Proprietary))]
    #endif
    [IsoId("_cta-K5KQEeWHWpTQn1FFVg")]
    [DisplayName("Option Availability Status 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionAvailabilityStatus4Choice_
    #else
    public abstract partial class OptionAvailabilityStatus4Choice_
    #endif
    {
    }
}
