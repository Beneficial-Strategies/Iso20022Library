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
[IsoId("b207a4a1-9b3d-4b69-a7eb-5cb6fafb08dd")]
[DisplayName("Drawdown04")]
public record Drawdown04
{
    /// <summary>
    /// Identification of the drawdown.
    /// </summary>
    [IsoId("3af9e103-86cd-489e-ba74-bb6dcd28812f")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax140Text? Identification { get; init; }

    /// <summary>
    /// Type of drawdown tranche.
    /// </summary>
    [IsoId("8f3046d4-16bf-4bf9-a186-6fcca0b86750")]
    [DisplayName("Tranche Type")]
    [IsoXmlTag("TrchTp")]
    public required DrawdownType2Choice_ TrancheType { get; init; }

    /// <summary>
    /// Specifies the rules that are applicable to the drawdown.
    /// </summary>
    [IsoId("4eb54b10-8e95-4903-9bfb-eb60b355dc3c")]
    [DisplayName("Applicable Rules")]
    [IsoXmlTag("AplblRules")]
    public ApplicableRules1Choice_? ApplicableRules { get; init; }

    /// <summary>
    /// Identification of the investor as assigned by a tax authority.
    /// </summary>
    [IsoId("535372bc-3eaf-49f7-b252-e7fe4f856da1")]
    [DisplayName("Investor Tax Reference")]
    [IsoXmlTag("InvstrTaxRef")]
    public TaxReference2? InvestorTaxReference { get; init; }

    /// <summary>
    /// Percentage of the total transfer value covered by the drawdown.
    /// </summary>
    [IsoId("d62cab76-aed5-48f7-a51f-7f52774226d2")]
    [DisplayName("Percentage Of Total Transfer Value")]
    [IsoXmlTag("PctgOfTtlTrfVal")]
    public IsoPercentageRate? PercentageOfTotalTransferValue { get; init; }

    /// <summary>
    /// Amount that was originally designated for drawdown.
    /// </summary>
    [IsoId("2efdf880-0790-4e17-aaaf-824821933c1f")]
    [DisplayName("Total Amount Net Drawdown")]
    [IsoXmlTag("TtlAmtNetDrwdwn")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountNetDrawdown { get; init; }

    /// <summary>
    /// Indicates whether any additional funds have been designated since the original arrangement.
    /// </summary>
    [IsoId("a7608977-5562-49b7-b2f5-4aeababa1ae4")]
    [DisplayName("Additional Funds Designated")]
    [IsoXmlTag("AddtlFndsDsgntd")]
    public IsoYesNoIndicator? AdditionalFundsDesignated { get; init; }

    /// <summary>
    /// Amount of the pension commencement lump sum (PCLS) remaining.
    /// </summary>
    [IsoId("7243d079-3566-43fa-8458-5640724c77d5")]
    [DisplayName("Pension Commencement Lump Sum Remaining")]
    [IsoXmlTag("PnsnCmcmntLumpSumRmng")]
    public ActiveCurrencyAnd13DecimalAmount? PensionCommencementLumpSumRemaining { get; init; }

    /// <summary>
    /// Date by which the pension commencement lump sum (PCLS) must be used.
    /// </summary>
    [IsoId("133a8671-5ecc-4c6d-abd9-6e14671b64ca")]
    [DisplayName("Pension Commencement Lump Sum Date")]
    [IsoXmlTag("PnsnCmcmntLumpSumDt")]
    public IsoISODate? PensionCommencementLumpSumDate { get; init; }

    /// <summary>
    /// Indicates there have been multiple pension commencement lump sum (PCLS) payments.
    /// </summary>
    [IsoId("c74a2ebd-0281-4201-9ff2-c80f6b9cbec9")]
    [DisplayName("Multiple Pension Commencement Lump Sums")]
    [IsoXmlTag("MltplPnsnCmcmntLumpSums")]
    public IsoYesNoIndicator? MultiplePensionCommencementLumpSums { get; init; }

    /// <summary>
    /// Percentage of the lifetime allowance (LTA) used.
    /// </summary>
    [IsoId("e46611e6-a36e-4682-b495-49dbd3f9e73f")]
    [DisplayName("Lifetime Allowance")]
    [IsoXmlTag("LftmAllwnc")]
    public IsoPercentageRate? LifetimeAllowance { get; init; }

    /// <summary>
    /// Indicates a person other than the original pension holder is the receiver of the drawdown payment.
    /// </summary>
    [IsoId("e68dac42-74c4-4ca8-b330-135362c35f66")]
    [DisplayName("Recipient Of Drawdown Indicator")]
    [IsoXmlTag("RcptOfDrwdwnInd")]
    public IsoYesNoIndicator? RecipientOfDrawdownIndicator { get; init; }

    /// <summary>
    /// Information about the recipient of the drawdown, when not the original pension holder.
    /// </summary>
    [IsoId("41c6d2c6-95e8-4fef-9bd4-d794e8a32a9a")]
    [DisplayName("Beneficiary Details")]
    [IsoXmlTag("BnfcryDtls")]
    public BeneficiaryDrawdown2? BeneficiaryDetails { get; init; }

    /// <summary>
    /// Limits of the capped drawdown.
    /// </summary>
    [IsoId("3dc96e58-d2e2-4dfc-9a1f-b8fa0cae77af")]
    [DisplayName("Capped Limits")]
    [IsoXmlTag("CapdLmts")]
    public Capped1? CappedLimits { get; init; }

    /// <summary>
    /// Date on which the drawdown was triggered when the drawdown type is flexible.
    /// </summary>
    [IsoId("429f5629-4e76-4f1d-95dc-63f198af35b3")]
    [DisplayName("Flexible Drawdown Triggered Date")]
    [IsoXmlTag("FlxblDrwdwnTrggrdDt")]
    public IsoISODate? FlexibleDrawdownTriggeredDate { get; init; }

    /// <summary>
    /// Date on which the tranche is actioned.
    /// </summary>
    [IsoId("667a3f91-caac-40e3-aea9-8d695610355e")]
    [DisplayName("Tranche Date")]
    [IsoXmlTag("TrchDt")]
    public IsoISODate? TrancheDate { get; init; }

    /// <summary>
    /// Additional information about the drawdown.
    /// </summary>
    [IsoId("13cd82ac-e442-4d9f-854e-6407bd93d5b9")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<AdditionalInformation15> AdditionalInformation { get; init; } = [];
}
