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
    /// Choice of formats for the EU capital gain.
    /// </summary>
    [KnownType(typeof(EUCapitalGain3Choice.Code))]
    [KnownType(typeof(EUCapitalGain3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EUCapitalGain3Choice.Code),nameof(EUCapitalGain3Choice.Code))]
    [JsonDerivedType(typeof(EUCapitalGain3Choice.Proprietary),nameof(EUCapitalGain3Choice.Proprietary))]
    #endif
    [IsoId("_6TX4YTh7EeaH-93K5JKmzw")]
    [DisplayName("EU Capital Gain 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUCapitalGain3Choice_
    #else
    public abstract partial class EUCapitalGain3Choice_
    #endif
    {
    }
}
