// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UpdateType25Choice
{
    /// <summary>
    /// Deletion of information in the securities transaction.
    /// </summary>
    [IsoId("_dXOX04yeEeaxLOI-Kq-S4w")]
    [DisplayName("Deletion")]
    [IsoXmlTag("Deltn")]
    public record Deletion : UpdateType25Choice_
    {
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_G9GMwYyhEea-QrbCUXny2w")]
        [DisplayName("Settlement Type And Additional Parameters")]
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; init; }

        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_G9GMw4yhEea-QrbCUXny2w")]
        [DisplayName("Linkages")]
        [IsoXmlTag("Lnkgs")]
        public Linkages40? Linkages { get; init; }

        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_G9GMxYyhEea-QrbCUXny2w")]
        [DisplayName("Trade Details")]
        [IsoXmlTag("TradDtls")]
        public SecuritiesTradeDetails50? TradeDetails { get; init; }

        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_G9GMx4yhEea-QrbCUXny2w")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public FinancialInstrumentAttributes64? FinancialInstrumentAttributes { get; init; }

        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_G9GMyYyhEea-QrbCUXny2w")]
        [DisplayName("Quantity And Account Details")]
        [IsoXmlTag("QtyAndAcctDtls")]
        public QuantityAndAccount44? QuantityAndAccountDetails { get; init; }

        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_G9GMy4yhEea-QrbCUXny2w")]
        [DisplayName("Settlement Parameters")]
        [IsoXmlTag("SttlmParams")]
        public SettlementDetails122? SettlementParameters { get; init; }

        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_G9GMzYyhEea-QrbCUXny2w")]
        [DisplayName("Standing Settlement Instruction Details")]
        [IsoXmlTag("StgSttlmInstrDtls")]
        public StandingSettlementInstruction11? StandingSettlementInstructionDetails { get; init; }

        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_G9GMz4yhEea-QrbCUXny2w")]
        [DisplayName("Delivering Settlement Parties")]
        [IsoXmlTag("DlvrgSttlmPties")]
        public SettlementParties39? DeliveringSettlementParties { get; init; }

        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_G9GM0YyhEea-QrbCUXny2w")]
        [DisplayName("Receiving Settlement Parties")]
        [IsoXmlTag("RcvgSttlmPties")]
        public SettlementParties39? ReceivingSettlementParties { get; init; }

        /// <summary>
        /// Cash parties involved in the transaction if different for the securities settlement parties.
        /// </summary>
        [IsoId("_G9GM04yhEea-QrbCUXny2w")]
        [DisplayName("Cash Parties")]
        [IsoXmlTag("CshPties")]
        public CashParties26? CashParties { get; init; }

        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_G9GM1YyhEea-QrbCUXny2w")]
        [DisplayName("Settlement Amount")]
        [IsoXmlTag("SttlmAmt")]
        public AmountAndDirection45? SettlementAmount { get; init; }

        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_G9GM14yhEea-QrbCUXny2w")]
        [DisplayName("Other Amounts")]
        [IsoXmlTag("OthrAmts")]
        public OtherAmounts28? OtherAmounts { get; init; }

        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_G9GM2YyhEea-QrbCUXny2w")]
        [DisplayName("Other Business Parties")]
        [IsoXmlTag("OthrBizPties")]
        public OtherParties27? OtherBusinessParties { get; init; }

        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_G9GM24yhEea-QrbCUXny2w")]
        [DisplayName("Additional Physical Or Registration Details")]
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        public RegistrationParameters4? AdditionalPhysicalOrRegistrationDetails { get; init; }

        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_G9GM3YyhEea-QrbCUXny2w")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; }
    }
}
