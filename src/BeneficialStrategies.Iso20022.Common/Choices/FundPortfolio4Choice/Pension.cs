// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio4Choice
{
    /// <summary>
    /// Portfolio is a pension policy, plan or scheme.
    /// </summary>
    [IsoId("_ViqWpZNMEemQB_8XA98K0Q")]
    [DisplayName("Pension")]
    [IsoXmlTag("Pnsn")]
    public record Pension : FundPortfolio4Choice_
    {
        /// <summary>
        /// Identification of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_7lP0cTOTEeqLMcD_sEa8Xw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PensionPolicy1? Identification { get; init; }

        /// <summary>
        /// Type of pension policy, plan or scheme.
        /// </summary>
        [IsoId("_7lP0czOTEeqLMcD_sEa8Xw")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public PensionSchemeType2Choice_? Type { get; init; }

        /// <summary>
        /// Scope of the pension policy, plan or scheme transfer.
        /// </summary>
        [IsoId("_7lP0dTOTEeqLMcD_sEa8Xw")]
        [DisplayName("Transfer Scope")]
        [IsoXmlTag("TrfScp")]
        public PensionTransferScope1Choice_? TransferScope { get; init; }

        /// <summary>
        /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
        /// </summary>
        [IsoId("_7lP0dzOTEeqLMcD_sEa8Xw")]
        [DisplayName("Tax Reference")]
        [IsoXmlTag("TaxRef")]
        public TaxReference1? TaxReference { get; init; }

        /// <summary>
        /// Reference of the drawdown.
        /// </summary>
        [IsoId("_7lP0eTOTEeqLMcD_sEa8Xw")]
        [DisplayName("Drawdown Tranche Identification")]
        [IsoXmlTag("DrwdwnTrchId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? DrawdownTrancheIdentification { get; init; }

        /// <summary>
        /// Additional information about the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_7lP0ezOTEeqLMcD_sEa8Xw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; }
    }
}
