// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status for the replacement processing.
    /// </summary>
    [KnownType(typeof(ReplacementProcessingStatus7Choice.Accepted))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.Completed))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.Denied))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.InRepair))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.PartialReplacementAccepted))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.Pending))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.ReceivedAtIntermediary))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.ReceivedAtStockExchange))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.Rejected))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.ModificationRequested))]
    [KnownType(typeof(ReplacementProcessingStatus7Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.Accepted),nameof(ReplacementProcessingStatus7Choice.Accepted))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.Completed),nameof(ReplacementProcessingStatus7Choice.Completed))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.Denied),nameof(ReplacementProcessingStatus7Choice.Denied))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.InRepair),nameof(ReplacementProcessingStatus7Choice.InRepair))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.PartialReplacementAccepted),nameof(ReplacementProcessingStatus7Choice.PartialReplacementAccepted))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.Pending),nameof(ReplacementProcessingStatus7Choice.Pending))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.ReceivedAtIntermediary),nameof(ReplacementProcessingStatus7Choice.ReceivedAtIntermediary))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.ReceivedAtStockExchange),nameof(ReplacementProcessingStatus7Choice.ReceivedAtStockExchange))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.Rejected),nameof(ReplacementProcessingStatus7Choice.Rejected))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.ModificationRequested),nameof(ReplacementProcessingStatus7Choice.ModificationRequested))]
    [JsonDerivedType(typeof(ReplacementProcessingStatus7Choice.ProprietaryStatus),nameof(ReplacementProcessingStatus7Choice.ProprietaryStatus))]
    [IsoId("_A5TcANokEeC60axPepSq7g_722143945")]
    [DisplayName("Replacement Processing Status 7 Choice")]
    public abstract partial record ReplacementProcessingStatus7Choice_
    {
    }
}
