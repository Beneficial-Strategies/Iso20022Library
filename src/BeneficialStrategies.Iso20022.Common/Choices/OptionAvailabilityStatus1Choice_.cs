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
    [KnownType(typeof(OptionAvailabilityStatus1Choice.Code))]
    [KnownType(typeof(OptionAvailabilityStatus1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionAvailabilityStatus1Choice.Code),nameof(OptionAvailabilityStatus1Choice.Code))]
    [JsonDerivedType(typeof(OptionAvailabilityStatus1Choice.Proprietary),nameof(OptionAvailabilityStatus1Choice.Proprietary))]
    #endif
    [IsoId("_Q0CqG9p-Ed-ak6NoX_4Aeg_-885794787")]
    [DisplayName("Option Availability Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionAvailabilityStatus1Choice_
    #else
    public abstract partial class OptionAvailabilityStatus1Choice_
    #endif
    {
    }
}
