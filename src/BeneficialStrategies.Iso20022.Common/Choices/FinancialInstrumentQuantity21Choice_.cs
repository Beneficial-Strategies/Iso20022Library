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
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity21Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.Unit),nameof(FinancialInstrumentQuantity21Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.FaceAmount),nameof(FinancialInstrumentQuantity21Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.AmortisedValue),nameof(FinancialInstrumentQuantity21Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity21Choice.Code),nameof(FinancialInstrumentQuantity21Choice.Code))]
    #endif
    [IsoId("_N-fhCQU-EeGZxNLgzisRtw")]
    [DisplayName("Financial Instrument Quantity 21 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity21Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity21Choice_
    #endif
    {
    }
}
