// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashAccountIdentification8Choice
{
    /// <summary>
    /// Unique identification of an account, as assigned by the account servicer, using an identification scheme.
    /// </summary>
    [IsoId("_lfxcBbfLEeuDTOqGwU_8EQ")]
    [DisplayName("Other")]
    public record Other : CashAccountIdentification8Choice_
    {
        /// <summary>
        /// Identification assigned by an institution.
        /// </summary>
        [IsoId("_P_u4Rtp-Ed-ak6NoX_4Aeg_2078970799")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max34Text)]
        [StringLength(maximumLength: 34, MinimumLength = 1)]
        public required IsoMax34Text Identification { get; init; }

        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_P_u4R9p-Ed-ak6NoX_4Aeg_-162653838")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        public AccountSchemeName1Choice_? SchemeName { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_P_u4SNp-Ed-ak6NoX_4Aeg_-2119026269")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
