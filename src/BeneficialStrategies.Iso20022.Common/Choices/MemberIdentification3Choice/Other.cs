// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MemberIdentification3Choice
{
    /// <summary>
    /// Unique identification of an agent, as assigned by an institution, using an identification scheme.
    /// </summary>
    [IsoId("_iR9Bh3SbEeiH1ZOt2UD8vQ")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public record Other : MemberIdentification3Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of a person.
        /// </summary>
        [IsoId("_QALkNNp-Ed-ak6NoX_4Aeg_-2141717392")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Identification { get; init; }

        /// <summary>
        /// Name of the identification scheme.
        /// </summary>
        [IsoId("_QALkNdp-Ed-ak6NoX_4Aeg_-2141717054")]
        [DisplayName("Scheme Name")]
        [IsoXmlTag("SchmeNm")]
        public FinancialIdentificationSchemeName1Choice_? SchemeName { get; init; }

        /// <summary>
        /// Entity that assigns the identification.
        /// </summary>
        [IsoId("_QALkNtp-Ed-ak6NoX_4Aeg_-2141717116")]
        [DisplayName("Issuer")]
        [IsoXmlTag("Issr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? Issuer { get; init; }
    }
}
