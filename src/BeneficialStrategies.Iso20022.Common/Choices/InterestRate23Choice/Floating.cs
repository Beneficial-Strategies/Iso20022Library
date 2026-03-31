// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate23Choice
{
    /// <summary>
    /// Attributes related specifically to floating rate of an interest rate contract.
    /// </summary>
    [IsoId("_6ao5k1fREeqqKf65rDYWYw")]
    [DisplayName("Floating")]
    [IsoXmlTag("Fltg")]
    public record Floating : InterestRate23Choice_
    {
        /// <summary>
        /// Indication of the floating rate used.
        /// </summary>
        [IsoId("_61uTE1fREeqqKf65rDYWYw")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        public FloatingRateIdentification4Choice_? Rate { get; init; }

        /// <summary>
        /// Information related to reference period.
        /// </summary>
        [IsoId("_61uTFVfREeqqKf65rDYWYw")]
        [DisplayName("Reference Period")]
        [IsoXmlTag("RefPrd")]
        public InterestRateContractTerm4? ReferencePeriod { get; init; }

        /// <summary>
        /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
        /// </summary>
        [IsoId("_61uTF1fREeqqKf65rDYWYw")]
        [DisplayName("Spread")]
        [IsoXmlTag("Sprd")]
        public SecuritiesTransactionPrice13Choice_? Spread { get; init; }

        /// <summary>
        /// Identifies the computation method that determines how interest payments are calculated. It is used to compute the year fraction of the calculation period, and indicates the number of days in the calculation period divided by the number of days in the year.
        /// </summary>
        [IsoId("_61uTGVfREeqqKf65rDYWYw")]
        [DisplayName("Day Count")]
        [IsoXmlTag("DayCnt")]
        public InterestComputationMethodFormat7? DayCount { get; init; }

        /// <summary>
        /// Specifies the time unit associated with the frequency of payments.
        /// </summary>
        [IsoId("_61uTG1fREeqqKf65rDYWYw")]
        [DisplayName("Payment Frequency")]
        [IsoXmlTag("PmtFrqcy")]
        public InterestRateFrequency3Choice_? PaymentFrequency { get; init; }

        /// <summary>
        /// Information related to reset of payment frequency.
        /// </summary>
        [IsoId("_61uTHVfREeqqKf65rDYWYw")]
        [DisplayName("Reset Frequency")]
        [IsoXmlTag("RstFrqcy")]
        public InterestRateFrequency3Choice_? ResetFrequency { get; init; }
    }
}
