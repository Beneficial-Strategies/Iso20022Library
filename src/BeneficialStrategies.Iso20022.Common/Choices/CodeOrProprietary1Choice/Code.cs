// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CodeOrProprietary1Choice
{
    /// <summary>
    /// Element expressed as an ISO 20022 code from an external list.
    /// </summary>
    [IsoId("_Qotj19p-Ed-ak6NoX_4Aeg_-1924456739")]
    [DisplayName("Code")]
    public record Code : CodeOrProprietary1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 4 characters.
        /// </summary>
        [IsoXmlTag("Cd")]
        [IsoSimpleType(IsoSimpleType.Max4Text)]
        [StringLength(maximumLength: 4, MinimumLength = 1)]
        public required IsoMax4Text Value { get; init; }
    }
}
