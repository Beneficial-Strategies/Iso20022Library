// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonIdentificationType1Choice
{
    /// <summary>
    /// Identifier issued to a person for which no specific identifier has been defined.
    /// </summary>
    [IsoId("_QEW5mdp-Ed-ak6NoX_4Aeg_-315280529")]
    [DisplayName("Other Identification")]
    public record OtherIdentification : PersonIdentificationType1Choice_
    {
        /// <summary>
        /// Identifier issued to a person for which no specific identifier has been defined.
        /// </summary>
        [IsoId("_P-sWddp-Ed-ak6NoX_4Aeg_-1304682662")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Specifies the nature of the identifier.|Usage: IdentificationType is used to specify what kind of identifier is used. It should be used in case the identifier is different from the identifiers listed in the pre-defined identifier list.
        /// </summary>
        [IsoId("_P-sWdtp-Ed-ak6NoX_4Aeg_-1601134417")]
        [DisplayName("Identification Type")]
        [IsoXmlTag("IdTp")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text IdentificationType { get; init; }
    }
}
