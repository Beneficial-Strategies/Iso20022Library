// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return criteria for information to be returned in the report deriving from a query about party reference data.
/// </summary>
[IsoId("_kn1p4e5NEeCisYr99QEiWA_-418922110")]
[DisplayName("Party Data Return Criteria")]
public partial record PartyDataReturnCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the opening date of the party is requested.
    /// </summary>
    [IsoId("_kn1p4u5NEeCisYr99QEiWA_1255511384")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? OpeningDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the closing date of the party is requested.
    /// </summary>
    [IsoId("_kn-z0O5NEeCisYr99QEiWA_1566614728")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ClosingDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the type is requested.
    /// </summary>
    [IsoId("_kn-z0e5NEeCisYr99QEiWA_1233025915")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? Type { get; init; } 
    
    /// <summary>
    /// Indicates whether the unique identification to unambiguously identify the party within the system is requested.
    /// </summary>
    [IsoId("_kn-z0u5NEeCisYr99QEiWA_-1567819817")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PartyIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the central security depository or the national central bank who initially created the party reference data is requested.
    /// </summary>
    [IsoId("_kolQwO5NEeCisYr99QEiWA_-1130555111")]
    [DisplayName("CSD Or NCB")]
    [IsoXmlTag("CSDOrNCB")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? CSDOrNCB { get; init; } 
    
    /// <summary>
    /// Indicates whether the identification of the restriction is requested.
    /// </summary>
    [IsoId("_kolQwe5NEeCisYr99QEiWA_987416096")]
    [DisplayName("Restriction Identification")]
    [IsoXmlTag("RstrctnId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? RestrictionIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the date at which a restriction for party has been issued is requested.
    /// </summary>
    [IsoId("_kolQwu5NEeCisYr99QEiWA_-1873928008")]
    [DisplayName("Restricted On Date")]
    [IsoXmlTag("RstrctdOnDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? RestrictedOnDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the name for the party is requested.
    /// </summary>
    [IsoId("_kolQw-5NEeCisYr99QEiWA_-2011913913")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? Name { get; init; } 
    
    /// <summary>
    /// Indicates whether the short name for the party is requested.
    /// </summary>
    [IsoId("_kolQxO5NEeCisYr99QEiWA_1047483532")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ShortName { get; init; } 
    
    /// <summary>
    /// Indicates whether the address for the party is requested.
    /// </summary>
    [IsoId("_kouasO5NEeCisYr99QEiWA_1541856106")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? Address { get; init; } 
    
    /// <summary>
    /// Indicates whether the technical addresses for the party are requested.
    /// </summary>
    [IsoId("_kouase5NEeCisYr99QEiWA_-149516394")]
    [DisplayName("Technical Address")]
    [IsoXmlTag("TechAdr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TechnicalAddress { get; init; } 
    
    /// <summary>
    /// Indicates whether the market specific attributes for the party are requested.
    /// </summary>
    [IsoId("_kouasu5NEeCisYr99QEiWA_707367313")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MarketSpecificAttribute { get; init; } 
    
    
    #nullable disable
    
}
