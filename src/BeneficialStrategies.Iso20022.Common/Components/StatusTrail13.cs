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
[IsoId("617628f5-cfc7-496d-8be5-a14dadab975f")]
[DisplayName("Status Trail13")]
public record StatusTrail13
{
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("7dd972d4-eb85-4450-beb5-a6daf648d90b")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public required IsoISODateTime StatusDate { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the organisation that sent the message instance.
    /// </summary>
    [IsoId("e5cfe75c-eeed-4d6f-bb4d-794eb13d5415")]
    [DisplayName("Sending Organisation Identification")]
    [IsoXmlTag("SndgOrgId")]
    public OrganisationIdentification31? SendingOrganisationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    [IsoId("42f06d21-b0b8-42f0-835d-c361ac4f825b")]
    [DisplayName("User Identification")]
    [IsoXmlTag("UsrId")]
    public IsoMax35Text? UserIdentification { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("38718fea-addd-4aa5-9fd0-1e56a67ae958")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus103Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    [IsoId("e3deab8a-e27b-4ed6-97fa-cf14f1254bf8")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus25Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("cf3b5414-3a7e-4633-beba-7d08cb6de069")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus25Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("86eb1da1-c943-4d9a-9e18-d7b3f2a718f7")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus32Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    [IsoId("ed3e8ffc-8d90-4f8f-8311-25aa7b1bce8b")]
    [DisplayName("Modification Processing Status")]
    [IsoXmlTag("ModPrcgSts")]
    public ModificationProcessingStatus13Choice_? ModificationProcessingStatus { get; init; }

    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    [IsoId("91b175a3-e828-4c4a-922e-6896c7e2ec1e")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public ProcessingStatus86Choice_? CancellationStatus { get; init; }

    /// <summary>
    /// Status is settled.
    /// </summary>
    [IsoId("6a77b065-4f20-47f7-9338-c42107c7886c")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("7d19cac3-5f30-4e0f-905b-92ffa81c0399")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
