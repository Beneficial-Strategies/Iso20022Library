// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateType33Choice
{
    /// <summary>
    /// Modification of information in the securities transaction.
    /// </summary>
    [IsoId("_lurUBQleEeuQ1MenzX1l-g")]
    [DisplayName("Modification")]
    public partial record Modification : UpdateType33Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides settlement type and identification information.
        /// </summary>
        [IsoId("_mkilAQleEeuQ1MenzX1l-g")]
        [DisplayName("Settlement Type And Additional Parameters")]
        [IsoXmlTag("SttlmTpAndAddtlParams")]
        public SettlementTypeAndAdditionalParameters14? SettlementTypeAndAdditionalParameters { get; init; } 
        
        /// <summary>
        /// Link to another transaction that must be processed after, before or at the same time.
        /// </summary>
        [IsoId("_mkilAwleEeuQ1MenzX1l-g")]
        [DisplayName("Linkages")]
        [IsoXmlTag("Lnkgs")]
        public Linkages38? Linkages { get; init; } 
        
        /// <summary>
        /// Details of the trade.
        /// </summary>
        [IsoId("_mkilBQleEeuQ1MenzX1l-g")]
        [DisplayName("Trade Details")]
        [IsoXmlTag("TradDtls")]
        public SecuritiesTradeDetails121? TradeDetails { get; init; } 
        
        /// <summary>
        /// Financial instrument representing a sum of rights of the investor vis-a-vis the issuer.
        /// </summary>
        [IsoId("_mkilBwleEeuQ1MenzX1l-g")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public SecurityIdentification19? FinancialInstrumentIdentification { get; init; } 
        
        /// <summary>
        /// Attributes defining a financial instrument.
        /// </summary>
        [IsoId("_mkilCQleEeuQ1MenzX1l-g")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public FinancialInstrumentAttributes91? FinancialInstrumentAttributes { get; init; } 
        
        /// <summary>
        /// Details related to the account and quantity involved in the transaction.
        /// </summary>
        [IsoId("_mkilCwleEeuQ1MenzX1l-g")]
        [DisplayName("Quantity And Account Details")]
        [IsoXmlTag("QtyAndAcctDtls")]
        public QuantityAndAccount83? QuantityAndAccountDetails { get; init; } 
        
        /// <summary>
        /// Parameters which explicitly state the conditions that must be fulfilled before a particular transaction of a financial instrument can be settled. These parameters are defined by the instructing party in compliance with settlement rules in the market the transaction will settle in.
        /// </summary>
        [IsoId("_mkilDQleEeuQ1MenzX1l-g")]
        [DisplayName("Settlement Parameters")]
        [IsoXmlTag("SttlmParams")]
        public SettlementDetails189? SettlementParameters { get; init; } 
        
        /// <summary>
        /// Specifies what settlement standing instruction database is to be used to derive the settlement parties involved in the transaction.
        /// </summary>
        [IsoId("_mkilDwleEeuQ1MenzX1l-g")]
        [DisplayName("Standing Settlement Instruction Details")]
        [IsoXmlTag("StgSttlmInstrDtls")]
        public StandingSettlementInstruction16? StandingSettlementInstructionDetails { get; init; } 
        
        /// <summary>
        /// Identifies the chain of delivering settlement parties.
        /// </summary>
        [IsoId("_mkilEQleEeuQ1MenzX1l-g")]
        [DisplayName("Delivering Settlement Parties")]
        [IsoXmlTag("DlvrgSttlmPties")]
        public SettlementParties76? DeliveringSettlementParties { get; init; } 
        
        /// <summary>
        /// Identifies the chain of receiving settlement parties.
        /// </summary>
        [IsoId("_mkilEwleEeuQ1MenzX1l-g")]
        [DisplayName("Receiving Settlement Parties")]
        [IsoXmlTag("RcvgSttlmPties")]
        public SettlementParties76? ReceivingSettlementParties { get; init; } 
        
        /// <summary>
        /// Cash parties involved in the transaction if different from the securities settlement parties.
        /// </summary>
        [IsoId("_mkilFQleEeuQ1MenzX1l-g")]
        [DisplayName("Cash Parties")]
        [IsoXmlTag("CshPties")]
        public CashParties36? CashParties { get; init; } 
        
        /// <summary>
        /// Total amount of money to be paid or received in exchange for the securities.
        /// </summary>
        [IsoId("_mkilFwleEeuQ1MenzX1l-g")]
        [DisplayName("Settlement Amount")]
        [IsoXmlTag("SttlmAmt")]
        public AmountAndDirection95? SettlementAmount { get; init; } 
        
        /// <summary>
        /// Other amounts than the settlement amount.
        /// </summary>
        [IsoId("_mkilGQleEeuQ1MenzX1l-g")]
        [DisplayName("Other Amounts")]
        [IsoXmlTag("OthrAmts")]
        public OtherAmounts39? OtherAmounts { get; init; } 
        
        /// <summary>
        /// Other business parties relevant to the transaction.
        /// </summary>
        [IsoId("_mkilGwleEeuQ1MenzX1l-g")]
        [DisplayName("Other Business Parties")]
        [IsoXmlTag("OthrBizPties")]
        public OtherParties33? OtherBusinessParties { get; init; } 
        
        /// <summary>
        /// Provides information required for the registration or physical settlement.
        /// </summary>
        [IsoId("_mkilHQleEeuQ1MenzX1l-g")]
        [DisplayName("Additional Physical Or Registration Details")]
        [IsoXmlTag("AddtlPhysOrRegnDtls")]
        public RegistrationParameters6? AdditionalPhysicalOrRegistrationDetails { get; init; } 
        
        /// <summary>
        /// Additional information that cannot be captured in the structured elements and/or any other specific block.
        /// </summary>
        [IsoId("_mkilHwleEeuQ1MenzX1l-g")]
        [DisplayName("Supplementary Data")]
        [IsoXmlTag("SplmtryData")]
        public SupplementaryData1? SupplementaryData { get; init; } 
        
        
        #nullable disable
        
    }
}
