// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a drawdown tranche.
/// </summary>
[IsoId("_Zv-yMZN5EembCsVG-3f_AA")]
[DisplayName("Drawdown")]
public record Drawdown2
{
    /// <summary>
    /// Identification of the drawdown.
    /// </summary>
    [IsoId("_ufZVUDOPEeqjy7_SkdcoGg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? Identification { get; init; }

    /// <summary>
    /// Type of drawdown tranche.
    /// </summary>
    [IsoId("_aFHUspN5EembCsVG-3f_AA")]
    [DisplayName("Tranche Type")]
    [IsoXmlTag("TrchTp")]
    public required DrawdownType2Choice_ TrancheType { get; init; }

    /// <summary>
    /// Specifies the rules that are applicable to the drawdown. For example, in the UK market, the pre-A-day rule that was introduced on 6 April 2006.)
    /// </summary>
    [IsoId("_aFHUtJN5EembCsVG-3f_AA")]
    [DisplayName("Applicable Rules")]
    [IsoXmlTag("AplblRules")]
    public ApplicableRules1Choice_? ApplicableRules { get; init; }

    /// <summary>
    /// Identification of the investor as assigned by a tax authority.
    /// </summary>
    [IsoId("_hqaSIJN5EembCsVG-3f_AA")]
    [DisplayName("Investor Tax Reference")]
    [IsoXmlTag("InvstrTaxRef")]
    public TaxReference2? InvestorTaxReference { get; init; }

    /// <summary>
    /// Percentage of the total transfer value covered by the drawdown.
    /// </summary>
    [IsoId("_aFHUtpN5EembCsVG-3f_AA")]
    [DisplayName("Percentage Of Total Transfer Value")]
    [IsoXmlTag("PctgOfTtlTrfVal")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfTotalTransferValue { get; init; }

    /// <summary>
    /// Amount that was originally designated for drawdown.
    /// </summary>
    [IsoId("_aFHUuJN5EembCsVG-3f_AA")]
    [DisplayName("Total Amount Net Drawdown")]
    [IsoXmlTag("TtlAmtNetDrwdwn")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountNetDrawdown { get; init; }

    /// <summary>
    /// Indicates whether any additional funds have been designated since the original arrangement.
    /// </summary>
    [IsoId("_aFHUupN5EembCsVG-3f_AA")]
    [DisplayName("Additional Funds Designated")]
    [IsoXmlTag("AddtlFndsDsgntd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AdditionalFundsDesignated { get; init; }

    /// <summary>
    /// Amount of the pension commencement lump sum (PCLS) remaining.
    /// </summary>
    [IsoId("_aFHUvpN5EembCsVG-3f_AA")]
    [DisplayName("Pension Commencement Lump Sum Remaining")]
    [IsoXmlTag("PnsnCmcmntLumpSumRmng")]
    public ActiveCurrencyAnd13DecimalAmount? PensionCommencementLumpSumRemaining { get; init; }

    /// <summary>
    /// Date by which the pension commencement lump sum (PCLS) must be used.
    /// </summary>
    [IsoId("_aFHUwJN5EembCsVG-3f_AA")]
    [DisplayName("Pension Commencement Lump Sum Date")]
    [IsoXmlTag("PnsnCmcmntLumpSumDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PensionCommencementLumpSumDate { get; init; }

    /// <summary>
    /// Indicates there have been multiple pension commencement lump sum (PCLS) payments.
    /// </summary>
    [IsoId("_aFHUwpN5EembCsVG-3f_AA")]
    [DisplayName("Multiple Pension Commencement Lump Sums")]
    [IsoXmlTag("MltplPnsnCmcmntLumpSums")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MultiplePensionCommencementLumpSums { get; init; }

    /// <summary>
    /// Percentage of the lifetime allowance (LTA) used.
    /// </summary>
    [IsoId("_aFHUxJN5EembCsVG-3f_AA")]
    [DisplayName("Lifetime Allowance")]
    [IsoXmlTag("LftmAllwnc")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LifetimeAllowance { get; init; }

    /// <summary>
    /// Indicates a person other than the original pension holder is the receiver of the drawdown payment.
    /// </summary>
    [IsoId("_aFHUxpN5EembCsVG-3f_AA")]
    [DisplayName("Recipient Of Drawdown Indicator")]
    [IsoXmlTag("RcptOfDrwdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RecipientOfDrawdownIndicator { get; init; }

    /// <summary>
    /// Information about the recipient of the drawdown, when not the original pension holder.
    /// </summary>
    [IsoId("_aFHUyJN5EembCsVG-3f_AA")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public BeneficiaryDrawdown1? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Limits of the capped drawdown.
    /// </summary>
    [IsoId("_aFHUypN5EembCsVG-3f_AA")]
    [DisplayName("Capped Limits")]
    [IsoXmlTag("CapdLmts")]
    public Capped1? CappedLimits { get; init; }

    /// <summary>
    /// Date on which the drawdown was triggered when the drawdown type is flexible.
    /// </summary>
    [IsoId("_aFHUzJN5EembCsVG-3f_AA")]
    [DisplayName("Flexible Drawdown Triggered Date")]
    [IsoXmlTag("FlxblDrwdwnTrggrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FlexibleDrawdownTriggeredDate { get; init; }

    /// <summary>
    /// Additional information about the drawdown.
    /// </summary>
    [IsoId("_aFHUzpN5EembCsVG-3f_AA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
