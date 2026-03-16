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
[IsoId("_Ui2OAewMEeiazoAmcoGsBQ")]
[DisplayName("Status Trail")]
public record StatusTrail8
{
    /// <summary>
    /// Date and time at which the status was assigned.
    /// </summary>
    [IsoId("_U2e7sewMEeiazoAmcoGsBQ")]
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime StatusDate { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the organisation that sent the message instance.
    /// </summary>
    [IsoId("_U2e7s-wMEeiazoAmcoGsBQ")]
    [DisplayName("Sending Organisation Identification")]
    [IsoXmlTag("SndgOrgId")]
    public OrganisationIdentification31? SendingOrganisationIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous way to identify the user that created the message instance.
    /// </summary>
    [IsoId("_U2e7tewMEeiazoAmcoGsBQ")]
    [DisplayName("User Identification")]
    [IsoXmlTag("UsrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? UserIdentification { get; init; }

    /// <summary>
    /// Provides details on the processing status of the transaction.
    /// </summary>
    [IsoId("_U2e7t-wMEeiazoAmcoGsBQ")]
    [DisplayName("Processing Status")]
    [IsoXmlTag("PrcgSts")]
    public ProcessingStatus75Choice_? ProcessingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of an instruction as per the account servicer or the Market Infrastructure based on an allegement. At this time no matching took place on the market (at the CSD/ICSD/MI).
    /// </summary>
    [IsoId("_U2e7uewMEeiazoAmcoGsBQ")]
    [DisplayName("Inferred Matching Status")]
    [IsoXmlTag("IfrrdMtchgSts")]
    public MatchingStatus25Choice_? InferredMatchingStatus { get; init; }

    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_U2e7u-wMEeiazoAmcoGsBQ")]
    [DisplayName("Matching Status")]
    [IsoXmlTag("MtchgSts")]
    public MatchingStatus25Choice_? MatchingStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of a transaction.
    /// </summary>
    [IsoId("_U2e7vewMEeiazoAmcoGsBQ")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus17Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Provides details on the modification processing status of the transaction.
    /// </summary>
    [IsoId("_U2e7v-wMEeiazoAmcoGsBQ")]
    [DisplayName("Modification Processing Status")]
    [IsoXmlTag("ModPrcgSts")]
    public ModificationProcessingStatus7Choice_? ModificationProcessingStatus { get; init; }

    /// <summary>
    /// Provides details on the processing status of the cancellation request.
    /// </summary>
    [IsoId("_U2e7wewMEeiazoAmcoGsBQ")]
    [DisplayName("Cancellation Status")]
    [IsoXmlTag("CxlSts")]
    public ProcessingStatus53Choice_? CancellationStatus { get; init; }

    /// <summary>
    /// Status is settled.
    /// </summary>
    [IsoId("_U2e7w-wMEeiazoAmcoGsBQ")]
    [DisplayName("Settled")]
    [IsoXmlTag("Sttld")]
    public ProprietaryReason4? Settled { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U2e7xewMEeiazoAmcoGsBQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
