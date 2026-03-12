// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FundPortfolio5Choice
{
    /// <summary>
    /// Portfolio is a pension policy, plan or scheme.
    /// </summary>
    [IsoId("_nxCypZNMEemQB_8XA98K0Q")]
    [DisplayName("Pension")]
    public partial record Pension : FundPortfolio5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Identification of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOA5NvEembCsVG-3f_AA")]
        [DisplayName("Identification")]
        [IsoXmlTag("Id")]
        public PensionPolicy1? Identification { get; init; } 
        
        /// <summary>
        /// Type of pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOBZNvEembCsVG-3f_AA")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required PensionSchemeType2Choice_ Type { get; init; } 
        
        /// <summary>
        /// Scope of the pension policy, plan or scheme transfer.
        /// </summary>
        [IsoId("_0utOB5NvEembCsVG-3f_AA")]
        [DisplayName("Transfer Scope")]
        [IsoXmlTag("TrfScp")]
        public PensionTransferScope1Choice_? TransferScope { get; init; } 
        
        /// <summary>
        /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
        /// </summary>
        [IsoId("_0utOCZNvEembCsVG-3f_AA")]
        [DisplayName("Tax Reference")]
        [IsoXmlTag("TaxRef")]
        public TaxReference1? TaxReference { get; init; } 
        
        /// <summary>
        /// Reference of the drawdown.
        /// </summary>
        [IsoId("_0utOC5NvEembCsVG-3f_AA")]
        [DisplayName("Drawdown Tranche Identification")]
        [IsoXmlTag("DrwdwnTrchId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? DrawdownTrancheIdentification { get; init; } 
        
        /// <summary>
        /// Drawdown status of the pension.
        /// </summary>
        [IsoId("_0utODZNvEembCsVG-3f_AA")]
        [DisplayName("Drawdown Status")]
        [IsoXmlTag("DrwdwnSts")]
        public DrawdownStatus1Choice_? DrawdownStatus { get; init; } 
        
        /// <summary>
        /// Type of drawdown tranche.
        /// </summary>
        [IsoId("_G6j6cJNwEembCsVG-3f_AA")]
        [DisplayName("Drawdown Type")]
        [IsoXmlTag("DrwdwnTp")]
        public DrawdownType2Choice_? DrawdownType { get; init; } 
        
        /// <summary>
        /// Estimated value of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOD5NvEembCsVG-3f_AA")]
        [DisplayName("Estimated Value")]
        [IsoXmlTag("EstmtdVal")]
        public DateAndAmount2? EstimatedValue { get; init; } 
        
        /// <summary>
        /// Indicates whether the transfer forms part of a block transfer.
        /// </summary>
        [IsoId("_0utOEZNvEembCsVG-3f_AA")]
        [DisplayName("Block Transfer")]
        [IsoXmlTag("BlckTrf")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? BlockTransfer { get; init; } 
        
        /// <summary>
        /// When the transfer is part of a block transfer, reference to link several items.
        /// </summary>
        [IsoId("_1FMl8JNwEembCsVG-3f_AA")]
        [DisplayName("Block Transfer Reference")]
        [IsoXmlTag("BlckTrfRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? BlockTransferReference { get; init; } 
        
        /// <summary>
        /// Indicates whether the tax-free cash is protected when the pension policy, plan or scheme is transferred.
        /// </summary>
        [IsoId("_0utOE5NvEembCsVG-3f_AA")]
        [DisplayName("Tax Free Cash Protection")]
        [IsoXmlTag("TaxFreeCshPrtcn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? TaxFreeCashProtection { get; init; } 
        
        /// <summary>
        /// Amount of cash that is tax free.
        /// </summary>
        [IsoId("_0utOFZNvEembCsVG-3f_AA")]
        [DisplayName("Tax Free Cash Amount")]
        [IsoXmlTag("TaxFreeCshAmt")]
        public DateAndAmount2? TaxFreeCashAmount { get; init; } 
        
        /// <summary>
        /// Value of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOF5NvEembCsVG-3f_AA")]
        [DisplayName("Value Of Pension Policy Or Plan Or Scheme")]
        [IsoXmlTag("ValOfPnsnPlcyOrPlanOrSchme")]
        public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; } 
        
        /// <summary>
        /// Indicates whether the pension policy, plan or scheme has retirement age protection.
        /// </summary>
        [IsoId("_0utOGZNvEembCsVG-3f_AA")]
        [DisplayName("Retirement Age Protection")]
        [IsoXmlTag("RtrmntAgePrtcn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? RetirementAgeProtection { get; init; } 
        
        /// <summary>
        /// Age at which the pension policy, plan or scheme holder retires.
        /// </summary>
        [IsoId("_0utOG5NvEembCsVG-3f_AA")]
        [DisplayName("Retirement Age")]
        [IsoXmlTag("RtrmntAge")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public IsoDecimalNumber? RetirementAge { get; init; } 
        
        /// <summary>
        /// Indicates whether the pension benefits are shared.
        /// </summary>
        [IsoId("_0utOHZNvEembCsVG-3f_AA")]
        [DisplayName("Sharing")]
        [IsoXmlTag("Shrg")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? Sharing { get; init; } 
        
        /// <summary>
        /// Type of lump sum paid to a member of the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOH5NvEembCsVG-3f_AA")]
        [DisplayName("Lump Sum Type")]
        [IsoXmlTag("LumpSumTp")]
        public LumpSumType1Choice_? LumpSumType { get; init; } 
        
        /// <summary>
        /// Order attached to the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOIZNvEembCsVG-3f_AA")]
        [DisplayName("Pension Order")]
        [IsoXmlTag("PnsnOrdr")]
        public PensionOrder1? PensionOrder { get; init; } 
        
        /// <summary>
        /// Indicates whether assets held within the pension are ring-fenced into specific tranches.
        /// </summary>
        [IsoId("_0utOI5NvEembCsVG-3f_AA")]
        [DisplayName("Ring Fenced Drawdown Assets")]
        [IsoXmlTag("RingFncdDrwdwnAssts")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? RingFencedDrawdownAssets { get; init; } 
        
        /// <summary>
        /// Money Purchase Annual Allowance (MPAA) details.
        /// </summary>
        [IsoId("_0utOJZNvEembCsVG-3f_AA")]
        [DisplayName("Money Purchase Annual Allowance")]
        [IsoXmlTag("MnyPurchsAnlAllwnc")]
        public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; } 
        
        /// <summary>
        /// Indicates whether the pension policy, plan or scheme is covered by a safeguard benefit.
        /// </summary>
        [IsoId("_0utOJ5NvEembCsVG-3f_AA")]
        [DisplayName("Safeguard Benefit")]
        [IsoXmlTag("SfgrdBnft")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? SafeguardBenefit { get; init; } 
        
        /// <summary>
        /// Indicates whether the pension policy, plan or scheme has non-safeguarded guaranteed benefits.
        /// </summary>
        [IsoId("_9vOW0JNwEembCsVG-3f_AA")]
        [DisplayName("Non Safeguarded Guaranteed Benefits")]
        [IsoXmlTag("NonSfgrddGrntedBnfts")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? NonSafeguardedGuaranteedBenefits { get; init; } 
        
        /// <summary>
        /// Indicates whether the pension policy, plan or scheme has lifetime allowance protection.
        /// </summary>
        [IsoId("_0utOKZNvEembCsVG-3f_AA")]
        [DisplayName("Lifetime Allowance Protection")]
        [IsoXmlTag("LftmAllwncPrtcn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; } 
        
        /// <summary>
        /// Indicates whether the client has any lifetime allowance protection.
        /// </summary>
        [IsoId("_G487cJNxEembCsVG-3f_AA")]
        [DisplayName("Client Lifetime Allowance Protection")]
        [IsoXmlTag("ClntLftmAllwncPrtcn")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? ClientLifetimeAllowanceProtection { get; init; } 
        
        /// <summary>
        /// Indicates whether a benefit crystallisation event (BCE) has occurred. This includes ‘age 75 checks’.
        /// </summary>
        [IsoId("_atF0UJNxEembCsVG-3f_AA")]
        [DisplayName("Benefit Crystallisation Event Occurred")]
        [IsoXmlTag("BnftCrstllstnEvtOcrd")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public IsoYesNoIndicator? BenefitCrystallisationEventOccurred { get; init; } 
        
        /// <summary>
        /// Additional information about the pension policy, plan or scheme.
        /// </summary>
        [IsoId("_0utOK5NvEembCsVG-3f_AA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        public AdditionalInformation15? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
