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
    /// Choice between ways to express the quantity of the financial instrument to be subscribed to or redeemed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity11Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity11Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity11Choice.HoldingsRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity11Choice.UnitsNumber),nameof(FinancialInstrumentQuantity11Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity11Choice.OrderedAmount),nameof(FinancialInstrumentQuantity11Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity11Choice.HoldingsRate),nameof(FinancialInstrumentQuantity11Choice.HoldingsRate))]
    #endif
    [IsoId("_RhV08tp-Ed-ak6NoX_4Aeg_1444004749")]
    [DisplayName("Financial Instrument Quantity 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity11Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity11Choice_
    #endif
    {
    }
}
