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
    /// Choice between different instruction cancellation request statuses.
    /// </summary>
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.CancellationCompleted))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.Accepted))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.Rejected))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.PendingCancellation))]
    [KnownType(typeof(MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus1Choice.CancellationCompleted),nameof(MarketClaimCancellationRequestStatus1Choice.CancellationCompleted))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus1Choice.Accepted),nameof(MarketClaimCancellationRequestStatus1Choice.Accepted))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus1Choice.Rejected),nameof(MarketClaimCancellationRequestStatus1Choice.Rejected))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus1Choice.PendingCancellation),nameof(MarketClaimCancellationRequestStatus1Choice.PendingCancellation))]
    [JsonDerivedType(typeof(MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus),nameof(MarketClaimCancellationRequestStatus1Choice.ProprietaryStatus))]
    #endif
    [IsoId("_1TcqZtx4EeqESbVR5AloZQ")]
    [DisplayName("Market Claim Cancellation Request Status 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record MarketClaimCancellationRequestStatus1Choice_
    #else
    public abstract partial class MarketClaimCancellationRequestStatus1Choice_
    #endif
    {
    }
}
