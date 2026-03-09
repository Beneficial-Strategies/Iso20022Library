// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the loan data details in case of a repurchase trade transaction.
/// </summary>
[IsoId("_nYaM8ax2Eem81-uIvTF5rQ")]
[DisplayName("Loan Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoanData81
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique Trade Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_nck7Qax2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7Q6x2Eem81-uIvTF5rQ")]
    [DisplayName("Event Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtDt")]
    #endif
    [IsoXmlTag("EvtDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? EventDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? EventDate { get; init; } 
    #else
    public System.DateOnly? EventDate { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the date and time when the contract was executed.
    /// </summary>
    [IsoId("_nck7Rax2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7R6x2Eem81-uIvTF5rQ")]
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
    /// Identification of the trading venue where the transaction was executed.
    /// </summary>
    [IsoId("_nck7Sax2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7S6x2Eem81-uIvTF5rQ")]
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
    /// Date on which the counterparties contractually agree the exchange of securities or commodities versus collateral for the opening leg (spot leg) of the secured financing transaction. In the case of rollover of transaction open term, this is the date on which the rollover settles, even if no exchange of cash takes place.
    /// </summary>
    [IsoId("_nck7Tax2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7T6x2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7Uax2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7U6x2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7Vax2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7V6x2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7Wax2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7W6x2Eem81-uIvTF5rQ")]
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
    [IsoId("_nck7Xax2Eem81-uIvTF5rQ")]
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
    /// Termination date in the case of a full early termination of the SFT.
    /// </summary>
    [IsoId("_nck7X6x2Eem81-uIvTF5rQ")]
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
