// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType26Choice
{
    /// <summary>
    /// Modification of information in the securities transaction.
    /// </summary>
    [IsoId("_JfG635w3EeazcsnODTksnQ")]
    [DisplayName("Modification")]
    [IsoXmlTag("Mod")]
    public record Modification : UpdateType26Choice_
    {
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_Jf2r_Zw3EeazcsnODTksnQ")]
        [DisplayName("Settlement Type And Additional Parameters")]
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        public SettlementTypeAndAdditionalParameters18? SettlementTypeAndAdditionalParameters { get; init; }

        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_Jf2r_5w3EeazcsnODTksnQ")]
        [DisplayName("Linkages")]
        [IsoXmlTag("Lnkgs")]
        public Linkages48? Linkages { get; init; }

        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_Jf2sAZw3EeazcsnODTksnQ")]
        [DisplayName("Trade Details")]
        [IsoXmlTag("TradDtls")]
        public SecuritiesTradeDetails66? TradeDetails { get; init; }

        /// <summary>
        /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
        /// </summary>
        [IsoId("_Jf2sA5w3EeazcsnODTksnQ")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public SecurityIdentification20? FinancialInstrumentIdentification { get; init; }

        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_Jf2sBZw3EeazcsnODTksnQ")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public FinancialInstrumentAttributes78? FinancialInstrumentAttributes { get; init; }

        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_Jf2sB5w3EeazcsnODTksnQ")]
        [DisplayName("Quantity And Account Details")]
        [IsoXmlTag("QtyAndAcctDtls")]
        public QuantityAndAccount60? QuantityAndAccountDetails { get; init; }

        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_Jf2sCZw3EeazcsnODTksnQ")]
        [DisplayName("Settlement Parameters")]
        [IsoXmlTag("SttlmParams")]
        public SettlementDetails138? SettlementParameters { get; init; }

        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_Jf2sC5w3EeazcsnODTksnQ")]
        [DisplayName("Standing Settlement Instruction Details")]
        [IsoXmlTag("StgSttlmInstrDtls")]
        public StandingSettlementInstruction12? StandingSettlementInstructionDetails { get; init; }

        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_Jf2sDZw3EeazcsnODTksnQ")]
        [DisplayName("Delivering Settlement Parties")]
        [IsoXmlTag("DlvrgSttlmPties")]
        public SettlementParties44? DeliveringSettlementParties { get; init; }

        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_Jf2sD5w3EeazcsnODTksnQ")]
        [DisplayName("Receiving Settlement Parties")]
        [IsoXmlTag("RcvgSttlmPties")]
        public SettlementParties44? ReceivingSettlementParties { get; init; }

        /// <summary>
        /// Cash parties involved in the transaction if different for the securities settlement parties.
        /// </summary>
        [IsoId("_Jf2sEZw3EeazcsnODTksnQ")]
        [DisplayName("Cash Parties")]
        [IsoXmlTag("CshPties")]
        public CashParties30? CashParties { get; init; }

        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_Jf2sE5w3EeazcsnODTksnQ")]
        [DisplayName("Settlement Amount")]
        [IsoXmlTag("SttlmAmt")]
        public AmountAndDirection85? SettlementAmount { get; init; }

        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_Jf2sFZw3EeazcsnODTksnQ")]
        [DisplayName("Other Amounts")]
        [IsoXmlTag("OthrAmts")]
        public OtherAmounts35? OtherAmounts { get; init; }

        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_Jf2sF5w3EeazcsnODTksnQ")]
        [DisplayName("Other Business Parties")]
        [IsoXmlTag("OthrBizPties")]
        public OtherParties29? OtherBusinessParties { get; init; }

        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_Jf2sGZw3EeazcsnODTksnQ")]
        [DisplayName("Additional Physical Or Registration Details")]
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        public RegistrationParameters5? AdditionalPhysicalOrRegistrationDetails { get; init; }

        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_Jf2sG5w3EeazcsnODTksnQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
