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
    /// Choice between a percentage rate or a rate name.
    /// </summary>
    [KnownType(typeof(RateOrName1Choice.Rate))]
    [KnownType(typeof(RateOrName1Choice.RateName))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RateOrName1Choice.Rate),nameof(RateOrName1Choice.Rate))]
    [JsonDerivedType(typeof(RateOrName1Choice.RateName),nameof(RateOrName1Choice.RateName))]
    #endif
    [IsoId("_Q-xTaNp-Ed-ak6NoX_4Aeg_-1686411263")]
    [DisplayName("Rate Or Name 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RateOrName1Choice_
    #else
    public abstract partial class RateOrName1Choice_
    #endif
    {
    }
}
