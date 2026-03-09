// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData20Choice
{
    /// <summary>
    /// Details of the securities lending transaction.
    /// </summary>
    [IsoId("_lksD1bONEemDE9K-I5TT8Q")]
    [DisplayName("Securities Lending")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record SecuritiesLending : TransactionLoanData20Choice_
    #else
    public partial class SecuritiesLending : TransactionLoanData20Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a SecuritiesLending instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public SecuritiesLending( System.DateOnly reqEventDate )
        {
            EventDate = reqEventDate;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_lqNdAbONEemDE9K-I5TT8Q")]
        [DisplayName("Unique Trade Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnqTradIdr")]
        #endif
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? UniqueTradeIdentifier { get; init; } 
        #else
        public System.String? UniqueTradeIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_lqNdA7ONEemDE9K-I5TT8Q")]
        [DisplayName("Event Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EvtDt")]
        #endif
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate EventDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly EventDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly EventDate { get; init; } 
        #else
        public System.DateOnly EventDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates the date and time when the contract was executed.
        /// </summary>
        [IsoId("_lqNdBbONEemDE9K-I5TT8Q")]
        [DisplayName("Execution Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExctnDtTm")]
        #endif
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODateTime? ExecutionDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime? ExecutionDateTime { get; init; } 
        #else
        public System.DateTime? ExecutionDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether clearing of contract has taken place.
        /// </summary>
        [IsoId("_lqNdB7ONEemDE9K-I5TT8Q")]
        [DisplayName("Clearing Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSts")]
        #endif
        [IsoXmlTag("ClrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Cleared10Choice_? ClearingStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Cleared10Choice_? ClearingStatus { get; init; } 
        #else
        public Cleared10Choice_? ClearingStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the venue where the transaction was executed.
        /// </summary>
        [IsoId("_lqNdCbONEemDE9K-I5TT8Q")]
        [DisplayName("Trading Venue")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradgVn")]
        #endif
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMICIdentifier? TradingVenue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? TradingVenue { get; init; } 
        #else
        public System.String? TradingVenue { get; set; } 
        #endif
        
        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_lqNdC7ONEemDE9K-I5TT8Q")]
        [DisplayName("Master Agreement")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MstrAgrmt")]
        #endif
        [IsoXmlTag("MstrAgrmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MasterAgreement6? MasterAgreement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MasterAgreement6? MasterAgreement { get; init; } 
        #else
        public MasterAgreement6? MasterAgreement { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_lqNdDbONEemDE9K-I5TT8Q")]
        [DisplayName("Value Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ValDt")]
        #endif
        [IsoXmlTag("ValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ValueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ValueDate { get; init; } 
        #else
        public System.DateOnly? ValueDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the secured financing transaction is subject to a general collateral arrangement.
        /// </summary>
        [IsoId("_lqNdD7ONEemDE9K-I5TT8Q")]
        [DisplayName("General Collateral")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="GnlColl")]
        #endif
        [IsoXmlTag("GnlColl")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SpecialCollateral1Code? GeneralCollateral { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SpecialCollateral1Code? GeneralCollateral { get; init; } 
        #else
        public SpecialCollateral1Code? GeneralCollateral { get; set; } 
        #endif
        
        /// <summary>
        /// This field specifies whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
        /// </summary>
        [IsoId("_lqNdEbONEemDE9K-I5TT8Q")]
        [DisplayName("Delivery By Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DlvryByVal")]
        #endif
        [IsoXmlTag("DlvryByVal")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoTrueFalseIndicator? DeliveryByValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DeliveryByValue { get; init; } 
        #else
        public System.String? DeliveryByValue { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies whether the collateral is subject to a title transfer collateral arrangement, a securities interest collateral arrangement, or a securities interest with the right of use.
        /// </summary>
        [IsoId("_lqNdE7ONEemDE9K-I5TT8Q")]
        [DisplayName("Collateral Delivery Method")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollDlvryMtd")]
        #endif
        [IsoXmlTag("CollDlvryMtd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; init; } 
        #else
        public CollateralDeliveryMethod1Code? CollateralDeliveryMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the transaction is open term or, i.e. has no fixed maturity date, or fixed term with a contractually agreed maturity date.
        /// </summary>
        [IsoId("_lqNdFbONEemDE9K-I5TT8Q")]
        [DisplayName("Term")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Term")]
        #endif
        [IsoXmlTag("Term")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ContractTerm3Choice_? Term { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractTerm3Choice_? Term { get; init; } 
        #else
        public ContractTerm3Choice_? Term { get; set; } 
        #endif
        
        /// <summary>
        /// Indication of the type of assets subject of the transaction.
        /// </summary>
        [IsoId("_lqNdF7ONEemDE9K-I5TT8Q")]
        [DisplayName("Asset Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AsstTp")]
        #endif
        [IsoXmlTag("AsstTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecurityCommodity8? AssetType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecurityCommodity8? AssetType { get; init; } 
        #else
        public SecurityCommodity8? AssetType { get; set; } 
        #endif
        
        /// <summary>
        /// Specifies loan value, that is the quantity or nominal amount multiplied by the price.
        /// </summary>
        [IsoId("_lqNdGbONEemDE9K-I5TT8Q")]
        [DisplayName("Loan Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LnVal")]
        #endif
        [IsoXmlTag("LnVal")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; init; } 
        #else
        public ActiveOrHistoricCurrencyAndAmount? LoanValue { get; set; } 
        #endif
        
        /// <summary>
        /// Rate agreed to be paid by the lender for the reinvestment of the cash collateral minus lending fee.
        /// </summary>
        [IsoId("_lqNdG7ONEemDE9K-I5TT8Q")]
        [DisplayName("Rebate Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RbtRate")]
        #endif
        [IsoXmlTag("RbtRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRate20Choice_? RebateRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRate20Choice_? RebateRate { get; init; } 
        #else
        public InterestRate20Choice_? RebateRate { get; set; } 
        #endif
        
        /// <summary>
        /// Fee that the borrower of the security or commodity pays to the lender.
        /// </summary>
        [IsoId("_lqNdHbONEemDE9K-I5TT8Q")]
        [DisplayName("Lending Fee")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="LndgFee")]
        #endif
        [IsoXmlTag("LndgFee")]
        [IsoSimpleType(IsoSimpleType.PercentageRate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoPercentageRate? LendingFee { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.Decimal? LendingFee { get; init; } 
        #else
        public System.Decimal? LendingFee { get; set; } 
        #endif
        
        /// <summary>
        /// Termination date in the case of a full early termination of the SFT.
        /// </summary>
        [IsoId("_lqNdH7ONEemDE9K-I5TT8Q")]
        [DisplayName("Termination Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TermntnDt")]
        #endif
        [IsoXmlTag("TermntnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? TerminationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? TerminationDate { get; init; } 
        #else
        public System.DateOnly? TerminationDate { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
