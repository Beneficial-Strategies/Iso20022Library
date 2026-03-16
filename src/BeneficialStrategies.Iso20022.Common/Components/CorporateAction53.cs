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
[IsoId("_o-RAiPfUEeiNZp_PtLohLw")]
[DisplayName("Corporate Action")]
public record CorporateAction53
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_o-RAjPfUEeiNZp_PtLohLw")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate74? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [IsoId("_o-RAlPfUEeiNZp_PtLohLw")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod14? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [IsoId("_o-RAnPfUEeiNZp_PtLohLw")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate96? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [IsoId("_o-RApPfUEeiNZp_PtLohLw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice67? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_o-RArPfUEeiNZp_PtLohLw")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity8? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_o-RAtPfUEeiNZp_PtLohLw")]
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max3Number)]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_o-RAvPfUEeiNZp_PtLohLw")]
    [DisplayName("Coupon Number")]
    [IsoXmlTag("CpnNb")]
    public IdentificationFormat4Choice_? CouponNumber { get; init; }

    /// <summary>
    /// Indicates whether certification/breakdown is required.
    /// Yes = certification required.
    /// No = no certification required.
    /// </summary>
    [IsoId("_o-RAxPfUEeiNZp_PtLohLw")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_o-RAzPfUEeiNZp_PtLohLw")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether restrictions apply to the corporate action event or not.
    /// </summary>
    [IsoId("_o-RA1PfUEeiNZp_PtLohLw")]
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [IsoId("_o-RA3PfUEeiNZp_PtLohLw")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Indicates whether a letter of guaranteed delivery can be submitted in order to participate in the offer on full eligible position. It is not intended for use in situations arising from failed or late trades.
    /// </summary>
    [IsoId("_o-RA5PfUEeiNZp_PtLohLw")]
    [DisplayName("Letter Of Guaranteed Delivery Indicator")]
    [IsoXmlTag("LttrOfGrntedDlvryInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; }

    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_o-RA5vfUEeiNZp_PtLohLw")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat10Choice_? DividendType { get; init; }

    /// <summary>
    /// Specifies whether the event is an interim or a final event in a series of predefined or planned events of the same type and for the same underlying instrument.
    /// </summary>
    [IsoId("_o-RA7vfUEeiNZp_PtLohLw")]
    [DisplayName("Event Sequence Type")]
    [IsoXmlTag("EvtSeqTp")]
    public EventSequenceTypeFormat2Choice_? EventSequenceType { get; init; }

    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    [IsoId("_o-RA8PfUEeiNZp_PtLohLw")]
    [DisplayName("Occurrence Type")]
    [IsoXmlTag("OcrncTp")]
    public DistributionTypeFormat8Choice_? OccurrenceType { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_o-RA-PfUEeiNZp_PtLohLw")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public OfferTypeFormat11Choice_? OfferType { get; init; }

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_o-RBAPfUEeiNZp_PtLohLw")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat4Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_o-RBCPfUEeiNZp_PtLohLw")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public CorporateActionEventStageFormat20Choice_? EventStage { get; init; }

    /// <summary>
    /// Specifies the type of the additional business process linked to a corporate action event such as a claim compensation or tax refund.
    /// </summary>
    [IsoId("_o-RBEPfUEeiNZp_PtLohLw")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public AdditionalBusinessProcessFormat12Choice_? AdditionalBusinessProcessIndicator { get; init; }

    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_o-RBGPfUEeiNZp_PtLohLw")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public CorporateActionChangeTypeFormat8Choice_? ChangeType { get; init; }

    /// <summary>
    /// Type of intermediates securities distribution.
    /// </summary>
    [IsoId("_o-RBIPfUEeiNZp_PtLohLw")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [IsoId("_o-RBKPfUEeiNZp_PtLohLw")]
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat4Choice_? CapitalGainInOutIndicator { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_o-RBMPfUEeiNZp_PtLohLw")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat4Choice_? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_o-RBOPfUEeiNZp_PtLohLw")]
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public ElectionTypeFormat4Choice_? ElectionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_o-RBQPfUEeiNZp_PtLohLw")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat5Choice_? LotteryType { get; init; }

    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    [IsoId("_o-RBSPfUEeiNZp_PtLohLw")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat4Choice_? CertificationType { get; init; }

    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    [IsoId("_o-RBUPfUEeiNZp_PtLohLw")]
    [DisplayName("Consent Type")]
    [IsoXmlTag("CnsntTp")]
    public ConsentTypeFormat5Choice_? ConsentType { get; init; }

    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    [IsoId("_o-RBUvfUEeiNZp_PtLohLw")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public InformationTypeFormat5Choice_? InformationType { get; init; }

    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event.
    /// </summary>
    [IsoId("_o-RBVPfUEeiNZp_PtLohLw")]
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    public GenericIdentification47? TaxOnNonDistributedProceedsIndicator { get; init; }

    /// <summary>
    /// New company&apos;s place of incorporation.
    /// </summary>
    [IsoId("_o-RBVvfUEeiNZp_PtLohLw")]
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoRestrictedFINXMax350Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted, cannot be coded.
    /// </summary>
    [IsoId("_o-RBXvfUEeiNZp_PtLohLw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative39? AdditionalInformation { get; init; }
}
