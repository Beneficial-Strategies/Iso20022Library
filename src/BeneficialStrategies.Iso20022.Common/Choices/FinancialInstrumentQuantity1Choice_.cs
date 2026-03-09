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
    [KnownType(typeof(FinancialInstrumentQuantity1Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity1Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity1Choice.AmortisedValue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity1Choice.Unit),nameof(FinancialInstrumentQuantity1Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity1Choice.FaceAmount),nameof(FinancialInstrumentQuantity1Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity1Choice.AmortisedValue),nameof(FinancialInstrumentQuantity1Choice.AmortisedValue))]
    #endif
    [IsoId("_SokiyNp-Ed-ak6NoX_4Aeg_-1672157653")]
    [DisplayName("Financial Instrument Quantity 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity1Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity1Choice_
    #endif
    {
    }
}
