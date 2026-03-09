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
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity34Choice.DigitalTokenUnit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity34Choice.Unit),nameof(FinancialInstrumentQuantity34Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity34Choice.FaceAmount),nameof(FinancialInstrumentQuantity34Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity34Choice.AmortisedValue),nameof(FinancialInstrumentQuantity34Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity34Choice.Code),nameof(FinancialInstrumentQuantity34Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity34Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity34Choice.DigitalTokenUnit))]
    #endif
    [IsoId("_lMyPmRu0EeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Quantity 34 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity34Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity34Choice_
    #endif
    {
    }
}
