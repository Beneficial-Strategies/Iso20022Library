// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.CancellationCompleted))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.Accepted))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.Rejected))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.PendingCancellation))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(MarketClaimCancellationRequestStatus1Choice.CancellationCompleted),
        nameof(MarketClaimCancellationRequestStatus1Choice.CancellationCompleted)
    )]
    [JsonDerivedType(
        typeof(MarketClaimCancellationRequestStatus1Choice.Accepted),
        nameof(MarketClaimCancellationRequestStatus1Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(MarketClaimCancellationRequestStatus1Choice.Rejected),
        nameof(MarketClaimCancellationRequestStatus1Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(MarketClaimCancellationRequestStatus1Choice.PendingCancellation),
        nameof(MarketClaimCancellationRequestStatus1Choice.PendingCancellation)
    )]
    [JsonDerivedType(
        typeof(MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus),
        nameof(MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus)
    )]
    [IsoId("_1TcqZtx4EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Cancellation Request Status 1 Choice")]
    public abstract record MarketClaimCancellationRequestStatus1Choice_ { }
}
