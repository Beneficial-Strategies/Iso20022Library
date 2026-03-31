// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AccountIdentificationFormatChoice
{
    /// <summary>
    /// Identification of the account expressed with a data source scheme, a code used within the data source scheme and the account identification.
    /// </summary>
    [IsoId("_RB5f4dp-Ed-ak6NoX_4Aeg_1770326434")]
    [DisplayName("Identification As DSS")]
    [IsoXmlTag("IdAsDSS")]
    public record IdentificationAsDSS : AccountIdentificationFormatChoice_
    {
        /// <summary>
        /// Unique and unambiguous identification for the account between the account owner and the account servicer.
        /// </summary>
        [IsoId("_PoVr89p-Ed-ak6NoX_4Aeg_1372251027")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required AccountIdentification1 Identification { get; init; }

        /// <summary>
        /// Entity that assigns the information.
        /// </summary>
        [IsoId("_PoVr9Np-Ed-ak6NoX_4Aeg_2100019973")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8, MinimumLength = 1)]
        public required IsoMax8Text Issuer { get; init; }

        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_PoVr9dp-Ed-ak6NoX_4Aeg_2100019938")]
        [DisplayName("Information")]
        [IsoXmlTag("Inf")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public required IsoExact4AlphaNumericText Information { get; init; }
    }
}
