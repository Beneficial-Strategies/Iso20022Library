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
/// Tangible items of value to a business.
/// </summary>
[IsoId("_PzlYF5JKEeuAlLVx8pyt3w")]
[DisplayName("Common Financial Instrument Attributes")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CommonFinancialInstrumentAttributes10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CommonFinancialInstrumentAttributes10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CommonFinancialInstrumentAttributes10( string reqDenominationCurrency )
    {
        DenominationCurrency = reqDenominationCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of the security within its lifecycle.
    /// </summary>
    [IsoId("_P1p0oZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctySts")]
    #endif
    [IsoXmlTag("SctySts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityStatus3Choice_? SecurityStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityStatus3Choice_? SecurityStatus { get; init; } 
    #else
    public SecurityStatus3Choice_? SecurityStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the security.
    /// </summary>
    [IsoId("_P1p0qZJKEeuAlLVx8pyt3w")]
    [DisplayName("ISO Security Long Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISOSctyLngNm")]
    #endif
    [IsoXmlTag("ISOSctyLngNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? ISOSecurityLongName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISOSecurityLongName { get; init; } 
    #else
    public System.String? ISOSecurityLongName { get; set; } 
    #endif
    
    /// <summary>
    /// Short name of the security expressed as ISO 18773/18774.
    /// </summary>
    [IsoId("_P1p0q5JKEeuAlLVx8pyt3w")]
    [DisplayName("ISO Security Short Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ISOSctyShrtNm")]
    #endif
    [IsoXmlTag("ISOSctyShrtNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ISOSecurityShortName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ISOSecurityShortName { get; init; } 
    #else
    public System.String? ISOSecurityShortName { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the date since when the name of the security is valid.
    /// </summary>
    [IsoId("_P1p0rZJKEeuAlLVx8pyt3w")]
    [DisplayName("Name Valid From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NmVldFr")]
    #endif
    [IsoXmlTag("NmVldFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? NameValidFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? NameValidFrom { get; init; } 
    #else
    public DateAndDateTime2Choice_? NameValidFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Currency in which a security is issued or redenominated.
    /// </summary>
    [IsoId("_P1p0r5JKEeuAlLVx8pyt3w")]
    [DisplayName("Denomination Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DnmtnCcy")]
    #endif
    [IsoXmlTag("DnmtnCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode DenominationCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string DenominationCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string DenominationCurrency { get; init; } 
    #else
    public string DenominationCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Unique and unambiguous identifier of a certificate assigned by the issuer.
    /// </summary>
    [IsoId("_P1p0t5JKEeuAlLVx8pyt3w")]
    [DisplayName("Certificate Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CertNb")]
    #endif
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CertificateNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CertificateNumber { get; init; } 
    #else
    public System.String? CertificateNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Version number assigned to the contract associated with the security.
    /// </summary>
    [IsoId("_P1p0uZJKEeuAlLVx8pyt3w")]
    [DisplayName("Contract Version Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtrctVrsnNb")]
    #endif
    [IsoXmlTag("CtrctVrsnNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? ContractVersionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ContractVersionNumber { get; init; } 
    #else
    public System.UInt64? ContractVersionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number of the coupon attached to the physical security.
    /// </summary>
    [IsoId("_P1p0u5JKEeuAlLVx8pyt3w")]
    [DisplayName("Coupon Attached Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CpnAttchdNb")]
    #endif
    [IsoXmlTag("CpnAttchdNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax3NumericText? CouponAttachedNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CouponAttachedNumber { get; init; } 
    #else
    public System.String? CouponAttachedNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identification, for tax purposes, of a lot of identical securities that are bought at a certain date and at a certain price.
    /// </summary>
    [IsoId("_P1p0vZJKEeuAlLVx8pyt3w")]
    [DisplayName("Tax Lot Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxLotNb")]
    #endif
    [IsoXmlTag("TaxLotNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? TaxLotNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TaxLotNumber { get; init; } 
    #else
    public System.String? TaxLotNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying a group of underlying assets assigned by the issuer of a factored security.
    /// </summary>
    [IsoId("_P1p0v5JKEeuAlLVx8pyt3w")]
    [DisplayName("Pool Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PoolNb")]
    #endif
    [IsoXmlTag("PoolNb")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax15NumericText? PoolNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PoolNumber { get; init; } 
    #else
    public System.String? PoolNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the derivative product is covered or not by an underlying financial instrument position.
    /// </summary>
    [IsoId("_P1p0x5JKEeuAlLVx8pyt3w")]
    [DisplayName("Covered Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CvrdInd")]
    #endif
    [IsoXmlTag("CvrdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? CoveredIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CoveredIndicator { get; init; } 
    #else
    public System.String? CoveredIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the regulatory restrictions applicable to a security.
    /// </summary>
    [IsoId("_P1p0yZJKEeuAlLVx8pyt3w")]
    [DisplayName("Legal Restrictions")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LglRstrctns")]
    #endif
    [IsoXmlTag("LglRstrctns")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LegalRestrictions4Choice_? LegalRestrictions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LegalRestrictions4Choice_? LegalRestrictions { get; init; } 
    #else
    public LegalRestrictions4Choice_? LegalRestrictions { get; set; } 
    #endif
    
    /// <summary>
    /// Position limits are created for the purpose of maintaining stable and fair markets. Contracts held by one individual investor with different brokers may be combined in order to gauge accurately the level of control held by one party. ||Each option and futures contract will have varying position limits.
    /// </summary>
    [IsoId("_P1p0y5JKEeuAlLVx8pyt3w")]
    [DisplayName("Position Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PosLmt")]
    #endif
    [IsoXmlTag("PosLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? PositionLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? PositionLimit { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? PositionLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Near-term position limit for the instrument.
    /// </summary>
    [IsoId("_P1p005JKEeuAlLVx8pyt3w")]
    [DisplayName("Near Term Position Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NearTermPosLmt")]
    #endif
    [IsoXmlTag("NearTermPosLmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? NearTermPositionLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? NearTermPositionLimit { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? NearTermPositionLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Original Date/time at which the security is listed at the specific exchange or trading venue.
    /// </summary>
    [IsoId("_P1p025JKEeuAlLVx8pyt3w")]
    [DisplayName("Listing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ListgDt")]
    #endif
    [IsoXmlTag("ListgDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ListingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ListingDate { get; init; } 
    #else
    public System.DateOnly? ListingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which positions are struck to note which parties are entitled to receive the entitlement to a corporate event or vote at a meeting.
    /// </summary>
    [IsoId("_P1p03ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Record Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RcrdDt")]
    #endif
    [IsoXmlTag("RcrdDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? RecordDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? RecordDate { get; init; } 
    #else
    public System.DateTime? RecordDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a privilege expires.
    /// </summary>
    [IsoId("_P1p035JKEeuAlLVx8pyt3w")]
    [DisplayName("Expiry Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XpryDt")]
    #endif
    [IsoXmlTag("XpryDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ExpiryDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ExpiryDate { get; init; } 
    #else
    public System.DateOnly? ExpiryDate { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for which money is raised through the issuance of a security.
    /// </summary>
    [IsoId("_P1p04ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Purpose")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Purp")]
    #endif
    [IsoXmlTag("Purp")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? Purpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Purpose { get; init; } 
    #else
    public System.String? Purpose { get; set; } 
    #endif
    
    /// <summary>
    /// Information allowing the classification of a financial instrument, for example, with its ISO CFI (Classification of Financial Instrument) or product type.
    /// </summary>
    [IsoId("_P1p045JKEeuAlLVx8pyt3w")]
    [DisplayName("Classification Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClssfctnTp")]
    #endif
    [IsoXmlTag("ClssfctnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClassificationType2? ClassificationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClassificationType2? ClassificationType { get; init; } 
    #else
    public ClassificationType2? ClassificationType { get; set; } 
    #endif
    
    /// <summary>
    /// Details regarding the issuance of an asset.
    /// </summary>
    [IsoId("_P1p05ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Issuance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Issnc")]
    #endif
    [IsoXmlTag("Issnc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Issuance5? Issuance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Issuance5? Issuance { get; init; } 
    #else
    public Issuance5? Issuance { get; set; } 
    #endif
    
    /// <summary>
    /// Market(s) on which the security is traded.
    /// </summary>
    [IsoId("_P1p055JKEeuAlLVx8pyt3w")]
    [DisplayName("Trading Market")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgMkt")]
    #endif
    [IsoXmlTag("TradgMkt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradingParameters2? TradingMarket { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradingParameters2? TradingMarket { get; init; } 
    #else
    public TradingParameters2? TradingMarket { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the spread to benchmark details of an indication of interest.
    /// </summary>
    [IsoId("_P1p06ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Spread And Benchmark Curve")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SprdAndBchmkCrv")]
    #endif
    [IsoXmlTag("SprdAndBchmkCrv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BenchmarkCurve6? SpreadAndBenchmarkCurve { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BenchmarkCurve6? SpreadAndBenchmarkCurve { get; init; } 
    #else
    public BenchmarkCurve6? SpreadAndBenchmarkCurve { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the type of put.
    /// </summary>
    [IsoId("_P1p065JKEeuAlLVx8pyt3w")]
    [DisplayName("Put Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutTp")]
    #endif
    [IsoXmlTag("PutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PutType3Choice_? PutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PutType3Choice_? PutType { get; init; } 
    #else
    public PutType3Choice_? PutType { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the type of call.
    /// </summary>
    [IsoId("_P1p07ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Call Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallTp")]
    #endif
    [IsoXmlTag("CallTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CallType3Choice_? CallType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CallType3Choice_? CallType { get; init; } 
    #else
    public CallType3Choice_? CallType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a security is interchangeable, ie, the security is allowed to be replaced by another security, without loss of value.
    /// </summary>
    [IsoId("_P1p075JKEeuAlLVx8pyt3w")]
    [DisplayName("Fungible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FngbInd")]
    #endif
    [IsoXmlTag("FngbInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? FungibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FungibleIndicator { get; init; } 
    #else
    public System.String? FungibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the details of the security are to be made available to the market, or kept private between ICSDs and agency network.
    /// </summary>
    [IsoId("_P1p08ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Confidential")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cnfdtl")]
    #endif
    [IsoXmlTag("Cnfdtl")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? Confidential { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Confidential { get; init; } 
    #else
    public System.String? Confidential { get; set; } 
    #endif
    
    /// <summary>
    /// The sale of securities directly to private persons, institutional investors, or both outside a public offering. Such non-public deals (often without a publicly available prospectus) closing through the ICSDs are placed directly with investors.
    /// </summary>
    [IsoId("_P1p085JKEeuAlLVx8pyt3w")]
    [DisplayName("Private Placement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvtPlcmnt")]
    #endif
    [IsoXmlTag("PrvtPlcmnt")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? PrivatePlacement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PrivatePlacement { get; init; } 
    #else
    public System.String? PrivatePlacement { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the investor or the issuer has a conversion option.
    /// </summary>
    [IsoId("_P1p09ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Convertible Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvtblInd")]
    #endif
    [IsoXmlTag("ConvtblInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ConvertibleIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConvertibleIndicator { get; init; } 
    #else
    public System.String? ConvertibleIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Period during which a convertible security may be converted according to the terms of the issue.
    /// </summary>
    [IsoId("_P1p095JKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsPrd")]
    #endif
    [IsoXmlTag("ConvsPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateTimePeriod1? ConversionPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateTimePeriod1? ConversionPeriod { get; init; } 
    #else
    public DateTimePeriod1? ConversionPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Number of target securities for the conversion.
    /// </summary>
    [IsoId("_P1p0-ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Ratio Numerator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsRatioNmrtr")]
    #endif
    [IsoXmlTag("ConvsRatioNmrtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? ConversionRatioNumerator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? ConversionRatioNumerator { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? ConversionRatioNumerator { get; set; } 
    #endif
    
    /// <summary>
    /// Number of held securities for the conversion.
    /// </summary>
    [IsoId("_P1p0-5JKEeuAlLVx8pyt3w")]
    [DisplayName("Conversion Ratio Denominator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ConvsRatioDnmtr")]
    #endif
    [IsoXmlTag("ConvsRatioDnmtr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity1Choice_? ConversionRatioDenominator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity1Choice_? ConversionRatioDenominator { get; init; } 
    #else
    public FinancialInstrumentQuantity1Choice_? ConversionRatioDenominator { get; set; } 
    #endif
    
    /// <summary>
    /// Primary place of deposit.
    /// </summary>
    [IsoId("_P1p0_ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Primary Place Of Deposit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmryPlcOfDpst")]
    #endif
    [IsoXmlTag("PmryPlcOfDpst")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? PrimaryPlaceOfDeposit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? PrimaryPlaceOfDeposit { get; init; } 
    #else
    public PartyIdentification136? PrimaryPlaceOfDeposit { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the notional amount value is to be traded in either an amount or in units.
    /// </summary>
    [IsoId("_P1p0_5JKEeuAlLVx8pyt3w")]
    [DisplayName("Trading Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TradgMtd")]
    #endif
    [IsoXmlTag("TradgMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public UnitOrFaceAmount1Choice_? TradingMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_? TradingMethod { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_? TradingMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the TEFRA rule under which the security is issued.
    /// </summary>
    [IsoId("_P1p1AZJKEeuAlLVx8pyt3w")]
    [DisplayName("TEFRA Rule")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TEFRARule")]
    #endif
    [IsoXmlTag("TEFRARule")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TEFRARules3Choice_? TEFRARule { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TEFRARules3Choice_? TEFRARule { get; init; } 
    #else
    public TEFRARules3Choice_? TEFRARule { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the series number.
    /// </summary>
    [IsoId("_P1p1A5JKEeuAlLVx8pyt3w")]
    [DisplayName("Serie Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrNb")]
    #endif
    [IsoXmlTag("SrNb")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? SerieNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SerieNumber { get; init; } 
    #else
    public System.String? SerieNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier that links multiple security classes.
    /// </summary>
    [IsoId("_P1p1BZJKEeuAlLVx8pyt3w")]
    [DisplayName("Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Clss")]
    #endif
    [IsoXmlTag("Clss")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax16Text? Class { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Class { get; init; } 
    #else
    public System.String? Class { get; set; } 
    #endif
    
    /// <summary>
    /// Amount or percentage of a cash distribution that will be withheld by a tax authority.
    /// </summary>
    [IsoId("_P1p1B5JKEeuAlLVx8pyt3w")]
    [DisplayName("Withholding Tax Regime")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WhldgTaxRgm")]
    #endif
    [IsoXmlTag("WhldgTaxRgm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityWithHoldingTax1? WithholdingTaxRegime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityWithHoldingTax1? WithholdingTaxRegime { get; init; } 
    #else
    public SecurityWithHoldingTax1? WithholdingTaxRegime { get; set; } 
    #endif
    
    /// <summary>
    /// Status of payment of a security at a particular time.
    /// </summary>
    [IsoId("_P1p1CZJKEeuAlLVx8pyt3w")]
    [DisplayName("Payment Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtSts")]
    #endif
    [IsoXmlTag("PmtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesPaymentStatus5Choice_? PaymentStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesPaymentStatus5Choice_? PaymentStatus { get; init; } 
    #else
    public SecuritiesPaymentStatus5Choice_? PaymentStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the physical form of the securities on the closing date.
    /// </summary>
    [IsoId("_P1p1C5JKEeuAlLVx8pyt3w")]
    [DisplayName("Initial Physical Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitlPhysForm")]
    #endif
    [IsoXmlTag("InitlPhysForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InitialPhysicalForm4Choice_? InitialPhysicalForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InitialPhysicalForm4Choice_? InitialPhysicalForm { get; init; } 
    #else
    public InitialPhysicalForm4Choice_? InitialPhysicalForm { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the physical form of the securities after the exchange of the initial certificate issued on the closing date.
    /// </summary>
    [IsoId("_P1rp0ZJKEeuAlLVx8pyt3w")]
    [DisplayName("After Exchange Physical Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AftrXchgPhysForm")]
    #endif
    [IsoXmlTag("AftrXchgPhysForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InitialPhysicalForm3Choice_? AfterExchangePhysicalForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InitialPhysicalForm3Choice_? AfterExchangePhysicalForm { get; init; } 
    #else
    public InitialPhysicalForm3Choice_? AfterExchangePhysicalForm { get; set; } 
    #endif
    
    /// <summary>
    /// Entity appointed by the ICSDs to provide safekeeping for securities in new global note (NGN) form.
    /// </summary>
    [IsoId("_P1rp05JKEeuAlLVx8pyt3w")]
    [DisplayName("Common Safekeeper")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CmonSfkpr")]
    #endif
    [IsoXmlTag("CmonSfkpr")]
    [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoAnyBICDec2014Identifier? CommonSafekeeper { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CommonSafekeeper { get; init; } 
    #else
    public System.String? CommonSafekeeper { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the type of redemption at maturity.
    /// </summary>
    [IsoId("_P1rp1ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Redemption Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedTp")]
    #endif
    [IsoXmlTag("RedTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public MaturityRedemptionType3Choice_? RedemptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public MaturityRedemptionType3Choice_? RedemptionType { get; init; } 
    #else
    public MaturityRedemptionType3Choice_? RedemptionType { get; set; } 
    #endif
    
    /// <summary>
    /// ISO currency for the payment of the cash proceeds.
    /// </summary>
    [IsoId("_P1rp15JKEeuAlLVx8pyt3w")]
    [DisplayName("Redemption Payment Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RedPmtCcy")]
    #endif
    [IsoXmlTag("RedPmtCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? RedemptionPaymentCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? RedemptionPaymentCurrency { get; init; } 
    #else
    public string? RedemptionPaymentCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Regulatory restriction(s) linked to the security.
    /// </summary>
    [IsoId("_P1rp2ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Restriction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rstrctn")]
    #endif
    [IsoXmlTag("Rstrctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityRestriction3? Restriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityRestriction3? Restriction { get; init; } 
    #else
    public SecurityRestriction3? Restriction { get; set; } 
    #endif
    
    /// <summary>
    /// Settlement of the securities in a securities transaction, that is, the instruction to deliver or receive securities, involving the payment of an amount of money or not.
    /// </summary>
    [IsoId("_P1rp25JKEeuAlLVx8pyt3w")]
    [DisplayName("Settlement Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SttlmInf")]
    #endif
    [IsoXmlTag("SttlmInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementInformation17? SettlementInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementInformation17? SettlementInformation { get; init; } 
    #else
    public SettlementInformation17? SettlementInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the form of the financial Instrument.
    /// </summary>
    [IsoId("_P1rp3ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Form")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmForm")]
    #endif
    [IsoXmlTag("FinInstrmForm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentForm2? FinancialInstrumentForm { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentForm2? FinancialInstrumentForm { get; init; } 
    #else
    public FinancialInstrumentForm2? FinancialInstrumentForm { get; set; } 
    #endif
    
    /// <summary>
    /// Details (name, e-mail address and/or telephone number) of the person requesting the allocation of the ISIN used as a point of reference in case further clarifications are required.
    /// </summary>
    [IsoId("_P1rp35JKEeuAlLVx8pyt3w")]
    [DisplayName("Contact Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CtctNm")]
    #endif
    [IsoXmlTag("CtctNm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? ContactName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? ContactName { get; init; } 
    #else
    public Organisation38? ContactName { get; set; } 
    #endif
    
    /// <summary>
    /// Entity appointed by the issuer to structure and lead the placement of a syndicated issue.
    /// </summary>
    [IsoId("_P1rp4ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Lead Manager")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LeadMgr")]
    #endif
    [IsoXmlTag("LeadMgr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? LeadManager { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? LeadManager { get; init; } 
    #else
    public Organisation38? LeadManager { get; set; } 
    #endif
    
    /// <summary>
    /// Main party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    [IsoId("_P1rp45JKEeuAlLVx8pyt3w")]
    [DisplayName("Principal Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrncplPngAgt")]
    #endif
    [IsoXmlTag("PrncplPngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? PrincipalPayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? PrincipalPayingAgent { get; init; } 
    #else
    public Organisation38? PrincipalPayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Additional party appointed to distribute payment or securities on behalf of the issuer.
    /// </summary>
    [IsoId("_P1rp5ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Paying Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PngAgt")]
    #endif
    [IsoXmlTag("PngAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? PayingAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? PayingAgent { get; init; } 
    #else
    public Organisation38? PayingAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Entity appointed by the relevant clearing system as a depository for instruments issued in global or definitive form. The depository keeps the securities for safekeeping purposes on behalf of the clearing system(s).
    /// </summary>
    [IsoId("_P1rp55JKEeuAlLVx8pyt3w")]
    [DisplayName("Depository")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dpstry")]
    #endif
    [IsoXmlTag("Dpstry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? Depository { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? Depository { get; init; } 
    #else
    public Organisation38? Depository { get; set; } 
    #endif
    
    /// <summary>
    /// Entity(ies), asset(s) or security(ies) on which the credit responsibility lies as identified in the documentation.
    /// </summary>
    [IsoId("_P1rp6ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Underlying Risk")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UndrlygRsk")]
    #endif
    [IsoXmlTag("UndrlygRsk")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Organisation38? UnderlyingRisk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Organisation38? UnderlyingRisk { get; init; } 
    #else
    public Organisation38? UnderlyingRisk { get; set; } 
    #endif
    
    
    #nullable disable
    
}
