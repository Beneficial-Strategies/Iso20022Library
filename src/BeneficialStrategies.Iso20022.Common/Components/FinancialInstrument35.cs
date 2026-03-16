// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Security that is a sub-set of an investment fund, and is governed by the same investment fund policy, eg, dividend option or valuation currency.
/// </summary>
[IsoId("_m8MGERw5EeOIveEnnb_1-A")]
[DisplayName("Financial Instrument")]
public record FinancialInstrument35
{
    /// <summary>
    /// Unique and unambiguous identifier of a security, assigned under a formal or proprietary identification scheme.
    /// </summary>
    [IsoId("_nUSdBRw5EeOIveEnnb_1-A")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required SecurityIdentification3Choice_ Identification { get; init; }

    /// <summary>
    /// Name of the financial instrument in free format text.
    /// </summary>
    [IsoId("_nUSdBxw5EeOIveEnnb_1-A")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? Name { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument is transferred as an asset or as cash.
    /// </summary>
    [IsoId("_nUSdCRw5EeOIveEnnb_1-A")]
    [DisplayName("Transfer Type")]
    [IsoXmlTag("TrfTp")]
    public required TransferType1Code TransferType { get; init; }

    /// <summary>
    /// Specifies the quantity of assets to be transferred in units or in a percentage rate.
    /// </summary>
    [IsoId("_nUSdCxw5EeOIveEnnb_1-A")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required Quantity14Choice_ Quantity { get; init; }

    /// <summary>
    /// Average cost per share of a security, including all charges and commissions.
    /// </summary>
    [IsoId("_nUSdDRw5EeOIveEnnb_1-A")]
    [DisplayName("Average Acquisition Price")]
    [IsoXmlTag("AvrgAcqstnPric")]
    public ActiveCurrencyAndAmount? AverageAcquisitionPrice { get; init; }

    /// <summary>
    /// Net asset on balance sheet - total portfolio value minus or plus the unrealised gain or loss.
    /// </summary>
    [IsoId("_nUSdDxw5EeOIveEnnb_1-A")]
    [DisplayName("Total Book Value")]
    [IsoXmlTag("TtlBookVal")]
    public ActiveOrHistoricCurrencyAndAmount? TotalBookValue { get; init; }

    /// <summary>
    /// Account held in the name of a party that is not the name of the beneficial owner of the shares.
    /// </summary>
    [IsoId("_nUSdERw5EeOIveEnnb_1-A")]
    [DisplayName("Transferee Account")]
    [IsoXmlTag("TrfeeAcct")]
    public Account16? TransfereeAccount { get; init; }

    /// <summary>
    /// Sub-accounts that are grouped in a master or omnibus account.
    /// </summary>
    [IsoId("_qu_pURw5EeOIveEnnb_1-A")]
    [DisplayName("Sub Account Details")]
    [IsoXmlTag("SubAcctDtls")]
    public SubAccount1? SubAccountDetails { get; init; }

    /// <summary>
    /// Party that receives securities from the delivering agent via the place of settlement, for example, securities central depository.
    /// </summary>
    [IsoId("_nUSdExw5EeOIveEnnb_1-A")]
    [DisplayName("Receiving Agent Details")]
    [IsoXmlTag("RcvgAgtDtls")]
    public PartyIdentificationAndAccount93? ReceivingAgentDetails { get; init; }

    /// <summary>
    /// Party that delivers securities to the receiving agent at the place of settlement, for example, a central securities depository.
    /// </summary>
    [IsoId("_nUSdFRw5EeOIveEnnb_1-A")]
    [DisplayName("Delivering Agent Details")]
    [IsoXmlTag("DlvrgAgtDtls")]
    public PartyIdentificationAndAccount93? DeliveringAgentDetails { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be exchanged at the International Central Securities Depository (ICSD) or Central Securities Depository (CSD).
    /// </summary>
    [IsoId("_nUSdFxw5EeOIveEnnb_1-A")]
    [DisplayName("Requested Settlement Date")]
    [IsoXmlTag("ReqdSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RequestedSettlementDate { get; init; }
}
