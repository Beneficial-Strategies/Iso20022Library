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
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.OrderedAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.NetAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity7Choice.GrossAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.UnitsNumber),nameof(FinancialInstrumentQuantity7Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.OrderedAmount),nameof(FinancialInstrumentQuantity7Choice.OrderedAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.NetAmount),nameof(FinancialInstrumentQuantity7Choice.NetAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity7Choice.GrossAmount),nameof(FinancialInstrumentQuantity7Choice.GrossAmount))]
    #endif
    [IsoId("_Rg5JAdp-Ed-ak6NoX_4Aeg_554727766")]
    [DisplayName("Financial Instrument Quantity 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity7Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity7Choice_
    #endif
    {
    }
}
