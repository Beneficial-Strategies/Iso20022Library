// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestRate2Choice
{
    /// <summary>
    /// Provides details about the variable rate.
    /// </summary>
    [IsoId("_lQ3UA-pnEeSsk6KxwbYJ9w")]
    [DisplayName("Floating")]
    [IsoXmlTag("Fltg")]
    public record Floating : InterestRate2Choice_
    {
        /// <summary>
        /// Identifies the reference index for the debt instrument.
        /// Usage:
        /// Where an identifier exists, the ISIN must be used; otherwise, names will be necessary (such as EURIBOR6M, LIBOR3M) as other identification.
        /// </summary>
        [IsoId("_rmIM8epnEeSsk6KxwbYJ9w")]
        [DisplayName("Reference Rate")]
        [IsoXmlTag("RefRate")]
        public required BenchmarkCurveName4Choice_ ReferenceRate { get; init; }

        /// <summary>
        /// Term of the index.
        /// </summary>
        [IsoId("_85QTUSSLEeW2Xf4A_zKwwg")]
        [DisplayName("Term")]
        [IsoXmlTag("Term")]
        public required InterestRateContractTerm1 Term { get; init; }

        /// <summary>
        /// Provides the number of basis points added to (if positive) or deducted from (if negative) the underlying reference rate to calculate the actual interest rate applicable for a given period at issuance of the floating rate instrument.
        /// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
        /// </summary>
        [IsoId("_r4PXcSSNEeW2Xf4A_zKwwg")]
        [DisplayName("Basis Point Spread")]
        [IsoXmlTag("BsisPtSprd")]
        [IsoSimpleType(IsoSimpleType.Number)]
        public required IsoNumber BasisPointSpread { get; init; }
    }
}
