// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification54Choice
{
    /// <summary>
    /// E-mail identifying the account.
    /// </summary>
    [IsoId("_5q1FpVHSEey4xOoMoOPSJQ")]
    [DisplayName("E Mail")]
    public record EMail : AccountIdentification54Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 256 characters.
        /// </summary>
        [IsoXmlTag("EMail")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public required IsoMax256Text Value { get; init; }
    }
}
