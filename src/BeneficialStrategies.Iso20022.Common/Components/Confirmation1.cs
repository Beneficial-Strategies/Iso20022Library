// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of confirmation in the CMU.
/// </summary>
[IsoId("_itJLUAJ-EeS2H9l84F_isg")]
[DisplayName("Confirmation")]
public record Confirmation1
{
    /// <summary>
    /// Identifies the status of the confirmation.
    /// </summary>
    [IsoId("_B6YGkAKDEeS2H9l84F_isg")]
    [DisplayName("Confirmation Status")]
    [IsoXmlTag("ConfSts")]
    public required TradeConfirmationStatus1Code ConfirmationStatus { get; init; }

    /// <summary>
    /// Time that both of parties confirm the trade.
    /// </summary>
    [IsoId("_RzrzQKazEeSxuMLA5o46jQ")]
    [DisplayName("Confirmation Time")]
    [IsoXmlTag("ConfTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ConfirmationTime { get; init; }

    /// <summary>
    /// Time that the trade party confirms the trade.
    /// </summary>
    [IsoId("_OKoP4AKGEeS2H9l84F_isg")]
    [DisplayName("Trade Party Confirmation Time")]
    [IsoXmlTag("TradPtyConfTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TradePartyConfirmationTime { get; init; }

    /// <summary>
    /// Time that the initiating party confirms the trade.
    /// </summary>
    [IsoId("_LLSw8AKGEeS2H9l84F_isg")]
    [DisplayName("Initiating Party Confirmation Time")]
    [IsoXmlTag("InitgPtyConfTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? InitiatingPartyConfirmationTime { get; init; }

    /// <summary>
    /// Identifies the type of confirmation message being sent.
    /// </summary>
    [IsoId("_5a5sUIHYEeSY3ulMDfpmvA")]
    [DisplayName("Confirmation Type")]
    [IsoXmlTag("ConfTp")]
    public required ConfirmationRequest1Code ConfirmationType { get; init; }

    /// <summary>
    /// Identifies the confirm request messge.
    /// </summary>
    [IsoId("_8SUZAKaxEeSxuMLA5o46jQ")]
    [DisplayName("Request Identification")]
    [IsoXmlTag("ReqId")]
    public required MessageIdentification1 RequestIdentification { get; init; }

    /// <summary>
    /// Start number in request result.
    /// </summary>
    [IsoId("_MhL0UKayEeSxuMLA5o46jQ")]
    [DisplayName("Query Start Number")]
    [IsoXmlTag("QryStartNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText QueryStartNumber { get; init; }

    /// <summary>
    /// Total number of reports returned in response to a request.
    /// </summary>
    [IsoId("_Wf7_4AKEEeS2H9l84F_isg")]
    [DisplayName("Total Number Of Reports")]
    [IsoXmlTag("TtlNbOfRpts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumberOfReports { get; init; }

    /// <summary>
    /// Query results will be grouped with fixed number. The field indicates that the total number of groups.
    /// </summary>
    [IsoId("_YpefQAKEEeS2H9l84F_isg")]
    [DisplayName("Page Number")]
    [IsoXmlTag("PgNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText PageNumber { get; init; }

    /// <summary>
    /// Page number in request result.
    /// </summary>
    [IsoId("_YXsvUKayEeSxuMLA5o46jQ")]
    [DisplayName("Query Page Number")]
    [IsoXmlTag("QryPgNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText QueryPageNumber { get; init; }

    /// <summary>
    /// Number of messages in current page.
    /// </summary>
    [IsoId("_CO9GQESsEeSTS-T7FO4CUQ")]
    [DisplayName("Message Number Of Current Page")]
    [IsoXmlTag("MsgNbOfCurPg")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber MessageNumberOfCurrentPage { get; init; }

    /// <summary>
    /// Number of reports at current page.
    /// </summary>
    [IsoId("_-32pYAKFEeS2H9l84F_isg")]
    [DisplayName("List Order Number")]
    [IsoXmlTag("ListOrdrNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber ListOrderNumber { get; init; }

    /// <summary>
    /// Indicate whether the current message is the last one of the current page or not.
    /// </summary>
    [IsoId("_eV2zQAKEEeS2H9l84F_isg")]
    [DisplayName("Last Page Indicator")]
    [IsoXmlTag("LastPgInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator LastPageIndicator { get; init; }

    /// <summary>
    /// Indicates whether this message is that last report message in response to a request.
    /// </summary>
    [IsoId("_B_YbAAKGEeS2H9l84F_isg")]
    [DisplayName("Last Report Requested")]
    [IsoXmlTag("LastRptReqd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator LastReportRequested { get; init; }
}
