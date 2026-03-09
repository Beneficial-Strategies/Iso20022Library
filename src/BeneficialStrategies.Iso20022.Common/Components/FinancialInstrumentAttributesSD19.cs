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
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_3f24kQ7uEeuZI5Sr_GAcuA")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD19
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_31lQ8Q7uEeuZI5Sr_GAcuA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Country of source income for the security.
    /// </summary>
    [IsoId("_31lQ8w7uEeuZI5Sr_GAcuA")]
    [DisplayName("Income Source Country")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IncmSrcCtry")]
    #endif
    [IsoXmlTag("IncmSrcCtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CountryCode? IncomeSourceCountry { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? IncomeSourceCountry { get; init; } 
    #else
    public string? IncomeSourceCountry { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_31lQ-w7uEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCAsstClss")]
    #endif
    [IsoXmlTag("DTCAsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClass1Code? DTCAssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClass1Code? DTCAssetClass { get; init; } 
    #else
    public AssetClass1Code? DTCAssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Further classification of instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_31lRAw7uEeuZI5Sr_GAcuA")]
    [DisplayName("DTC Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCAsstTp")]
    #endif
    [IsoXmlTag("DTCAsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAssetType3Code? DTCAssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAssetType3Code? DTCAssetType { get; init; } 
    #else
    public DTCAssetType3Code? DTCAssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the security is eligible for holding at DTC.
    /// </summary>
    [IsoId("_31lRCw7uEeuZI5Sr_GAcuA")]
    [DisplayName("Security Eligibility Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctyElgbltyInd")]
    #endif
    [IsoXmlTag("SctyElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? SecurityEligibilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SecurityEligibilityIndicator { get; init; } 
    #else
    public System.String? SecurityEligibilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Ticket symbol for the event security (underlying security).
    /// </summary>
    [IsoId("_31lREw7uEeuZI5Sr_GAcuA")]
    [DisplayName("Ticker Symbol")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TckrSymb")]
    #endif
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TickerSymbol { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TickerSymbol { get; init; } 
    #else
    public System.String? TickerSymbol { get; set; } 
    #endif
    
    /// <summary>
    /// Security whose characteristics mirror the event security for purposes of FCP eligibility and tax relief. Certain derivative securities like HOLDR may have certain events where the source of payments are from an underlying security.
    /// </summary>
    [IsoId("_31lRGw7uEeuZI5Sr_GAcuA")]
    [DisplayName("Linked Security")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LkdScty")]
    #endif
    [IsoXmlTag("LkdScty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification20? LinkedSecurity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20? LinkedSecurity { get; init; } 
    #else
    public SecurityIdentification20? LinkedSecurity { get; set; } 
    #endif
    
    /// <summary>
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_31lRKQ7uEeuZI5Sr_GAcuA")]
    [DisplayName("Originating Security Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgtgSctyId")]
    #endif
    [IsoXmlTag("OrgtgSctyId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    #else
    public OtherIdentification2? OriginatingSecurityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Security description associated with DIVANN legacy system which contains additional values such as NTL for interest only notional.
    /// </summary>
    [IsoId("_31lRKw7uEeuZI5Sr_GAcuA")]
    [DisplayName("DIVANN Security Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DIVANNSctyDesc")]
    #endif
    [IsoXmlTag("DIVANNSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax50Text? DIVANNSecurityDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DIVANNSecurityDescription { get; init; } 
    #else
    public System.String? DIVANNSecurityDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the event security is a foreign issue. This element will be initially used for CD Early Redemptions AC63.
    /// </summary>
    [IsoId("_31lRLQ7uEeuZI5Sr_GAcuA")]
    [DisplayName("Foreign Issue Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrgnIsseFlg")]
    #endif
    [IsoXmlTag("FrgnIsseFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? ForeignIssueFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ForeignIssueFlag { get; init; } 
    #else
    public System.String? ForeignIssueFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates that underlying security is a Money Market Instrument.
    /// </summary>
    [IsoId("_EFBpUA7vEeuZI5Sr_GAcuA")]
    [DisplayName("Money Market Instrument Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MnyMktInstrmFlg")]
    #endif
    [IsoXmlTag("MnyMktInstrmFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? MoneyMarketInstrumentFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MoneyMarketInstrumentFlag { get; init; } 
    #else
    public System.String? MoneyMarketInstrumentFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
