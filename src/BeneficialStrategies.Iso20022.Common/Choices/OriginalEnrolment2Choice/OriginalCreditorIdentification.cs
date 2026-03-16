// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalEnrolment2Choice
{
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the original creditor.
    /// Usage:
    /// This element must be identical to the creditor identification in the original creditor enrolment.
    /// </summary>
    [IsoId("_UZbOIeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Creditor Identification")]
    public record OriginalCreditorIdentification : OriginalEnrolment2Choice_ { }
}
