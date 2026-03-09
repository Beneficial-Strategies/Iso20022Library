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
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity20Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity20Choice.Unit),nameof(FinancialInstrumentQuantity20Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity20Choice.FaceAmount),nameof(FinancialInstrumentQuantity20Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity20Choice.AmortisedValue),nameof(FinancialInstrumentQuantity20Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity20Choice.Code),nameof(FinancialInstrumentQuantity20Choice.Code))]
    #endif
    [IsoId("_pPlzMQFIEeGhYJiRaPcH8g")]
    [DisplayName("Financial Instrument Quantity 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity20Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity20Choice_
    #endif
    {
    }
}
