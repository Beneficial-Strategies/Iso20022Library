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
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.PercentageOfTotalRedemptionAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity26Choice.GrossAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity26Choice.UnitsNumber),nameof(FinancialInstrumentQuantity26Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity26Choice.PercentageOfTotalRedemptionAmount),nameof(FinancialInstrumentQuantity26Choice.PercentageOfTotalRedemptionAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity26Choice.NetAmount),nameof(FinancialInstrumentQuantity26Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity26Choice.GrossAmount),nameof(FinancialInstrumentQuantity26Choice.GrossAmount))]
    #endif
    [IsoId("_AYbkQU_4Eea1ZIrmU5dI3w")]
    [DisplayName("Financial Instrument Quantity 26 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity26Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity26Choice_
    #endif
    {
    }
}
