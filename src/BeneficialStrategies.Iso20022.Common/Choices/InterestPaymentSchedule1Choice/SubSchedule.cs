// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestPaymentSchedule1Choice
{
    /// <summary>
    /// Specifies an interest payment schedule, that is an interest amount that must be paid no sooner than the expected payment date and no later than the due date.
    /// </summary>
    [IsoId("_u7i5ReFWEeSvv6t4Ka7B7A")]
    [DisplayName("Sub Schedule")]
    [IsoXmlTag("SubSchdl")]
    public record SubSchedule : InterestPaymentSchedule1Choice_
    {
        /// <summary>
        /// Unique and unambiguous identification of the interest payment schedule.
        /// </summary>
        [IsoId("_es4FptOJEeSQ_-lmj1tzfw")]
        [DisplayName("Interest Schedule Identification")]
        [IsoXmlTag("IntrstSchdlId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? InterestScheduleIdentification { get; init; }

        /// <summary>
        /// Interest amount that must be paid at due date.
        /// </summary>
        [IsoId("_es4FqdOJEeSQ_-lmj1tzfw")]
        [DisplayName("Amount")]
        [IsoXmlTag("Amt")]
        public required ActiveCurrencyAndAmount Amount { get; init; }

        /// <summary>
        /// Latest date whereby the interest must be paid.
        /// </summary>
        [IsoId("_es4FqNOJEeSQ_-lmj1tzfw")]
        [DisplayName("Due Date")]
        [IsoXmlTag("DueDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate DueDate { get; init; }

        /// <summary>
        /// Further details on the interest payments.
        /// </summary>
        [IsoId("_obya8dOJEeSQ_-lmj1tzfw")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max1025Text)]
        [StringLength(maximumLength: 1025, MinimumLength = 1)]
        public IsoMax1025Text? AdditionalInformation { get; init; }
    }
}
