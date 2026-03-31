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
[IsoId("_YXWff199Ee262vCSVgjImg")]
[DisplayName("Corporate Action")]
public record CorporateAction79
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_YXWfi199Ee262vCSVgjImg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate96? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [IsoId("_YXWfk199Ee262vCSVgjImg")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod15? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [IsoId("_YXWfm199Ee262vCSVgjImg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate110? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [IsoId("_YXWfo199Ee262vCSVgjImg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice80? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_YXWfq199Ee262vCSVgjImg")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity14? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_YXWfs199Ee262vCSVgjImg")]
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_YXWfu199Ee262vCSVgjImg")]
    [DisplayName("Coupon Number")]
    [IsoXmlTag("CpnNb")]
    public ValueList<IdentificationFormat4Choice_> CouponNumber { get; init; } = [];

    /// <summary>
    /// Indicates whether certification/breakdown is required.
    /// Yes = certification required.
    /// No = no certification required.
    /// </summary>
    [IsoId("_YXWfw199Ee262vCSVgjImg")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_YXWfy199Ee262vCSVgjImg")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether restrictions apply to the corporate action event or not.
    /// </summary>
    [IsoId("_YXWf0199Ee262vCSVgjImg")]
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [IsoId("_YXWf2199Ee262vCSVgjImg")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Indicates whether a letter of guaranteed delivery can be submitted in order to participate in the offer on full eligible position. It is not intended for use in situations arising from failed or late trades.
    /// </summary>
    [IsoId("_YXWf4199Ee262vCSVgjImg")]
    [DisplayName("Letter Of Guaranteed Delivery Indicator")]
    [IsoXmlTag("LttrOfGrntedDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; }

    /// <summary>
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_YXWf5V99Ee262vCSVgjImg")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }

    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_YXWf5199Ee262vCSVgjImg")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat10Choice_? DividendType { get; init; }

    /// <summary>
    /// Specifies whether the event is an interim or a final event in a series of predefined or planned events of the same type and for the same underlying instrument.
    /// </summary>
    [IsoId("_YXWf7199Ee262vCSVgjImg")]
    [DisplayName("Event Sequence Type")]
    [IsoXmlTag("EvtSeqTp")]
    public EventSequenceTypeFormat2Choice_? EventSequenceType { get; init; }

    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    [IsoId("_YXWf8V99Ee262vCSVgjImg")]
    [DisplayName("Occurrence Type")]
    [IsoXmlTag("OcrncTp")]
    public DistributionTypeFormat8Choice_? OccurrenceType { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_YXWf-V99Ee262vCSVgjImg")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat13Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_YXWgAV99Ee262vCSVgjImg")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat4Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_YXWgCV99Ee262vCSVgjImg")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStageFormat20Choice_> EventStage { get; init; } = [];

    /// <summary>
    /// Specifies the type of the additional business process linked to the corporate action event such as a claim compensation or tax refund.
    /// </summary>
    [IsoId("_YXWgEV99Ee262vCSVgjImg")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat22Choice_> AdditionalBusinessProcessIndicator { get; init; } =
        [];

    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_YXWgGV99Ee262vCSVgjImg")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat8Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_YXWgIV99Ee262vCSVgjImg")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [IsoId("_YXWgKV99Ee262vCSVgjImg")]
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat4Choice_? CapitalGainInOutIndicator { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_YXWgMV99Ee262vCSVgjImg")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat4Choice_? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_YXWgOV99Ee262vCSVgjImg")]
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public ElectionTypeFormat4Choice_? ElectionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_YXWgQV99Ee262vCSVgjImg")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat5Choice_? LotteryType { get; init; }

    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    [IsoId("_YXWgSV99Ee262vCSVgjImg")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat4Choice_? CertificationType { get; init; }

    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    [IsoId("_YXWgUV99Ee262vCSVgjImg")]
    [DisplayName("Consent Type")]
    [IsoXmlTag("CnsntTp")]
    public ConsentTypeFormat5Choice_? ConsentType { get; init; }

    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    [IsoId("_YXWgU199Ee262vCSVgjImg")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public InformationTypeFormat5Choice_? InformationType { get; init; }

    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event or to any other event.
    /// </summary>
    [IsoId("_YXWgVV99Ee262vCSVgjImg")]
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    public ValueList<GenericIdentification47> TaxOnNonDistributedProceedsIndicator { get; init; } =
        [];

    /// <summary>
    /// New company&apos;s place of incorporation.
    /// </summary>
    [IsoId("_YXWgV199Ee262vCSVgjImg")]
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_YXWgX199Ee262vCSVgjImg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative54? AdditionalInformation { get; init; }
}
