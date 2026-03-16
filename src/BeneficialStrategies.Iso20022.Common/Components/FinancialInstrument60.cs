// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, for example, dividend option or valuation currency.
/// </summary>
[IsoId("_DKaXeYfuEeevKP8c-ilVhA")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument60
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_DbEplYfuEeevKP8c-ilVhA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification25Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_DbEpl4fuEeevKP8c-ilVhA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Financial Instrument Short Name (FISN) expressed in conformance with the ISO 18774 standard.
    /// </summary>
    [IsoId("_DbEpmYfuEeevKP8c-ilVhA")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ShortName { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument is transferred as an asset or as cash.
    /// </summary>
    [IsoId("_DbEpm4fuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType1Code TransferType { get; init; }

    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_DbEpnYfuEeevKP8c-ilVhA")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public Quantity12Choice_? Quantity { get; init; }

    /// <summary>
    /// Average cost per share of the security, including all fees.
    /// </summary>
    [IsoId("_DbEpn4fuEeevKP8c-ilVhA")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveOrHistoricCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Currency to be used to transfer the holdings. Some transfer agents register holdings grouped by currency in addition to using the ISIN for multi-currency fund shares.
    /// </summary>
    [IsoId("_DbEpoYfuEeevKP8c-ilVhA")]
    [DisplayName("Transfer Currency")]
    [IsoXmlTag("TrfCcy")]
    public ActiveOrHistoricCurrencyCode? TransferCurrency { get; init; }

    /// <summary>
    /// Net asset on the balance sheet, the total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_DbEpo4fuEeevKP8c-ilVhA")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; }

    /// <summary>
    /// Account held in the name of the party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_DbEppYfuEeevKP8c-ilVhA")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account24? TransfereeAccount { get; init; }

    /// <summary>
    /// Sub-account of the master or omnibus account.
    /// </summary>
    [IsoId("_DbEpp4fuEeevKP8c-ilVhA")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount5? SubAccountDetails { get; init; }

    /// <summary>
    /// Chain of parties involved in the settlement of a transaction.
    /// </summary>
    [IsoId("_DbEpqYfuEeevKP8c-ilVhA")]
    [DisplayName("Settlement Parties Receiving Side Details")]
    [IsoXmlTag("SttlmPtiesRcvgSdDtls")]
    public ReceivingPartiesAndAccount18? SettlementPartiesReceivingSideDetails { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_DbEpq4fuEeevKP8c-ilVhA")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public PartyIdentificationAndAccount156? DeliveringAgentDetails { get; init; }
}
