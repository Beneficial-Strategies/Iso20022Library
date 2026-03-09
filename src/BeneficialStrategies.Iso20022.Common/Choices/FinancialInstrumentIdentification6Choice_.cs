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
    /// Choice between formats for the identification of the financial instruments.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentIdentification6Choice.ISIN))]
    [KnownType(typeof(FinancialInstrumentIdentification6Choice.Index))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentIdentification6Choice.ISIN),nameof(FinancialInstrumentIdentification6Choice.ISIN))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification6Choice.Index),nameof(FinancialInstrumentIdentification6Choice.Index))]
    #endif
    [IsoId("_ImVPSX5aEea2k7EBUopqxw")]
    [DisplayName("Financial Instrument Identification 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentIdentification6Choice_
    #else
    public abstract partial class FinancialInstrumentIdentification6Choice_
    #endif
    {
    }
}
