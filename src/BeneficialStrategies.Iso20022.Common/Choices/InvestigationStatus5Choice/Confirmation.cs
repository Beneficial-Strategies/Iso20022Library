// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus5Choice
{
    /// <summary>
    /// Specifies the status of the investigation, in a coded form.
    /// </summary>
    [IsoId("_NRkho249EeiU9cctagi5ow")]
    [DisplayName("Confirmation")]
    public record Confirmation : InvestigationStatus5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the result of an investigation, as published in an external investigation execution confirmation code set.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Conf")]
        public required ExternalInvestigationExecutionConfirmation1Code Value { get; init; }
    }
}
