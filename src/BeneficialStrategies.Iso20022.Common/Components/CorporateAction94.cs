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
[IsoId("_Hzc_ofIIEfCS-OXqezZQmw")]
[DisplayName("Corporate Action94")]
public record CorporateAction94
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("_H7370_IIEfCS-OXqezZQmw")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate83? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [IsoId("_H7372_IIEfCS-OXqezZQmw")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod17? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [IsoId("_H7374_IIEfCS-OXqezZQmw")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate122? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [IsoId("_H7376_IIEfCS-OXqezZQmw")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice85? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("_H7378_IIEfCS-OXqezZQmw")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity15? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_H737-_IIEfCS-OXqezZQmw")]
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_H738A_IIEfCS-OXqezZQmw")]
    [DisplayName("Coupon Number")]
    [IsoXmlTag("CpnNb")]
    public ValueList<IdentificationFormat3Choice> CouponNumber { get; init; } = [];

    /// <summary>
    /// Level of priority of the given offer which will be accepted by the issuer/agent within the tiered structure of the event.
    /// </summary>
    [IsoId("_H738C_IIEfCS-OXqezZQmw")]
    [DisplayName("Acceptance Priority Level")]
    [IsoXmlTag("AccptncPrtyLvl")]
    public IsoExact3UpperCaseAlphaNumericText? AcceptancePriorityLevel { get; init; }

    /// <summary>
    /// Indicates whether certification/breakdown is required.
    /// </summary>
    [IsoId("_H738DfIIEfCS-OXqezZQmw")]
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("_H738FfIIEfCS-OXqezZQmw")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether restrictions apply to the corporate action event or not.
    /// </summary>
    [IsoId("_H738HfIIEfCS-OXqezZQmw")]
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [IsoId("_H738JfIIEfCS-OXqezZQmw")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Indicates that bondholders who convert between record date and payable date will forfeit their interest.
    /// </summary>
    [IsoId("_H738LfIIEfCS-OXqezZQmw")]
    [DisplayName("Forfeiture Of Interest Indicator")]
    [IsoXmlTag("FrftrOfIntrstInd")]
    public IsoYesNoIndicator? ForfeitureOfInterestIndicator { get; init; }

    /// <summary>
    /// Indicates whether a letter of guaranteed delivery can be submitted in order to participate in the offer on full eligible position.
    /// </summary>
    [IsoId("_H738L_IIEfCS-OXqezZQmw")]
    [DisplayName("Letter Of Guaranteed Delivery Indicator")]
    [IsoXmlTag("LttrOfGrntedDlvryInd")]
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; }

    /// <summary>
    /// Indicates whether the announcement was initiated by the first intermediary in the custody chain in accordance with SRD II.
    /// </summary>
    [IsoId("_H738MfIIEfCS-OXqezZQmw")]
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }

    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_H738M_IIEfCS-OXqezZQmw")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat9Choice? DividendType { get; init; }

    /// <summary>
    /// Specifies whether the event is an interim or a final event in a series of predefined or planned events.
    /// </summary>
    [IsoId("_H738O_IIEfCS-OXqezZQmw")]
    [DisplayName("Event Sequence Type")]
    [IsoXmlTag("EvtSeqTp")]
    public EventSequenceTypeFormat1Choice? EventSequenceType { get; init; }

    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    [IsoId("_H738PfIIEfCS-OXqezZQmw")]
    [DisplayName("Occurrence Type")]
    [IsoXmlTag("OcrncTp")]
    public DistributionTypeFormat7Choice? OccurrenceType { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_H738RfIIEfCS-OXqezZQmw")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat18Choice> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_H738TfIIEfCS-OXqezZQmw")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat3Choice? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_H738VfIIEfCS-OXqezZQmw")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStageFormat13Choice> EventStage { get; init; } = [];

    /// <summary>
    /// Specifies the type of the additional business process linked to the corporate action event.
    /// </summary>
    [IsoId("_H738XfIIEfCS-OXqezZQmw")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat17Choice> AdditionalBusinessProcessIndicator { get; init; } = [];

    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_H738ZfIIEfCS-OXqezZQmw")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat5Choice> ChangeType { get; init; } = [];

    /// <summary>
    /// Specifies the event type of the following event.
    /// </summary>
    [IsoId("_H738bfIIEfCS-OXqezZQmw")]
    [DisplayName("Following Event Type Indicator")]
    [IsoXmlTag("FllwngEvtTpInd")]
    public IntermediateSecuritiesDistributionTypeFormat19Choice? FollowingEventTypeIndicator { get; init; }

    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive.
    /// </summary>
    [IsoId("_H74i4fIIEfCS-OXqezZQmw")]
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat3Choice? CapitalGainInOutIndicator { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_H74i6fIIEfCS-OXqezZQmw")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat3Choice? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Specifies the effect on the holdings of electing a corporate action option.
    /// </summary>
    [IsoId("_H74i8fIIEfCS-OXqezZQmw")]
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public ElectionTypeFormat3Choice? ElectionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_H74i-fIIEfCS-OXqezZQmw")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat4Choice? LotteryType { get; init; }

    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    [IsoId("_H74jAfIIEfCS-OXqezZQmw")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat3Choice? CertificationType { get; init; }

    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    [IsoId("_H74jCfIIEfCS-OXqezZQmw")]
    [DisplayName("Consent Type")]
    [IsoXmlTag("CnsntTp")]
    public ConsentTypeFormat4Choice? ConsentType { get; init; }

    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    [IsoId("_H74jC_IIEfCS-OXqezZQmw")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public InformationTypeFormat4Choice? InformationType { get; init; }

    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event or to any other event.
    /// </summary>
    [IsoId("_H74jDfIIEfCS-OXqezZQmw")]
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    public ValueList<GenericIdentification30> TaxOnNonDistributedProceedsIndicator { get; init; } = [];

    /// <summary>
    /// Specifies whether a Dutch auction is modified or unmodified.
    /// </summary>
    [IsoId("_H74jD_IIEfCS-OXqezZQmw")]
    [DisplayName("Dutch Auction Type")]
    [IsoXmlTag("DtchAuctnTp")]
    public DutchAuctionTypeFormat1Choice? DutchAuctionType { get; init; }

    /// <summary>
    /// Indicates that the Dutch Auction event is a Reverse Dutch Auction.
    /// </summary>
    [IsoId("_H74jEfIIEfCS-OXqezZQmw")]
    [DisplayName("Reverse Dutch Auction Indicator")]
    [IsoXmlTag("RvsDtchAuctnInd")]
    public IsoYesNoIndicator? ReverseDutchAuctionIndicator { get; init; }

    /// <summary>
    /// New company's place of incorporation.
    /// </summary>
    [IsoId("_H74jE_IIEfCS-OXqezZQmw")]
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    public IsoMax350Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted cannot be coded.
    /// </summary>
    [IsoId("_H74jG_IIEfCS-OXqezZQmw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative58? AdditionalInformation { get; init; }
}
