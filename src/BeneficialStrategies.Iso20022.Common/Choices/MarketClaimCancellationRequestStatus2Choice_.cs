// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Market Claim Cancellation Request Status2Choice.
    /// </summary>
    [KnownType(typeof(MarketClaimCancellationRequestStatus2Choice.Accepted))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus2Choice.CancellationCompleted))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus2Choice.PendingCancellation))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus2Choice.ProprietaryStatus))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus2Choice.Rejected))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus2Choice.Accepted),nameof(MarketClaimCancellationRequestStatus2Choice.Accepted))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus2Choice.CancellationCompleted),nameof(MarketClaimCancellationRequestStatus2Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus2Choice.PendingCancellation),nameof(MarketClaimCancellationRequestStatus2Choice.PendingCancellation))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus2Choice.ProprietaryStatus),nameof(MarketClaimCancellationRequestStatus2Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus2Choice.Rejected),nameof(MarketClaimCancellationRequestStatus2Choice.Rejected))]
    [IsoId("_A4VBYYYTEe-9jM3-w7OB3g")]
    [DisplayName("Market Claim Cancellation Request Status2Choice")]
    public abstract partial record MarketClaimCancellationRequestStatus2Choice_
    {
    }
}
