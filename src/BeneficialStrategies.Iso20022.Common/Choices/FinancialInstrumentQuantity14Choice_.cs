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
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity14Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.Unit),nameof(FinancialInstrumentQuantity14Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.FaceAmount),nameof(FinancialInstrumentQuantity14Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.AmortisedValue),nameof(FinancialInstrumentQuantity14Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity14Choice.Code),nameof(FinancialInstrumentQuantity14Choice.Code))]
    #endif
    [IsoId("_Wr_78Np-Ed-ak6NoX_4Aeg_-719785587")]
    [DisplayName("Financial Instrument Quantity 14 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity14Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity14Choice_
    #endif
    {
    }
}
