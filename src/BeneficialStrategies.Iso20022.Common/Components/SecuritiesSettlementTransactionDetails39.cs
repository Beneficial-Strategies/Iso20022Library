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
[IsoId("_vQIuX8vGEeihG9bKfarOOA")]
[DisplayName("Securities Settlement Transaction Details")]
public record SecuritiesSettlementTransactionDetails39
{
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_vhinUcvGEeihG9bKfarOOA")]
    [DisplayName("Settlement Type And Additional Parameters")]
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_vhinU8vGEeihG9bKfarOOA")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages40> Linkages { get; init; } = [];

    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_vhinVcvGEeihG9bKfarOOA")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public SecuritiesTradeDetails91? TradeDetails { get; init; }

    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    [IsoId("_vhinV8vGEeihG9bKfarOOA")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_vhinWcvGEeihG9bKfarOOA")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public QuantityAndAccount81? QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_vhinW8vGEeihG9bKfarOOA")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails165? SettlementParameters { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_vhinXcvGEeihG9bKfarOOA")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction16? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_vhinX8vGEeihG9bKfarOOA")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties79? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_vhinYcvGEeihG9bKfarOOA")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties79? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    [IsoId("_vhinY8vGEeihG9bKfarOOA")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties36? CashParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_vhinZcvGEeihG9bKfarOOA")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection95? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_vhinZ8vGEeihG9bKfarOOA")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts39? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_vhinacvGEeihG9bKfarOOA")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties33? OtherBusinessParties { get; init; }

    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_vhina8vGEeihG9bKfarOOA")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_vhinbcvGEeihG9bKfarOOA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
