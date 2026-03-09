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
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity33Choice.DigitalTokenUnit))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.Unit),nameof(FinancialInstrumentQuantity33Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.FaceAmount),nameof(FinancialInstrumentQuantity33Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.AmortisedValue),nameof(FinancialInstrumentQuantity33Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity33Choice.DigitalTokenUnit),nameof(FinancialInstrumentQuantity33Choice.DigitalTokenUnit))]
    #endif
    [IsoId("_Gu-7FRuyEeyhRdHRjakS2w")]
    [DisplayName("Financial Instrument Quantity 33 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity33Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity33Choice_
    #endif
    {
    }
}
