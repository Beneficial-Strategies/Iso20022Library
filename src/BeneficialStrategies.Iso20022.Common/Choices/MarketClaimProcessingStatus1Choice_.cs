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
    /// Choice between different instruction processing statuses.
    /// </summary>
    [KnownType(typeof(MarketClaimProcessingStatus1Choice.Cancelled))]
    [KnownType(typeof(MarketClaimProcessingStatus1Choice.AcceptedForFurtherProcessing))]
    [KnownType(typeof(MarketClaimProcessingStatus1Choice.Rejected))]
    [KnownType(typeof(MarketClaimProcessingStatus1Choice.Pending))]
    [KnownType(typeof(MarketClaimProcessingStatus1Choice.MatchingStatus))]
    [KnownType(typeof(MarketClaimProcessingStatus1Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.Cancelled),nameof(MarketClaimProcessingStatus1Choice.Cancelled))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.AcceptedForFurtherProcessing),nameof(MarketClaimProcessingStatus1Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.Rejected),nameof(MarketClaimProcessingStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.Pending),nameof(MarketClaimProcessingStatus1Choice.Pending))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.MatchingStatus),nameof(MarketClaimProcessingStatus1Choice.MatchingStatus))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.ProprietaryStatus),nameof(MarketClaimProcessingStatus1Choice.ProprietaryStatus))]
    #endif
    [IsoId("_YGaIftx4EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Processing Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketClaimProcessingStatus1Choice_
    #else
    public abstract partial class MarketClaimProcessingStatus1Choice_
    #endif
    {
    }
}
