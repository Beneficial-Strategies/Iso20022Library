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
    /// Choice between ways to express the quantity of the financial instrument to be subscribed.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.PercentageOfTotalRedemptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity6Choice.GrossAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity6Choice.UnitsNumber),nameof(FinancialInstrumentQuantity6Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity6Choice.PercentageOfTotalRedemptionAmount),nameof(FinancialInstrumentQuantity6Choice.PercentageOfTotalRedemptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity6Choice.NetAmount),nameof(FinancialInstrumentQuantity6Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity6Choice.GrossAmount),nameof(FinancialInstrumentQuantity6Choice.GrossAmount))]
    #endif
    [IsoId("_SoRAxNp-Ed-ak6NoX_4Aeg_-1931223701")]
    [DisplayName("Financial Instrument Quantity 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity6Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity6Choice_
    #endif
    {
    }
}
