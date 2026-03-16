// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides information about the status of a corporate action or the status of a payment.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus6Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus6Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus6Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus6Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(EventProcessingStatus6Choice.Complete),
        nameof(EventProcessingStatus6Choice.Complete)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus6Choice.Reconciled),
        nameof(EventProcessingStatus6Choice.Reconciled)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus6Choice.Pending),
        nameof(EventProcessingStatus6Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus6Choice.ProprietaryStatus),
        nameof(EventProcessingStatus6Choice.ProprietaryStatus)
    )]
    [IsoId("_Szi6OgVREeqjd8n6wD9JVw")]
    [DisplayName("Event Processing Status 6 Choice")]
    public abstract record EventProcessingStatus6Choice_ { }
}
