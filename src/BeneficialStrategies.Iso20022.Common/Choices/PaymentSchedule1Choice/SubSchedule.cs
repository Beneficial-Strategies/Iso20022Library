// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentSchedule1Choice
{
    /// <summary>
    /// Specifies a payment sub-schedule, that is the amount of money that must be paid no sooner than the expected date and no later than the latest shipment date.
    /// </summary>
    [IsoId("_Bhnbc9OAEeSQ_-lmj1tzfw")]
    [DisplayName("Sub Schedule")]
    public record SubSchedule : PaymentSchedule1Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of the payment schedule.
        /// </summary>
        [IsoId("_L71Bg9OJEeSQ_-lmj1tzfw")]
        [DisplayName("Payment Schedule Identification")]
        [IsoXmlTag("PmtSchdlId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? PaymentScheduleIdentification { get; init; }

        /// <summary>
        /// Amount that must be paid no sooner than the expected payment date and no later than the due date.
        /// </summary>
        [IsoId("_L71BgdOJEeSQ_-lmj1tzfw")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Expected date whereby the amount must be paid.
        /// </summary>
        [IsoId("_L71BgNOJEeSQ_-lmj1tzfw")]
        [DisplayName("Expected Date")]
        [IsoXmlTag("XpctdDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ExpectedDate { get; init; }

        /// <summary>
        /// Latest date whereby the amount of money must be paid.
        /// </summary>
        [IsoId("_L71Bf9OJEeSQ_-lmj1tzfw")]
        [DisplayName("Due Date")]
        [IsoXmlTag("DueDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate DueDate { get; init; }
    }
}
