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
[IsoId("_LgF2lSs9EeySlt9bF77XfA")]
[DisplayName("Collateral Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CollateralParameters11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CollateralParameters11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CollateralParameters11( CollateralTransactionType1Choice_ reqCollateralInstructionType,ExposureType23Choice_ reqExposureType,CollateralRole1Code reqCollateralSide )
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
    [IsoId("_L3V48Ss9EeySlt9bF77XfA")]
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
    [IsoId("_L3V48ys9EeySlt9bF77XfA")]
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
    /// Specifies whether the alleged side is the collateral taker or giver. So it will be the opposite  side of the instruction.
    /// </summary>
    [IsoId("_L3V49Ss9EeySlt9bF77XfA")]
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
    /// </summary>
    [IsoId("_L3V49ys9EeySlt9bF77XfA")]
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
    /// Number identifying the collateral eligibility set profile of the counterparty.
    /// </summary>
    [IsoId("_L3V4-Ss9EeySlt9bF77XfA")]
    [DisplayName("Eligibility Set Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElgbltySetPrfl")]
    #endif
    [IsoXmlTag("ElgbltySetPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification1? EligibilitySetProfile { get; init; } 
    #else
    public GenericIdentification1? EligibilitySetProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Change of title for the collateral. If N then collateral is pledged.
    /// </summary>
    [IsoId("_L3V4-ys9EeySlt9bF77XfA")]
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
    [IsoId("_L3V4_Ss9EeySlt9bF77XfA")]
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
    
    
    #nullable disable
    
}
