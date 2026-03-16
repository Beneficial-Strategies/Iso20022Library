// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Event Processing Status7Choice.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus7Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus7Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus7Choice.ProprietaryStatus))]
    [KnownType(typeof(EventProcessingStatus7Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus7Choice.Complete),nameof(EventProcessingStatus7Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus7Choice.Pending),nameof(EventProcessingStatus7Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus7Choice.ProprietaryStatus),nameof(EventProcessingStatus7Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(EventProcessingStatus7Choice.Reconciled),nameof(EventProcessingStatus7Choice.Reconciled))]
    [IsoId("_qB__EZB0Ee-COKgew96POA")]
    [DisplayName("Event Processing Status7Choice")]
    public abstract partial record EventProcessingStatus7Choice_
    {
    }
}
