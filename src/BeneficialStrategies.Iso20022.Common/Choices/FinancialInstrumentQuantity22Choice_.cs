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
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity22Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity22Choice.Unit),nameof(FinancialInstrumentQuantity22Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity22Choice.FaceAmount),nameof(FinancialInstrumentQuantity22Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity22Choice.AmortisedValue),nameof(FinancialInstrumentQuantity22Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity22Choice.Code),nameof(FinancialInstrumentQuantity22Choice.Code))]
    #endif
    [IsoId("_N-fhSQU-EeGZxNLgzisRtw")]
    [DisplayName("Financial Instrument Quantity 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity22Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity22Choice_
    #endif
    {
    }
}
