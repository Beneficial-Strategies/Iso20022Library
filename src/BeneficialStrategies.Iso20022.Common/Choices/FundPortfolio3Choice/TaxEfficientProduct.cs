// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio3Choice
{
    /// <summary>
    /// Portfolio is a government scheme to encourage investment in securities based unit and investment trusts, offering certain tax benefits. These are not investments in their own right but are tax exempt &apos;wrappers&apos; in which equities, bonds and funds can be held to shelter them from various types of tax.
    /// In the UK, a typical tax wrapper product is known as an &apos;ISA&apos; (Individual Savings Account).
    /// </summary>
    [IsoId("_U5MVgU7cEeifNrXGwadPmg")]
    [DisplayName("Tax Efficient Product")]
    public record TaxEfficientProduct : FundPortfolio3Choice_
    {
        /// <summary>
        /// Type of tax efficient product, for example, an individual savings account (ISA) in the UK.
        /// </summary>
        [IsoId("_si-DMU7cEeifNrXGwadPmg")]
        [DisplayName("Tax Efficient Product Type")]
        [IsoXmlTag("TaxEffcntPdctTp")]
        public required TaxEfficientProductType1Choice_ TaxEfficientProductType { get; init; }

        /// <summary>
        /// Indicates whether the product contains a cash asset for transfer.
        /// </summary>
        [IsoId("_kAXwB07cEeifNrXGwadPmg")]
        [DisplayName("Cash Component Indicator")]
        [IsoXmlTag("CshCmpntInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? CashComponentIndicator { get; init; }

        /// <summary>
        /// Investment plans issued during previous years.
        /// </summary>
        [IsoId("_kAXwCU7cEeifNrXGwadPmg")]
        [DisplayName("Previous Years")]
        [IsoXmlTag("PrvsYrs")]
        public PreviousYear4? PreviousYears { get; init; }

        /// <summary>
        /// Amounts already subscribed for the current year.
        /// </summary>
        [IsoId("_kAXwC07cEeifNrXGwadPmg")]
        [DisplayName("Current Year Subscription Details")]
        [IsoXmlTag("CurYrSbcptDtls")]
        public SubscriptionInformation2? CurrentYearSubscriptionDetails { get; init; }

        /// <summary>
        /// Additional information about the tax efficient product.
        /// </summary>
        [IsoId("_c860D07fEeifNrXGwadPmg")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; }
    }
}
