// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Incoterms4Choice
{
    /// <summary>
    /// Specifies the applicable Incoterm by means of a code.
    /// </summary>
    [IsoId("_S5ezYQEcEeCQm6a_G2yO_w_-666365163")]
    [DisplayName("Code")]
    public record Code : Incoterms4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the incoterms, as published in an external incoterms code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalIncoterms1Code Value { get; init; }
    }
}
