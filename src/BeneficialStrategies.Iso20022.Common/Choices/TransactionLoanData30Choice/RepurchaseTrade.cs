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
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData30Choice
{
    /// <summary>
    /// Details of the repurchase trade transaction.
    /// </summary>
    [IsoId("_gHkCccg4Eeu4ecZgAYuz5w")]
    [DisplayName("Repurchase Trade")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record RepurchaseTrade : TransactionLoanData30Choice_
    #else
    public partial class RepurchaseTrade : TransactionLoanData30Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a RepurchaseTrade instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public RepurchaseTrade( System.String reqUniqueTradeIdentifier,System.DateOnly reqEventDate,System.DateTime reqExecutionDateTime )
        {
            UniqueTradeIdentifier = reqUniqueTradeIdentifier;
            EventDate = reqEventDate;
            ExecutionDateTime = reqExecutionDateTime;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Unique Trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_gI_l0cg4Eeu4ecZgAYuz5w")]
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
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_gI_l08g4Eeu4ecZgAYuz5w")]
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
        [IsoId("_gI_l1cg4Eeu4ecZgAYuz5w")]
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
        [IsoId("_gI_l18g4Eeu4ecZgAYuz5w")]
        [DisplayName("Clearing Status")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClrSts")]
        #endif
        [IsoXmlTag("ClrSts")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Cleared16Choice_? ClearingStatus { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Cleared16Choice_? ClearingStatus { get; init; } 
        #else
        public Cleared16Choice_? ClearingStatus { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the trading venue where the transaction was executed.
        /// </summary>
        [IsoId("_gI_l2cg4Eeu4ecZgAYuz5w")]
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
        [IsoId("_gI_l28g4Eeu4ecZgAYuz5w")]
        [DisplayName("Master Agreement")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MstrAgrmt")]
        #endif
        [IsoXmlTag("MstrAgrmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public MasterAgreement7? MasterAgreement { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public MasterAgreement7? MasterAgreement { get; init; } 
        #else
        public MasterAgreement7? MasterAgreement { get; set; } 
        #endif
        
        /// <summary>
        /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of transaction open term, this is the date on which the rollover settles, even if no exchange of cash takes place.
        /// </summary>
        [IsoId("_gI_l3cg4Eeu4ecZgAYuz5w")]
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
        /// Minimum number of business days that one of the counterparties has to inform about the termination of the transaction.
        /// </summary>
        [IsoId("_gI_l38g4Eeu4ecZgAYuz5w")]
        [DisplayName("Minimum Notice Period")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="MinNtcePrd")]
        #endif
        [IsoXmlTag("MinNtcePrd")]
        [IsoSimpleType(IsoSimpleType.Max20PositiveNumber)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax20PositiveNumber? MinimumNoticePeriod { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.UInt64? MinimumNoticePeriod { get; init; } 
        #else
        public System.UInt64? MinimumNoticePeriod { get; set; } 
        #endif
        
        /// <summary>
        /// Earliest date that the cash lender has the right to call back a portion of the amount of money or to terminate the transaction.
        /// </summary>
        [IsoId("_gI_l4cg4Eeu4ecZgAYuz5w")]
        [DisplayName("Earliest Call Back Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="EarlstCallBckDt")]
        #endif
        [IsoXmlTag("EarlstCallBckDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? EarliestCallBackDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? EarliestCallBackDate { get; init; } 
        #else
        public System.DateOnly? EarliestCallBackDate { get; set; } 
        #endif
        
        /// <summary>
        /// Indication whether the secured financing transaction is subject to a general or special collateral arrangement.
        /// </summary>
        [IsoId("_gI_l48g4Eeu4ecZgAYuz5w")]
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
        [IsoId("_gI_l5cg4Eeu4ecZgAYuz5w")]
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
        /// Delivery method of the collateral.
        /// </summary>
        [IsoId("_gI_l58g4Eeu4ecZgAYuz5w")]
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
        /// Period before or at the end of which the loan should be repaid or renegotiated for another term. 
        /// </summary>
        [IsoId("_gI_l6cg4Eeu4ecZgAYuz5w")]
        [DisplayName("Term")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Term")]
        #endif
        [IsoXmlTag("Term")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ContractTerm7Choice_? Term { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ContractTerm7Choice_? Term { get; init; } 
        #else
        public ContractTerm7Choice_? Term { get; set; } 
        #endif
        
        /// <summary>
        /// Interest rate of the loan.
        /// </summary>
        [IsoId("_gI_l68g4Eeu4ecZgAYuz5w")]
        [DisplayName("Interest Rate")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="IntrstRate")]
        #endif
        [IsoXmlTag("IntrstRate")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public InterestRate27Choice_? InterestRate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public InterestRate27Choice_? InterestRate { get; init; } 
        #else
        public InterestRate27Choice_? InterestRate { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money to be settled as of the start date and maturity date of the transaction.
        /// </summary>
        [IsoId("_gI_l7cg4Eeu4ecZgAYuz5w")]
        [DisplayName("Principal Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PrncplAmt")]
        #endif
        [IsoXmlTag("PrncplAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PrincipalAmount3? PrincipalAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PrincipalAmount3? PrincipalAmount { get; init; } 
        #else
        public PrincipalAmount3? PrincipalAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Termination date in the case of a full early termination of the Securities Financing Transaction (SFT).
        /// </summary>
        [IsoId("_gI_l78g4Eeu4ecZgAYuz5w")]
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
