// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides information about the status of a corporate action or the status of a payment.
    /// </summary>
    [KnownType(typeof(EventProcessingStatus1Choice.Complete))]
    [KnownType(typeof(EventProcessingStatus1Choice.Reconciled))]
    [KnownType(typeof(EventProcessingStatus1Choice.Pending))]
    [KnownType(typeof(EventProcessingStatus1Choice.ProprietaryStatus))]
    [JsonDerivedType(
        typeof(EventProcessingStatus1Choice.Complete),
        nameof(EventProcessingStatus1Choice.Complete)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus1Choice.Reconciled),
        nameof(EventProcessingStatus1Choice.Reconciled)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus1Choice.Pending),
        nameof(EventProcessingStatus1Choice.Pending)
    )]
    [JsonDerivedType(
        typeof(EventProcessingStatus1Choice.ProprietaryStatus),
        nameof(EventProcessingStatus1Choice.ProprietaryStatus)
    )]
    [IsoId("_QxzOZ9p-Ed-ak6NoX_4Aeg_-1514957759")]
    [DisplayName("Event Processing Status 1 Choice")]
    public abstract record EventProcessingStatus1Choice_ { }
}
