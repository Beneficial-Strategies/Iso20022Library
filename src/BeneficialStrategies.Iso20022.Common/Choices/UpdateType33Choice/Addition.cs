// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateType33Choice
{
    /// <summary>
    /// Addition of information to the securities transaction.
    /// </summary>
    [IsoId("_lurUAQleEeuQ1MenzX1l-g")]
    [DisplayName("Addition")]
    public partial record Addition : UpdateType33Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_l8XKsQleEeuQ1MenzX1l-g")]
        [DisplayName("Settlement Type And Additional Parameters")]
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        public SettlementTypeAndAdditionalParameters13? SettlementTypeAndAdditionalParameters { get; init; } 
        
        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_l8XKswleEeuQ1MenzX1l-g")]
        [DisplayName("Linkages")]
        [IsoXmlTag("Lnkgs")]
        public Linkages38? Linkages { get; init; } 
        
        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_l8XKtQleEeuQ1MenzX1l-g")]
        [DisplayName("Trade Details")]
        [IsoXmlTag("TradDtls")]
        public SecuritiesTradeDetails120? TradeDetails { get; init; } 
        
        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_l8XKtwleEeuQ1MenzX1l-g")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_l8XKuQleEeuQ1MenzX1l-g")]
        [DisplayName("Quantity And Account Details")]
        [IsoXmlTag("QtyAndAcctDtls")]
        public QuantityAndAccount81? QuantityAndAccountDetails { get; init; } 
        
        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_l8XKuwleEeuQ1MenzX1l-g")]
        [DisplayName("Settlement Parameters")]
        [IsoXmlTag("SttlmParams")]
        public SettlementDetails189? SettlementParameters { get; init; } 
        
        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_l8XKvQleEeuQ1MenzX1l-g")]
        [DisplayName("Standing Settlement Instruction Details")]
        [IsoXmlTag("StgSttlmInstrDtls")]
        public StandingSettlementInstruction16? StandingSettlementInstructionDetails { get; init; } 
        
        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_l8XKvwleEeuQ1MenzX1l-g")]
        [DisplayName("Delivering Settlement Parties")]
        [IsoXmlTag("DlvrgSttlmPties")]
        public SettlementParties79? DeliveringSettlementParties { get; init; } 
        
        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_l8XKwQleEeuQ1MenzX1l-g")]
        [DisplayName("Receiving Settlement Parties")]
        [IsoXmlTag("RcvgSttlmPties")]
        public SettlementParties79? ReceivingSettlementParties { get; init; } 
        
        /// <summary>
        /// Cash parties involved in the transaction if different from the securities settlement parties.
        /// </summary>
        [IsoId("_l8XKwwleEeuQ1MenzX1l-g")]
        [DisplayName("Cash Parties")]
        [IsoXmlTag("CshPties")]
        public CashParties36? CashParties { get; init; } 
        
        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_l8XKxQleEeuQ1MenzX1l-g")]
        [DisplayName("Settlement Amount")]
        [IsoXmlTag("SttlmAmt")]
        public AmountAndDirection95? SettlementAmount { get; init; } 
        
        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_l8XKxwleEeuQ1MenzX1l-g")]
        [DisplayName("Other Amounts")]
        [IsoXmlTag("OthrAmts")]
        public OtherAmounts39? OtherAmounts { get; init; } 
        
        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_l8XKyQleEeuQ1MenzX1l-g")]
        [DisplayName("Other Business Parties")]
        [IsoXmlTag("OthrBizPties")]
        public OtherParties33? OtherBusinessParties { get; init; } 
        
        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_l8XKywleEeuQ1MenzX1l-g")]
        [DisplayName("Additional Physical Or Registration Details")]
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_l8XKzQleEeuQ1MenzX1l-g")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
