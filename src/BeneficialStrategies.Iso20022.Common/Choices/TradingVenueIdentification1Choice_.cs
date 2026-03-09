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
    /// Trade venue related fields.
    /// </summary>
    [KnownType(typeof(TradingVenueIdentification1Choice.MarketIdentificationCode))]
    [KnownType(typeof(TradingVenueIdentification1Choice.NationalCompetentAuthority))]
    [KnownType(typeof(TradingVenueIdentification1Choice.Other))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradingVenueIdentification1Choice.MarketIdentificationCode),nameof(TradingVenueIdentification1Choice.MarketIdentificationCode))]
    [JsonDerivedType(typeof(TradingVenueIdentification1Choice.NationalCompetentAuthority),nameof(TradingVenueIdentification1Choice.NationalCompetentAuthority))]
    [JsonDerivedType(typeof(TradingVenueIdentification1Choice.Other),nameof(TradingVenueIdentification1Choice.Other))]
    #endif
    [IsoId("_3sh9EhtGEeWhp-Wous5jzA")]
    [DisplayName("Trading Venue Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradingVenueIdentification1Choice_
    #else
    public abstract partial class TradingVenueIdentification1Choice_
    #endif
    {
    }
}
