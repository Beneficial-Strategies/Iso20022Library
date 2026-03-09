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
    /// Specifies the attributes of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentAttributes3Choice.Identification))]
    [KnownType(typeof(FinancialInstrumentAttributes3Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentAttributes3Choice.Identification),nameof(FinancialInstrumentAttributes3Choice.Identification))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes3Choice.Other),nameof(FinancialInstrumentAttributes3Choice.Other))]
    #endif
    [IsoId("_KJ36VYG-EeaalK9UbuVGFw")]
    [DisplayName("Financial Instrument Attributes 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentAttributes3Choice_
    #else
    public abstract partial class FinancialInstrumentAttributes3Choice_
    #endif
    {
    }
}
