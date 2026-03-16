// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatementBasisCodeAndDSSCodeChoice
{
    /// <summary>
    /// Statement basis expressed as a data source scheme and a code used within the data source scheme.
    /// </summary>
    [IsoId("_Q7Cp8tp-Ed-ak6NoX_4Aeg_-1630736025")]
    [DisplayName("Statement Basis As DSS")]
    public record StatementBasisAsDSS : StatementBasisCodeAndDSSCodeChoice_
    {
        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_luVtp-Ed-ak6NoX_4Aeg_858746211")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max8Text)]
        [StringLength(maximumLength: 8, MinimumLength = 1)]
        public required IsoMax8Text Issuer { get; init; }

        /// <summary>
        /// Proprietary information, often a code, issued by the data source scheme issuer.
        /// </summary>
        [IsoId("_P_luV9p-Ed-ak6NoX_4Aeg_858746099")]
        [DisplayName("Information")]
        [IsoXmlTag("Inf")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Information { get; init; }
    }
}
