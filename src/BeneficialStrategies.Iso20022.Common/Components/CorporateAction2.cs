// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the CA event.
/// </summary>
[IsoId("_TdKoc9p-Ed-ak6NoX_4Aeg_281523718")]
[DisplayName("Corporate Action")]
public record CorporateAction2
{
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_TdKodNp-Ed-ak6NoX_4Aeg_-642508316")]
    [DisplayName("Event Stage")]
    [IsoXmlTag("EvtStag")]
    public ValueList<CorporateActionEventStage1FormatChoice_> EventStage { get; init; } = [];

    /// <summary>
    /// Identifies the option that will be selected by default if no instruction is provided by account owner.
    /// </summary>
    [IsoId("_TdKoddp-Ed-ak6NoX_4Aeg_2061150383")]
    [DisplayName("Default Option Type")]
    [IsoXmlTag("DfltOptnTp")]
    public CorporateActionOption1FormatChoice_? DefaultOptionType { get; init; }

    /// <summary>
    /// Identifies the option number that will be selected by default if no instruction is provided by account owner.
    /// </summary>
    [IsoId("_TdKodtp-Ed-ak6NoX_4Aeg_205464242")]
    [DisplayName("Default Option Number")]
    [IsoXmlTag("DfltOptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public IsoExact3NumericText? DefaultOptionNumber { get; init; }

    /// <summary>
    /// The method of calculation of drawings and partial redemptions.
    /// </summary>
    [IsoId("_TdKod9p-Ed-ak6NoX_4Aeg_1573530587")]
    [DisplayName("Calculation Method")]
    [IsoXmlTag("ClctnMtd")]
    public CorporateActionCalculationMethod1FormatChoice_? CalculationMethod { get; init; }

    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_TdKoeNp-Ed-ak6NoX_4Aeg_-40172049")]
    [DisplayName("Back End Odd Lot Securities Quantity")]
    [IsoXmlTag("BckEndOddLotSctiesQty")]
    public UnitOrFaceAmountOrCode1Choice_? BackEndOddLotSecuritiesQuantity { get; init; }

    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_TdKoedp-Ed-ak6NoX_4Aeg_464307")]
    [DisplayName("Front End Odd Lot Securities Quantity")]
    [IsoXmlTag("FrntEndOddLotSctiesQty")]
    public UnitOrFaceAmountOrCode1Choice_? FrontEndOddLotSecuritiesQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TdUZcNp-Ed-ak6NoX_4Aeg_790074264")]
    [DisplayName("Minimum Exercisable Securities Quantity")]
    [IsoXmlTag("MinExrcblSctiesQty")]
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TdUZcdp-Ed-ak6NoX_4Aeg_790074356")]
    [DisplayName("Minimum Exercisable Multiple Securities Quantity")]
    [IsoXmlTag("MinExrcblMltplSctiesQty")]
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; init; }

    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    [IsoId("_TdUZctp-Ed-ak6NoX_4Aeg_-1821980355")]
    [DisplayName("Incremental Denomination")]
    [IsoXmlTag("IncrmtlDnmtn")]
    public UnitOrFaceAmount1Choice_? IncrementalDenomination { get; init; }

    /// <summary>
    /// New Denomination of the equity following, eg, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_TdUZc9p-Ed-ak6NoX_4Aeg_727102664")]
    [DisplayName("New Denomination Securities Quantity")]
    [IsoXmlTag("NewDnmtnSctiesQty")]
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_TdUZdNp-Ed-ak6NoX_4Aeg_597714776")]
    [DisplayName("New Board Lot Securities Quantity")]
    [IsoXmlTag("NewBrdLotSctiesQty")]
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; init; }

    /// <summary>
    /// Quantity of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_TdUZddp-Ed-ak6NoX_4Aeg_1203810691")]
    [DisplayName("Securities Quantity Sought")]
    [IsoXmlTag("SctiesQtySght")]
    public UnitOrFaceAmountOrCode1Choice_? SecuritiesQuantitySought { get; init; }

    /// <summary>
    /// The minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    [IsoId("_TdUZdtp-Ed-ak6NoX_4Aeg_-1375919680")]
    [DisplayName("Base Denomination")]
    [IsoXmlTag("BaseDnmtn")]
    public UnitOrFaceAmount1Choice_? BaseDenomination { get; init; }

    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_TdUZd9p-Ed-ak6NoX_4Aeg_-1796992526")]
    [DisplayName("Change Type")]
    [IsoXmlTag("ChngTp")]
    public ValueList<CorporateActionChangeType1FormatChoice_> ChangeType { get; init; } = [];

    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_TdUZeNp-Ed-ak6NoX_4Aeg_-1408191238")]
    [DisplayName("Offer Type")]
    [IsoXmlTag("OfferTp")]
    public ValueList<OfferType1FormatChoice_> OfferType { get; init; } = [];

    /// <summary>
    /// Indicates whether there is restrictions apply to the CA event or not.||Yes = There is restrictions.|No = There is no restrictions.
    /// </summary>
    [IsoId("_TdUZedp-Ed-ak6NoX_4Aeg_-1393415357")]
    [DisplayName("Restriction Indicator")]
    [IsoXmlTag("RstrctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RestrictionIndicator { get; init; }

    /// <summary>
    /// Specifies if the issuer will allow the agent to accept partial elections. It is to allow split voting over options. It allows the client to elect more than one option to be selected per designated holding.
    /// </summary>
    [IsoId("_TddjYNp-Ed-ak6NoX_4Aeg_-1367556347")]
    [DisplayName("Partial Election Indicator")]
    [IsoXmlTag("PrtlElctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? PartialElectionIndicator { get; init; }

    /// <summary>
    /// Specifies the effect on the holdings of electing a Corporate Action option.
    /// </summary>
    [IsoId("_TddjYdp-Ed-ak6NoX_4Aeg_-1279821801")]
    [DisplayName("Election Type")]
    [IsoXmlTag("ElctnTp")]
    public ElectionMovementType1FormatChoice_? ElectionType { get; init; }

    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_TddjYtp-Ed-ak6NoX_4Aeg_1254927257")]
    [DisplayName("Lottery Type")]
    [IsoXmlTag("LtryTp")]
    public LotteryType1FormatChoice_? LotteryType { get; init; }

    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_TddjY9p-Ed-ak6NoX_4Aeg_1284479557")]
    [DisplayName("Income Type")]
    [IsoXmlTag("IncmTp")]
    public GenericIdentification13? IncomeType { get; init; }

    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_TddjZNp-Ed-ak6NoX_4Aeg_-1508514745")]
    [DisplayName("Dividend Type")]
    [IsoXmlTag("DvddTp")]
    public CorporateActionFrequencyType1FormatChoice_? DividendType { get; init; }

    /// <summary>
    /// Type of intermediates securities distribution, eg, stock dividend, reverse right.
    /// </summary>
    [IsoId("_TddjZdp-Ed-ak6NoX_4Aeg_727102756")]
    [DisplayName("Intermediate Securities Distribution Type")]
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; init; }

    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_TddjZtp-Ed-ak6NoX_4Aeg_-1756777381")]
    [DisplayName("Coupon Number")]
    [IsoXmlTag("CpnNb")]
    public SimpleValueList<IsoMax3NumericText> CouponNumber { get; init; } = [];

    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_TddjZ9p-Ed-ak6NoX_4Aeg_1584193884")]
    [DisplayName("Interest Accrued Number Of Days")]
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? InterestAccruedNumberOfDays { get; init; }

    /// <summary>
    /// New denomination currency of the inancial instrument.
    /// </summary>
    [IsoId("_TddjaNp-Ed-ak6NoX_4Aeg_727102641")]
    [DisplayName("New Denomination Currency")]
    [IsoXmlTag("NewDnmtnCcy")]
    public ActiveCurrencyCode? NewDenominationCurrency { get; init; }

    /// <summary>
    /// Provides information about the dates related to a CA event.
    /// </summary>
    [IsoId("_Tddjadp-Ed-ak6NoX_4Aeg_-1094455556")]
    [DisplayName("Date Details")]
    [IsoXmlTag("DtDtls")]
    public CorporateActionDate2? DateDetails { get; init; }

    /// <summary>
    /// Provides information about the prices related to a CA event.
    /// </summary>
    [IsoId("_TdnUYNp-Ed-ak6NoX_4Aeg_-915572886")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public ValueList<CorporateActionPrice2> PriceDetails { get; init; } = [];

    /// <summary>
    /// Provides information about the periods related to a CA event.
    /// </summary>
    [IsoId("_TdnUYdp-Ed-ak6NoX_4Aeg_1204048727")]
    [DisplayName("Period Details")]
    [IsoXmlTag("PrdDtls")]
    public CorporateActionPeriod1? PeriodDetails { get; init; }

    /// <summary>
    /// Provides information about rates and amounts related to a CA event.
    /// </summary>
    [IsoId("_TdnUYtp-Ed-ak6NoX_4Aeg_-1412132684")]
    [DisplayName("Rate And Amount Details")]
    [IsoXmlTag("RateAndAmtDtls")]
    public CorporateActionRate1? RateAndAmountDetails { get; init; }

    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TdnUY9p-Ed-ak6NoX_4Aeg_-1469079005")]
    [DisplayName("Corporate Action Additional Information")]
    [IsoXmlTag("CorpActnAddtlInf")]
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; init; }

    /// <summary>
    /// Indicates whether certification is required from the account owner.
    /// </summary>
    [IsoId("_TdnUZNp-Ed-ak6NoX_4Aeg_991134143")]
    [DisplayName("Certification Required Indicator")]
    [IsoXmlTag("CertfctnReqrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CertificationRequiredIndicator { get; init; }

    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_TdnUZdp-Ed-ak6NoX_4Aeg_2027718544")]
    [DisplayName("Certification Type")]
    [IsoXmlTag("CertfctnTp")]
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; }

    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [IsoId("_TdnUZtp-Ed-ak6NoX_4Aeg_-1262193495")]
    [DisplayName("Capital Gain")]
    [IsoXmlTag("CptlGn")]
    public EUCapitalGain2Code? CapitalGain { get; init; }

    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_TdnUZ9p-Ed-ak6NoX_4Aeg_-1974567544")]
    [DisplayName("Taxable Income Per Share Calculated")]
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; }

    /// <summary>
    /// New companys place of incorporation.
    /// </summary>
    [IsoId("_TdnUaNp-Ed-ak6NoX_4Aeg_715065943")]
    [DisplayName("New Place Of Incorporation")]
    [IsoXmlTag("NewPlcOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? NewPlaceOfIncorporation { get; init; }

    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_TdnUadp-Ed-ak6NoX_4Aeg_-1307180145")]
    [DisplayName("Renounceable Entitlement Status Type")]
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    public RenounceableStatus1FormatChoice_? RenounceableEntitlementStatusType { get; init; }

    /// <summary>
    /// Specifies the conversion type of an instrument.
    /// </summary>
    [IsoId("_TdxFYNp-Ed-ak6NoX_4Aeg_-1393990716")]
    [DisplayName("Conversion Type")]
    [IsoXmlTag("ConvsTp")]
    public ConversionType1FormatChoice_? ConversionType { get; init; }

    /// <summary>
    /// Indicates whether redemption charges apply.
    /// </summary>
    [IsoId("_TdxFYdp-Ed-ak6NoX_4Aeg_1075177055")]
    [DisplayName("Redemption Charges Applied Indicator")]
    [IsoXmlTag("RedChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? RedemptionChargesAppliedIndicator { get; init; }

    /// <summary>
    /// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
    /// </summary>
    [IsoId("_TdxFYtp-Ed-ak6NoX_4Aeg_1643717254")]
    [DisplayName("Distribution Type")]
    [IsoXmlTag("DstrbtnTp")]
    public DistributionType1FormatChoice_? DistributionType { get; init; }
}
