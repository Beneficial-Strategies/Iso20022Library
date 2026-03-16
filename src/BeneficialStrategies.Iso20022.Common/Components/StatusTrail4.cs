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
[IsoId("_hkjzQVhgEeS8HfHHd4stCA")]
[DisplayName("Status Trail")]
public record StatusTrail4
{
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_h_e0oVhgEeS8HfHHd4stCA")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime StatusDate { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the organisation that sent the message instance.
    /// </summary>
    [IsoId("_h_e0o1hgEeS8HfHHd4stCA")]
    [DisplayName("Sending Organisation Identification")]
    [IsoXmlTag("SndgOrgId")]
    public OrganisationIdentification7? SendingOrganisationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    [IsoId("_h_e0pVhgEeS8HfHHd4stCA")]
    [DisplayName("User Identification")]
    [IsoXmlTag("UsrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? UserIdentification { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_h_e0p1hgEeS8HfHHd4stCA")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus19Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    [IsoId("_h_e0qVhgEeS8HfHHd4stCA")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus7Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_h_e0q1hgEeS8HfHHd4stCA")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus7Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_h_e0rVhgEeS8HfHHd4stCA")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus7Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    [IsoId("_h_e0r1hgEeS8HfHHd4stCA")]
    [DisplayName("Modification Processing Status")]
    [IsoXmlTag("ModPrcgSts")]
    public ModificationProcessingStatus4Choice_? ModificationProcessingStatus { get; init; }

    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    [IsoId("_h_e0sVhgEeS8HfHHd4stCA")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public ProcessingStatus20Choice_? CancellationStatus { get; init; }

    /// <summary>
    /// Status is settled.
    /// </summary>
    [IsoId("_h_e0s1hgEeS8HfHHd4stCA")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason1? Settled { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_h_e0tVhgEeS8HfHHd4stCA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
