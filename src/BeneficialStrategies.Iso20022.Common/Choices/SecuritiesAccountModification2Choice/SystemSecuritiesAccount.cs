// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccountModification2Choice
{
    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_8IwTgTp0Eemk2e6qGBk8IQ")]
    [DisplayName("System Securities Account")]
    [IsoXmlTag("SysSctiesAcct")]
    public record SystemSecuritiesAccount : SecuritiesAccountModification2Choice_
    {
        /// <summary>
        /// Legal closing date of the securities account.
        /// </summary>
        [IsoId("_8VuYgTp0Eemk2e6qGBk8IQ")]
        [DisplayName("Closing Date")]
        [IsoXmlTag("ClsgDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ClosingDate { get; init; }

        /// <summary>
        /// Indicates whether the securities account is on hold or not.
        /// Usage:
        /// - Meaning when true: account is in hold status.
        /// - Meaning when false: account is in release status.
        /// </summary>
        [IsoId("_8VuYgzp0Eemk2e6qGBk8IQ")]
        [DisplayName("Hold Indicator")]
        [IsoXmlTag("HldInd")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? HoldIndicator { get; init; }

        /// <summary>
        /// Indicates whether the securities account can hold a negative position in a security or not.
        /// </summary>
        [IsoId("_8VuYhTp0Eemk2e6qGBk8IQ")]
        [DisplayName("Negative Position")]
        [IsoXmlTag("NegPos")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? NegativePosition { get; init; }

        /// <summary>
        /// Specifies information to identify securities accounts where allocation instructions are posted.
        /// </summary>
        [IsoId("_8VuYhzp0Eemk2e6qGBk8IQ")]
        [DisplayName("End Investor Flag")]
        [IsoXmlTag("EndInvstrFlg")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public IsoExact4AlphaNumericText? EndInvestorFlag { get; init; }

        /// <summary>
        /// Defines how the price is applied to the securities account.
        /// </summary>
        [IsoId("_8VuYiTp0Eemk2e6qGBk8IQ")]
        [DisplayName("Pricing Scheme")]
        [IsoXmlTag("PricgSchme")]
        [IsoSimpleType(IsoSimpleType.Exact4AlphaNumericText)]
        public IsoExact4AlphaNumericText? PricingScheme { get; init; }
    }
}
