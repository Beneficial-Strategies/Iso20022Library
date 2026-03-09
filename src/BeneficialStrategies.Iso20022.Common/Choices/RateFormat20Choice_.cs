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
    [KnownType(typeof(RateFormat20Choice.Rate))]
    [KnownType(typeof(RateFormat20Choice.Amount))]
    [KnownType(typeof(RateFormat20Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat20Choice.Rate),nameof(RateFormat20Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat20Choice.Amount),nameof(RateFormat20Choice.Amount))]
    [JsonDerivedType(typeof(RateFormat20Choice.NotSpecifiedRate),nameof(RateFormat20Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_CpHdYUENEeWVgfuHGaKtRQ")]
    [DisplayName("Rate Format 20 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat20Choice_
    #else
    public abstract partial class RateFormat20Choice_
    #endif
    {
    }
}
