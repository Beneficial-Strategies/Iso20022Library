// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus3Choice
{
    /// <summary>
    /// Specifies the status of the investigation, in a coded form.
    /// </summary>
    [IsoId("_tx5SAlkyEeGeoaLUQk__nA_-1832258084")]
    [DisplayName("Confirmation")]
    public record Confirmation : InvestigationStatus3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the result of an investigation.
        /// </summary>
        [IsoXmlTag("Conf")]
        public required InvestigationExecutionConfirmation3Code Value { get; init; }
    }
}
