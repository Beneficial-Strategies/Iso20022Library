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
[IsoId("_Rpr4p9p-Ed-ak6NoX_4Aeg_-135162253")]
[DisplayName("Transaction Dates")]
public record TransactionDates2
{
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    [IsoId("_Rpr4qNp-Ed-ak6NoX_4Aeg_-135162161")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Identifies when an amount of money should have contractually been credited or debited the account versus when the amount of money was actually settled (debited/credited) on the cash account.
    /// </summary>
    [IsoId("_Rp1CkNp-Ed-ak6NoX_4Aeg_-939812305")]
    [DisplayName("Trade Activity Contractual Settlement Date")]
    [IsoXmlTag("TradActvtyCtrctlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeActivityContractualSettlementDate { get; init; }

    /// <summary>
    /// Date on which the trade was executed.
    /// </summary>
    [IsoId("_Rp1Ckdp-Ed-ak6NoX_4Aeg_-135161799")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_Rp1Cktp-Ed-ak6NoX_4Aeg_-135162222")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Start date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_Rp1Ck9p-Ed-ak6NoX_4Aeg_-135161738")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// End date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_Rp1ClNp-Ed-ak6NoX_4Aeg_-135161707")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }

    /// <summary>
    /// Date and time of the underlying transaction.
    /// </summary>
    [IsoId("_Rp1Cldp-Ed-ak6NoX_4Aeg_-135162100")]
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionDateTime { get; init; }

    /// <summary>
    /// Proprietary date related to the underlying transaction.
    /// </summary>
    [IsoId("_Rp1Cltp-Ed-ak6NoX_4Aeg_-135161675")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ProprietaryDate2? Proprietary { get; init; }
}
