// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action87.
/// </summary>
[IsoId("_nLeBUZt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action87")]
public record CorporateAction87
{
    /// <summary>
    /// Acceptance Priority Level.
    /// </summary>
    [DisplayName("Acceptance Priority Level")]
    [IsoXmlTag("AccptncPrtyLvl")]
    public IsoExact3UpperCaseAlphaNumericText? AcceptancePriorityLevel { get; init; }

    /// <summary>
    /// Accrued Interest Indicator.
    /// </summary>
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Additional Business Process Indicator.
    /// </summary>
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat22Choice_> AdditionalBusinessProcessIndicator { get; init; } =
        [];

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative63? AdditionalInformation { get; init; }

    /// <summary>
    /// Capital Gain In Out Indicator.
    /// </summary>
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat4Choice_? CapitalGainInOutIndicator { get; init; }

    /// <summary>
    /// Certification Breakdown Indicator.
    /// </summary>
    [DisplayName("Certification Breakdown Indicator")]
    [IsoXmlTag("CertfctnBrkdwnInd")]
    public IsoYesNoIndicator? CertificationBreakdownIndicator { get; init; }

    /// <summary>
    /// Certification Type.
    /// </summary>
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat4Choice_? CertificationType { get; init; }

    /// <summary>
    /// Change Type.
    /// </summary>
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat8Choice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Charges Applied Indicator.
    /// </summary>
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Consent Type.
    /// </summary>
    [DisplayName("Consent Type")]
    [IsoXmlTag("CnsntTp")]
    public ConsentTypeFormat5Choice_? ConsentType { get; init; }

    /// <summary>
    /// Coupon Number.
    /// </summary>
    [DisplayName("Coupon Number")]
    [IsoXmlTag("CpnNb")]
    public ValueList<IdentificationFormat4Choice_> CouponNumber { get; init; } = [];

    /// <summary>
    /// Date Details.
    /// </summary>
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate96? DateDetails { get; init; }

    /// <summary>
    /// Dividend Type.
    /// </summary>
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat10Choice_? DividendType { get; init; }

    /// <summary>
    /// Dutch Auction Type.
    /// </summary>
    [DisplayName("Dutch Auction Type")]
    [IsoXmlTag("DtchAuctnTp")]
    public DutchAuctionTypeFormat2Choice_? DutchAuctionType { get; init; }

    /// <summary>
    /// Election Type.
    /// </summary>
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public ElectionTypeFormat4Choice_? ElectionType { get; init; }

    /// <summary>
    /// Event Sequence Type.
    /// </summary>
    [DisplayName("Event Sequence Type")]
    [IsoXmlTag("EvtSeqTp")]
    public EventSequenceTypeFormat2Choice_? EventSequenceType { get; init; }

    /// <summary>
    /// Event Stage.
    /// </summary>
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStageFormat20Choice_> EventStage { get; init; } = [];

    /// <summary>
    /// Forfeiture Of Interest Indicator.
    /// </summary>
    [DisplayName("Forfeiture Of Interest Indicator")]
    [IsoXmlTag("FrftrOfIntrstInd")]
    public IsoYesNoIndicator? ForfeitureOfInterestIndicator { get; init; }

    /// <summary>
    /// Information Type.
    /// </summary>
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public InformationTypeFormat5Choice_? InformationType { get; init; }

    /// <summary>
    /// Interest Accrued Number Of Days.
    /// </summary>
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// Intermediate Securities Distribution Type.
    /// </summary>
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecuritiesDistributionTypeFormat18Choice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Letter Of Guaranteed Delivery Indicator.
    /// </summary>
    [DisplayName("Letter Of Guaranteed Delivery Indicator")]
    [IsoXmlTag("LttrOfGrntedDlvryInd")]
    public IsoYesNoIndicator? LetterOfGuaranteedDeliveryIndicator { get; init; }

    /// <summary>
    /// Lottery Type.
    /// </summary>
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat5Choice_? LotteryType { get; init; }

    /// <summary>
    /// New Place Of Incorporation.
    /// </summary>
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    public IsoRestrictedFINXMax350Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Occurrence Type.
    /// </summary>
    [DisplayName("Occurrence Type")]
    [IsoXmlTag("OcrncTp")]
    public DistributionTypeFormat8Choice_? OccurrenceType { get; init; }

    /// <summary>
    /// Offer Type.
    /// </summary>
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat16Choice_> OfferType { get; init; } = [];

    /// <summary>
    /// Period Details.
    /// </summary>
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod16? PeriodDetails { get; init; }

    /// <summary>
    /// Price Details.
    /// </summary>
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice96? PriceDetails { get; init; }

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate135? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Renounceable Entitlement Status Type.
    /// </summary>
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat4Choice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Restriction Indicator.
    /// </summary>
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Securities Quantity.
    /// </summary>
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity14? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Shareholder Rights Directive Indicator.
    /// </summary>
    [DisplayName("Shareholder Rights Directive Indicator")]
    [IsoXmlTag("ShrhldrRghtsDrctvInd")]
    public IsoYesNoIndicator? ShareholderRightsDirectiveIndicator { get; init; }

    /// <summary>
    /// Taxable Income Per Share Calculated.
    /// </summary>
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat4Choice_? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Tax On Non Distributed Proceeds Indicator.
    /// </summary>
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    public ValueList<GenericIdentification47> TaxOnNonDistributedProceedsIndicator { get; init; } =
        [];
}
