// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio1Choice
{
    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax.
    /// The Individual Savings Account (ISA) is provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_Ku_xm_pfEeCLMa5EIHtDrg")]
    [DisplayName("ISA")]
    [IsoXmlTag("ISA")]
    public record ISA : ISAPortfolio1Choice_
    {
        /// <summary>
        /// Current year of the Investment Saving Plan (ISA) that was issued during the current fiscal year.
        /// </summary>
        [IsoId("_3gENY0XfEeGY6MkiuzuPOA_1731435670")]
        [DisplayName("Current Year")]
        [IsoXmlTag("CurYr")]
        public CurrentYearType1Choice_? CurrentYear { get; init; }

        /// <summary>
        /// Indicates whether the ISA contains a cash component asset for transfer.
        /// </summary>
        [IsoId("_3gENZEXfEeGY6MkiuzuPOA_271903704")]
        [DisplayName("Cash Component Indicator")]
        [IsoXmlTag("CshCmpntInd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator CashComponentIndicator { get; init; }

        /// <summary>
        /// Selection of investment plans issued during previous years.
        /// </summary>
        [IsoId("_3gNXUEXfEeGY6MkiuzuPOA_-611329583")]
        [DisplayName("Previous Years")]
        [IsoXmlTag("PrvsYrs")]
        public PreviousYear2? PreviousYears { get; init; }

        /// <summary>
        /// Specifies the amounts already subscribed for the current year.
        /// </summary>
        [IsoId("_3gNXUUXfEeGY6MkiuzuPOA_-1608401936")]
        [DisplayName("Current Year Subscription Details")]
        [IsoXmlTag("CurYrSbcptDtls")]
        public SubscriptionInformation1? CurrentYearSubscriptionDetails { get; init; }
    }
}
