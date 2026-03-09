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
    [KnownType(typeof(FinancialInstrumentQuantity18Choice.Unit))]
    [KnownType(typeof(FinancialInstrumentQuantity18Choice.FaceAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrumentQuantity18Choice.Unit),nameof(FinancialInstrumentQuantity18Choice.Unit))]
    [JsonDerivedType(typeof(FinancialInstrumentQuantity18Choice.FaceAmount),nameof(FinancialInstrumentQuantity18Choice.FaceAmount))]
    #endif
    [IsoId("_SrfnENorEeCWg-hsBVGrDA_1068412329")]
    [DisplayName("Financial Instrument Quantity 18 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrumentQuantity18Choice_
    #else
    public abstract partial class FinancialInstrumentQuantity18Choice_
    #endif
    {
    }
}
