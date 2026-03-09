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
    /// Choice between formats for the specification of the number of units, amount of money or percentage.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.PercentageOfTotalSubscriptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity29Choice.HoldingsRedemptionRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.UnitsNumber),nameof(FinancialInstrumentQuantity29Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity29Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.NetAmount),nameof(FinancialInstrumentQuantity29Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.GrossAmount),nameof(FinancialInstrumentQuantity29Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity29Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity29Choice.HoldingsRedemptionRate))]
    #endif
    [IsoId("_5dOFoU_3Eea1ZIrmU5dI3w")]
    [DisplayName("Financial Instrument Quantity 29 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity29Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity29Choice_
    #endif
    {
    }
}
