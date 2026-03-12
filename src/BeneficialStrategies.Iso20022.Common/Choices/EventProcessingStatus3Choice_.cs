// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides information about the status of a corporate action or the status of a payment.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus3Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus3Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus3Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus3Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.Complete),nameof(EventProcessingStatus3Choice.Complete))]
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.Reconciled),nameof(EventProcessingStatus3Choice.Reconciled))]
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.Pending),nameof(EventProcessingStatus3Choice.Pending))]
    [JsonDerivedType(typeof(EventProcessingStatus3Choice.ProprietaryStatus),nameof(EventProcessingStatus3Choice.ProprietaryStatus))]
    [IsoId("_s1KyAUGSEeWqy4niLuXETA")]
    [DisplayName("Event Processing Status 3 Choice")]
    public abstract partial record EventProcessingStatus3Choice_
    {
    }
}
