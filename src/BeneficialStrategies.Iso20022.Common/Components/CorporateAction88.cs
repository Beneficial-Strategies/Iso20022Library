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
[IsoId("a2995d12-cea5-4f65-ba58-f4636dff68d9")]
[DisplayName("Corporate Action88")]
public record CorporateAction88
{
    /// <summary>
    /// Provides information about the dates related to a corporate action event.
    /// </summary>
    [IsoId("7a9cf92c-edbe-4b30-9934-95c4cb9c1b9e")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate83? DateDetails { get; init; }

    /// <summary>
    /// Balances related to the corporate action event.
    /// </summary>
    [IsoId("e921573f-8667-4147-843e-c1260b3a337d")]
    [DisplayName("Event Balance Details")]
    [IsoXmlTag("EvtBalDtls")]
    public CorporateActionBalanceDetails48? EventBalanceDetails { get; init; }

    /// <summary>
    /// Provides information about the amounts related to a corporate action event.
    /// </summary>
    [IsoId("1133590c-0138-4c54-9db8-4e2792d383d0")]
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts80? AmountDetails { get; init; }

    /// <summary>
    /// Provides information about the periods related to a corporate action event.
    /// </summary>
    [IsoId("b5ab645b-118f-4f49-9e91-cb60f0ab1629")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod17? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a corporate action event.
    /// </summary>
    [IsoId("3600e21e-d070-4f0e-a904-48bacfc42457")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate122? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a corporate action event.
    /// </summary>
    [IsoId("929a4371-fa36-420d-9a73-7300a5246070")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public CorporateActionPrice85? PriceDetails { get; init; }

    /// <summary>
    /// Provides information about securities quantity linked to a corporate action.
    /// </summary>
    [IsoId("57c00b9d-3b55-4891-b8ce-79b90c2e7649")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public CorporateActionQuantity15? SecuritiesQuantity { get; init; }

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("26853107-21ad-4870-bb19-06db30ff8285")]
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    public IsoMax3Number? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// Level of priority of the given offer which will be accepted by the issuer/agent within the tiered structure of the event.
    /// </summary>
    [IsoId("3f352cad-0166-4d99-a014-fd4496817550")]
    [DisplayName("Acceptance Priority Level")]
    [IsoXmlTag("AccptncPrtyLvl")]
    public IsoExact3UpperCaseAlphaNumericText? AcceptancePriorityLevel { get; init; }

    /// <summary>
    /// Indicates whether charges apply to the holder, for instance redemption charges.
    /// </summary>
    [IsoId("c64eb572-32e4-463e-8185-fbd6287935a7")]
    [DisplayName("Charges Applied Indicator")]
    [IsoXmlTag("ChrgsApldInd")]
    public IsoYesNoIndicator? ChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Indicates whether restrictions apply to the corporate action event or not.
    /// </summary>
    [IsoId("9e68be68-7736-47de-b688-e1dd26d89cb4")]
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Indicates whether the holder is entitled to accrued interest.
    /// </summary>
    [IsoId("e4f2c251-91c4-4ad1-a1a7-3e2cbe67acf8")]
    [DisplayName("Accrued Interest Indicator")]
    [IsoXmlTag("AcrdIntrstInd")]
    public IsoYesNoIndicator? AccruedInterestIndicator { get; init; }

    /// <summary>
    /// Identification of a supplementary data element.
    /// </summary>
    [IsoId("7d1131ab-eb02-4168-9e3b-d3469082b043")]
    [DisplayName("Supplementary Indicators")]
    [IsoXmlTag("SplmtryIndctrs")]
    public CorporateActionSupplementaryIndicators2? SupplementaryIndicators { get; init; }

    /// <summary>
    /// Indicates that bondholders who convert between record date and payable date will forfeit their interest.
    /// </summary>
    [IsoId("838f583d-7c8e-4873-89e7-9f6fdf912679")]
    [DisplayName("Forfeiture Of Interest Indicator")]
    [IsoXmlTag("FrftrOfIntrstInd")]
    public IsoYesNoIndicator? ForfeitureOfInterestIndicator { get; init; }

    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("15b2e88d-8c3d-431f-86c6-eff329f3ff0d")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat9Choice? DividendType { get; init; }

    /// <summary>
    /// Specifies the conditions in which the instructions and/or payment of the proceeds occurs.
    /// </summary>
    [IsoId("c19c21eb-074c-4faf-aa12-719d62f1710f")]
    [DisplayName("Occurrence Type")]
    [IsoXmlTag("OcrncTp")]
    public DistributionTypeFormat7Choice? OccurrenceType { get; init; }

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("2777773b-21a1-4a42-bf4c-4cbe96497f0b")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat18Choice> OfferType { get; init; } = [];

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("17aa637b-a0c1-4fc2-8da6-482780c159a7")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat3Choice? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("b4f7b24c-4c3c-4693-a11b-f92bc85f70b0")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStageFormat13Choice> EventStage { get; init; } = [];

    /// <summary>
    /// Specifies the type of the additional business process linked to the corporate action event.
    /// </summary>
    [IsoId("34fbf6b0-f588-42b6-9418-f86600cb7488")]
    [DisplayName("Additional Business Process Indicator")]
    [IsoXmlTag("AddtlBizPrcInd")]
    public ValueList<AdditionalBusinessProcessFormat25Choice> AdditionalBusinessProcessIndicator { get; init; } = [];

    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("461bbda8-13f2-497e-881d-ad4f0c71e00a")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat5Choice> ChangeType { get; init; } = [];

    /// <summary>
    /// Specifies the event type of the following event.
    /// </summary>
    [IsoId("43d24008-82ad-483c-9e31-2bcd0cd82842")]
    [DisplayName("Following Event Type Indicator")]
    [IsoXmlTag("FllwngEvtTpInd")]
    public IntermediateSecuritiesDistributionTypeFormat19Choice? FollowingEventTypeIndicator { get; init; }

    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive.
    /// </summary>
    [IsoId("1c098bb3-7ede-458b-ab62-82665484b3d1")]
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat3Choice? CapitalGainInOutIndicator { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("4d1a33cb-3706-4ae5-a071-67188c42aa2e")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat3Choice? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// Specifies the details of a lottery.
    /// </summary>
    [IsoId("2b552d15-33c4-446c-963b-b7d5a1406610")]
    [DisplayName("Lottery Event Information")]
    [IsoXmlTag("LtryEvtInf")]
    public CorporateActionLotteryEvent1? LotteryEventInformation { get; init; }

    /// <summary>
    /// Specifies the certification format required, this is, physical or electronic format.
    /// </summary>
    [IsoId("61c75ae1-fc41-431d-8d26-1ab14c293d7b")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat3Choice? CertificationType { get; init; }

    /// <summary>
    /// Specifies the type of consent announced.
    /// </summary>
    [IsoId("b33767f6-4a7d-42ec-a766-dde4f80f3fbb")]
    [DisplayName("Consent Type")]
    [IsoXmlTag("CnsntTp")]
    public ConsentTypeFormat4Choice? ConsentType { get; init; }

    /// <summary>
    /// Specifies the type of information event.
    /// </summary>
    [IsoId("6e0499fb-7bf3-4f46-9847-7b744eda8d6e")]
    [DisplayName("Information Type")]
    [IsoXmlTag("InfTp")]
    public InformationTypeFormat4Choice? InformationType { get; init; }

    /// <summary>
    /// Specifies the tax regulation being attributed to the non-distributed proceeds event or to any other event.
    /// </summary>
    [IsoId("e162c8cc-bad2-42ff-8b78-b9c86b73b3fe")]
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    public ValueList<GenericIdentification30> TaxOnNonDistributedProceedsIndicator { get; init; } = [];

    /// <summary>
    /// Specifies whether a Dutch auction is modified or unmodified.
    /// </summary>
    [IsoId("c938a200-0cd7-4a74-a4fc-f6ea41f8c1c7")]
    [DisplayName("Dutch Auction Type")]
    [IsoXmlTag("DtchAuctnTp")]
    public DutchAuctionTypeFormat1Choice? DutchAuctionType { get; init; }

    /// <summary>
    /// Indicates that the Dutch Auction event is a Reverse Dutch Auction.
    /// </summary>
    [IsoId("_VkWkkKL0EfCHi7w3_0pcpw")]
    [DisplayName("Reverse Dutch Auction Indicator")]
    [IsoXmlTag("RvsDtchAuctnInd")]
    public IsoYesNoIndicator? ReverseDutchAuctionIndicator { get; init; }

    /// <summary>
    /// New company's place of incorporation.
    /// </summary>
    [IsoId("f8740f8a-b80c-42f9-9bd5-71450c94c2c4")]
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    public IsoMax350Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Specifies whether a redemption announcement refers to certificates held only at depository or also outside of depository.
    /// </summary>
    [IsoId("13115995-3258-4ca7-aac2-3bd582691e4c")]
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public RedemptionAnnouncementNoticeType1Code? NoticeType { get; init; }

    /// <summary>
    /// Indicates how prorated instructions will be handled when the prorated entitlement results in less than the minimum denomination.
    /// </summary>
    [IsoId("434fd0e0-d4d1-44d9-962b-757cfbe28172")]
    [DisplayName("Proration Return Minimum Quantity Treatment")]
    [IsoXmlTag("PrratnRtrMinQtyTrtmnt")]
    public ProrationReturnQuantityTreatment1Code? ProrationReturnMinimumQuantityTreatment { get; init; }

    /// <summary>
    /// Details of certificates that have been called for redemption.
    /// </summary>
    [IsoId("98bfeeb6-4c10-464a-96de-16bae230fd73")]
    [DisplayName("Certificate Details")]
    [IsoXmlTag("CertDtls")]
    public ValueList<CorporateActionSD26> CertificateDetails { get; init; } = [];

    /// <summary>
    /// Provides additional information. This field may only be used when the information to be transmitted cannot be coded.
    /// </summary>
    [IsoId("1dbb1d46-e6fa-4ecc-beb3-1e6f5f557330")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative58? AdditionalInformation { get; init; }
}
