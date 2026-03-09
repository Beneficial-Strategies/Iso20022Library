// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the CA event.
/// </summary>
[IsoId("_TdKoc9p-Ed-ak6NoX_4Aeg_281523718")]
[DisplayName("Corporate Action")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateAction2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Stage in the corporate action event life cycle.
    /// </summary>
    [IsoId("_TdKodNp-Ed-ak6NoX_4Aeg_-642508316")]
    [DisplayName("Event Stage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtStag")]
    #endif
    [IsoXmlTag("EvtStag")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionEventStage1FormatChoice_? EventStage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionEventStage1FormatChoice_? EventStage { get; init; } 
    #else
    public CorporateActionEventStage1FormatChoice_? EventStage { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the option that will be selected by default if no instruction is provided by account owner.
    /// </summary>
    [IsoId("_TdKoddp-Ed-ak6NoX_4Aeg_2061150383")]
    [DisplayName("Default Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltOptnTp")]
    #endif
    [IsoXmlTag("DfltOptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionOption1FormatChoice_? DefaultOptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_? DefaultOptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_? DefaultOptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the option number that will be selected by default if no instruction is provided by account owner.
    /// </summary>
    [IsoId("_TdKodtp-Ed-ak6NoX_4Aeg_205464242")]
    [DisplayName("Default Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltOptnNb")]
    #endif
    [IsoXmlTag("DfltOptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact3NumericText? DefaultOptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DefaultOptionNumber { get; init; } 
    #else
    public System.String? DefaultOptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// The method of calculation of drawings and partial redemptions.
    /// </summary>
    [IsoId("_TdKod9p-Ed-ak6NoX_4Aeg_1573530587")]
    [DisplayName("Calculation Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClctnMtd")]
    #endif
    [IsoXmlTag("ClctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionCalculationMethod1FormatChoice_? CalculationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionCalculationMethod1FormatChoice_? CalculationMethod { get; init; } 
    #else
    public CorporateActionCalculationMethod1FormatChoice_? CalculationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_TdKoeNp-Ed-ak6NoX_4Aeg_-40172049")]
    [DisplayName("Back End Odd Lot Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BckEndOddLotSctiesQty")]
    #endif
    [IsoXmlTag("BckEndOddLotSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmountOrCode1Choice_? BackEndOddLotSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmountOrCode1Choice_? BackEndOddLotSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmountOrCode1Choice_? BackEndOddLotSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_TdKoedp-Ed-ak6NoX_4Aeg_464307")]
    [DisplayName("Front End Odd Lot Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrntEndOddLotSctiesQty")]
    #endif
    [IsoXmlTag("FrntEndOddLotSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmountOrCode1Choice_? FrontEndOddLotSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmountOrCode1Choice_? FrontEndOddLotSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmountOrCode1Choice_? FrontEndOddLotSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TdUZcNp-Ed-ak6NoX_4Aeg_790074264")]
    [DisplayName("Minimum Exercisable Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblSctiesQty")]
    #endif
    [IsoXmlTag("MinExrcblSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? MinimumExercisableSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple quantity of financial instrument or lot of rights/warrants that must be exercised.
    /// </summary>
    [IsoId("_TdUZcdp-Ed-ak6NoX_4Aeg_790074356")]
    [DisplayName("Minimum Exercisable Multiple Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinExrcblMltplSctiesQty")]
    #endif
    [IsoXmlTag("MinExrcblMltplSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? MinimumExercisableMultipleSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    [IsoId("_TdUZctp-Ed-ak6NoX_4Aeg_-1821980355")]
    [DisplayName("Incremental Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncrmtlDnmtn")]
    #endif
    [IsoXmlTag("IncrmtlDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? IncrementalDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? IncrementalDenomination { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? IncrementalDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// New Denomination of the equity following, eg, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_TdUZc9p-Ed-ak6NoX_4Aeg_727102664")]
    [DisplayName("New Denomination Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDnmtnSctiesQty")]
    #endif
    [IsoXmlTag("NewDnmtnSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? NewDenominationSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_TdUZdNp-Ed-ak6NoX_4Aeg_597714776")]
    [DisplayName("New Board Lot Securities Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewBrdLotSctiesQty")]
    #endif
    [IsoXmlTag("NewBrdLotSctiesQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? NewBoardLotSecuritiesQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities the offeror/issuer will purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_TdUZddp-Ed-ak6NoX_4Aeg_1203810691")]
    [DisplayName("Securities Quantity Sought")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesQtySght")]
    #endif
    [IsoXmlTag("SctiesQtySght")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmountOrCode1Choice_? SecuritiesQuantitySought { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmountOrCode1Choice_? SecuritiesQuantitySought { get; init; } 
    #else
    public UnitOrFaceAmountOrCode1Choice_? SecuritiesQuantitySought { get; set; } 
    #endif
    
    /// <summary>
    /// The minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    [IsoId("_TdUZdtp-Ed-ak6NoX_4Aeg_-1375919680")]
    [DisplayName("Base Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BaseDnmtn")]
    #endif
    [IsoXmlTag("BaseDnmtn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? BaseDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? BaseDenomination { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? BaseDenomination { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of change announced.
    /// </summary>
    [IsoId("_TdUZd9p-Ed-ak6NoX_4Aeg_-1796992526")]
    [DisplayName("Change Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ChngTp")]
    #endif
    [IsoXmlTag("ChngTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionChangeType1FormatChoice_? ChangeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionChangeType1FormatChoice_? ChangeType { get; init; } 
    #else
    public CorporateActionChangeType1FormatChoice_? ChangeType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions that apply to the offer.
    /// </summary>
    [IsoId("_TdUZeNp-Ed-ak6NoX_4Aeg_-1408191238")]
    [DisplayName("Offer Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OfferTp")]
    #endif
    [IsoXmlTag("OfferTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OfferType1FormatChoice_? OfferType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OfferType1FormatChoice_? OfferType { get; init; } 
    #else
    public OfferType1FormatChoice_? OfferType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether there is restrictions apply to the CA event or not.||Yes = There is restrictions.|No = There is no restrictions.
    /// </summary>
    [IsoId("_TdUZedp-Ed-ak6NoX_4Aeg_-1393415357")]
    [DisplayName("Restriction Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RstrctnInd")]
    #endif
    [IsoXmlTag("RstrctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RestrictionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RestrictionIndicator { get; init; } 
    #else
    public System.String? RestrictionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies if the issuer will allow the agent to accept partial elections. It is to allow split voting over options. It allows the client to elect more than one option to be selected per designated holding.
    /// </summary>
    [IsoId("_TddjYNp-Ed-ak6NoX_4Aeg_-1367556347")]
    [DisplayName("Partial Election Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtlElctnInd")]
    #endif
    [IsoXmlTag("PrtlElctnInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PartialElectionIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PartialElectionIndicator { get; init; } 
    #else
    public System.String? PartialElectionIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the effect on the holdings of electing a Corporate Action option.
    /// </summary>
    [IsoId("_TddjYdp-Ed-ak6NoX_4Aeg_-1279821801")]
    [DisplayName("Election Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ElctnTp")]
    #endif
    [IsoXmlTag("ElctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ElectionMovementType1FormatChoice_? ElectionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElectionMovementType1FormatChoice_? ElectionType { get; init; } 
    #else
    public ElectionMovementType1FormatChoice_? ElectionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of lottery announced.
    /// </summary>
    [IsoId("_TddjYtp-Ed-ak6NoX_4Aeg_1254927257")]
    [DisplayName("Lottery Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LtryTp")]
    #endif
    [IsoXmlTag("LtryTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LotteryType1FormatChoice_? LotteryType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LotteryType1FormatChoice_? LotteryType { get; init; } 
    #else
    public LotteryType1FormatChoice_? LotteryType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the type of income.|The lists of income type codes to be used, are available on the SMPG website at www.smpg.info.
    /// </summary>
    [IsoId("_TddjY9p-Ed-ak6NoX_4Aeg_1284479557")]
    [DisplayName("Income Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmTp")]
    #endif
    [IsoXmlTag("IncmTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification13? IncomeType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification13? IncomeType { get; init; } 
    #else
    public GenericIdentification13? IncomeType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conditions in which a dividend is paid.
    /// </summary>
    [IsoId("_TddjZNp-Ed-ak6NoX_4Aeg_-1508514745")]
    [DisplayName("Dividend Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DvddTp")]
    #endif
    [IsoXmlTag("DvddTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionFrequencyType1FormatChoice_? DividendType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionFrequencyType1FormatChoice_? DividendType { get; init; } 
    #else
    public CorporateActionFrequencyType1FormatChoice_? DividendType { get; set; } 
    #endif
    
    /// <summary>
    /// Type of intermediates securities distribution, eg, stock dividend, reverse right.
    /// </summary>
    [IsoId("_TddjZdp-Ed-ak6NoX_4Aeg_727102756")]
    [DisplayName("Intermediate Securities Distribution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrmdtSctiesDstrbtnTp")]
    #endif
    [IsoXmlTag("IntrmdtSctiesDstrbtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; init; } 
    #else
    public IntermediateSecurityDistributionType1FormatChoice_? IntermediateSecuritiesDistributionType { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the coupon attached/associated with a security.
    /// </summary>
    [IsoId("_TddjZtp-Ed-ak6NoX_4Aeg_-1756777381")]
    [DisplayName("Coupon Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnNb")]
    #endif
    [IsoXmlTag("CpnNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? CouponNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CouponNumber { get; init; } 
    #else
    public System.String? CouponNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number of days used for calculating the accrued interest amount.
    /// </summary>
    [IsoId("_TddjZ9p-Ed-ak6NoX_4Aeg_1584193884")]
    [DisplayName("Interest Accrued Number Of Days")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IntrstAcrdNbOfDays")]
    #endif
    [IsoXmlTag("IntrstAcrdNbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? InterestAccruedNumberOfDays { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? InterestAccruedNumberOfDays { get; init; } 
    #else
    public System.UInt64? InterestAccruedNumberOfDays { get; set; } 
    #endif
    
    /// <summary>
    /// New denomination currency of the inancial instrument.
    /// </summary>
    [IsoId("_TddjaNp-Ed-ak6NoX_4Aeg_727102641")]
    [DisplayName("New Denomination Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewDnmtnCcy")]
    #endif
    [IsoXmlTag("NewDnmtnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? NewDenominationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? NewDenominationCurrency { get; init; } 
    #else
    public string? NewDenominationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the dates related to a CA event.
    /// </summary>
    [IsoId("_Tddjadp-Ed-ak6NoX_4Aeg_-1094455556")]
    [DisplayName("Date Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DtDtls")]
    #endif
    [IsoXmlTag("DtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionDate2? DateDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionDate2? DateDetails { get; init; } 
    #else
    public CorporateActionDate2? DateDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the prices related to a CA event.
    /// </summary>
    [IsoId("_TdnUYNp-Ed-ak6NoX_4Aeg_-915572886")]
    [DisplayName("Price Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PricDtls")]
    #endif
    [IsoXmlTag("PricDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPrice2? PriceDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPrice2? PriceDetails { get; init; } 
    #else
    public CorporateActionPrice2? PriceDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about the periods related to a CA event.
    /// </summary>
    [IsoId("_TdnUYdp-Ed-ak6NoX_4Aeg_1204048727")]
    [DisplayName("Period Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrdDtls")]
    #endif
    [IsoXmlTag("PrdDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionPeriod1? PeriodDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionPeriod1? PeriodDetails { get; init; } 
    #else
    public CorporateActionPeriod1? PeriodDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information about rates and amounts related to a CA event.
    /// </summary>
    [IsoId("_TdnUYtp-Ed-ak6NoX_4Aeg_-1412132684")]
    [DisplayName("Rate And Amount Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateAndAmtDtls")]
    #endif
    [IsoXmlTag("RateAndAmtDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionRate1? RateAndAmountDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionRate1? RateAndAmountDetails { get; init; } 
    #else
    public CorporateActionRate1? RateAndAmountDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional information.
    /// </summary>
    [IsoId("_TdnUY9p-Ed-ak6NoX_4Aeg_-1469079005")]
    [DisplayName("Corporate Action Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CorpActnAddtlInf")]
    #endif
    [IsoXmlTag("CorpActnAddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; init; } 
    #else
    public CorporateActionNarrative1? CorporateActionAdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether certification is required from the account owner.
    /// </summary>
    [IsoId("_TdnUZNp-Ed-ak6NoX_4Aeg_991134143")]
    [DisplayName("Certification Required Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnReqrdInd")]
    #endif
    [IsoXmlTag("CertfctnReqrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CertificationRequiredIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificationRequiredIndicator { get; init; } 
    #else
    public System.String? CertificationRequiredIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Type of certification which is required.
    /// </summary>
    [IsoId("_TdnUZdp-Ed-ak6NoX_4Aeg_2027718544")]
    [DisplayName("Certification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertfctnTp")]
    #endif
    [IsoXmlTag("CertfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; init; } 
    #else
    public BeneficiaryCertificationType1FormatChoice_? CertificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the capital gain is in the scope of the EU Savings directive for the income realised upon the sale, refund or redemption of shares and units (.) (Article 6(1d)).
    /// </summary>
    [IsoId("_TdnUZtp-Ed-ak6NoX_4Aeg_-1262193495")]
    [DisplayName("Capital Gain")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CptlGn")]
    #endif
    [IsoXmlTag("CptlGn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EUCapitalGain2Code? CapitalGain { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EUCapitalGain2Code? CapitalGain { get; init; } 
    #else
    public EUCapitalGain2Code? CapitalGain { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the financial instrument calculates the taxable income per dividend/taxable income per share.
    /// </summary>
    [IsoId("_TdnUZ9p-Ed-ak6NoX_4Aeg_-1974567544")]
    [DisplayName("Taxable Income Per Share Calculated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxblIncmPerShrClctd")]
    #endif
    [IsoXmlTag("TaxblIncmPerShrClctd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; init; } 
    #else
    public TaxableIncomePerShareCalculated2Code? TaxableIncomePerShareCalculated { get; set; } 
    #endif
    
    /// <summary>
    /// New companys place of incorporation.
    /// </summary>
    [IsoId("_TdnUaNp-Ed-ak6NoX_4Aeg_715065943")]
    [DisplayName("New Place Of Incorporation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewPlcOfIncorprtn")]
    #endif
    [IsoXmlTag("NewPlcOfIncorprtn")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? NewPlaceOfIncorporation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? NewPlaceOfIncorporation { get; init; } 
    #else
    public System.String? NewPlaceOfIncorporation { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether terms of the event allow resale of the rights.
    /// </summary>
    [IsoId("_TdnUadp-Ed-ak6NoX_4Aeg_-1307180145")]
    [DisplayName("Renounceable Entitlement Status Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RnncblEntitlmntStsTp")]
    #endif
    [IsoXmlTag("RnncblEntitlmntStsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RenounceableStatus1FormatChoice_? RenounceableEntitlementStatusType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RenounceableStatus1FormatChoice_? RenounceableEntitlementStatusType { get; init; } 
    #else
    public RenounceableStatus1FormatChoice_? RenounceableEntitlementStatusType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the conversion type of an instrument.
    /// </summary>
    [IsoId("_TdxFYNp-Ed-ak6NoX_4Aeg_-1393990716")]
    [DisplayName("Conversion Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsTp")]
    #endif
    [IsoXmlTag("ConvsTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ConversionType1FormatChoice_? ConversionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ConversionType1FormatChoice_? ConversionType { get; init; } 
    #else
    public ConversionType1FormatChoice_? ConversionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether redemption charges apply.
    /// </summary>
    [IsoId("_TdxFYdp-Ed-ak6NoX_4Aeg_1075177055")]
    [DisplayName("Redemption Charges Applied Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedChrgsApldInd")]
    #endif
    [IsoXmlTag("RedChrgsApldInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? RedemptionChargesAppliedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RedemptionChargesAppliedIndicator { get; init; } 
    #else
    public System.String? RedemptionChargesAppliedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
    /// </summary>
    [IsoId("_TdxFYtp-Ed-ak6NoX_4Aeg_1643717254")]
    [DisplayName("Distribution Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DstrbtnTp")]
    #endif
    [IsoXmlTag("DstrbtnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DistributionType1FormatChoice_? DistributionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DistributionType1FormatChoice_? DistributionType { get; init; } 
    #else
    public DistributionType1FormatChoice_? DistributionType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
