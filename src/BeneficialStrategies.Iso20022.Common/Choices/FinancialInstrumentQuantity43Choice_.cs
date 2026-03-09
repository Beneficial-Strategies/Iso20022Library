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
    /// Choice between formats for the quantity of security.
    /// </summary>
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity43Choice.DigitalTokenUnit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity43Choice.Unit),nameof(FinancialInstrumentQuantity43Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity43Choice.FaceAmount),nameof(FinancialInstrumentQuantity43Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity43Choice.AmortisedValue),nameof(FinancialInstrumentQuantity43Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity43Choice.Code),nameof(FinancialInstrumentQuantity43Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity43Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity43Choice.DigitalTokenUnit))]
    #endif
    [IsoId("_ptGAfzi7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Quantity 43 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity43Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity43Choice_
    #endif
    {
    }
}
