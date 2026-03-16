// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the attributes of the benchmark, which is / are being created.
/// </summary>
[IsoId("_-mkGetOtEeilDKNlC_3bSg")]
[DisplayName("Benchmark Create")]
public record BenchmarkCreate1
{
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    [IsoId("_-mkGfdOtEeilDKNlC_3bSg")]
    [DisplayName("Technical Record Identification")]
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TechnicalRecordIdentification { get; init; }

    /// <summary>
    /// Unique identification of the benchmark.
    /// </summary>
    [IsoId("_-mkGf9OtEeilDKNlC_3bSg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification19 Identification { get; init; }

    /// <summary>
    /// Any other additional information about the benchmark.
    /// </summary>
    [IsoId("_-mktgNOtEeilDKNlC_3bSg")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public required BenchmarkDetail1 Other { get; init; }

    /// <summary>
    /// Set of identifiers of the party who is administrating the benchmark.
    /// </summary>
    [IsoId("_-mktg9OtEeilDKNlC_3bSg")]
    [DisplayName("Administrator")]
    [IsoXmlTag("Admstr")]
    public required PartyIdentification136 Administrator { get; init; }

    /// <summary>
    /// Set of identifiers of the party who is the supervised entity endorsing the benchmark.
    /// </summary>
    [IsoId("_-mktgdOtEeilDKNlC_3bSg")]
    [DisplayName("Endorsing Party")]
    [IsoXmlTag("NdrsngPty")]
    public PartyIdentification136? EndorsingParty { get; init; }

    /// <summary>
    /// Status of the decision taken by a relevant institution concerning the benchmark.
    /// </summary>
    [IsoId("_-mkGe9OtEeilDKNlC_3bSg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public StatusDetail1? Status { get; init; }

    /// <summary>
    /// Period of time when the associated record is technically valid.
    /// </summary>
    [IsoId("_-mktgtOtEeilDKNlC_3bSg")]
    [DisplayName("Technical Validity Period")]
    [IsoXmlTag("TechVldtyPrd")]
    public Period4Choice_? TechnicalValidityPeriod { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_-mkGftOtEeilDKNlC_3bSg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
