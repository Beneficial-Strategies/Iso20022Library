// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of a transaction.
    /// </summary>
    [KnownType(typeof(ProcessingStatus56Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus56Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus56Choice.Accepted))]
    [JsonDerivedType(typeof(ProcessingStatus56Choice.Rejected),nameof(ProcessingStatus56Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus56Choice.Cancelled),nameof(ProcessingStatus56Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus56Choice.Accepted),nameof(ProcessingStatus56Choice.Accepted))]
    [IsoId("_c72FMTt5EeW638lNyHKv7A")]
    [DisplayName("Processing Status 56 Choice")]
    public abstract partial record ProcessingStatus56Choice_
    {
    }
}
