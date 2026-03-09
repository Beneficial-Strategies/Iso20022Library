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
    /// Specifies the frequency fixing for the rate.
    /// </summary>
    [KnownType(typeof(FrequencyRateFixing1Choice.Code))]
    [KnownType(typeof(FrequencyRateFixing1Choice.NumberOfDays))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FrequencyRateFixing1Choice.Code),nameof(FrequencyRateFixing1Choice.Code))]
    [JsonDerivedType(typeof(FrequencyRateFixing1Choice.NumberOfDays),nameof(FrequencyRateFixing1Choice.NumberOfDays))]
    #endif
    [IsoId("_OPAdMI9PEeqMo4JxiuZGSw")]
    [DisplayName("Frequency Rate Fixing 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FrequencyRateFixing1Choice_
    #else
    public abstract partial class FrequencyRateFixing1Choice_
    #endif
    {
    }
}
