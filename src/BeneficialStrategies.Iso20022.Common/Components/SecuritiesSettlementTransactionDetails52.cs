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
[IsoId("_japFMSglEey2k_sfZmJz4g")]
[DisplayName("Securities Settlement Transaction Details")]
public record SecuritiesSettlementTransactionDetails52
{
    /// <summary>
    /// Provides settlement type and identification information.
    /// </summary>
    [IsoId("_jzEzMSglEey2k_sfZmJz4g")]
    [DisplayName("Settlement Type And Additional Parameters")]
    [IsoXmlTag("SttlmTpAndAddtlParams")]
    public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; init; }

    /// <summary>
    /// Link to another transaction that must be processed after, before or at the same time.
    /// </summary>
    [IsoId("_jzEzMyglEey2k_sfZmJz4g")]
    [DisplayName("Linkages")]
    [IsoXmlTag("Lnkgs")]
    public ValueList<Linkages63> Linkages { get; init; } = [];

    /// <summary>
    /// Details of the trade.
    /// </summary>
    [IsoId("_jzEzNSglEey2k_sfZmJz4g")]
    [DisplayName("Trade Details")]
    [IsoXmlTag("TradDtls")]
    public SecuritiesTradeDetails120? TradeDetails { get; init; }

    /// <summary>
    /// Attributes defining a financial instrument.
    /// </summary>
    [IsoId("_jzEzNyglEey2k_sfZmJz4g")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes111? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Details related to the account and quantity involved in the transaction.
    /// </summary>
    [IsoId("_jzEzOSglEey2k_sfZmJz4g")]
    [DisplayName("Quantity And Account Details")]
    [IsoXmlTag("QtyAndAcctDtls")]
    public QuantityAndAccount100? QuantityAndAccountDetails { get; init; }

    /// <summary>
    /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
    /// </summary>
    [IsoId("_jzEzOyglEey2k_sfZmJz4g")]
    [DisplayName("Settlement Parameters")]
    [IsoXmlTag("SttlmParams")]
    public SettlementDetails200? SettlementParameters { get; init; }

    /// <summary>
    /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
    /// </summary>
    [IsoId("_jzEzPSglEey2k_sfZmJz4g")]
    [DisplayName("Standing Settlement Instruction Details")]
    [IsoXmlTag("StgSttlmInstrDtls")]
    public StandingSettlementInstruction18? StandingSettlementInstructionDetails { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_jzEzPyglEey2k_sfZmJz4g")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties98? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_jzEzQSglEey2k_sfZmJz4g")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties98? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Cash parties involved in the transaction if different from the securities settlement parties.
    /// </summary>
    [IsoId("_jzEzQyglEey2k_sfZmJz4g")]
    [DisplayName("Cash Parties")]
    [IsoXmlTag("CshPties")]
    public CashParties36? CashParties { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_jzEzRSglEey2k_sfZmJz4g")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection95? SettlementAmount { get; init; }

    /// <summary>
    /// Other amounts than the settlement amount.
    /// </summary>
    [IsoId("_jzEzRyglEey2k_sfZmJz4g")]
    [DisplayName("Other Amounts")]
    [IsoXmlTag("OthrAmts")]
    public OtherAmounts39? OtherAmounts { get; init; }

    /// <summary>
    /// Other business parties relevant to the transaction.
    /// </summary>
    [IsoId("_jzEzSSglEey2k_sfZmJz4g")]
    [DisplayName("Other Business Parties")]
    [IsoXmlTag("OthrBizPties")]
    public OtherParties43? OtherBusinessParties { get; init; }

    /// <summary>
    /// Provides information required for the registration or physical settlement.
    /// </summary>
    [IsoId("_jzEzSyglEey2k_sfZmJz4g")]
    [DisplayName("Additional Physical Or Registration Details")]
    [IsoXmlTag("AddtlPhysOrRegnDtls")]
    public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_jzEzTSglEey2k_sfZmJz4g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
