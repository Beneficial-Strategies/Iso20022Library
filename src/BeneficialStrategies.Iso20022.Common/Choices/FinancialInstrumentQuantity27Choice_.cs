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
    /// Choice between formats for the specification of the number of units or amount of money.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity27Choice.UnitsNumber))]
    [KnownType(typeof(FinancialInstrumentQuantity27Choice.GrossAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity27Choice.NetAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity27Choice.UnitsNumber),nameof(FinancialInstrumentQuantity27Choice.UnitsNumber))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity27Choice.GrossAmount),nameof(FinancialInstrumentQuantity27Choice.GrossAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity27Choice.NetAmount),nameof(FinancialInstrumentQuantity27Choice.NetAmount))]
    #endif
    [IsoId("_RoyRsDhSEeaRwdGFv45qTQ")]
    [DisplayName("Financial Instrument Quantity 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity27Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity27Choice_
    #endif
    {
    }
}
