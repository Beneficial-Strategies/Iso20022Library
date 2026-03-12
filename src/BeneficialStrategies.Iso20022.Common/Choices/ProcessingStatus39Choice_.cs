// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of a transaction (eg, at a non-matching CSD) as far as the message sender is concerned.
    /// </summary>
    [KnownType(typeof(ProcessingStatus39Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus39Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus39Choice.Accepted))]
    [JsonDerivedType(typeof(ProcessingStatus39Choice.Rejected),nameof(ProcessingStatus39Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus39Choice.Cancelled),nameof(ProcessingStatus39Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus39Choice.Accepted),nameof(ProcessingStatus39Choice.Accepted))]
    [IsoId("_lip6ACzREeOsiuMH68so7Q")]
    [DisplayName("Processing Status 39 Choice")]
    public abstract partial record ProcessingStatus39Choice_
    {
    }
}
