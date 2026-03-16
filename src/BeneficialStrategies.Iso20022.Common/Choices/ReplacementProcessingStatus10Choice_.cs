// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the replacement processing.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Accepted))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Completed))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Denied))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.InRepair))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.PartialReplacementAccepted))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Pending))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ReceivedAtIntermediary))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ReceivedAtStockExchange))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.Rejected))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ModificationRequested))]
    [KnownType(typeof(ReplacementProcessingStatus10Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.Accepted),
        nameof(ReplacementProcessingStatus10Choice.Accepted)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.Completed),
        nameof(ReplacementProcessingStatus10Choice.Completed)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.Denied),
        nameof(ReplacementProcessingStatus10Choice.Denied)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.InRepair),
        nameof(ReplacementProcessingStatus10Choice.InRepair)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.PartialReplacementAccepted),
        nameof(ReplacementProcessingStatus10Choice.PartialReplacementAccepted)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.Pending),
        nameof(ReplacementProcessingStatus10Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.ReceivedAtIntermediary),
        nameof(ReplacementProcessingStatus10Choice.ReceivedAtIntermediary)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.ReceivedAtStockExchange),
        nameof(ReplacementProcessingStatus10Choice.ReceivedAtStockExchange)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.Rejected),
        nameof(ReplacementProcessingStatus10Choice.Rejected)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.ModificationRequested),
        nameof(ReplacementProcessingStatus10Choice.ModificationRequested)
    )]
    [JsonDerivedType(
        typeof(ReplacementProcessingStatus10Choice.ProprietaryStatus),
        nameof(ReplacementProcessingStatus10Choice.ProprietaryStatus)
    )]
    [IsoId("_RPMBxQeDEe2fOITqoTnSLQ")]
    [DisplayName("Replacement Processing Status 10 Choice")]
    public abstract record ReplacementProcessingStatus10Choice_ { }
}
