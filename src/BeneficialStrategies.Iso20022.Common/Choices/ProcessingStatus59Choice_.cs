// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides the status of a transaction.
    /// </summary>
    [KnownType(typeof(ProcessingStatus59Choice.Rejected))]
    [KnownType(typeof(ProcessingStatus59Choice.Cancelled))]
    [KnownType(typeof(ProcessingStatus59Choice.Accepted))]
    [JsonDerivedType(typeof(ProcessingStatus59Choice.Rejected),nameof(ProcessingStatus59Choice.Rejected))]
    [JsonDerivedType(typeof(ProcessingStatus59Choice.Cancelled),nameof(ProcessingStatus59Choice.Cancelled))]
    [JsonDerivedType(typeof(ProcessingStatus59Choice.Accepted),nameof(ProcessingStatus59Choice.Accepted))]
    [IsoId("_6HV0_ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Processing Status 59 Choice")]
    public abstract partial record ProcessingStatus59Choice_
    {
    }
}
