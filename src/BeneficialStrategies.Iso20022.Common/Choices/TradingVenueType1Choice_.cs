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
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [KnownType(typeof(TradingVenueType1Choice.OnVenue))]
    [KnownType(typeof(TradingVenueType1Choice.OffVenue))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(TradingVenueType1Choice.OnVenue),nameof(TradingVenueType1Choice.OnVenue))]
    [JsonDerivedType(typeof(TradingVenueType1Choice.OffVenue),nameof(TradingVenueType1Choice.OffVenue))]
    #endif
    [IsoId("_MXZ-8Hy7Eeu1BeE84IrnAQ")]
    [DisplayName("Trading Venue Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record TradingVenueType1Choice_
    #else
    public abstract partial class TradingVenueType1Choice_
    #endif
    {
    }
}
