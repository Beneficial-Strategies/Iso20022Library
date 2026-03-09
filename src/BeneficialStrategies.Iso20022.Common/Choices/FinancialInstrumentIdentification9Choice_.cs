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
    [KnownType(typeof(FinancialInstrumentIdentification9Choice.ISIN))]
    [KnownType(typeof(FinancialInstrumentIdentification9Choice.Index))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentIdentification9Choice.ISIN),nameof(FinancialInstrumentIdentification9Choice.ISIN))]
    [JsonDerivedType(typeof(FinancialInstrumentIdentification9Choice.Index),nameof(FinancialInstrumentIdentification9Choice.Index))]
    #endif
    [IsoId("_26V3lZ3DEeuwmdq0KtnICg")]
    [DisplayName("Financial Instrument Identification 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentIdentification9Choice_
    #else
    public abstract partial class FinancialInstrumentIdentification9Choice_
    #endif
    {
    }
}
