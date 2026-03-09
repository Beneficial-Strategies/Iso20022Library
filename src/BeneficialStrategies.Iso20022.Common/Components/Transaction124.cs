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
/// Details of the transactions reported.
/// </summary>
[IsoId("_M9-J0Ss9EeySlt9bF77XfA")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction124
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction124 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction124( System.String reqTripartyAgentServiceProviderCollateralTransactionIdentification,ExposureType23Choice_ reqExposureType,CollateralParties11 reqCollateralParties,ClosingDate4Choice_ reqExecutionRequestedDate,ClosingDate4Choice_ reqClosingDate,CollateralAmount17 reqValuationAmounts )
    {
        TripartyAgentServiceProviderCollateralTransactionIdentification = reqTripartyAgentServiceProviderCollateralTransactionIdentification;
        ExposureType = reqExposureType;
        CollateralParties = reqCollateralParties;
        ExecutionRequestedDate = reqExecutionRequestedDate;
        ClosingDate = reqClosingDate;
        ValuationAmounts = reqValuationAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique reference identifying the triparty collateral management transaction from the client&apos;s point of view.
    /// </summary>
    [IsoId("_NVOMNSs9EeySlt9bF77XfA")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClntTrptyCollTxId")]
    #endif
    [IsoXmlTag("ClntTrptyCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ClientTripartyCollateralTransactionIdentification { get; init; } 
    #else
    public System.String? ClientTripartyCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique reference identifying the triparty-agent/service-provider collateral management transaction from the triparty-agent&apos;s/service-provider&apos;s point of view.
    /// </summary>
    [IsoId("_NVOMNys9EeySlt9bF77XfA")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrptyAgtSvcPrvdrCollTxId")]
    #endif
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; } 
    #else
    public System.String TripartyAgentServiceProviderCollateralTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique collateral transaction reference assigned by counterparty.
    /// </summary>
    [IsoId("_NVOMOSs9EeySlt9bF77XfA")]
    [DisplayName("Counterparty Collateral Transaction Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrPtyCollTxRef")]
    #endif
    [IsoXmlTag("CtrPtyCollTxRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CounterpartyCollateralTransactionReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CounterpartyCollateralTransactionReference { get; init; } 
    #else
    public System.String? CounterpartyCollateralTransactionReference { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification (UTI) agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_NVOMOys9EeySlt9bF77XfA")]
    [DisplayName("Common Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonTxId")]
    #endif
    [IsoXmlTag("CmonTxId")]
    [IsoSimpleType(IsoSimpleType.Max52Text)]
    [StringLength(maximumLength: 52 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax52Text? CommonTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonTransactionIdentification { get; init; } 
    #else
    public System.String? CommonTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_NVOMPSs9EeySlt9bF77XfA")]
    [DisplayName("Exposure Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpsrTp")]
    #endif
    [IsoXmlTag("XpsrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExposureType23Choice_ ExposureType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExposureType23Choice_ ExposureType { get; init; } 
    #else
    public ExposureType23Choice_ ExposureType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether it is a Call option (right to purchase a specific underlying asset) or a Put option (right to sell a specific underlying asset).
    /// </summary>
    [IsoId("_NVOMPys9EeySlt9bF77XfA")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OptionType6Choice_? OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionType6Choice_? OptionType { get; init; } 
    #else
    public OptionType6Choice_? OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the counterparties to the transaction have agreed to an evergreen or extendable repo.
    /// </summary>
    [IsoId("_NVOMQSs9EeySlt9bF77XfA")]
    [DisplayName("Termination Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermntnOptn")]
    #endif
    [IsoXmlTag("TermntnOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RepoTerminationOption1Code? TerminationOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RepoTerminationOption1Code? TerminationOption { get; init; } 
    #else
    public RepoTerminationOption1Code? TerminationOption { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the baskets identification and the Eligiblity Set Profile.
    /// </summary>
    [IsoId("_NVOMQys9EeySlt9bF77XfA")]
    [DisplayName("Basket Identification And Eligibility Set Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BsktIdAndElgbltySetPrfl")]
    #endif
    [IsoXmlTag("BsktIdAndElgbltySetPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; init; } 
    #else
    public BasketIdentificationAndEligibilitySetProfile1? BasketIdentificationAndEligibilitySetProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_NVOMRSs9EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollPties")]
    #endif
    [IsoXmlTag("CollPties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralParties11 CollateralParties { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralParties11 CollateralParties { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralParties11 CollateralParties { get; init; } 
    #else
    public CollateralParties11 CollateralParties { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which the party requested the initiation instruction to be executed.
    /// </summary>
    [IsoId("_NVOMRys9EeySlt9bF77XfA")]
    [DisplayName("Execution Requested Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ExctnReqdDt")]
    #endif
    [IsoXmlTag("ExctnReqdDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClosingDate4Choice_ ExecutionRequestedDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClosingDate4Choice_ ExecutionRequestedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingDate4Choice_ ExecutionRequestedDate { get; init; } 
    #else
    public ClosingDate4Choice_ ExecutionRequestedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Closing date/time or maturity date/time of the transaction.
    /// </summary>
    [IsoId("_NVOMSSs9EeySlt9bF77XfA")]
    [DisplayName("Closing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClsgDt")]
    #endif
    [IsoXmlTag("ClsgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ClosingDate4Choice_ ClosingDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ClosingDate4Choice_ ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClosingDate4Choice_ ClosingDate { get; init; } 
    #else
    public ClosingDate4Choice_ ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the collateral valuation.
    /// </summary>
    [IsoId("_NVOMSys9EeySlt9bF77XfA")]
    [DisplayName("Valuation Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValtnAmts")]
    #endif
    [IsoXmlTag("ValtnAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralAmount17 ValuationAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralAmount17 ValuationAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralAmount17 ValuationAmounts { get; init; } 
    #else
    public CollateralAmount17 ValuationAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Interest rate to be paid on the transaction amount, as agreed between the counterparties.
    /// </summary>
    [IsoId("_NVOMTSs9EeySlt9bF77XfA")]
    [DisplayName("Pricing Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricgRate")]
    #endif
    [IsoXmlTag("PricgRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateOrName4Choice_? PricingRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateOrName4Choice_? PricingRate { get; init; } 
    #else
    public RateOrName4Choice_? PricingRate { get; set; } 
    #endif
    
    /// <summary>
    /// The collateral excess/shortage expressed in the percentage of the collateral required.
    /// </summary>
    [IsoId("_NVOMTys9EeySlt9bF77XfA")]
    [DisplayName("Margin Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MrgnRate")]
    #endif
    [IsoXmlTag("MrgnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MarginRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MarginRate { get; init; } 
    #else
    public System.Decimal? MarginRate { get; set; } 
    #endif
    
    /// <summary>
    /// Margin rate over or under an index.
    /// Feedback 
    /// </summary>
    [IsoId("_NVOMUSs9EeySlt9bF77XfA")]
    [DisplayName("Spread Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SprdRate")]
    #endif
    [IsoXmlTag("SprdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? SpreadRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? SpreadRate { get; init; } 
    #else
    public System.Decimal? SpreadRate { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the computation method of (accrued) interest of the financial instrument.
    /// </summary>
    [IsoId("_NVOMUys9EeySlt9bF77XfA")]
    [DisplayName("Day Count Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DayCntBsis")]
    #endif
    [IsoXmlTag("DayCntBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; init; } 
    #else
    public InterestComputationMethodFormat4Choice_? DayCountBasis { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the allocation of the collateral is manual or automatic.
    /// </summary>
    [IsoId("_NVOMVSs9EeySlt9bF77XfA")]
    [DisplayName("Automatic Allocation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AutomtcAllcn")]
    #endif
    [IsoXmlTag("AutomtcAllcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? AutomaticAllocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AutomaticAllocation { get; init; } 
    #else
    public System.String? AutomaticAllocation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides the status of a  transaction.
    /// </summary>
    [IsoId("_NVOMVys9EeySlt9bF77XfA")]
    [DisplayName("Transaction Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSts")]
    #endif
    [IsoXmlTag("TxSts")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<TransactionStatus6> TransactionStatus { get; init; } = new ValueList<TransactionStatus6>(){};
    
    /// <summary>
    /// Quantity of securities assigned as collateral position.
    /// </summary>
    [IsoId("_NVOMWSs9EeySlt9bF77XfA")]
    [DisplayName("Securities Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBal")]
    #endif
    [IsoXmlTag("SctiesBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesBalance3? SecuritiesBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalance3? SecuritiesBalance { get; init; } 
    #else
    public SecuritiesBalance3? SecuritiesBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash assigned as collateral position.
    /// </summary>
    [IsoId("_NVOMWys9EeySlt9bF77XfA")]
    [DisplayName("Cash Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshBal")]
    #endif
    [IsoXmlTag("CshBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashBalance15? CashBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashBalance15? CashBalance { get; init; } 
    #else
    public CashBalance15? CashBalance { get; set; } 
    #endif
    
    
    #nullable disable
    
}
