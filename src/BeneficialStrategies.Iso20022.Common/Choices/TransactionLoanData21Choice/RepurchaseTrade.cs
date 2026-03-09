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
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData21Choice
{
    /// <summary>
    /// Details of the repurchase trade transaction.
    /// </summary>
    [IsoId("_4Eg3Ef_qEemm3skPVSMJQg")]
    [DisplayName("Repurchase Trade")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RepurchaseTrade : TransactionLoanData21Choice_
    #else
    public partial class RepurchaseTrade : TransactionLoanData21Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RepurchaseTrade instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RepurchaseTrade( System.String reqUniqueTradeIdentifier,System.DateOnly reqEventDate,System.DateTime reqExecutionDateTime,Cleared10Choice_ reqClearingStatus,System.String reqTradingVenue,System.DateOnly reqValueDate,System.String reqDeliveryByValue,CollateralDeliveryMethod1Code reqCollateralDeliveryMethod )
        {
            UniqueTradeIdentifier = reqUniqueTradeIdentifier;
            EventDate = reqEventDate;
            ExecutionDateTime = reqExecutionDateTime;
            ClearingStatus = reqClearingStatus;
            TradingVenue = reqTradingVenue;
            ValueDate = reqValueDate;
            DeliveryByValue = reqDeliveryByValue;
            CollateralDeliveryMethod = reqCollateralDeliveryMethod;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_43g-a7OYEemDE9K-I5TT8Q")]
        [DisplayName("Unique Trade Identifier")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnqTradIdr")]
        #endif
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMax52Text UniqueTradeIdentifier { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String UniqueTradeIdentifier { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String UniqueTradeIdentifier { get; init; } 
        #else
        public System.String UniqueTradeIdentifier { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place. In the case of action types valuation update, collateral update, reuse update, margin update, the date for which the information contained in the report is provided.
        /// </summary>
        [IsoId("_43g-bbOYEemDE9K-I5TT8Q")]
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
        [IsoId("_43g-dbOYEemDE9K-I5TT8Q")]
        [DisplayName("Execution Date Time")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ExctnDtTm")]
        #endif
        [IsoXmlTag("ExctnDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODateTime ExecutionDateTime { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateTime ExecutionDateTime { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateTime ExecutionDateTime { get; init; } 
        #else
        public System.DateTime ExecutionDateTime { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether clearing of contract has taken place.
        /// </summary>
        [IsoId("_43g-b7OYEemDE9K-I5TT8Q")]
        [DisplayName("Clearing Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSts")]
        #endif
        [IsoXmlTag("ClrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required Cleared10Choice_ ClearingStatus { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required Cleared10Choice_ ClearingStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Cleared10Choice_ ClearingStatus { get; init; } 
        #else
        public Cleared10Choice_ ClearingStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Venue of execution shall be identified by a unique code for this venue.
        /// </summary>
        [IsoId("_43g-cbOYEemDE9K-I5TT8Q")]
        [DisplayName("Trading Venue")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TradgVn")]
        #endif
        [IsoXmlTag("TradgVn")]
        [IsoSimpleType(IsoSimpleType.MICIdentifier)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoMICIdentifier TradingVenue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String TradingVenue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String TradingVenue { get; init; } 
        #else
        public System.String TradingVenue { get; set; } 
        #endif
        
        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_43g-c7OYEemDE9K-I5TT8Q")]
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
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of open term repurchase transactions, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_43g-d7OYEemDE9K-I5TT8Q")]
        [DisplayName("Value Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ValDt")]
        #endif
        [IsoXmlTag("ValDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoISODate ValueDate { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.DateOnly ValueDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly ValueDate { get; init; } 
        #else
        public System.DateOnly ValueDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the transaction is subject to a general collateral arrangement. -‘true’ shall be populated for general collateral. General collateral specifies a collateral arrangement for a repurchase transaction in which the security lender may choose the security to provide as collateral with the cash provider amongst a relatively wide range of securities meeting predefined criteria.
        /// -‘false’ shall be populated for specific collateral. Specific collateral specifies a collateral arrangement for a repurchase transaction in which the buyer requests a specific security or commodity (individual ISIN) to be provided by the seller.
        /// </summary>
        [IsoId("_43g-e7OYEemDE9K-I5TT8Q")]
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
        /// Indicates whether the transaction was settled using the Delivery-by-Value (DBV) mechanism.
        /// </summary>
        [IsoId("_43g-YbOYEemDE9K-I5TT8Q")]
        [DisplayName("Delivery By Value")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DlvryByVal")]
        #endif
        [IsoXmlTag("DlvryByVal")]
        [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required IsoTrueFalseIndicator DeliveryByValue { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required System.String DeliveryByValue { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String DeliveryByValue { get; init; } 
        #else
        public System.String DeliveryByValue { get; set; } 
        #endif
        
        /// <summary>
        /// Delivery method of the collateral.
        /// </summary>
        [IsoId("_43g-Y7OYEemDE9K-I5TT8Q")]
        [DisplayName("Collateral Delivery Method")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CollDlvryMtd")]
        #endif
        [IsoXmlTag("CollDlvryMtd")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; init; } 
        #else
        public CollateralDeliveryMethod1Code CollateralDeliveryMethod { get; set; } 
        #endif
        
        /// <summary>
        /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
        /// </summary>
        [IsoId("_43g-ZbOYEemDE9K-I5TT8Q")]
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
        /// Interest rate of the loan.
        /// </summary>
        [IsoId("_43g-Z7OYEemDE9K-I5TT8Q")]
        [DisplayName("Interest Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrstRate")]
        #endif
        [IsoXmlTag("IntrstRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRate20Choice_? InterestRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRate20Choice_? InterestRate { get; init; } 
        #else
        public InterestRate20Choice_? InterestRate { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money to be settled as of the start date and maturity date of the transaction.
        /// </summary>
        [IsoId("_43g-abOYEemDE9K-I5TT8Q")]
        [DisplayName("Principal Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrncplAmt")]
        #endif
        [IsoXmlTag("PrncplAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PrincipalAmount2? PrincipalAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PrincipalAmount2? PrincipalAmount { get; init; } 
        #else
        public PrincipalAmount2? PrincipalAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Termination date in the case of a full early termination of the reported transaction.
        /// </summary>
        [IsoId("_43g-ebOYEemDE9K-I5TT8Q")]
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
        
        /// <summary>
        /// Price of unit of collateral component, including accrued interest for interest-bearing securities.
        /// </summary>
        [IsoId("_43g-fbOYEemDE9K-I5TT8Q")]
        [DisplayName("Unit Price")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="UnitPric")]
        #endif
        [IsoXmlTag("UnitPric")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; init; } 
        #else
        public SecuritiesTransactionPrice11Choice_? UnitPrice { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
