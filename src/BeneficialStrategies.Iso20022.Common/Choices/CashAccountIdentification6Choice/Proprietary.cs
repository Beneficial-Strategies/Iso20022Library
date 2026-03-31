// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification6Choice
{
    /// <summary>
    /// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
    /// </summary>
    [IsoId("_WO8MjNp-Ed-ak6NoX_4Aeg_-834802137")]
    [DisplayName("Proprietary")]
    public record Proprietary : CashAccountIdentification6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 34 characters limited to character set X, that is, a-z A-Z / - ? : ( ) . , ‘ + .
        /// </summary>
        [IsoXmlTag("Prtry")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINX2Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public required IsoRestrictedFINX2Max34Text Value { get; init; }
    }
}
