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
    /// Choice of format to expressed a rate.
    /// </summary>
    [KnownType(typeof(RateFormat1Choice.Rate))]
    [KnownType(typeof(RateFormat1Choice.NotSpecifiedRate))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateFormat1Choice.Rate),nameof(RateFormat1Choice.Rate))]
    [JsonDerivedType(typeof(RateFormat1Choice.NotSpecifiedRate),nameof(RateFormat1Choice.NotSpecifiedRate))]
    #endif
    [IsoId("_UPh5htp-Ed-ak6NoX_4Aeg_-1635558299")]
    [DisplayName("Rate Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateFormat1Choice_
    #else
    public abstract partial class RateFormat1Choice_
    #endif
    {
    }
}
