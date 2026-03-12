// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateType28Choice
{
    /// <summary>
    /// Addition of information to the securities transaction.
    /// </summary>
    [IsoId("_VLd_6832Eee5nJBZsW8MFQ")]
    [DisplayName("Addition")]
    public partial record Addition : UpdateType28Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_VLd_9c32Eee5nJBZsW8MFQ")]
        [DisplayName("Settlement Type And Additional Parameters")]
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        public SettlementTypeAndAdditionalParameters17? SettlementTypeAndAdditionalParameters { get; init; } 
        
        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_VLd_9832Eee5nJBZsW8MFQ")]
        [DisplayName("Linkages")]
        [IsoXmlTag("Lnkgs")]
        public Linkages48? Linkages { get; init; } 
        
        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_VLd_-c32Eee5nJBZsW8MFQ")]
        [DisplayName("Trade Details")]
        [IsoXmlTag("TradDtls")]
        public SecuritiesTradeDetails89? TradeDetails { get; init; } 
        
        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_VLd_-832Eee5nJBZsW8MFQ")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public FinancialInstrumentAttributes97? FinancialInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_VLd__c32Eee5nJBZsW8MFQ")]
        [DisplayName("Quantity And Account Details")]
        [IsoXmlTag("QtyAndAcctDtls")]
        public QuantityAndAccount75? QuantityAndAccountDetails { get; init; } 
        
        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_VLd__832Eee5nJBZsW8MFQ")]
        [DisplayName("Settlement Parameters")]
        [IsoXmlTag("SttlmParams")]
        public SettlementDetails158? SettlementParameters { get; init; } 
        
        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_VLeAAc32Eee5nJBZsW8MFQ")]
        [DisplayName("Standing Settlement Instruction Details")]
        [IsoXmlTag("StgSttlmInstrDtls")]
        public StandingSettlementInstruction15? StandingSettlementInstructionDetails { get; init; } 
        
        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_VLeAA832Eee5nJBZsW8MFQ")]
        [DisplayName("Delivering Settlement Parties")]
        [IsoXmlTag("DlvrgSttlmPties")]
        public SettlementParties73? DeliveringSettlementParties { get; init; } 
        
        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_VLeABc32Eee5nJBZsW8MFQ")]
        [DisplayName("Receiving Settlement Parties")]
        [IsoXmlTag("RcvgSttlmPties")]
        public SettlementParties73? ReceivingSettlementParties { get; init; } 
        
        /// <summary>
        /// Cash parties involved in the transaction if different for the securities settlement parties.
        /// </summary>
        [IsoId("_VLeAB832Eee5nJBZsW8MFQ")]
        [DisplayName("Cash Parties")]
        [IsoXmlTag("CshPties")]
        public CashParties30? CashParties { get; init; } 
        
        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_VLeACc32Eee5nJBZsW8MFQ")]
        [DisplayName("Settlement Amount")]
        [IsoXmlTag("SttlmAmt")]
        public AmountAndDirection91? SettlementAmount { get; init; } 
        
        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_VLeAC832Eee5nJBZsW8MFQ")]
        [DisplayName("Other Amounts")]
        [IsoXmlTag("OthrAmts")]
        public OtherAmounts43? OtherAmounts { get; init; } 
        
        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_VLeADc32Eee5nJBZsW8MFQ")]
        [DisplayName("Other Business Parties")]
        [IsoXmlTag("OthrBizPties")]
        public OtherParties29? OtherBusinessParties { get; init; } 
        
        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_VLeAD832Eee5nJBZsW8MFQ")]
        [DisplayName("Additional Physical Or Registration Details")]
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        public RegistrationParameters7? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_VLeAEc32Eee5nJBZsW8MFQ")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
