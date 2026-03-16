// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate8Choice
{
    /// <summary>
    /// Interest rate is a variable / floating rate, based on an index.
    /// </summary>
    [IsoId("_IEREA35aEea2k7EBUopqxw")]
    [DisplayName("Floating")]
    public record Floating : InterestRate8Choice_
    {
        /// <summary>
        /// Identifies the reference index for the instrument.
        /// Usage:
        /// Index or name if the reference rate is not included in the index list.
        /// </summary>
        [IsoId("_Hq0pQX5aEea2k7EBUopqxw")]
        [DisplayName("Reference Rate")]
        [IsoXmlTag("RefRate")]
        public required BenchmarkCurveName5Choice_ ReferenceRate { get; init; }

        /// <summary>
        /// Term of the reference rate.
        /// </summary>
        [IsoId("_Hq0pQ35aEea2k7EBUopqxw")]
        [DisplayName("Term")]
        [IsoXmlTag("Term")]
        public InterestRateContractTerm2? Term { get; init; }
    }
}
