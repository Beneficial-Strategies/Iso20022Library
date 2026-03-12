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
[IsoId("_fzEuYZ2MEeW-bsa36JFb9A")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD12
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_gJr3kZ2MEeW-bsa36JFb9A")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Country of source income for the security.
    /// </summary>
    [IsoId("_gJr3k52MEeW-bsa36JFb9A")]
    [DisplayName("Income Source Country")]
    [IsoXmlTag("IncmSrcCtry")]
    public CountryCode? IncomeSourceCountry { get; init; } 
    
    /// <summary>
    /// Classification of instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_gJr3m52MEeW-bsa36JFb9A")]
    [DisplayName("DTC Asset Class")]
    [IsoXmlTag("DTCAsstClss")]
    public AssetClass1Code? DTCAssetClass { get; init; } 
    
    /// <summary>
    /// Further classification of instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_gJr3o52MEeW-bsa36JFb9A")]
    [DisplayName("DTC Asset Type")]
    [IsoXmlTag("DTCAsstTp")]
    public DTCAssetType2Code? DTCAssetType { get; init; } 
    
    /// <summary>
    /// Indicates whether the security is eligible for holding at DTC.
    /// </summary>
    [IsoId("_gJr3q52MEeW-bsa36JFb9A")]
    [DisplayName("Security Eligibility Indicator")]
    [IsoXmlTag("SctyElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecurityEligibilityIndicator { get; init; } 
    
    /// <summary>
    /// Ticket symbol for the event security (underlying security).
    /// </summary>
    [IsoId("_gJr3s52MEeW-bsa36JFb9A")]
    [DisplayName("Ticker Symbol")]
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TickerSymbol { get; init; } 
    
    /// <summary>
    /// Security whose characteristics mirror the event security for purposes of FCP eligibility and tax relief. Certain derivative securities like HOLDR may have certain events where the source of payments are from an underlying security.
    /// </summary>
    [IsoId("_gJr3u52MEeW-bsa36JFb9A")]
    [DisplayName("Linked Security")]
    [IsoXmlTag("LkdScty")]
    public SecurityIdentification15? LinkedSecurity { get; init; } 
    
    /// <summary>
    /// Represents the &apos;original&apos; security identifier of the event. It is used in the scenarios like &quot;partial call&quot; where there are 2 events. The first event distributes into the Contra CUSIP, a temporary security; and on the second event that temporary security becomes the underlying security of the event. This element is used in the second event to point to the original CUSIP.
    /// </summary>
    [IsoId("_gJr3yZ2MEeW-bsa36JFb9A")]
    [DisplayName("Originating Security Identification")]
    [IsoXmlTag("OrgtgSctyId")]
    public OtherIdentification2? OriginatingSecurityIdentification { get; init; } 
    
    /// <summary>
    /// Security description associated with DIVANN legacy system which contains additional values such as NTL for interest only notional.
    /// </summary>
    [IsoId("_gJr3y52MEeW-bsa36JFb9A")]
    [DisplayName("DIVANN Security Description")]
    [IsoXmlTag("DIVANNSctyDesc")]
    [IsoSimpleType(IsoSimpleType.Max50Text)]
    [StringLength(maximumLength: 50 ,MinimumLength = 1)]
    public IsoMax50Text? DIVANNSecurityDescription { get; init; } 
    
    
    #nullable disable
    
}
