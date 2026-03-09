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
    /// Choice between ways to express the quantity of the financial instrument to be redeemed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.HoldingsRate))]
    [KnownType(typeof(FinancialInstrumentQuantity12Choice.PercentageOfTotalSubscriptionAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.UnitsNumber),nameof(FinancialInstrumentQuantity12Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.OrderedAmount),nameof(FinancialInstrumentQuantity12Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.NetAmount),nameof(FinancialInstrumentQuantity12Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.GrossAmount),nameof(FinancialInstrumentQuantity12Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.HoldingsRate),nameof(FinancialInstrumentQuantity12Choice.HoldingsRate))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity12Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity12Choice.PercentageOfTotalSubscriptionAmount))]
    #endif
    [IsoId("_RgvYAtp-Ed-ak6NoX_4Aeg_426549080")]
    [DisplayName("Financial Instrument Quantity 12 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity12Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity12Choice_
    #endif
    {
    }
}
