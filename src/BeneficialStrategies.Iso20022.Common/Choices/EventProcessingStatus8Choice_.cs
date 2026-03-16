// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Event Processing Status8Choice.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus8Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus8Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus8Choice.ProprietaryStatus))]
    [KnownType(typeof(EventProcessingStatus8Choice.Reconciled))]
    [JsonDerivedType(
        typeof(EventProcessingStatus8Choice.Complete),
        nameof(EventProcessingStatus8Choice.Complete)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus8Choice.Pending),
        nameof(EventProcessingStatus8Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus8Choice.ProprietaryStatus),
        nameof(EventProcessingStatus8Choice.ProprietaryStatus)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus8Choice.Reconciled),
        nameof(EventProcessingStatus8Choice.Reconciled)
    )]
    [IsoId("_jWq525t3Ee-wQIOX0djF2w")]
    [DisplayName("Event Processing Status8Choice")]
    public abstract record EventProcessingStatus8Choice_ { }
}
