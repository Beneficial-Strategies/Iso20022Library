// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.MarketClaimCancellationRequestStatus3Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between different instruction cancellation request statuses.</summary>
    [IsoId("_JYsmYa8xEfCx2aBifPEdRg")]
    [DisplayName("Market Claim Cancellation Request Status 3 Choice")]
    [KnownType(typeof(CancellationCompleted))]
    [JsonDerivedType(typeof(CancellationCompleted), nameof(CancellationCompleted))]
    [KnownType(typeof(Accepted))]
    [JsonDerivedType(typeof(Accepted), nameof(Accepted))]
    [KnownType(typeof(Rejected))]
    [JsonDerivedType(typeof(Rejected), nameof(Rejected))]
    [KnownType(typeof(PendingCancellation))]
    [JsonDerivedType(typeof(PendingCancellation), nameof(PendingCancellation))]
    [KnownType(typeof(ProprietaryStatus))]
    [JsonDerivedType(typeof(ProprietaryStatus), nameof(ProprietaryStatus))]
    public abstract record MarketClaimCancellationRequestStatus3Choice_;
}
