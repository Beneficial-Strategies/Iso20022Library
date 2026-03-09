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
    /// Choice between a standard code or proprietary code to specify a deemed rate type.
    /// </summary>
    [KnownType(typeof(DeemedRateType2Choice.Code))]
    [KnownType(typeof(DeemedRateType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DeemedRateType2Choice.Code),nameof(DeemedRateType2Choice.Code))]
    [JsonDerivedType(typeof(DeemedRateType2Choice.Proprietary),nameof(DeemedRateType2Choice.Proprietary))]
    #endif
    [IsoId("_r25EEdBbEee0mNiKMkpGNQ")]
    [DisplayName("Deemed Rate Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DeemedRateType2Choice_
    #else
    public abstract partial class DeemedRateType2Choice_
    #endif
    {
    }
}
