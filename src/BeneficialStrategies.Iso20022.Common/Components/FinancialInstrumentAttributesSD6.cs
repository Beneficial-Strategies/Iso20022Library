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
[IsoId("_1eZYVDL3EeKU9IrkkToqcw_1099419252")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD6
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1eZYVTL3EeKU9IrkkToqcw_102346899")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Country in which the security was issued.
    /// </summary>
    [IsoId("_1ejJUDL3EeKU9IrkkToqcw_667803525")]
    [DisplayName("Country Of Listing")]
    [IsoXmlTag("CtryOfListg")]
    public CountryCode? CountryOfListing { get; init; } 
    
    /// <summary>
    /// Country of source income for the security.
    /// </summary>
    [IsoId("_1ejJUTL3EeKU9IrkkToqcw_1971553762")]
    [DisplayName("Income Source Country")]
    [IsoXmlTag("IncmSrcCtry")]
    public CountryCode? IncomeSourceCountry { get; init; } 
    
    /// <summary>
    /// Classification of instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1ejJUjL3EeKU9IrkkToqcw_2025614481")]
    [DisplayName("DTC Asset Class")]
    [IsoXmlTag("DTCAsstClss")]
    public AssetClass1Code? DTCAssetClass { get; init; } 
    
    /// <summary>
    /// Further classification of instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1ejJUzL3EeKU9IrkkToqcw_145308841")]
    [DisplayName("DTC Asset Type")]
    [IsoXmlTag("DTCAsstTp")]
    public DTCAssetType1Code? DTCAssetType { get; init; } 
    
    /// <summary>
    /// Indicates whether the security is eligible for holding at DTC.
    /// </summary>
    [IsoId("_1ejJVDL3EeKU9IrkkToqcw_-965602578")]
    [DisplayName("Security Eligibility Indicator")]
    [IsoXmlTag("SctyElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? SecurityEligibilityIndicator { get; init; } 
    
    /// <summary>
    /// Ticket symbol for the event security (underlying security).
    /// </summary>
    [IsoId("_1ejJVTL3EeKU9IrkkToqcw_-1698560148")]
    [DisplayName("Ticker Symbol")]
    [IsoXmlTag("TckrSymb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TickerSymbol { get; init; } 
    
    /// <summary>
    /// Security whose characteristics mirror the event security for purposes of FCP eligibility and tax relief. Certain derivative securities like HOLDR may have certain events where the source of payments are from an underlying security.
    /// </summary>
    [IsoId("_1ejJVjL3EeKU9IrkkToqcw_-1540829435")]
    [DisplayName("Linked Security")]
    [IsoXmlTag("LkdScty")]
    public SecurityIdentification15? LinkedSecurity { get; init; } 
    
    
    #nullable disable
    
}
