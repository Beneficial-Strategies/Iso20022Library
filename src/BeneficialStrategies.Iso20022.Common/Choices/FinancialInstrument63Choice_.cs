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
    /// Choice of financial instrument.
    /// </summary>
    [KnownType(typeof(FinancialInstrument63Choice.Security))]
    [KnownType(typeof(FinancialInstrument63Choice.CashAsset))]
    [KnownType(typeof(FinancialInstrument63Choice.OtherAsset))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FinancialInstrument63Choice.Security),nameof(FinancialInstrument63Choice.Security))]
    [JsonDerivedType(typeof(FinancialInstrument63Choice.CashAsset),nameof(FinancialInstrument63Choice.CashAsset))]
    [JsonDerivedType(typeof(FinancialInstrument63Choice.OtherAsset),nameof(FinancialInstrument63Choice.OtherAsset))]
    #endif
    [IsoId("_nPXaoaPvEemf4IaGqCtquA")]
    [DisplayName("Financial Instrument 63 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FinancialInstrument63Choice_
    #else
    public abstract partial class FinancialInstrument63Choice_
    #endif
    {
    }
}
