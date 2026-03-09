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
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.PercentageOfTotalSubscriptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity3Choice.HoldingsRedemptionRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.UnitsNumber),nameof(FinancialInstrumentQuantity3Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity3Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.NetAmount),nameof(FinancialInstrumentQuantity3Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.GrossAmount),nameof(FinancialInstrumentQuantity3Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity3Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity3Choice.HoldingsRedemptionRate))]
    #endif
    [IsoId("_VOten9p-Ed-ak6NoX_4Aeg_1922478092")]
    [DisplayName("Financial Instrument Quantity 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity3Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity3Choice_
    #endif
    {
    }
}
