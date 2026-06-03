// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the penalties for a given party.
/// </summary>
[IsoId("_xNODwagzEfCXwLUUylXgrQ")]
[DisplayName("Penalty4")]
public record Penalty4
{
    /// <summary>
    /// Currency of the penalties reported.
    /// </summary>
    [IsoId("_xQ9UQ6gzEfCXwLUUylXgrQ")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public required ActiveCurrencyCode Currency { get; init; }

    /// <summary>
    /// Date where the penalties reported in this block were initially computed.
    /// </summary>
    [IsoId("_xQ9URagzEfCXwLUUylXgrQ")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public DateAndDateTime2Choice? Date { get; init; }

    /// <summary>
    /// Unique identification of the party within the system.
    /// </summary>
    [IsoId("_xQ9UR6gzEfCXwLUUylXgrQ")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required PenaltyPartyIdentification1 PartyIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the party for which the aggregated amounts are referred to.
    /// </summary>
    [IsoId("_xQ9USagzEfCXwLUUylXgrQ")]
    [DisplayName("Counterparty CSD")]
    [IsoXmlTag("CtrPtyCSD")]
    public PartyIdentification136? CounterpartyCSD { get; init; }

    /// <summary>
    /// Depository/intermediary that is used by an ICSD to access a specific counterparty's CSD.
    /// </summary>
    [IsoId("_xQ9US6gzEfCXwLUUylXgrQ")]
    [DisplayName("CSD Depository")]
    [IsoXmlTag("CSDDpstry")]
    public PartyIdentification136? CSDDepository { get; init; }

    /// <summary>
    /// Aggregated penalty amount.
    /// </summary>
    [IsoId("_xQ9UU6gzEfCXwLUUylXgrQ")]
    [DisplayName("Aggregated Amount")]
    [IsoXmlTag("AggtdAmt")]
    public AggregatedPenaltyAmount1? AggregatedAmount { get; init; }

    /// <summary>
    /// Account to be debited/credited for the settlement of the penalty.
    /// </summary>
    [IsoId("_xQ9UVagzEfCXwLUUylXgrQ")]
    [DisplayName("Cash Account")]
    [IsoXmlTag("CshAcct")]
    public AccountIdentification4Choice? CashAccount { get; init; }

    /// <summary>
    /// Date on which the payment of the penalty is due.
    /// </summary>
    [IsoId("_xQ9UXagzEfCXwLUUylXgrQ")]
    [DisplayName("Cash Settlement Date")]
    [IsoXmlTag("CshSttlmDt")]
    public IsoISODate? CashSettlementDate { get; init; }

    /// <summary>
    /// Reference of the penalty payment.
    /// </summary>
    [IsoId("_xQ9UX6gzEfCXwLUUylXgrQ")]
    [DisplayName("Cash Penalty Identification")]
    [IsoXmlTag("CshPnltyId")]
    public IsoMax35Text? CashPenaltyIdentification { get; init; }

    /// <summary>
    /// Number of counterparties involved in the penalty.
    /// </summary>
    [IsoId("_xQ9UYagzEfCXwLUUylXgrQ")]
    [DisplayName("Number Of Counterparties")]
    [IsoXmlTag("NbOfCtrPties")]
    public IsoNumber? NumberOfCounterparties { get; init; }

    /// <summary>
    /// Claims (penalties) in a currency and of a date reported for a given party.
    /// </summary>
    [IsoId("_xQ9UY6gzEfCXwLUUylXgrQ")]
    [DisplayName("Penalty Per Counterparty")]
    [IsoXmlTag("PnltyPerCtrPty")]
    public ValueList<PenaltyPerCounterparty4> PenaltyPerCounterparty { get; init; } = [];
}
