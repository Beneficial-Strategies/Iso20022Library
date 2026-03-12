// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData30Choice
{
    /// <summary>
    /// Details of the margin lending transaction.
    /// </summary>
    [IsoId("_gHkCd8g4Eeu4ecZgAYuz5w")]
    [DisplayName("Margin Lending")]
    public partial record MarginLending : TransactionLoanData30Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_oLE7Acg6Eeu4ecZgAYuz5w")]
        [DisplayName("Unique Trade Identifier")]
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_oLE7A8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDate { get; init; } 
        
        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_oLE7Bcg6Eeu4ecZgAYuz5w")]
        [DisplayName("Execution Date Time")]
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ExecutionDateTime { get; init; } 
        
        /// <summary>
        /// Identification of the trading venue where the transaction was executed.
        /// </summary>
        [IsoId("_oLE7B8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Trading Venue")]
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? TradingVenue { get; init; } 
        
        /// <summary>
        /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
        /// </summary>
        [IsoId("_oLE7Ccg6Eeu4ecZgAYuz5w")]
        [DisplayName("Collateral Delivery Method")]
        [IsoXmlTag("CollDlvryMtd")]
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
        
        /// <summary>
        /// Total amount of margin loans in base currency.
        /// </summary>
        [IsoId("_oLE7C8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Outstanding Margin Loan Amount")]
        [IsoXmlTag("OutsdngMrgnLnAmt")]
        public ActiveOrHistoricCurrencyAndAmount? OutstandingMarginLoanAmount { get; init; } 
        
        /// <summary>
        /// Market value of short position in base currency.
        /// </summary>
        [IsoId("_oLE7Dcg6Eeu4ecZgAYuz5w")]
        [DisplayName("Short Market Value Amount")]
        [IsoXmlTag("ShrtMktValAmt")]
        public ActiveOrHistoricCurrencyAndAmount? ShortMarketValueAmount { get; init; } 
        
        /// <summary>
        /// Data on amount and interest rates of the transaction.
        /// </summary>
        [IsoId("_oLE7D8g6Eeu4ecZgAYuz5w")]
        [DisplayName("Margin Loan Attribute")]
        [IsoXmlTag("MrgnLnAttr")]
        public InterestRate6? MarginLoanAttribute { get; init; } 
        
        /// <summary>
        /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
        /// </summary>
        [IsoId("_oLE7Ecg6Eeu4ecZgAYuz5w")]
        [DisplayName("Termination Date")]
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? TerminationDate { get; init; } 
        
        
        #nullable disable
        
    }
}
