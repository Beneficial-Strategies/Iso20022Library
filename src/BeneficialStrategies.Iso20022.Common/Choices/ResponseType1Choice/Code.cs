// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ResponseType1Choice
{
    /// <summary>
    /// Provides a margin call response type using an ISO 20022 code.
    /// </summary>
    [IsoId("_QnOWF9p-Ed-ak6NoX_4Aeg_1829122886")]
    [DisplayName("Code")]
    public record Code : ResponseType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the margin call request was sent on a non valuation day or was received after notification time.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required MarginCallResponse1Code Value { get; init; }
    }
}
