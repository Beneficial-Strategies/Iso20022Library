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
    /// Choice between a rate or an unspecified rate.
    /// </summary>
    [KnownType(typeof(RateFormat22Choice.Rate))]
    [KnownType(typeof(RateFormat22Choice.Amount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat22Choice.Rate),nameof(RateFormat22Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat22Choice.Amount),nameof(RateFormat22Choice.Amount))]
    #endif
    [IsoId("_uFrRK68wEee2P-j6wtfM2A")]
    [DisplayName("Rate Format 22 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat22Choice_
    #else
    public abstract partial class RateFormat22Choice_
    #endif
    {
    }
}
