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
[IsoId("_9IEgwFNcEeijdq8ilaxyOA")]
[DisplayName("Drawdown")]
public record Drawdown1
{
    /// <summary>
    /// Type of drawdown tranche.
    /// </summary>
    [IsoId("_K5HOwFNdEeijdq8ilaxyOA")]
    [DisplayName("Tranche Type")]
    [IsoXmlTag("TrchTp")]
    public required DrawdownType1Choice_ TrancheType { get; init; }

    /// <summary>
    /// Specifies the rules that are applicable to the drawdown. For example, in the UK market, the pre-A-day rule that was introduced on 6 April 2006.)
    /// </summary>
    [IsoId("_YigxwVNfEeijdq8ilaxyOA")]
    [DisplayName("Applicable Rules")]
    [IsoXmlTag("AplblRules")]
    public ApplicableRules1Choice_? ApplicableRules { get; init; }

    /// <summary>
    /// Percentage of the total transfer value covered by the drawdown.
    /// </summary>
    [IsoId("_mtcmcFNfEeijdq8ilaxyOA")]
    [DisplayName("Percentage Of Total Transfer Value")]
    [IsoXmlTag("PctgOfTtlTrfVal")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? PercentageOfTotalTransferValue { get; init; }

    /// <summary>
    /// Amount that was originally designated for drawdown.
    /// </summary>
    [IsoId("_uPeNcFNfEeijdq8ilaxyOA")]
    [DisplayName("Total Amount Net Drawdown")]
    [IsoXmlTag("TtlAmtNetDrwdwn")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountNetDrawdown { get; init; }

    /// <summary>
    /// Indicates whether any additional funds have been designated since the original arrangement.
    /// </summary>
    [IsoId("_ClsfsFNgEeijdq8ilaxyOA")]
    [DisplayName("Additional Funds Designated")]
    [IsoXmlTag("AddtlFndsDsgntd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AdditionalFundsDesignated { get; init; }

    /// <summary>
    /// Drawdown allowance check. For pensions that have a lifetime allowance, a check is made of the maximum value of benefits that may be taken from the pension without incurring a special tax. (This check or &apos;event&apos; is known as the benefit crystallisation event in the UK market.)
    /// </summary>
    [IsoId("_hNJmoFNfEeijdq8ilaxyOA")]
    [DisplayName("Drawdown Allowance Check")]
    [IsoXmlTag("DrwdwnAllwncChck")]
    public DrawdownAllowanceCheck1? DrawdownAllowanceCheck { get; init; }

    /// <summary>
    /// Amount of the pension commencement lump sum (PCLS) remaining.
    /// </summary>
    [IsoId("_hCjj8LpcEeij7vHPZxBWhA")]
    [DisplayName("Pension Commencement Lump Sum Remaining")]
    [IsoXmlTag("PnsnCmcmntLumpSumRmng")]
    public ActiveCurrencyAnd13DecimalAmount? PensionCommencementLumpSumRemaining { get; init; }

    /// <summary>
    /// Date by which the pension commencement lump sum (PCLS) must be used.
    /// </summary>
    [IsoId("_jYEp0LpcEeij7vHPZxBWhA")]
    [DisplayName("Pension Commencement Lump Sum Date")]
    [IsoXmlTag("PnsnCmcmntLumpSumDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PensionCommencementLumpSumDate { get; init; }

    /// <summary>
    /// Indicates there have been multiple pension commencement lump sum (PCLS) payments.
    /// </summary>
    [IsoId("_tSJtULpcEeij7vHPZxBWhA")]
    [DisplayName("Multiple Pension Commencement Lump Sums")]
    [IsoXmlTag("MltplPnsnCmcmntLumpSums")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MultiplePensionCommencementLumpSums { get; init; }

    /// <summary>
    /// Percentage of the lifetime allowance (LTA) used.
    /// </summary>
    [IsoId("_2dgpobpcEeij7vHPZxBWhA")]
    [DisplayName("Lifetime Allowance")]
    [IsoXmlTag("LftmAllwnc")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? LifetimeAllowance { get; init; }

    /// <summary>
    /// Indicates a person other than the original pension holder is the receiver of the drawdown payment.
    /// </summary>
    [IsoId("_8_IcgLGpEeirN-C08vro8Q")]
    [DisplayName("Recipient Of Drawdown Indicator")]
    [IsoXmlTag("RcptOfDrwdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RecipientOfDrawdownIndicator { get; init; }

    /// <summary>
    /// Information about the recipient of the drawdown, when not the original pension holder.
    /// </summary>
    [IsoId("_h9sdUFNgEeijdq8ilaxyOA")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public BeneficiaryDrawdown1? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Limits of the capped drawdown.
    /// </summary>
    [IsoId("_1dK1IFNdEeijdq8ilaxyOA")]
    [DisplayName("Capped Limits")]
    [IsoXmlTag("CapdLmts")]
    public Capped1? CappedLimits { get; init; }

    /// <summary>
    /// Date on which the drawdown was triggered when the drawdown type is flexible.
    /// </summary>
    [IsoId("_HEE24FNdEeijdq8ilaxyOA")]
    [DisplayName("Flexible Drawdown Triggered Date")]
    [IsoXmlTag("FlxblDrwdwnTrggrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? FlexibleDrawdownTriggeredDate { get; init; }

    /// <summary>
    /// Additional information about the drawdown.
    /// </summary>
    [IsoId("_1Q6vkFNiEeijdq8ilaxyOA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
