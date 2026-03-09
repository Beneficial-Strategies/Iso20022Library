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
    [KnownType(typeof(FinancialInstrumentAttributes5Choice.Identification))]
    [KnownType(typeof(FinancialInstrumentAttributes5Choice.AlternateIdentification))]
    [KnownType(typeof(FinancialInstrumentAttributes5Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentAttributes5Choice.Identification),nameof(FinancialInstrumentAttributes5Choice.Identification))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes5Choice.AlternateIdentification),nameof(FinancialInstrumentAttributes5Choice.AlternateIdentification))]
    [JsonDerivedType(typeof(FinancialInstrumentAttributes5Choice.Other),nameof(FinancialInstrumentAttributes5Choice.Other))]
    #endif
    [IsoId("_6fVwkZicEe2f7NHvXATP5g")]
    [DisplayName("Financial Instrument Attributes 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentAttributes5Choice_
    #else
    public abstract partial class FinancialInstrumentAttributes5Choice_
    #endif
    {
    }
}
