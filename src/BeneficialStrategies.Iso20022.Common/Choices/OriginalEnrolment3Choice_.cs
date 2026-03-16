// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Original Enrolment3Choice.
    /// </summary>
    [KnownType(typeof(OriginalEnrolment3Choice.OriginalCreditorIdentification))]
    [KnownType(typeof(OriginalEnrolment3Choice.OriginalEnrolmentData))]
    [JsonDerivedType(
        typeof(OriginalEnrolment3Choice.OriginalCreditorIdentification),
        nameof(OriginalEnrolment3Choice.OriginalCreditorIdentification)
    )]
    [JsonDerivedType(
        typeof(OriginalEnrolment3Choice.OriginalEnrolmentData),
        nameof(OriginalEnrolment3Choice.OriginalEnrolmentData)
    )]
    [IsoId("_xDw1NTEyEe6g-ffJsqGiSA")]
    [DisplayName("Original Enrolment3Choice")]
    public abstract record OriginalEnrolment3Choice_ { }
}
