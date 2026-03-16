// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements identifying the dates related to the underlying transactions.
/// </summary>
[IsoId("_RUrR99p-Ed-ak6NoX_4Aeg_1881477218")]
[DisplayName("Transaction Dates")]
public record TransactionDates1
{
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent (debtor&apos;s agent in case of a credit transfer, creditor&apos;s agent in case of a direct debit). This means - amongst others - that the account servicing agent has received the payment order and has applied checks as eg, authorisation, availability of funds.
    /// </summary>
    [IsoId("_RUrR-Np-Ed-ak6NoX_4Aeg_-1547227036")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <summary>
    /// Date on which the trade was executed.
    /// </summary>
    [IsoId("_RU0b4Np-Ed-ak6NoX_4Aeg_-963564510")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? TradeDate { get; init; }

    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    [IsoId("_RU0b4dp-Ed-ak6NoX_4Aeg_-2022842250")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <summary>
    /// Start date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_RU0b4tp-Ed-ak6NoX_4Aeg_-287547761")]
    [DisplayName("Start Date")]
    [IsoXmlTag("StartDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? StartDate { get; init; }

    /// <summary>
    /// End date of the underlying transaction, such as a treasury transaction, an investment plan.
    /// </summary>
    [IsoId("_RU0b49p-Ed-ak6NoX_4Aeg_-287547743")]
    [DisplayName("End Date")]
    [IsoXmlTag("EndDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? EndDate { get; init; }

    /// <summary>
    /// Date and time of the underlying transaction.
    /// </summary>
    [IsoId("_RU0b5Np-Ed-ak6NoX_4Aeg_-1175050973")]
    [DisplayName("Transaction Date Time")]
    [IsoXmlTag("TxDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? TransactionDateTime { get; init; }

    /// <summary>
    /// Proprietary date related to the underlying transaction.
    /// </summary>
    [IsoId("_RU0b5dp-Ed-ak6NoX_4Aeg_768963176")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    public ValueList<ProprietaryDate1> Proprietary { get; init; } = [];
}
