// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BenchmarkReport1Choice
{
    /// <summary>
    /// Update of a benchmark.
    /// </summary>
    [IsoId("_DzGLgjrgEeedCZZ8dIPp6g")]
    [DisplayName("Update")]
    public record Update : BenchmarkReport1Choice_
    {
        /// <summary>
        /// Unique identifier of a record in a message used as part of error management and status advice messages.
        /// </summary>
        [IsoId("_ntONXDrcEeedCZZ8dIPp6g")]
        [DisplayName("Technical Record Identification")]
        [IsoXmlTag("TechRcrdId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? TechnicalRecordIdentification { get; init; }

        /// <summary>
        /// Unique identification of the benchmark.
        /// </summary>
        [IsoId("_6vngMDrcEeedCZZ8dIPp6g")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public required SecurityIdentification19 Identification { get; init; }

        /// <summary>
        /// Unique identification of the benchmark, as previously defined.
        /// </summary>
        [IsoId("_KqtcwEn4EeexwKvkdw4OGA")]
        [DisplayName("Previous Identification")]
        [IsoXmlTag("PrvsId")]
        public SecurityIdentification19? PreviousIdentification { get; init; }

        /// <summary>
        /// Any other additional information about the benchmark.
        /// </summary>
        [IsoId("_ntONWDrcEeedCZZ8dIPp6g")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public required BenchmarkDetail1 Other { get; init; }

        /// <summary>
        /// Set of identifiers of the party who is administrating the benchmark.
        /// </summary>
        [IsoId("_gYeWIGFkEeeAEKez2LaLwA")]
        [DisplayName("Administrator")]
        [IsoXmlTag("Admstr")]
        public required PartyIdentification136 Administrator { get; init; }

        /// <summary>
        /// Set of identifiers of the party who is the supervised entity endorsing the benchmark.
        /// </summary>
        [IsoId("_qZsjcGFkEeeAEKez2LaLwA")]
        [DisplayName("Endorsing Party")]
        [IsoXmlTag("NdrsngPty")]
        public PartyIdentification136? EndorsingParty { get; init; }

        /// <summary>
        /// Status of the decision taken by a relevant institution concerning the benchmark.
        /// </summary>
        [IsoId("_ntONXTrcEeedCZZ8dIPp6g")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public StatusDetail1? Status { get; init; }

        /// <summary>
        /// Period of time when the associated record is technically valid.
        /// </summary>
        [IsoId("_ntONWjrcEeedCZZ8dIPp6g")]
        [DisplayName("Technical Validity Period")]
        [IsoXmlTag("TechVldtyPrd")]
        public Period4Choice_? TechnicalValidityPeriod { get; init; }

        /// <summary>
        /// Additional information that can not be captured in the structured fields and/or any other specific block.
        /// </summary>
        [IsoId("_ntONWzrcEeedCZZ8dIPp6g")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
