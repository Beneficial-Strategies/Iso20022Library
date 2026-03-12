// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateType29Choice
{
    /// <summary>
    /// Modification of information in the securities transaction.
    /// </summary>
    [IsoId("_utLLJcvGEeihG9bKfarOOA")]
    [DisplayName("Modification")]
    public partial record Modification : UpdateType29Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_vy9HccvGEeihG9bKfarOOA")]
        [DisplayName("Settlement Type And Additional Parameters")]
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        public SettlementTypeAndAdditionalParameters14? SettlementTypeAndAdditionalParameters { get; init; } 
        
        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_vy9Hc8vGEeihG9bKfarOOA")]
        [DisplayName("Linkages")]
        [IsoXmlTag("Lnkgs")]
        public Linkages38? Linkages { get; init; } 
        
        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_vy9HdcvGEeihG9bKfarOOA")]
        [DisplayName("Trade Details")]
        [IsoXmlTag("TradDtls")]
        public SecuritiesTradeDetails92? TradeDetails { get; init; } 
        
        /// <summary>
        /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
        /// </summary>
        [IsoId("_vy9Hd8vGEeihG9bKfarOOA")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
        
        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_vy9HecvGEeihG9bKfarOOA")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_vy9He8vGEeihG9bKfarOOA")]
        [DisplayName("Quantity And Account Details")]
        [IsoXmlTag("QtyAndAcctDtls")]
        public QuantityAndAccount83? QuantityAndAccountDetails { get; init; } 
        
        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_vy9HfcvGEeihG9bKfarOOA")]
        [DisplayName("Settlement Parameters")]
        [IsoXmlTag("SttlmParams")]
        public SettlementDetails165? SettlementParameters { get; init; } 
        
        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_vy9Hf8vGEeihG9bKfarOOA")]
        [DisplayName("Standing Settlement Instruction Details")]
        [IsoXmlTag("StgSttlmInstrDtls")]
        public StandingSettlementInstruction16? StandingSettlementInstructionDetails { get; init; } 
        
        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_vy9HgcvGEeihG9bKfarOOA")]
        [DisplayName("Delivering Settlement Parties")]
        [IsoXmlTag("DlvrgSttlmPties")]
        public SettlementParties76? DeliveringSettlementParties { get; init; } 
        
        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_vy9Hg8vGEeihG9bKfarOOA")]
        [DisplayName("Receiving Settlement Parties")]
        [IsoXmlTag("RcvgSttlmPties")]
        public SettlementParties76? ReceivingSettlementParties { get; init; } 
        
        /// <summary>
        /// Cash parties involved in the transaction if different from the securities settlement parties.
        /// </summary>
        [IsoId("_vy9HhcvGEeihG9bKfarOOA")]
        [DisplayName("Cash Parties")]
        [IsoXmlTag("CshPties")]
        public CashParties36? CashParties { get; init; } 
        
        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_vy9Hh8vGEeihG9bKfarOOA")]
        [DisplayName("Settlement Amount")]
        [IsoXmlTag("SttlmAmt")]
        public AmountAndDirection95? SettlementAmount { get; init; } 
        
        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_vy9HicvGEeihG9bKfarOOA")]
        [DisplayName("Other Amounts")]
        [IsoXmlTag("OthrAmts")]
        public OtherAmounts39? OtherAmounts { get; init; } 
        
        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_vy9Hi8vGEeihG9bKfarOOA")]
        [DisplayName("Other Business Parties")]
        [IsoXmlTag("OthrBizPties")]
        public OtherParties33? OtherBusinessParties { get; init; } 
        
        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_vy9HjcvGEeihG9bKfarOOA")]
        [DisplayName("Additional Physical Or Registration Details")]
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_vy9Hj8vGEeihG9bKfarOOA")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
