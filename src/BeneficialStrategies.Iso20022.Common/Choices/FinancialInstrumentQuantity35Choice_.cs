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
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.Code))]
    [KnownType(typeof(FinancialInstrumentQuantity35Choice.DigitalTokenUnit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.Unit),nameof(FinancialInstrumentQuantity35Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.FaceAmount),nameof(FinancialInstrumentQuantity35Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.AmortisedValue),nameof(FinancialInstrumentQuantity35Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.Code),nameof(FinancialInstrumentQuantity35Choice.Code))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity35Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity35Choice.DigitalTokenUnit))]
    #endif
    [IsoId("_lyZogxu1EeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Quantity 35 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity35Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity35Choice_
    #endif
    {
    }
}
