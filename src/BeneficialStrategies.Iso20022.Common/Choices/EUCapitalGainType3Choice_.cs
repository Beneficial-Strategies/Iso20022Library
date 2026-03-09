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
    [KnownType(typeof(EUCapitalGainType3Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(EUCapitalGainType3Choice.EUCapitalGain),nameof(EUCapitalGainType3Choice.EUCapitalGain))]
    [JsonDerivedType(typeof(EUCapitalGainType3Choice.Proprietary),nameof(EUCapitalGainType3Choice.Proprietary))]
    #endif
    [IsoId("_XolpcZBhEeakHoV5BVecAQ")]
    [DisplayName("EU Capital Gain Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record EUCapitalGainType3Choice_
    #else
    public abstract partial class EUCapitalGainType3Choice_
    #endif
    {
    }
}
