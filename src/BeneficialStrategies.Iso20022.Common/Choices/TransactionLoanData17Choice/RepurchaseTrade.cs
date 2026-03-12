// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData17Choice
{
    /// <summary>
    /// Details of the repurchase trade transaction.
    /// </summary>
    [IsoId("_16F6Ya1KEemojPqsRBB5Lg")]
    [DisplayName("Repurchase Trade")]
    public partial record RepurchaseTrade : TransactionLoanData17Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Unique Trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_xJWY0bOYEemDE9K-I5TT8Q")]
        [DisplayName("Unique Trade Identifier")]
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_xJWY07OYEemDE9K-I5TT8Q")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDate { get; init; } 
        
        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_xJWY1bOYEemDE9K-I5TT8Q")]
        [DisplayName("Execution Date Time")]
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ExecutionDateTime { get; init; } 
        
        /// <summary>
        /// Indicates whether clearing of contract has taken place.
        /// </summary>
        [IsoId("_xJWY17OYEemDE9K-I5TT8Q")]
        [DisplayName("Clearing Status")]
        [IsoXmlTag("ClrSts")]
        public Cleared10Choice_? ClearingStatus { get; init; } 
        
        /// <summary>
        /// Identification of the trading venue where the transaction was executed.
        /// </summary>
        [IsoId("_xJWY2bOYEemDE9K-I5TT8Q")]
        [DisplayName("Trading Venue")]
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        public IsoMICIdentifier? TradingVenue { get; init; } 
        
        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_xJWY27OYEemDE9K-I5TT8Q")]
        [DisplayName("Master Agreement")]
        [IsoXmlTag("MstrAgrmt")]
        public MasterAgreement6? MasterAgreement { get; init; } 
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of transaction open term, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_xJWY3bOYEemDE9K-I5TT8Q")]
        [DisplayName("Value Date")]
        [IsoXmlTag("ValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValueDate { get; init; } 
        
        /// <summary>
        /// Minimum number of business days that one of the counterparties has to inform about the termination of the transaction.
        /// </summary>
        [IsoId("_xJWY37OYEemDE9K-I5TT8Q")]
        [DisplayName("Minimum Notice Period")]
        [IsoXmlTag("MinNtcePrd")]
        [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
        public IsoMax20PositiveNumber? MinimumNoticePeriod { get; init; } 
        
        /// <summary>
        /// Earliest date that the cash lender has the right to call back a portion of the amount of money or to terminate the transaction.
        /// </summary>
        [IsoId("_xJWY4bOYEemDE9K-I5TT8Q")]
        [DisplayName("Earliest Call Back Date")]
        [IsoXmlTag("EarlstCallBckDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? EarliestCallBackDate { get; init; } 
        
        /// <summary>
        /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
        /// </summary>
        [IsoId("_xJWY47OYEemDE9K-I5TT8Q")]
        [DisplayName("General Collateral")]
        [IsoXmlTag("GnlColl")]
        public SpecialCollateral1Code? GeneralCollateral { get; init; } 
        
        /// <summary>
        /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
        /// </summary>
        [IsoId("_xJWY5bOYEemDE9K-I5TT8Q")]
        [DisplayName("Delivery By Value")]
        [IsoXmlTag("DlvryByVal")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        public IsoTrueFalseIndicator? DeliveryByValue { get; init; } 
        
        /// <summary>
        /// Delivery method of the collateral.
        /// </summary>
        [IsoId("_xJWY57OYEemDE9K-I5TT8Q")]
        [DisplayName("Collateral Delivery Method")]
        [IsoXmlTag("CollDlvryMtd")]
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
        
        /// <summary>
        /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
        /// </summary>
        [IsoId("_xJWY67OYEemDE9K-I5TT8Q")]
        [DisplayName("Term")]
        [IsoXmlTag("Term")]
        public ContractTerm3Choice_? Term { get; init; } 
        
        /// <summary>
        /// Interest rate of the loan.
        /// </summary>
        [IsoId("_xJWY6bOYEemDE9K-I5TT8Q")]
        [DisplayName("Interest Rate")]
        [IsoXmlTag("IntrstRate")]
        public InterestRate20Choice_? InterestRate { get; init; } 
        
        /// <summary>
        /// Amount of money to be settled as of the start date and maturity date of the transaction.
        /// </summary>
        [IsoId("_xJWY7bOYEemDE9K-I5TT8Q")]
        [DisplayName("Principal Amount")]
        [IsoXmlTag("PrncplAmt")]
        public PrincipalAmount2? PrincipalAmount { get; init; } 
        
        /// <summary>
        /// Termination date in the case of a full early termination of the SFT.
        /// </summary>
        [IsoId("_xJWY77OYEemDE9K-I5TT8Q")]
        [DisplayName("Termination Date")]
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? TerminationDate { get; init; } 
        
        
        #nullable disable
        
    }
}
