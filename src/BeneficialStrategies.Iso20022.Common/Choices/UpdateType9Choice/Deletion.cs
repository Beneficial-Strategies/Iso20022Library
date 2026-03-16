// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType9Choice
{
    /// <summary>
    /// Deletion of information in the securities transaction.
    /// </summary>
    [IsoId("_nWE8qQ0BEeKd14R19frrfQ")]
    [DisplayName("Deletion")]
    [IsoXmlTag("Deltn")]
    public record Deletion : UpdateType9Choice_
    {
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_xUKWYQ0BEeKd14R19frrfQ")]
        [DisplayName("Settlement Type And Additional Parameters")]
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        public SettlementTypeAndAdditionalParameters6? SettlementTypeAndAdditionalParameters { get; init; }

        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_xUKWZQ0BEeKd14R19frrfQ")]
        [DisplayName("Linkages")]
        [IsoXmlTag("Lnkgs")]
        public Linkages21? Linkages { get; init; }

        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_xUKWaQ0BEeKd14R19frrfQ")]
        [DisplayName("Trade Details")]
        [IsoXmlTag("TradDtls")]
        public SecuritiesTradeDetails25? TradeDetails { get; init; }

        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_xUKWbQ0BEeKd14R19frrfQ")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public FinancialInstrumentAttributes35? FinancialInstrumentAttributes { get; init; }

        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_xUKWcQ0BEeKd14R19frrfQ")]
        [DisplayName("Quantity And Account Details")]
        [IsoXmlTag("QtyAndAcctDtls")]
        public QuantityAndAccount29? QuantityAndAccountDetails { get; init; }

        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_xUKWdQ0BEeKd14R19frrfQ")]
        [DisplayName("Settlement Parameters")]
        [IsoXmlTag("SttlmParams")]
        public SettlementDetails50? SettlementParameters { get; init; }

        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_xUKWeQ0BEeKd14R19frrfQ")]
        [DisplayName("Standing Settlement Instruction Details")]
        [IsoXmlTag("StgSttlmInstrDtls")]
        public StandingSettlementInstruction4? StandingSettlementInstructionDetails { get; init; }

        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_xUKWfQ0BEeKd14R19frrfQ")]
        [DisplayName("Delivering Settlement Parties")]
        [IsoXmlTag("DlvrgSttlmPties")]
        public SettlementParties26? DeliveringSettlementParties { get; init; }

        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_xUKWgQ0BEeKd14R19frrfQ")]
        [DisplayName("Receiving Settlement Parties")]
        [IsoXmlTag("RcvgSttlmPties")]
        public SettlementParties26? ReceivingSettlementParties { get; init; }

        /// <summary>
        /// Cash parties involved in the transaction if different for the securities settlement parties.
        /// </summary>
        [IsoId("_xUKWhQ0BEeKd14R19frrfQ")]
        [DisplayName("Cash Parties")]
        [IsoXmlTag("CshPties")]
        public CashParties17? CashParties { get; init; }

        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_xUKWiQ0BEeKd14R19frrfQ")]
        [DisplayName("Settlement Amount")]
        [IsoXmlTag("SttlmAmt")]
        public AmountAndDirection32? SettlementAmount { get; init; }

        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_xUKWjQ0BEeKd14R19frrfQ")]
        [DisplayName("Other Amounts")]
        [IsoXmlTag("OthrAmts")]
        public OtherAmounts14? OtherAmounts { get; init; }

        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_xUKWkQ0BEeKd14R19frrfQ")]
        [DisplayName("Other Business Parties")]
        [IsoXmlTag("OthrBizPties")]
        public OtherParties19? OtherBusinessParties { get; init; }

        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_xUKWlQ0BEeKd14R19frrfQ")]
        [DisplayName("Additional Physical Or Registration Details")]
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        public RegistrationParameters1? AdditionalPhysicalOrRegistrationDetails { get; init; }

        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_xUKWmQ0BEeKd14R19frrfQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
