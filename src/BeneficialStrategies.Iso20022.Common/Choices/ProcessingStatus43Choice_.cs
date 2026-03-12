// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of a status.
    /// </summary>
    [KnownType(typeof(ProcessingStatus43Choice.Received))]
    [KnownType(typeof(ProcessingStatus43Choice.Accepted))]
    [KnownType(typeof(ProcessingStatus43Choice.PendingProcessing))]
    [KnownType(typeof(ProcessingStatus43Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus43Choice.ProprietaryStatus))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.Received),nameof(ProcessingStatus43Choice.Received))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.Accepted),nameof(ProcessingStatus43Choice.Accepted))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.PendingProcessing),nameof(ProcessingStatus43Choice.PendingProcessing))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.Rejected),nameof(ProcessingStatus43Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus43Choice.ProprietaryStatus),nameof(ProcessingStatus43Choice.ProprietaryStatus))]
    [IsoId("_ezCkoVhFEeOMYfRGLS0NbA")]
    [DisplayName("Processing Status 43 Choice")]
    public abstract partial record ProcessingStatus43Choice_
    {
    }
}
