// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action83.
/// </summary>
[IsoId("_jtN600m_Ee-NocYul3BKXQ")]
[DisplayName("Corporate Action83")]
public partial record CorporateAction83
{
    #nullable enable

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
    public ValueList<AdditionalBusinessProcessFormat17Choice_> AdditionalBusinessProcessIndicator { get; init; } = [];

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public CorporateActionNarrative58? AdditionalInformation { get; init; } 

    /// <summary>
    /// Amount Details.
    /// </summary>
    [DisplayName("Amount Details")]
    [IsoXmlTag("AmtDtls")]
    public CorporateActionAmounts70? AmountDetails { get; init; } 

    /// <summary>
    /// Capital Gain In Out Indicator.
    /// </summary>
    [DisplayName("Capital Gain In Out Indicator")]
    [IsoXmlTag("CptlGnInOutInd")]
    public CapitalGainFormat3Choice_? CapitalGainInOutIndicator { get; init; } 

    /// <summary>
    /// Certificate Details.
    /// </summary>
    [DisplayName("Certificate Details")]
    [IsoXmlTag("CertDtls")]
    public ValueList<CorporateActionSD26> CertificateDetails { get; init; } = [];

    /// <summary>
    /// Certification Type.
    /// </summary>
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public CertificationTypeFormat3Choice_? CertificationType { get; init; } 

    /// <summary>
    /// Change Type.
    /// </summary>
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeTypeFormat5Choice_> ChangeType { get; init; } = [];

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
    public ConsentTypeFormat4Choice_? ConsentType { get; init; } 

    /// <summary>
    /// Date Details.
    /// </summary>
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate83? DateDetails { get; init; } 

    /// <summary>
    /// Dividend Type.
    /// </summary>
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public DividendTypeFormat9Choice_? DividendType { get; init; } 

    /// <summary>
    /// Dutch Auction Type.
    /// </summary>
    [DisplayName("Dutch Auction Type")]
    [IsoXmlTag("DtchAuctnTp")]
    public DutchAuctionTypeFormat1Choice_? DutchAuctionType { get; init; } 

    /// <summary>
    /// Event Balance Details.
    /// </summary>
    [DisplayName("Event Balance Details")]
    [IsoXmlTag("EvtBalDtls")]
    public CorporateActionBalanceDetails47? EventBalanceDetails { get; init; } 

    /// <summary>
    /// Event Stage.
    /// </summary>
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStageFormat13Choice_> EventStage { get; init; } = [];

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
    public InformationTypeFormat4Choice_? InformationType { get; init; } 

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
    public IntermediateSecuritiesDistributionTypeFormat15Choice_? IntermediateSecuritiesDistributionType { get; init; } 

    /// <summary>
    /// Lottery Type.
    /// </summary>
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryTypeFormat4Choice_? LotteryType { get; init; } 

    /// <summary>
    /// New Place Of Incorporation.
    /// </summary>
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    public IsoMax350Text? NewPlaceOfIncorporation { get; init; } 

    /// <summary>
    /// Notice Type.
    /// </summary>
    [DisplayName("Notice Type")]
    [IsoXmlTag("NtceTp")]
    public RedemptionAnnouncementNoticeType1Code? NoticeType { get; init; } 

    /// <summary>
    /// Occurrence Type.
    /// </summary>
    [DisplayName("Occurrence Type")]
    [IsoXmlTag("OcrncTp")]
    public DistributionTypeFormat7Choice_? OccurrenceType { get; init; } 

    /// <summary>
    /// Offer Type.
    /// </summary>
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferTypeFormat14Choice_> OfferType { get; init; } = [];

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
    public CorporateActionPrice85? PriceDetails { get; init; } 

    /// <summary>
    /// Proration Return Minimum Quantity Treatment.
    /// </summary>
    [DisplayName("Proration Return Minimum Quantity Treatment")]
    [IsoXmlTag("PrratnRtrMinQtyTrtmnt")]
    public ProrationReturnQuantityTreatment1Code? ProrationReturnMinimumQuantityTreatment { get; init; } 

    /// <summary>
    /// Rate And Amount Details.
    /// </summary>
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate122? RateAndAmountDetails { get; init; } 

    /// <summary>
    /// Renounceable Entitlement Status Type.
    /// </summary>
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableEntitlementStatusTypeFormat3Choice_? RenounceableEntitlementStatusType { get; init; } 

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
    public CorporateActionQuantity11? SecuritiesQuantity { get; init; } 

    /// <summary>
    /// Supplementary Indicators.
    /// </summary>
    [DisplayName("Supplementary Indicators")]
    [IsoXmlTag("SplmtryIndctrs")]
    public CorporateActionSupplementaryIndicators1? SupplementaryIndicators { get; init; } 

    /// <summary>
    /// Taxable Income Per Share Calculated.
    /// </summary>
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculatedFormat3Choice_? TaxableIncomePerShareCalculated { get; init; } 

    /// <summary>
    /// Tax On Non Distributed Proceeds Indicator.
    /// </summary>
    [DisplayName("Tax On Non Distributed Proceeds Indicator")]
    [IsoXmlTag("TaxOnNonDstrbtdPrcdsInd")]
    public ValueList<GenericIdentification30> TaxOnNonDistributedProceedsIndicator { get; init; } = [];

    
    #nullable disable
    
}
