// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides information about the status of a corporate action or the status of a payment.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus5Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus5Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus5Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus5Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.Complete),nameof(EventProcessingStatus5Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.Reconciled),nameof(EventProcessingStatus5Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.Pending),nameof(EventProcessingStatus5Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus5Choice.ProprietaryStatus),nameof(EventProcessingStatus5Choice.ProprietaryStatus))]
    [IsoId("_sSD3MeaEEemtTOaHuc_63w")]
    [DisplayName("Event Processing Status 5 Choice")]
    public abstract partial record EventProcessingStatus5Choice_
    {
    }
}
