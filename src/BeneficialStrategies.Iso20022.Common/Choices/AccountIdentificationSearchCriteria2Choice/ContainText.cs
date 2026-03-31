// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentificationSearchCriteria2Choice
{
    /// <summary>
    /// Search for one or more accounts based on partial identification of the account(s).
    /// </summary>
    [IsoId("_g7QEumliEeGaMcKyqKNRfQ_-1833344609")]
    [DisplayName("Contain Text")]
    public record ContainText : AccountIdentificationSearchCriteria2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("CTTxt")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
