// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitOrError3Choice
{
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_Rf2uIZlhEeeE1Ya-LgRsuQ")]
    [DisplayName("Limit")]
    [IsoXmlTag("Lmt")]
    public record Limit : LimitOrError3Choice_
    {
        /// <summary>
        /// Amount of money of the limit, expressed in an eligible currency.
        /// </summary>
        [IsoId("_Rt38AZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required Amount2Choice_ Amount { get; init; }

        /// <summary>
        /// Specifies if a limit is a debit limit or a credit limit.
        /// </summary>
        [IsoId("_Rt38A5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Credit Debit Indicator")]
        [IsoXmlTag("CdtDbtInd")]
        public CreditDebitCode? CreditDebitIndicator { get; init; }

        /// <summary>
        /// Status of the limit, such as enabled or disabled.
        /// </summary>
        [IsoId("_Rt38BZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public LimitStatus1Code? Status { get; init; }

        /// <summary>
        /// Date and time at which the limit becomes effective.
        /// </summary>
        [IsoId("_Rt38B5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Start Date Time")]
        [IsoXmlTag("StartDtTm")]
        public DateAndDateTime2Choice_? StartDateTime { get; init; }

        /// <summary>
        /// Actual usage of the limit expressed as an amount.
        /// </summary>
        [IsoId("_Rt38CZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Used Amount")]
        [IsoXmlTag("UsdAmt")]
        public Amount2Choice_? UsedAmount { get; init; }

        /// <summary>
        /// Specifies if the used amount of the limit is a debit amount or a credit amount.
        /// </summary>
        [IsoId("_Rt38C5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Used Amount Credit Debit Indicator")]
        [IsoXmlTag("UsdAmtCdtDbtInd")]
        public CreditDebitCode? UsedAmountCreditDebitIndicator { get; init; }

        /// <summary>
        /// Actual usage of the limit expressed as a percentage.
        /// </summary>
        [IsoId("_Rt38DZlhEeeE1Ya-LgRsuQ")]
        [DisplayName("Used Percentage")]
        [IsoXmlTag("UsdPctg")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        public IsoPercentageRate? UsedPercentage { get; init; }

        /// <summary>
        /// Actual usage of the limit expressed as an amount.
        /// </summary>
        [IsoId("_Rt38D5lhEeeE1Ya-LgRsuQ")]
        [DisplayName("Remaining Amount")]
        [IsoXmlTag("RmngAmt")]
        public Amount2Choice_? RemainingAmount { get; init; }
    }
}
