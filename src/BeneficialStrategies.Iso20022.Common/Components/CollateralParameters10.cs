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
/// Parameters which explicitly state the conditions that must be fulfilled before a particular triparty collateral instruction/transaction  can be confirmed. These parameters are defined by the instructing party in compliance with triparty collateral rules in the market the instruction/transaction will take place.
/// </summary>
[IsoId("_KuBgcSs9EeySlt9bF77XfA")]
[DisplayName("Collateral Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralParameters10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralParameters10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralParameters10( CollateralTransactionType1Choice_ reqCollateralInstructionType,ExposureType23Choice_ reqExposureType,CollateralRole1Code reqCollateralSide )
    {
        CollateralInstructionType = reqCollateralInstructionType;
        ExposureType = reqExposureType;
        CollateralSide = reqCollateralSide;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of collateral instruction.
    /// </summary>
    [IsoId("_LIZvVys9EeySlt9bF77XfA")]
    [DisplayName("Collateral Instruction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInstrTp")]
    #endif
    [IsoXmlTag("CollInstrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralTransactionType1Choice_ CollateralInstructionType { get; init; } 
    #else
    public CollateralTransactionType1Choice_ CollateralInstructionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the underlying business area/type of trade causing the exposure.
    /// </summary>
    [IsoId("_LIZvWSs9EeySlt9bF77XfA")]
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
    /// Specifies whether the client is the collateral taker or giver.
    /// </summary>
    [IsoId("_LIZvWys9EeySlt9bF77XfA")]
    [DisplayName("Collateral Side")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollSd")]
    #endif
    [IsoXmlTag("CollSd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CollateralRole1Code CollateralSide { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CollateralRole1Code CollateralSide { get; init; } 
    #else
    public CollateralRole1Code CollateralSide { get; set; } 
    #endif
    
    /// <summary>
    /// Percentage by which the collateral value sought is increased, in selecting securities for a collateral basket, to reflect the taker&apos;s margin requirements.
    /// Margin or haircut to be applied on the exposure amount, expressed  as a percentage.
    /// </summary>
    [IsoId("_LIZvXSs9EeySlt9bF77XfA")]
    [DisplayName("Value Sought Margin Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValSghtMrgnRate")]
    #endif
    [IsoXmlTag("ValSghtMrgnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateOrType1Choice_? ValueSoughtMarginRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateOrType1Choice_? ValueSoughtMarginRate { get; init; } 
    #else
    public RateOrType1Choice_? ValueSoughtMarginRate { get; set; } 
    #endif
    
    /// <summary>
    /// Change of title for the collateral. If N then collateral is pledged.
    /// </summary>
    [IsoId("_LIZvXys9EeySlt9bF77XfA")]
    [DisplayName("Transfer Title")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfTitl")]
    #endif
    [IsoXmlTag("TrfTitl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TransferTitle { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransferTitle { get; init; } 
    #else
    public System.String? TransferTitle { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the settlement process in which the collateral will be settled.
    /// </summary>
    [IsoId("_LIZvYSs9EeySlt9bF77XfA")]
    [DisplayName("Settlement Process")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmPrc")]
    #endif
    [IsoXmlTag("SttlmPrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? SettlementProcess { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? SettlementProcess { get; init; } 
    #else
    public GenericIdentification30? SettlementProcess { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the priority with which the instruction needs to be executed.
    /// </summary>
    [IsoId("_LIZvYys9EeySlt9bF77XfA")]
    [DisplayName("Priority")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prty")]
    #endif
    [IsoXmlTag("Prty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification30? Priority { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification30? Priority { get; init; } 
    #else
    public GenericIdentification30? Priority { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the allocation of the collateral is manual or automatic.
    /// </summary>
    [IsoId("_LIZvZSs9EeySlt9bF77XfA")]
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
    /// Specifies whether the taker is allowed to solve the failing settlement by proposing other collateral movements.
    /// </summary>
    [IsoId("_LIZvZys9EeySlt9bF77XfA")]
    [DisplayName("Failed Settlement Salvation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FaildSttlmSlvtn")]
    #endif
    [IsoXmlTag("FaildSttlmSlvtn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FailedSettlementSalvation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FailedSettlementSalvation { get; init; } 
    #else
    public System.String? FailedSettlementSalvation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the main trading account  is included in the pool of securities positions available for collateralisation. It is used in case of re-use of collateral to specify the account from which the securities collateral is taken from.
    /// </summary>
    [IsoId("_LIZvaSs9EeySlt9bF77XfA")]
    [DisplayName("Main Trading Account Collateralisation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MainTradgAcctCollstn")]
    #endif
    [IsoXmlTag("MainTradgAcctCollstn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MainTradingAccountCollateralisation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MainTradingAccountCollateralisation { get; init; } 
    #else
    public System.String? MainTradingAccountCollateralisation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the baskets identification and the Eligibility Set Profile.
    /// </summary>
    [IsoId("_LIZvays9EeySlt9bF77XfA")]
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
    /// Collateral taker&apos;s answer to the collateral giver instruction.
    /// </summary>
    [IsoId("_LIZvbSs9EeySlt9bF77XfA")]
    [DisplayName("Response Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RspnSts")]
    #endif
    [IsoXmlTag("RspnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ResponseStatus9Choice_? ResponseStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseStatus9Choice_? ResponseStatus { get; init; } 
    #else
    public ResponseStatus9Choice_? ResponseStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information to a collateral instruction.
    /// </summary>
    [IsoId("_LIZvbys9EeySlt9bF77XfA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation24? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation24? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation24? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
