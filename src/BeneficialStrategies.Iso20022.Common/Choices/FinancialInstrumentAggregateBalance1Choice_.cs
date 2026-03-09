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
    /// Choice of holding indicator and aggregated position of holdings.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentAggregateBalance1Choice.HoldingsIndicator))]
    [KnownType(typeof(FinancialInstrumentAggregateBalance1Choice.HoldingBalance))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentAggregateBalance1Choice.HoldingsIndicator),nameof(FinancialInstrumentAggregateBalance1Choice.HoldingsIndicator))]
    [JsonDerivedType(typeof(FinancialInstrumentAggregateBalance1Choice.HoldingBalance),nameof(FinancialInstrumentAggregateBalance1Choice.HoldingBalance))]
    #endif
    [IsoId("_PW7ItqCCEeOEyO7fCl8lLA")]
    [DisplayName("Financial Instrument Aggregate Balance 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentAggregateBalance1Choice_
    #else
    public abstract partial class FinancialInstrumentAggregateBalance1Choice_
    #endif
    {
    }
}
