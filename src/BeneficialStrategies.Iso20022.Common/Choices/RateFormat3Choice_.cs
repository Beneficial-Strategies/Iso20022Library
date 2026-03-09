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
    [KnownType(typeof(RateFormat3Choice.Rate))]
    [KnownType(typeof(RateFormat3Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat3Choice.Rate),nameof(RateFormat3Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat3Choice.NotSpecifiedRate),nameof(RateFormat3Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UPO-ltp-Ed-ak6NoX_4Aeg_681666773")]
    [DisplayName("Rate Format 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat3Choice_
    #else
    public abstract partial class RateFormat3Choice_
    #endif
    {
    }
}
