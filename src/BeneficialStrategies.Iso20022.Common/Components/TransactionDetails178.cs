// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the securities settlement transaction.
/// </summary>
[IsoId("_Vh7E0ZaBEfC2_67yGLymgA")]
[DisplayName("Transaction Details178")]
public record TransactionDetails178
{
    [IsoId("_Vh7E0ZaBEfC2_67yGLymgB")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgC")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgD")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgE")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgF")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity51Choice SettlementQuantity { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgG")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection51? SettlementAmount { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgH")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public DigitalPaymentSettlement2? DigitalPaymentSettlement { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgI")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice? TradeDate { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgJ")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate19Choice SettlementDate { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgK")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties125? DeliveringSettlementParties { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgL")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties125? ReceivingSettlementParties { get; init; }

    [IsoId("_Vh7E0ZaBEfC2_67yGLymgM")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification149? Investor { get; init; }
}
