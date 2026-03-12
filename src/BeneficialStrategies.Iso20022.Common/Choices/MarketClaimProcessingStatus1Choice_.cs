// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.Cancelled),nameof(MarketClaimProcessingStatus1Choice.Cancelled))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.AcceptedForFurtherProcessing),nameof(MarketClaimProcessingStatus1Choice.AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.Rejected),nameof(MarketClaimProcessingStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.Pending),nameof(MarketClaimProcessingStatus1Choice.Pending))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.MatchingStatus),nameof(MarketClaimProcessingStatus1Choice.MatchingStatus))]
    [JsonDerivedType(typeof(MarketClaimProcessingStatus1Choice.ProprietaryStatus),nameof(MarketClaimProcessingStatus1Choice.ProprietaryStatus))]
    [IsoId("_YGaIftx4EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Processing Status 1 Choice")]
    public abstract partial record MarketClaimProcessingStatus1Choice_
    {
    }
}
