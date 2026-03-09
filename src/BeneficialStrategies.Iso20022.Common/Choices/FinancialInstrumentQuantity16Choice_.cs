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
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.FaceAmount))]
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.AmortisedValue))]
    [KnownType(typeof(FinancialInstrumentQuantity16Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.Unit),nameof(FinancialInstrumentQuantity16Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.FaceAmount),nameof(FinancialInstrumentQuantity16Choice.FaceAmount))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.AmortisedValue),nameof(FinancialInstrumentQuantity16Choice.AmortisedValue))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity16Choice.Code),nameof(FinancialInstrumentQuantity16Choice.Code))]
    #endif
    [IsoId("_CfV6b-GaEd-1Ktb5rVaajw")]
    [DisplayName("Financial Instrument Quantity 16 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity16Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity16Choice_
    #endif
    {
    }
}
