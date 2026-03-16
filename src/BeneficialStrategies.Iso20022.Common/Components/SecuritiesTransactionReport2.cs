// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities transaction report.
/// </summary>
[IsoId("_CVjMkCrlEeWiy6-TnRWhpA")]
[DisplayName("Securities Transaction Report")]
public record SecuritiesTransactionReport2
{
    /// <summary>
    /// Unique and unambiguous identification of the transaction.
    /// </summary>
    [IsoId("_CVjMkyrlEeWiy6-TnRWhpA")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52, MinimumLength = 1)]
    public required IsoMax52Text TransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the entity executing the transaction.
    /// Usage:
    /// For legal entities, use the legal entity identifier. For non-legal entities, this field shall be populated with an identifier as specified in the local regulation.
    /// </summary>
    [IsoId("_CVjMmSrlEeWiy6-TnRWhpA")]
    [DisplayName("Executing Party")]
    [IsoXmlTag("ExctgPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier ExecutingParty { get; init; }

    /// <summary>
    /// Entity submitting the transaction report to the competent authority.
    /// </summary>
    [IsoId("_QrvSQFymEeWe9sWf-OA_kA")]
    [DisplayName("Submitting Party")]
    [IsoXmlTag("SubmitgPty")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier SubmittingParty { get; init; }

    /// <summary>
    /// Data used for exchanges between national competent authorities, not to be used by reporting entities.
    /// </summary>
    [IsoId("_vgWC4DH8EeWRJePX1ORoaw")]
    [DisplayName("Technical Attributes")]
    [IsoXmlTag("TechAttrbts")]
    public RecordTechnicalData2? TechnicalAttributes { get; init; }

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_WLYxoMpeEeW3lKrJLTgxRg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
