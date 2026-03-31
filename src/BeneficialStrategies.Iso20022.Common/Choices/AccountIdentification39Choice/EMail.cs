// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentification39Choice
{
    /// <summary>
    /// E-mail identifying the account.
    /// </summary>
    [IsoId("_mpl8ZdmpEeeN3v2fup_Shw")]
    [DisplayName("E Mail")]
    public record EMail : AccountIdentification39Choice_
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
