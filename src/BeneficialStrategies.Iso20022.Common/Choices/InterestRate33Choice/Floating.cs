// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate33Choice
{
    /// <summary>
    /// Attributes related specifically to floating rate of an interest rate contract.
    /// </summary>
    [IsoId("_CRCiEyJLEe2zWP9pqvmqdw")]
    [DisplayName("Floating")]
    public record Floating : InterestRate33Choice_
    {
        /// <summary>
        /// Identifier of the security subject of the transaction
        /// </summary>
        [IsoId("_WJf1EyJdEe2zWP9pqvmqdw")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        [IsoSimpleType(IsoSimpleType.ISINOct2015Identifier)]
        public IsoISINOct2015Identifier? Identification { get; init; }

        /// <summary>
        /// The full name of the interest rate as assigned by the index provider.
        /// </summary>
        [IsoId("_WJf1FSJdEe2zWP9pqvmqdw")]
        [DisplayName("Name")]
        [IsoXmlTag("Nm")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public IsoMax350Text? Name { get; init; }

        /// <summary>
        /// Indication of the floating rate used.
        /// </summary>
        [IsoId("_WJf1FyJdEe2zWP9pqvmqdw")]
        [DisplayName("Rate")]
        [IsoXmlTag("Rate")]
        public FloatingRateIdentification8Choice_? Rate { get; init; }

        /// <summary>
        /// Information related to reference period.
        /// </summary>
        [IsoId("_WJf1GSJdEe2zWP9pqvmqdw")]
        [DisplayName("Reference Period")]
        [IsoXmlTag("RefPrd")]
        public InterestRateContractTerm4? ReferencePeriod { get; init; }

        /// <summary>
        /// Indicates a margin, over or under an index, which determines a price or a rate for each leg of a derivative transaction with periodic payments; or a difference between two floating leg indexes.
        /// </summary>
        [IsoId("_WJf1GyJdEe2zWP9pqvmqdw")]
        [DisplayName("Spread")]
        [IsoXmlTag("Sprd")]
        public SecuritiesTransactionPrice20Choice_? Spread { get; init; }

        /// <summary>
        /// Identifies the computation method that determines how interest payments are calculated. It is used to compute the year fraction of the calculation period, and indicates the number of days in the calculation period divided by the number of days in the year.
        /// </summary>
        [IsoId("_WJf1HSJdEe2zWP9pqvmqdw")]
        [DisplayName("Day Count")]
        [IsoXmlTag("DayCnt")]
        public InterestComputationMethodFormat7? DayCount { get; init; }

        /// <summary>
        /// Specifies the time unit associated with the frequency of payments.
        /// </summary>
        [IsoId("_WJf1HyJdEe2zWP9pqvmqdw")]
        [DisplayName("Payment Frequency")]
        [IsoXmlTag("PmtFrqcy")]
        public InterestRateFrequency3Choice_? PaymentFrequency { get; init; }

        /// <summary>
        /// Information related to reset of payment frequency.
        /// </summary>
        [IsoId("_WJf1ISJdEe2zWP9pqvmqdw")]
        [DisplayName("Reset Frequency")]
        [IsoXmlTag("RstFrqcy")]
        public InterestRateFrequency3Choice_? ResetFrequency { get; init; }

        /// <summary>
        /// Indicates the nearest date in the future at which the floating reference rate will be reset.
        /// </summary>
        [IsoId("_WJf1IyJdEe2zWP9pqvmqdw")]
        [DisplayName("Next Floating Reset")]
        [IsoXmlTag("NxtFltgRst")]
        public ResetDateAndValue1? NextFloatingReset { get; init; }

        /// <summary>
        /// Most recent date and value at which the floating reference rate was reset.
        /// </summary>
        [IsoId("_iXROYCReEe2VuKUpJ7HXPg")]
        [DisplayName("Last Floating Reset")]
        [IsoXmlTag("LastFltgRst")]
        public ResetDateAndValue1? LastFloatingReset { get; init; }
    }
}
