// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides information about the status of a corporate action or the status of a payment.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus4Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus4Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus4Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus4Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.Complete),nameof(EventProcessingStatus4Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.Reconciled),nameof(EventProcessingStatus4Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.Pending),nameof(EventProcessingStatus4Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus4Choice.ProprietaryStatus),nameof(EventProcessingStatus4Choice.ProprietaryStatus))]
    [IsoId("_cel395KQEeWHWpTQn1FFVg")]
    [DisplayName("Event Processing Status 4 Choice")]
    public abstract partial record EventProcessingStatus4Choice_
    {
    }
}
