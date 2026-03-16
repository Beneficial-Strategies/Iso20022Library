// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the dates related to the underlying individual transaction.
/// </summary>
[IsoId("_rkenUa6OEeexrtTFgmVD3Q")]
[DisplayName("Transaction Dates")]
public record TransactionDates3
{
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_rtZ5066OEeexrtTFgmVD3Q")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Identifies when an amount of money should have contractually been credited or debited the account versus when the amount of money was actually settled (debited/credited) on the cash account.
    /// </summary>
    [IsoId("_rtZ51a6OEeexrtTFgmVD3Q")]
    [DisplayName("Trade Activity Contractual Settlement Date")]
    [IsoXmlTag("TradActvtyCtrctlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeActivityContractualSettlementDate { get; init; }

    /// <summary>
    /// Date on which the trade was executed.
    /// </summary>
    [IsoId("_rtZ5166OEeexrtTFgmVD3Q")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_rtZ52a6OEeexrtTFgmVD3Q")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Start date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_rtZ5266OEeexrtTFgmVD3Q")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// End date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_rtZ53a6OEeexrtTFgmVD3Q")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }

    /// <summary>
    /// Date and time of the underlying transaction.
    /// </summary>
    [IsoId("_rtZ5366OEeexrtTFgmVD3Q")]
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionDateTime { get; init; }

    /// <summary>
    /// Proprietary date related to the underlying transaction.
    /// </summary>
    [IsoId("_rtZ54a6OEeexrtTFgmVD3Q")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryDate3> Proprietary { get; init; } = [];
}
