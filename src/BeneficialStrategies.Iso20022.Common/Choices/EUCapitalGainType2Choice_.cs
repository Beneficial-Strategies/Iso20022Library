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
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType2Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EUCapitalGainType2Choice.EUCapitalGain),nameof(EUCapitalGainType2Choice.EUCapitalGain))]
    [JsonDerivedType(typeof(EUCapitalGainType2Choice.Proprietary),nameof(EUCapitalGainType2Choice.Proprietary))]
    #endif
    [IsoId("_f57zwNoqEeCWg-hsBVGrDA_-1171256508")]
    [DisplayName("EU Capital Gain Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUCapitalGainType2Choice_
    #else
    public abstract partial class EUCapitalGainType2Choice_
    #endif
    {
    }
}
