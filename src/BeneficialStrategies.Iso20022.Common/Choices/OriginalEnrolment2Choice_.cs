// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the enrolment details which is referenced.
    /// </summary>
    [KnownType(typeof(OriginalEnrolment2Choice.OriginalCreditorIdentification))]
    [KnownType(typeof(OriginalEnrolment2Choice.OriginalEnrolmentData))]
    [JsonDerivedType(typeof(OriginalEnrolment2Choice.OriginalCreditorIdentification),nameof(OriginalEnrolment2Choice.OriginalCreditorIdentification))]
    [JsonDerivedType(typeof(OriginalEnrolment2Choice.OriginalEnrolmentData),nameof(OriginalEnrolment2Choice.OriginalEnrolmentData))]
    [IsoId("_UX7ZV-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Enrolment 2 Choice")]
    public abstract partial record OriginalEnrolment2Choice_
    {
    }
}
