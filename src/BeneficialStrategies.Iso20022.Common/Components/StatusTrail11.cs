// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the history of status and reasons for a pending, posted or cancelled transaction.
/// </summary>
[IsoId("_dsyaDji8Eeydid5dcNPKvg")]
[DisplayName("Status Trail")]
public record StatusTrail11
{
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_dsyaEDi8Eeydid5dcNPKvg")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime StatusDate { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the organisation that sent the message instance.
    /// </summary>
    [IsoId("_dsyaEji8Eeydid5dcNPKvg")]
    [DisplayName("Sending Organisation Identification")]
    [IsoXmlTag("SndgOrgId")]
    public OrganisationIdentification32? SendingOrganisationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    [IsoId("_dsyaFDi8Eeydid5dcNPKvg")]
    [DisplayName("User Identification")]
    [IsoXmlTag("UsrId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINXMax35Text? UserIdentification { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_dsyaFji8Eeydid5dcNPKvg")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus92Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    [IsoId("_dsyaGDi8Eeydid5dcNPKvg")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus30Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_dsyaGji8Eeydid5dcNPKvg")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus30Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_dsyaHDi8Eeydid5dcNPKvg")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus22Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    [IsoId("_dsyaHji8Eeydid5dcNPKvg")]
    [DisplayName("Modification Processing Status")]
    [IsoXmlTag("ModPrcgSts")]
    public ModificationProcessingStatus11Choice_? ModificationProcessingStatus { get; init; }

    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    [IsoId("_dsyaIDi8Eeydid5dcNPKvg")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public ProcessingStatus93Choice_? CancellationStatus { get; init; }

    /// <summary>
    /// Status is settled.
    /// </summary>
    [IsoId("_dsyaIji8Eeydid5dcNPKvg")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason5? Settled { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_dsyaJDi8Eeydid5dcNPKvg")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
