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
    /// Choice between an indicator or a proprietary code to specify whether the security is a temporary security.
    /// </summary>
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator4Choice.TemporaryIndicator))]
    [KnownType(typeof(TemporaryFinancialInstrumentIndicator4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TemporaryFinancialInstrumentIndicator4Choice.TemporaryIndicator),nameof(TemporaryFinancialInstrumentIndicator4Choice.TemporaryIndicator))]
    [JsonDerivedType(typeof(TemporaryFinancialInstrumentIndicator4Choice.Proprietary),nameof(TemporaryFinancialInstrumentIndicator4Choice.Proprietary))]
    #endif
    [IsoId("_cj_8O5KQEeWHWpTQn1FFVg")]
    [DisplayName("Temporary Financial Instrument Indicator 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TemporaryFinancialInstrumentIndicator4Choice_
    #else
    public abstract partial class TemporaryFinancialInstrumentIndicator4Choice_
    #endif
    {
    }
}
