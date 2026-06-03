// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus2Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice between different instruction processing statuses.</summary>
    [IsoId("_GjbckbMaEfCEXew4g5B5oA")]
    [DisplayName("Market Claim Processing Status 2 Choice")]
    [KnownType(typeof(Cancelled))]
    [JsonDerivedType(typeof(Cancelled), nameof(Cancelled))]
    [KnownType(typeof(AcceptedForFurtherProcessing))]
    [JsonDerivedType(typeof(AcceptedForFurtherProcessing), nameof(AcceptedForFurtherProcessing))]
    [KnownType(typeof(Rejected))]
    [JsonDerivedType(typeof(Rejected), nameof(Rejected))]
    [KnownType(typeof(Pending))]
    [JsonDerivedType(typeof(Pending), nameof(Pending))]
    [KnownType(typeof(MatchingStatus))]
    [JsonDerivedType(typeof(MatchingStatus), nameof(MatchingStatus))]
    [KnownType(typeof(ProprietaryStatus))]
    [JsonDerivedType(typeof(ProprietaryStatus), nameof(ProprietaryStatus))]
    public abstract record MarketClaimProcessingStatus2Choice_;
}
