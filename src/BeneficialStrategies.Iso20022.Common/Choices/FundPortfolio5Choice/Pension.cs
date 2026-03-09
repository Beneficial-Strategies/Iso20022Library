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
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio5Choice
{
    /// <summary>
    /// Portfolio is a pension policy, plan or scheme.
    /// </summary>
    [IsoId("_nxCypZNMEemQB_8XA98K0Q")]
    [DisplayName("Pension")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Pension : FundPortfolio5Choice_
    #else
    public partial class Pension : FundPortfolio5Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        /// <summary>
        /// Constructs a Pension instance using the members the ISO20022 deems required.
        /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
        /// </summary>
        public Pension( PensionSchemeType2Choice_ reqType )
        {
            Type = reqType;
        }
        #endif
        #nullable enable
        
        /// <summary>
        /// Identification of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOA5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOBZNvEembCsVG-3f_AA")]
        [DisplayName("Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Tp")]
        #endif
        [IsoXmlTag("Tp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public required PensionSchemeType2Choice_ Type { get; init; } 
        #elif NET7_0_OR_GREATER // C# 11 Records, required members
        public required PensionSchemeType2Choice_ Type { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PensionSchemeType2Choice_ Type { get; init; } 
        #else
        public PensionSchemeType2Choice_ Type { get; set; } 
        #endif
        
        /// <summary>
        /// Scope of the pension policy, plan or scheme transfer.
        /// </summary>
        [IsoId("_0utOB5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOCZNvEembCsVG-3f_AA")]
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
        [IsoId("_0utOC5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utODZNvEembCsVG-3f_AA")]
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
        /// Type of drawdown tranche.
        /// </summary>
        [IsoId("_G6j6cJNwEembCsVG-3f_AA")]
        [DisplayName("Drawdown Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DrwdwnTp")]
        #endif
        [IsoXmlTag("DrwdwnTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DrawdownType2Choice_? DrawdownType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DrawdownType2Choice_? DrawdownType { get; init; } 
        #else
        public DrawdownType2Choice_? DrawdownType { get; set; } 
        #endif
        
        /// <summary>
        /// Estimated value of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOD5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOEZNvEembCsVG-3f_AA")]
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
        /// When the transfer is part of a block transfer, reference to link several items.
        /// </summary>
        [IsoId("_1FMl8JNwEembCsVG-3f_AA")]
        [DisplayName("Block Transfer Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BlckTrfRef")]
        #endif
        [IsoXmlTag("BlckTrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? BlockTransferReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BlockTransferReference { get; init; } 
        #else
        public System.String? BlockTransferReference { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the tax-free cash is protected when the pension policy, plan or scheme is transferred.
        /// </summary>
        [IsoId("_0utOE5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOFZNvEembCsVG-3f_AA")]
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
        [IsoId("_0utOF5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOGZNvEembCsVG-3f_AA")]
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
        [IsoId("_0utOG5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOHZNvEembCsVG-3f_AA")]
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
        [IsoId("_0utOH5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOIZNvEembCsVG-3f_AA")]
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
        [IsoId("_0utOI5NvEembCsVG-3f_AA")]
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
        [IsoId("_0utOJZNvEembCsVG-3f_AA")]
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
        [IsoId("_0utOJ5NvEembCsVG-3f_AA")]
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
        /// Indicates whether the pension policy, plan or scheme has non-safeguarded guaranteed benefits.
        /// </summary>
        [IsoId("_9vOW0JNwEembCsVG-3f_AA")]
        [DisplayName("Non Safeguarded Guaranteed Benefits")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="NonSfgrddGrntedBnfts")]
        #endif
        [IsoXmlTag("NonSfgrddGrntedBnfts")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? NonSafeguardedGuaranteedBenefits { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? NonSafeguardedGuaranteedBenefits { get; init; } 
        #else
        public System.String? NonSafeguardedGuaranteedBenefits { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether the pension policy, plan or scheme has lifetime allowance protection.
        /// </summary>
        [IsoId("_0utOKZNvEembCsVG-3f_AA")]
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
        /// Indicates whether the client has any lifetime allowance protection.
        /// </summary>
        [IsoId("_G487cJNxEembCsVG-3f_AA")]
        [DisplayName("Client Lifetime Allowance Protection")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ClntLftmAllwncPrtcn")]
        #endif
        [IsoXmlTag("ClntLftmAllwncPrtcn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? ClientLifetimeAllowanceProtection { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ClientLifetimeAllowanceProtection { get; init; } 
        #else
        public System.String? ClientLifetimeAllowanceProtection { get; set; } 
        #endif
        
        /// <summary>
        /// Indicates whether a benefit crystallisation event (BCE) has occurred. This includes ‘age 75 checks’.
        /// </summary>
        [IsoId("_atF0UJNxEembCsVG-3f_AA")]
        [DisplayName("Benefit Crystallisation Event Occurred")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="BnftCrstllstnEvtOcrd")]
        #endif
        [IsoXmlTag("BnftCrstllstnEvtOcrd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoYesNoIndicator? BenefitCrystallisationEventOccurred { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? BenefitCrystallisationEventOccurred { get; init; } 
        #else
        public System.String? BenefitCrystallisationEventOccurred { get; set; } 
        #endif
        
        /// <summary>
        /// Additional information about the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOK5NvEembCsVG-3f_AA")]
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
}
