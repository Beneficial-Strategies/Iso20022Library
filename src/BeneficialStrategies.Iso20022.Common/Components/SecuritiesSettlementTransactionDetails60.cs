// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details of the update(s) for the settlement transaction.
/// </summary>
[IsoId("_MKioQZaNEfC2_67yGLymgA")]
[DisplayName("Securities Settlement Transaction Details60")]
public record SecuritiesSettlementTransactionDetails60
{
    [IsoId("_MNyJhZaNEfC2_67yGLymgA")]
    [DisplayName("Settlement Type And Additional Parameters")]
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; init; }

    [IsoId("_MNyJi5aNEfC2_67yGLymgA")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages40> Linkages { get; init; } = [];

    [IsoId("_MNyJkZaNEfC2_67yGLymgA")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public SecuritiesTradeDetails146? TradeDetails { get; init; }

    [IsoId("_MNyJl5aNEfC2_67yGLymgA")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; }

    [IsoId("_MNyJnZaNEfC2_67yGLymgA")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public QuantityAndAccount118? QuantityAndAccountDetails { get; init; }

    [IsoId("_MNyJo5aNEfC2_67yGLymgA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails230? SettlementParameters { get; init; }

    [IsoId("_MNyJqZaNEfC2_67yGLymgA")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction20? StandingSettlementInstructionDetails { get; init; }

    [IsoId("_MNyJr5aNEfC2_67yGLymgA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties98? DeliveringSettlementParties { get; init; }

    [IsoId("_MNyJtZaNEfC2_67yGLymgA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties98? ReceivingSettlementParties { get; init; }

    [IsoId("_MNyJu5aNEfC2_67yGLymgA")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties41? CashParties { get; init; }

    [IsoId("_MNyJwZaNEfC2_67yGLymgA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection95? SettlementAmount { get; init; }

    [IsoId("_MNyJx5aNEfC2_67yGLymgA")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts39? OtherAmounts { get; init; }

    [IsoId("_s2IxMZaMEfC2_67yGLymgA")]
    [DisplayName("Digital Payment Settlement")]
    [IsoXmlTag("DgtlPmtSttlm")]
    public ValueList<DigitalPaymentSettlement1> DigitalPaymentSettlement { get; init; } = [];

    [IsoId("_MNyJzZaNEfC2_67yGLymgA")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties43? OtherBusinessParties { get; init; }

    [IsoId("_MNyJ05aNEfC2_67yGLymgA")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; }

    [IsoId("_MNyJ2ZaNEfC2_67yGLymgA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
