// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the corporate action event.
/// </summary>
[IsoId("_TaVW6dp-Ed-ak6NoX_4Aeg_-812699506")]
[DisplayName("Corporate Action")]
public record CorporateAction3
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_TaVW6tp-Ed-ak6NoX_4Aeg_-811777517")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate1? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [IsoId("_TafH4Np-Ed-ak6NoX_4Aeg_-812697566")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod3? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [IsoId("_TafH4dp-Ed-ak6NoX_4Aeg_-812697626")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate3? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [IsoId("_TafH4tp-Ed-ak6NoX_4Aeg_-812697873")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice3? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_TafH49p-Ed-ak6NoX_4Aeg_2024507232")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity1? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_TafH5Np-Ed-ak6NoX_4Aeg_-812699085")]
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_TafH5dp-Ed-ak6NoX_4Aeg_-812698870")]
    [DisplayName("Coupon Number")]
    [IsoXmlTag("CpnNb")]
    public ValueList<IdentificationFormat1Choice_> CouponNumber { get; init; } = [];

    /// <summary>
    /// Indicates whether certification is required from the account owner. |Yes = certification required.|No = no certification required.
    /// </summary>
    [IsoId("_TafH5tp-Ed-ak6NoX_4Aeg_-812698853")]
    [DisplayName("Certification Required Indicator")]
    [IsoXmlTag("CertfctnReqrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationRequiredIndicator { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_TafH59p-Ed-ak6NoX_4Aeg_-812698576")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether there is restrictions apply to the corporate action event or not.|Yes = There is restrictions.|No = There is no restrictions.
    /// </summary>
    [IsoId("_TafH6Np-Ed-ak6NoX_4Aeg_-812698558")]
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [IsoId("_TafH6dp-Ed-ak6NoX_4Aeg_1538920349")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_Tao44Np-Ed-ak6NoX_4Aeg_-812698523")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat1Choice_? DividendType { get; init; }

    /// <summary>
    /// Specifies the conversion type of an instrument.
    /// </summary>
    [IsoId("_Tao44dp-Ed-ak6NoX_4Aeg_-812698138")]
    [DisplayName("Conversion Type")]
    [IsoXmlTag("ConvsTp")]
    public ConversionTypeFormat1Choice_? ConversionType { get; init; }

    /// <summary>
    /// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
    /// </summary>
    [IsoId("_Tao44tp-Ed-ak6NoX_4Aeg_-812698498")]
    [DisplayName("Distribution Type")]
    [IsoXmlTag("DstrbtnTp")]
    public DistributionTypeFormat1Choice_? DistributionType { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_Tao449p-Ed-ak6NoX_4Aeg_-812698481")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat1Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_Tao45Np-Ed-ak6NoX_4Aeg_-812698120")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat1Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_Tao45dp-Ed-ak6NoX_4Aeg_-812698060")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStageFormat1Choice_> EventStage { get; init; } = [];

    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    [IsoId("_Tao45tp-Ed-ak6NoX_4Aeg_-930957469")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat1Choice_> AdditionalBusinessProcessIndicator { get; init; } =
        [];

    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_Tao459p-Ed-ak6NoX_4Aeg_-812698463")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat1Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_Tao46Np-Ed-ak6NoX_4Aeg_-812698438")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat1Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [IsoId("_Tao46dp-Ed-ak6NoX_4Aeg_-812698095")]
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat1Choice_? CapitalGainInOutIndicator { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_TayC0Np-Ed-ak6NoX_4Aeg_-812697983")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat1Choice_? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_TayC0dp-Ed-ak6NoX_4Aeg_-812698421")]
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public ElectionTypeFormat1Choice_? ElectionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_TayC0tp-Ed-ak6NoX_4Aeg_-683874074")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat1Choice_? LotteryType { get; init; }

    /// <summary>
    /// Specifies the certification format required, ie, physical or electronic format.
    /// </summary>
    [IsoId("_TayC09p-Ed-ak6NoX_4Aeg_-812698000")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat1Choice_? CertificationType { get; init; }

    /// <summary>
    /// New company&apos;s place of incorporation.
    /// </summary>
    [IsoId("_TayC1Np-Ed-ak6NoX_4Aeg_-812698035")]
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_TayC1dp-Ed-ak6NoX_4Aeg_-812697531")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative3? AdditionalInformation { get; init; }
}
