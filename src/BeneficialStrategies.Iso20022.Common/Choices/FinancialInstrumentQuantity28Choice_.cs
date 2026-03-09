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
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity28Choice.HoldingsRedemptionRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.UnitsNumber),nameof(FinancialInstrumentQuantity28Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.GrossAmount),nameof(FinancialInstrumentQuantity28Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.NetAmount),nameof(FinancialInstrumentQuantity28Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity28Choice.HoldingsRedemptionRate),nameof(FinancialInstrumentQuantity28Choice.HoldingsRedemptionRate))]
    #endif
    [IsoId("_ZJ9SMThUEeaRwdGFv45qTQ")]
    [DisplayName("Financial Instrument Quantity 28 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity28Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity28Choice_
    #endif
    {
    }
}
