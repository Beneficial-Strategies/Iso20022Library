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
    /// Choice to specific an instrument of type ISIN, LEI or Index.
    /// </summary>
    [KnownType(typeof(FinancialInstrument48Choice.ISIN))]
    [KnownType(typeof(FinancialInstrument48Choice.LEI))]
    [KnownType(typeof(FinancialInstrument48Choice.Index))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrument48Choice.ISIN),nameof(FinancialInstrument48Choice.ISIN))]
    [JsonDerivedType(typeof(FinancialInstrument48Choice.LEI),nameof(FinancialInstrument48Choice.LEI))]
    [JsonDerivedType(typeof(FinancialInstrument48Choice.Index),nameof(FinancialInstrument48Choice.Index))]
    #endif
    [IsoId("_HQWTxX5aEea2k7EBUopqxw")]
    [DisplayName("Financial Instrument 48 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrument48Choice_
    #else
    public abstract partial class FinancialInstrument48Choice_
    #endif
    {
    }
}
