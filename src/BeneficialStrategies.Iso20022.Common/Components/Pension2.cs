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
/// Attributes of a pension.
/// </summary>
[IsoId("_00BtYFKgEeiOGaojF53zIw")]
[DisplayName("Pension")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Pension2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Pension2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Pension2( PensionSchemeType1Choice_ reqType )
    {
        Type = reqType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_aKAk4VkOEeiaQoK2-_0KTA")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionPolicy1? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionPolicy1? Identification { get; init; } 
    #else
    public PensionPolicy1? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    [IsoId("_4Nrw1VKgEeiOGaojF53zIw")]
    [DisplayName("Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tp")]
    #endif
    [IsoXmlTag("Tp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PensionSchemeType1Choice_ Type { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PensionSchemeType1Choice_ Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionSchemeType1Choice_ Type { get; init; } 
    #else
    public PensionSchemeType1Choice_ Type { get; set; } 
    #endif
    
    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    [IsoId("_4Nrw1lKgEeiOGaojF53zIw")]
    [DisplayName("Transfer Scope")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrfScp")]
    #endif
    [IsoXmlTag("TrfScp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionTransferScope1Choice_? TransferScope { get; init; } 
    #else
    public PensionTransferScope1Choice_? TransferScope { get; set; } 
    #endif
    
    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    [IsoId("_4Nrw11KgEeiOGaojF53zIw")]
    [DisplayName("Tax Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRef")]
    #endif
    [IsoXmlTag("TaxRef")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxReference1? TaxReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxReference1? TaxReference { get; init; } 
    #else
    public TaxReference1? TaxReference { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    [IsoId("_4Nrw2FKgEeiOGaojF53zIw")]
    [DisplayName("Drawdown Tranche Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrwdwnTrchId")]
    #endif
    [IsoXmlTag("DrwdwnTrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DrawdownTrancheIdentification { get; init; } 
    #else
    public System.String? DrawdownTrancheIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Drawdown status of the pension.
    /// </summary>
    [IsoId("_VhXQ0FKiEeiSDqv62fL07g")]
    [DisplayName("Drawdown Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrwdwnSts")]
    #endif
    [IsoXmlTag("DrwdwnSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DrawdownStatus1Choice_? DrawdownStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DrawdownStatus1Choice_? DrawdownStatus { get; init; } 
    #else
    public DrawdownStatus1Choice_? DrawdownStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Estimated value of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_YhLbcFKjEeiSDqv62fL07g")]
    [DisplayName("Estimated Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EstmtdVal")]
    #endif
    [IsoXmlTag("EstmtdVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? EstimatedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? EstimatedValue { get; init; } 
    #else
    public DateAndAmount2? EstimatedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the transfer forms part of a block transfer.
    /// </summary>
    [IsoId("_dEiFUFK4EeiSDqv62fL07g")]
    [DisplayName("Block Transfer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BlckTrf")]
    #endif
    [IsoXmlTag("BlckTrf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? BlockTransfer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? BlockTransfer { get; init; } 
    #else
    public System.String? BlockTransfer { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the tax-free cash is protected when the pension policy, plan or scheme is transferred.
    /// </summary>
    [IsoId("_gkMNoFK5EeiSDqv62fL07g")]
    [DisplayName("Tax Free Cash Protection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxFreeCshPrtcn")]
    #endif
    [IsoXmlTag("TaxFreeCshPrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? TaxFreeCashProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxFreeCashProtection { get; init; } 
    #else
    public System.String? TaxFreeCashProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of cash that is tax free.
    /// </summary>
    [IsoId("_35fDoFK6EeiSDqv62fL07g")]
    [DisplayName("Tax Free Cash Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxFreeCshAmt")]
    #endif
    [IsoXmlTag("TaxFreeCshAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? TaxFreeCashAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? TaxFreeCashAmount { get; init; } 
    #else
    public DateAndAmount2? TaxFreeCashAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Value of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_-wq94FK6EeiSDqv62fL07g")]
    [DisplayName("Value Of Pension Policy Or Plan Or Scheme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValOfPnsnPlcyOrPlanOrSchme")]
    #endif
    [IsoXmlTag("ValOfPnsnPlcyOrPlanOrSchme")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; } 
    #else
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has retirement age protection.
    /// </summary>
    [IsoId("_Lp0sgFK5EeiSDqv62fL07g")]
    [DisplayName("Retirement Age Protection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrmntAgePrtcn")]
    #endif
    [IsoXmlTag("RtrmntAgePrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RetirementAgeProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RetirementAgeProtection { get; init; } 
    #else
    public System.String? RetirementAgeProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Age at which the pension policy, plan or scheme holder retires.
    /// </summary>
    [IsoId("_Ts388FK5EeiSDqv62fL07g")]
    [DisplayName("Retirement Age")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RtrmntAge")]
    #endif
    [IsoXmlTag("RtrmntAge")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? RetirementAge { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? RetirementAge { get; init; } 
    #else
    public System.UInt64? RetirementAge { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension benefits are shared.
    /// </summary>
    [IsoId("_jpNf0FKjEeiSDqv62fL07g")]
    [DisplayName("Sharing")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Shrg")]
    #endif
    [IsoXmlTag("Shrg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Sharing { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Sharing { get; init; } 
    #else
    public System.String? Sharing { get; set; } 
    #endif
    
    /// <summary>
    /// Type of lump sum paid to a member of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xJuJULKcEeiXL6Ccd-oU8g")]
    [DisplayName("Lump Sum Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LumpSumTp")]
    #endif
    [IsoXmlTag("LumpSumTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LumpSumType1Choice_? LumpSumType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LumpSumType1Choice_? LumpSumType { get; init; } 
    #else
    public LumpSumType1Choice_? LumpSumType { get; set; } 
    #endif
    
    /// <summary>
    /// Order attached to the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_GV_SkLTpEeiENt6AoDfPXg")]
    [DisplayName("Pension Order")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PnsnOrdr")]
    #endif
    [IsoXmlTag("PnsnOrdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PensionOrder1? PensionOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PensionOrder1? PensionOrder { get; init; } 
    #else
    public PensionOrder1? PensionOrder { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether assets held within the pension are ring-fenced into specific tranches.
    /// </summary>
    [IsoId("_NHpqgFK7EeiSDqv62fL07g")]
    [DisplayName("Ring Fenced Drawdown Assets")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RingFncdDrwdwnAssts")]
    #endif
    [IsoXmlTag("RingFncdDrwdwnAssts")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RingFencedDrawdownAssets { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RingFencedDrawdownAssets { get; init; } 
    #else
    public System.String? RingFencedDrawdownAssets { get; set; } 
    #endif
    
    /// <summary>
    /// Money Purchase Annual Allowance (MPAA) details.
    /// </summary>
    [IsoId("_XbTroFK7EeiSDqv62fL07g")]
    [DisplayName("Money Purchase Annual Allowance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnyPurchsAnlAllwnc")]
    #endif
    [IsoXmlTag("MnyPurchsAnlAllwnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; } 
    #else
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme is covered by a safeguard benefit.
    /// </summary>
    [IsoId("_t0J88FK7EeiSDqv62fL07g")]
    [DisplayName("Safeguard Benefit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SfgrdBnft")]
    #endif
    [IsoXmlTag("SfgrdBnft")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SafeguardBenefit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SafeguardBenefit { get; init; } 
    #else
    public System.String? SafeguardBenefit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has lifetime allowance protection.
    /// </summary>
    [IsoId("_1spjMFK7EeiSDqv62fL07g")]
    [DisplayName("Lifetime Allowance Protection")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LftmAllwncPrtcn")]
    #endif
    [IsoXmlTag("LftmAllwncPrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LifetimeAllowanceProtection { get; init; } 
    #else
    public System.String? LifetimeAllowanceProtection { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_4Nrw2VKgEeiOGaojF53zIw")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
