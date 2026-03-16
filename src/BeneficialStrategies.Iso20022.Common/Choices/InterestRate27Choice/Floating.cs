// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate27Choice
{
    /// <summary>
    /// Details about the variable rate.
    /// </summary>
    [IsoId("_Z-T6U8g6Eeu4ecZgAYuz5w")]
    [DisplayName("Floating")]
    public record Floating : InterestRate27Choice_
    {
        /// <summary>
        /// Identifies the reference index for the debt instrument.
        /// </summary>
        [IsoId("_Z_09Q8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Reference Rate")]
        [IsoXmlTag("RefRate")]
        public BenchmarkCurveName10Choice_? ReferenceRate { get; init; }

        /// <summary>
        /// Term of the reference rate of the floating rate bond. The term shall be expressed in days, weeks, months or years.
        /// </summary>
        [IsoId("_Z_09Rcg6Eeu4ecZgAYuz5w")]
        [DisplayName("Term")]
        [IsoXmlTag("Term")]
        public InterestRateContractTerm2? Term { get; init; }

        /// <summary>
        /// Information related to payment frequency.
        /// </summary>
        [IsoId("_Z_09R8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Payment Frequency")]
        [IsoXmlTag("PmtFrqcy")]
        public InterestRateContractTerm2? PaymentFrequency { get; init; }

        /// <summary>
        /// Information related to the reset of payment frequency.
        /// </summary>
        [IsoId("_Z_09Scg6Eeu4ecZgAYuz5w")]
        [DisplayName("Reset Frequency")]
        [IsoXmlTag("RstFrqcy")]
        public InterestRateContractTerm2? ResetFrequency { get; init; }

        /// <summary>
        /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
        /// </summary>
        [IsoId("_Z_09S8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Spread")]
        [IsoXmlTag("Sprd")]
        public SecuritiesTransactionPrice18Choice_? Spread { get; init; }

        /// <summary>
        /// Specifies the rate adjustments as determined by the rate schedule.
        /// </summary>
        [IsoId("_Z_09Tcg6Eeu4ecZgAYuz5w")]
        [DisplayName("Rate Adjustment")]
        [IsoXmlTag("RateAdjstmnt")]
        public RateAdjustment1? RateAdjustment { get; init; }

        /// <summary>
        /// Method for calculating the accrued interest on the principal amount for a fixed rate.
        /// </summary>
        [IsoId("_Z_09T8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Day Count Basis")]
        [IsoXmlTag("DayCntBsis")]
        public InterestComputationMethodFormat6Choice_? DayCountBasis { get; init; }
    }
}
