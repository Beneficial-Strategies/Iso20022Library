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
    /// Specifies underlying instruments or index a derivative has.
    /// </summary>
    [KnownType(typeof(FinancialInstrument46Choice.ISIN))]
    [KnownType(typeof(FinancialInstrument46Choice.Index))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrument46Choice.ISIN),nameof(FinancialInstrument46Choice.ISIN))]
    [JsonDerivedType(typeof(FinancialInstrument46Choice.Index),nameof(FinancialInstrument46Choice.Index))]
    #endif
    [IsoId("_X1AUQ738EeWvRsMSLyTf-A")]
    [DisplayName("Financial Instrument 46 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrument46Choice_
    #else
    public abstract partial class FinancialInstrument46Choice_
    #endif
    {
    }
}
