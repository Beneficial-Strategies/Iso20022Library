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
[IsoId("_fp1I-_fYEeiNZp_PtLohLw")]
[DisplayName("Securities Settlement Transaction Details")]
public record SecuritiesSettlementTransactionDetails43
{
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_fp1I_ffYEeiNZp_PtLohLw")]
    [DisplayName("Settlement Type And Additional Parameters")]
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    public SettlementTypeAndAdditionalParameters18? SettlementTypeAndAdditionalParameters { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_fp1I__fYEeiNZp_PtLohLw")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages48> Linkages { get; init; } = [];

    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_fp1JAffYEeiNZp_PtLohLw")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public SecuritiesTradeDetails110? TradeDetails { get; init; }

    /// <summary>
    /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_fp1JA_fYEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    [IsoId("_fp1JBffYEeiNZp_PtLohLw")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_fp1JB_fYEeiNZp_PtLohLw")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public QuantityAndAccount94? QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_fp1JCffYEeiNZp_PtLohLw")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails179? SettlementParameters { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_fp1JC_fYEeiNZp_PtLohLw")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction17? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_fp1JDffYEeiNZp_PtLohLw")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties81? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_fp1JD_fYEeiNZp_PtLohLw")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties81? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    [IsoId("_fp1JEffYEeiNZp_PtLohLw")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties38? CashParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_fp1JE_fYEeiNZp_PtLohLw")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection101? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_fp1JFffYEeiNZp_PtLohLw")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts43? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_fp1JF_fYEeiNZp_PtLohLw")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties35? OtherBusinessParties { get; init; }

    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_fp1JGffYEeiNZp_PtLohLw")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_fp1JG_fYEeiNZp_PtLohLw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
