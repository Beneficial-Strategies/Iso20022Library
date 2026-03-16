// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the meta data associated with a netting cut off report.
/// </summary>
[IsoId("_BuNM0QN1Ee2-vqzwMUAewg")]
[DisplayName("Netting Cut Off Report Data")]
public record NettingCutOffReportData2
{
    /// <summary>
    /// Unique and unambiguous identifier for a message, as assigned by the Sender. This unique identifier can be used for cross-referencing purposes in subsequent messages.
    /// </summary>
    [IsoId("_Bzi_0QN1Ee2-vqzwMUAewg")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; }

    /// <summary>
    /// Date and time at which the net report was generated.
    /// </summary>
    [IsoId("_Bzi_0wN1Ee2-vqzwMUAewg")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; }

    /// <summary>
    /// Describes the type of net report, indicating how the obligations have been calculated.
    /// </summary>
    [IsoId("_Bzi_1QN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Type")]
    [IsoXmlTag("RptTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public required IsoMax4Text ReportType { get; init; }

    /// <summary>
    /// Date on which the proposed netting cut off will become active.
    /// </summary>
    [IsoId("_Bzi_1wN1Ee2-vqzwMUAewg")]
    [DisplayName("Activation Date")]
    [IsoXmlTag("ActvtnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ActivationDate { get; init; }

    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_Bzi_2QN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Participant Identification")]
    [IsoXmlTag("NetSvcPtcptId")]
    public PartyIdentification242Choice_? NetServiceParticipantIdentification { get; init; }

    /// <summary>
    /// Describes the central system responsible for generating the net report.
    /// </summary>
    [IsoId("_Bzi_2wN1Ee2-vqzwMUAewg")]
    [DisplayName("Report Servicer")]
    [IsoXmlTag("RptSvcr")]
    public PartyIdentification242Choice_? ReportServicer { get; init; }

    /// <summary>
    /// Describes the type of netting service supporting the net report.
    /// </summary>
    [IsoId("_Bzi_3QN1Ee2-vqzwMUAewg")]
    [DisplayName("Net Service Type")]
    [IsoXmlTag("NetSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? NetServiceType { get; init; }

    /// <summary>
    /// Page number of the message (within the net cut off report) and continuation indicator to indicate that the report is to continue or that the message is the last page of the report.
    /// </summary>
    [IsoId("_Bzi_3wN1Ee2-vqzwMUAewg")]
    [DisplayName("Message Pagination")]
    [IsoXmlTag("MsgPgntn")]
    public Pagination1? MessagePagination { get; init; }
}
