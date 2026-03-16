// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityClassificationType2Choice
{
    /// <summary>
    /// Other type of classification of the financial instrument.
    /// </summary>
    [IsoId("_T81ZQ21MEeiqaPNRWUnGNA")]
    [DisplayName("Alternate Classification")]
    public record AlternateClassification : SecurityClassificationType2Choice_
    {
        /// <summary>
        /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
        /// </summary>
        [IsoId("_P-sWctp-Ed-ak6NoX_4Aeg_1256785338")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P-sWc9p-Ed-ak6NoX_4Aeg_1555083105")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
