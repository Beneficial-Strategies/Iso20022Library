// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepurchaseAgreementType3Choice
{
    /// <summary>
    /// Indicates that the repurchase agreement allows for the sale and repurchase of any of a selection of assets from a pool of eligible assets.
    /// </summary>
    [IsoId("_BqvK8-oaEeadseq5W5YLvQ")]
    [DisplayName("General Collateral")]
    [IsoXmlTag("GnlColl")]
    public record GeneralCollateral : RepurchaseAgreementType3Choice_
    {
        /// <summary>
        /// ISINs of allocated securities of general collateral where known.
        /// </summary>
        [IsoId("_plT7AfnbEeaHA8tUPpXMKA")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public FinancialInstrument59? FinancialInstrumentIdentification { get; init; }

        /// <summary>
        /// List of eligible securities to be allocated where known.
        /// </summary>
        [IsoId("_M-XbUeoaEeadseq5W5YLvQ")]
        [DisplayName("Eligible Financial Instrument Identification")]
        [IsoXmlTag("ElgblFinInstrmId")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? EligibleFinancialInstrumentIdentification { get; init; }
    }
}
