// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a pension.
/// </summary>
[IsoId("_00BtYFKgEeiOGaojF53zIw")]
[DisplayName("Pension")]
public record Pension2
{
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_aKAk4VkOEeiaQoK2-_0KTA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PensionPolicy1? Identification { get; init; }

    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    [IsoId("_4Nrw1VKgEeiOGaojF53zIw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required PensionSchemeType1Choice_ Type { get; init; }

    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    [IsoId("_4Nrw1lKgEeiOGaojF53zIw")]
    [DisplayName("Transfer Scope")]
    [IsoXmlTag("TrfScp")]
    public PensionTransferScope1Choice_? TransferScope { get; init; }

    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    [IsoId("_4Nrw11KgEeiOGaojF53zIw")]
    [DisplayName("Tax Reference")]
    [IsoXmlTag("TaxRef")]
    public ValueList<TaxReference1> TaxReference { get; init; } = [];

    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    [IsoId("_4Nrw2FKgEeiOGaojF53zIw")]
    [DisplayName("Drawdown Tranche Identification")]
    [IsoXmlTag("DrwdwnTrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; }

    /// <summary>
    /// Drawdown status of the pension.
    /// </summary>
    [IsoId("_VhXQ0FKiEeiSDqv62fL07g")]
    [DisplayName("Drawdown Status")]
    [IsoXmlTag("DrwdwnSts")]
    public DrawdownStatus1Choice_? DrawdownStatus { get; init; }

    /// <summary>
    /// Estimated value of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_YhLbcFKjEeiSDqv62fL07g")]
    [DisplayName("Estimated Value")]
    [IsoXmlTag("EstmtdVal")]
    public DateAndAmount2? EstimatedValue { get; init; }

    /// <summary>
    /// Indicates whether the transfer forms part of a block transfer.
    /// </summary>
    [IsoId("_dEiFUFK4EeiSDqv62fL07g")]
    [DisplayName("Block Transfer")]
    [IsoXmlTag("BlckTrf")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? BlockTransfer { get; init; }

    /// <summary>
    /// Indicates whether the tax-free cash is protected when the pension policy, plan or scheme is transferred.
    /// </summary>
    [IsoId("_gkMNoFK5EeiSDqv62fL07g")]
    [DisplayName("Tax Free Cash Protection")]
    [IsoXmlTag("TaxFreeCshPrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? TaxFreeCashProtection { get; init; }

    /// <summary>
    /// Amount of cash that is tax free.
    /// </summary>
    [IsoId("_35fDoFK6EeiSDqv62fL07g")]
    [DisplayName("Tax Free Cash Amount")]
    [IsoXmlTag("TaxFreeCshAmt")]
    public DateAndAmount2? TaxFreeCashAmount { get; init; }

    /// <summary>
    /// Value of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_-wq94FK6EeiSDqv62fL07g")]
    [DisplayName("Value Of Pension Policy Or Plan Or Scheme")]
    [IsoXmlTag("ValOfPnsnPlcyOrPlanOrSchme")]
    public DateAndAmount2? ValueOfPensionPolicyOrPlanOrScheme { get; init; }

    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has retirement age protection.
    /// </summary>
    [IsoId("_Lp0sgFK5EeiSDqv62fL07g")]
    [DisplayName("Retirement Age Protection")]
    [IsoXmlTag("RtrmntAgePrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RetirementAgeProtection { get; init; }

    /// <summary>
    /// Age at which the pension policy, plan or scheme holder retires.
    /// </summary>
    [IsoId("_Ts388FK5EeiSDqv62fL07g")]
    [DisplayName("Retirement Age")]
    [IsoXmlTag("RtrmntAge")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? RetirementAge { get; init; }

    /// <summary>
    /// Indicates whether the pension benefits are shared.
    /// </summary>
    [IsoId("_jpNf0FKjEeiSDqv62fL07g")]
    [DisplayName("Sharing")]
    [IsoXmlTag("Shrg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? Sharing { get; init; }

    /// <summary>
    /// Type of lump sum paid to a member of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_xJuJULKcEeiXL6Ccd-oU8g")]
    [DisplayName("Lump Sum Type")]
    [IsoXmlTag("LumpSumTp")]
    public ValueList<LumpSumType1Choice_> LumpSumType { get; init; } = [];

    /// <summary>
    /// Order attached to the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_GV_SkLTpEeiENt6AoDfPXg")]
    [DisplayName("Pension Order")]
    [IsoXmlTag("PnsnOrdr")]
    public ValueList<PensionOrder1> PensionOrder { get; init; } = [];

    /// <summary>
    /// Indicates whether assets held within the pension are ring-fenced into specific tranches.
    /// </summary>
    [IsoId("_NHpqgFK7EeiSDqv62fL07g")]
    [DisplayName("Ring Fenced Drawdown Assets")]
    [IsoXmlTag("RingFncdDrwdwnAssts")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RingFencedDrawdownAssets { get; init; }

    /// <summary>
    /// Money Purchase Annual Allowance (MPAA) details.
    /// </summary>
    [IsoId("_XbTroFK7EeiSDqv62fL07g")]
    [DisplayName("Money Purchase Annual Allowance")]
    [IsoXmlTag("MnyPurchsAnlAllwnc")]
    public MoneyPurchaseAnnualAllowance1? MoneyPurchaseAnnualAllowance { get; init; }

    /// <summary>
    /// Indicates whether the pension policy, plan or scheme is covered by a safeguard benefit.
    /// </summary>
    [IsoId("_t0J88FK7EeiSDqv62fL07g")]
    [DisplayName("Safeguard Benefit")]
    [IsoXmlTag("SfgrdBnft")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SafeguardBenefit { get; init; }

    /// <summary>
    /// Indicates whether the pension policy, plan or scheme has lifetime allowance protection.
    /// </summary>
    [IsoId("_1spjMFK7EeiSDqv62fL07g")]
    [DisplayName("Lifetime Allowance Protection")]
    [IsoXmlTag("LftmAllwncPrtcn")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LifetimeAllowanceProtection { get; init; }

    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_4Nrw2VKgEeiOGaojF53zIw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
