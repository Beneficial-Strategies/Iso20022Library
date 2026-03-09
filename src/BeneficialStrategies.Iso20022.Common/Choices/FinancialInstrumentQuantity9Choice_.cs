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
    /// Choice between ways to express the quantity of the financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity9Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity9Choice.OrderedAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity9Choice.UnitsNumber),nameof(FinancialInstrumentQuantity9Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity9Choice.OrderedAmount),nameof(FinancialInstrumentQuantity9Choice.OrderedAmount))]
    #endif
    [IsoId("_RhC6A9p-Ed-ak6NoX_4Aeg_1213138425")]
    [DisplayName("Financial Instrument Quantity 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity9Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity9Choice_
    #endif
    {
    }
}
