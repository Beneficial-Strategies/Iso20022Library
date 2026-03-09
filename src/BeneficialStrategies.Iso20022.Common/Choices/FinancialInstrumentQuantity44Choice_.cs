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
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity44Choice.DigitalTokenUnit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.Unit),nameof(FinancialInstrumentQuantity44Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.FaceAmount),nameof(FinancialInstrumentQuantity44Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.AmortisedValue),nameof(FinancialInstrumentQuantity44Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.Code),nameof(FinancialInstrumentQuantity44Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity44Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity44Choice.DigitalTokenUnit))]
    #endif
    [IsoId("_ptJrOzi7Eeydid5dcNPKvg")]
    [DisplayName("Financial Instrument Quantity 44 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity44Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity44Choice_
    #endif
    {
    }
}
