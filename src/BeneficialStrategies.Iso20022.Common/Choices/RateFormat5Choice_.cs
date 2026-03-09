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
    [KnownType(typeof(RateFormat5Choice.Rate))]
    [KnownType(typeof(RateFormat5Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat5Choice.Rate),nameof(RateFormat5Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat5Choice.NotSpecifiedRate),nameof(RateFormat5Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UPF0p9p-Ed-ak6NoX_4Aeg_918914452")]
    [DisplayName("Rate Format 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat5Choice_
    #else
    public abstract partial class RateFormat5Choice_
    #endif
    {
    }
}
