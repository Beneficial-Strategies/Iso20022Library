// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding underlying security details.
/// </summary>
[IsoId("_3beX4b5PEeexmbB7KsjCwA")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD15
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_3r_gIb5PEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Country of source income for the security.
    /// </summary>
    [IsoId("_3r_gI75PEeexmbB7KsjCwA")]
    [DisplayName("Income Source Country")]
    [IsoXmlTag("IncmSrcCtry")]
    public CountryCode? IncomeSourceCountry { get; init; } 
    
    /// <summary>
    /// Classification of instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_3r_gK75PEeexmbB7KsjCwA")]
    [DisplayName("DTC Asset Class")]
    [IsoXmlTag("DTCAsstClss")]
    public AssetClass1Code? DTCAssetClass { get; init; } 
    
    /// <summary>
    /// Further classification of instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_3r_gM75PEeexmbB7KsjCwA")]
    [DisplayName("DTC Asset Type")]
    [IsoXmlTag("DTCAsstTp")]
    public DTCAssetType3Code? DTCAssetType { get; init; } 
    
    /// <summary>
    /// Indicates whether the security is eligible for holding at DTC.
    /// </summary>
    [IsoId("_3r_gO75PEeexmbB7KsjCwA")]
    [DisplayName("Security Eligibility Indicator")]
    [IsoXmlTag("SctyElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecurityEligibilityIndicator { get; init; } 
    
    /// <summary>
    /// Ticket symbol for the event security (underlying security).
    /// </summary>
    [IsoId("_3r_gQ75PEeexmbB7KsjCwA")]
    [DisplayName("Ticker Symbol")]
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TickerSymbol { get; init; } 
    
    /// <summary>
    /// Security whose characteristics mirror the event security for purposes of FCP eligibility and tax relief. Certain derivative securities like HOLDR may have certain events where the source of payments are from an underlying security.
    /// </summary>
    [IsoId("_3r_gS75PEeexmbB7KsjCwA")]
    [DisplayName("Linked Security")]
    [IsoXmlTag("LkdScty")]
    public SecurityIdentification20? LinkedSecurity { get; init; } 
    
    /// <summary>
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_3r_gWb5PEeexmbB7KsjCwA")]
    [DisplayName("Originating Security Identification")]
    [IsoXmlTag("OrgtgSctyId")]
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    
    /// <summary>
    /// Security description associated with DIVANN legacy system which contains additional values such as NTL for interest only notional.
    /// </summary>
    [IsoId("_3r_gW75PEeexmbB7KsjCwA")]
    [DisplayName("DIVANN Security Description")]
    [IsoXmlTag("DIVANNSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? DIVANNSecurityDescription { get; init; } 
    
    /// <summary>
    /// Indicates whether the event security is a foreign issue. This field will be initially used for CD Early Redemptions AC63.
    /// </summary>
    [IsoId("_3r_gXb5PEeexmbB7KsjCwA")]
    [DisplayName("Foreign Issue Flag")]
    [IsoXmlTag("FrgnIsseFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ForeignIssueFlag { get; init; } 
    
    
    #nullable disable
    
}
