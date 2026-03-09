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
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.UnitsNumber),nameof(FinancialInstrumentQuantity5Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount),nameof(FinancialInstrumentQuantity5Choice.PercentageOfTotalSubscriptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.NetAmount),nameof(FinancialInstrumentQuantity5Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.GrossAmount),nameof(FinancialInstrumentQuantity5Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity5Choice.HoldingsRedemptionRate))]
    #endif
    [IsoId("_Soaxwdp-Ed-ak6NoX_4Aeg_1036643949")]
    [DisplayName("Financial Instrument Quantity 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity5Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity5Choice_
    #endif
    {
    }
}
