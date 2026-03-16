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
[IsoId("_i8aGITkoEeqKvZI4inWIVg")]
[DisplayName("Corporate Action")]
public record CorporateAction56
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_jRiBkzkoEeqKvZI4inWIVg")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate61? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [IsoId("_jRiBmzkoEeqKvZI4inWIVg")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod14? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [IsoId("_jRiBozkoEeqKvZI4inWIVg")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate91? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [IsoId("_jRiBqzkoEeqKvZI4inWIVg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice57? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_jRiBszkoEeqKvZI4inWIVg")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity7? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_jRiBuzkoEeqKvZI4inWIVg")]
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_jRiBwzkoEeqKvZI4inWIVg")]
    [DisplayName("Coupon Number")]
    [IsoXmlTag("CpnNb")]
    public ValueList<IdentificationFormat3Choice_> CouponNumber { get; init; } = [];

    /// <summary>
    /// Indicates whether certification/breakdown is required.
    /// Yes = certification required.
    /// No = no certification required.
    /// </summary>
    [IsoId("_jRiByzkoEeqKvZI4inWIVg")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_jRiB0zkoEeqKvZI4inWIVg")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether restrictions apply to the corporate action event or not.
    /// </summary>
    [IsoId("_jRiB2zkoEeqKvZI4inWIVg")]
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [IsoId("_jRiB4zkoEeqKvZI4inWIVg")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Indicates whether a letter of guaranteed delivery can be submitted in order to participate in the offer on full eligible position. It is not intended for use in situations arising from failed or late trades.
    /// </summary>
    [IsoId("_jRiB6zkoEeqKvZI4inWIVg")]
    [DisplayName("Letter Of Guaranteed Delivery Indicator")]
    [IsoXmlTag("LttrOfGrntedDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; }

    /// <summary>
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_mqJjMTkoEeqKvZI4inWIVg")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }

    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_jRiB7TkoEeqKvZI4inWIVg")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat9Choice_? DividendType { get; init; }

    /// <summary>
    /// Specifies whether the event is an interim or a final event in a series of predefined or planned events of the same type and for the same underlying instrument.
    /// </summary>
    [IsoId("_jRiB9TkoEeqKvZI4inWIVg")]
    [DisplayName("Event Sequence Type")]
    [IsoXmlTag("EvtSeqTp")]
    public EventSequenceTypeFormat1Choice_? EventSequenceType { get; init; }

    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    [IsoId("_jRiB9zkoEeqKvZI4inWIVg")]
    [DisplayName("Occurrence Type")]
    [IsoXmlTag("OcrncTp")]
    public DistributionTypeFormat7Choice_? OccurrenceType { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_jRiB_zkoEeqKvZI4inWIVg")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat10Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_jRiCBzkoEeqKvZI4inWIVg")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat3Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_jRiCDzkoEeqKvZI4inWIVg")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStageFormat13Choice_> EventStage { get; init; } = [];

    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    [IsoId("_jRiCFzkoEeqKvZI4inWIVg")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat9Choice_> AdditionalBusinessProcessIndicator { get; init; } =
        [];

    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_jRiCHzkoEeqKvZI4inWIVg")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat5Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_jRiCJzkoEeqKvZI4inWIVg")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [IsoId("_jRiCLzkoEeqKvZI4inWIVg")]
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat3Choice_? CapitalGainInOutIndicator { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_jRiCNzkoEeqKvZI4inWIVg")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat3Choice_? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_jRiCPzkoEeqKvZI4inWIVg")]
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public ElectionTypeFormat3Choice_? ElectionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_jRiCRzkoEeqKvZI4inWIVg")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat4Choice_? LotteryType { get; init; }

    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    [IsoId("_jRiCTzkoEeqKvZI4inWIVg")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat3Choice_? CertificationType { get; init; }

    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    [IsoId("_jRiCVzkoEeqKvZI4inWIVg")]
    [DisplayName("Consent Type")]
    [IsoXmlTag("CnsntTp")]
    public ConsentTypeFormat4Choice_? ConsentType { get; init; }

    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    [IsoId("_jRiCWTkoEeqKvZI4inWIVg")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public InformationTypeFormat4Choice_? InformationType { get; init; }

    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event.
    /// </summary>
    [IsoId("_jRiCWzkoEeqKvZI4inWIVg")]
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    public GenericIdentification30? TaxOnNonDistributedProceedsIndicator { get; init; }

    /// <summary>
    /// New company&apos;s place of incorporation.
    /// </summary>
    [IsoId("_jRiCXTkoEeqKvZI4inWIVg")]
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_jRiCZTkoEeqKvZI4inWIVg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative26? AdditionalInformation { get; init; }
}
