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
[IsoId("_bwbnYYwXEei289CGNqs21g")]
[DisplayName("Party Data Return Criteria")]
public partial record PartyDataReturnCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the opening date of the party is requested.
    /// </summary>
    [IsoId("_b7KQsYwXEei289CGNqs21g")]
    [DisplayName("Opening Date")]
    [IsoXmlTag("OpngDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? OpeningDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the closing date of the party is requested.
    /// </summary>
    [IsoId("_b7KQs4wXEei289CGNqs21g")]
    [DisplayName("Closing Date")]
    [IsoXmlTag("ClsgDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ClosingDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the type is requested.
    /// </summary>
    [IsoId("_b7KQtYwXEei289CGNqs21g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? Type { get; init; } 
    
    /// <summary>
    /// Indicates whether the unique identification to unambiguously identify the party within the system is requested.
    /// </summary>
    [IsoId("_b7KQt4wXEei289CGNqs21g")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? PartyIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the responsible party who initially created the party reference data is requested.
    /// </summary>
    [IsoId("_b7KQuYwXEei289CGNqs21g")]
    [DisplayName("Responsible Party Identification")]
    [IsoXmlTag("RspnsblPtyId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ResponsiblePartyIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the identification of the restriction is requested.
    /// </summary>
    [IsoId("_b7KQu4wXEei289CGNqs21g")]
    [DisplayName("Restriction Identification")]
    [IsoXmlTag("RstrctnId")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? RestrictionIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether the date at which a restriction for party has been issued is requested.
    /// </summary>
    [IsoId("_b7KQvYwXEei289CGNqs21g")]
    [DisplayName("Restricted On Date")]
    [IsoXmlTag("RstrctdOnDt")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? RestrictedOnDate { get; init; } 
    
    /// <summary>
    /// Indicates whether the name for the party is requested.
    /// </summary>
    [IsoId("_b7KQv4wXEei289CGNqs21g")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? Name { get; init; } 
    
    /// <summary>
    /// Indicates whether the short name for the party is requested.
    /// </summary>
    [IsoId("_b7KQwYwXEei289CGNqs21g")]
    [DisplayName("Short Name")]
    [IsoXmlTag("ShrtNm")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ShortName { get; init; } 
    
    /// <summary>
    /// Indicates whether the address for the party is requested.
    /// </summary>
    [IsoId("_b7KQw4wXEei289CGNqs21g")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? Address { get; init; } 
    
    /// <summary>
    /// Indicates whether the technical addresses for the party are requested.
    /// </summary>
    [IsoId("_b7KQxYwXEei289CGNqs21g")]
    [DisplayName("Technical Address")]
    [IsoXmlTag("TechAdr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? TechnicalAddress { get; init; } 
    
    /// <summary>
    /// Indicates whether the party contact details are requested.
    /// </summary>
    [IsoId("_UHeKk4waEei289CGNqs21g")]
    [DisplayName("Contact Details")]
    [IsoXmlTag("CtctDtls")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ContactDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether the residence type is requested.
    /// </summary>
    [IsoId("_UHeKlIwaEei289CGNqs21g")]
    [DisplayName("Residence Type")]
    [IsoXmlTag("ResTp")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? ResidenceType { get; init; } 
    
    /// <summary>
    /// Indicates whether the lock status is requested.
    /// </summary>
    [IsoId("_UHeKlYwaEei289CGNqs21g")]
    [DisplayName("Lock Status")]
    [IsoXmlTag("LckSts")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? LockStatus { get; init; } 
    
    /// <summary>
    /// Indicates whether the market specific attributes for the party are requested.
    /// </summary>
    [IsoId("_b7KQx4wXEei289CGNqs21g")]
    [DisplayName("Market Specific Attribute")]
    [IsoXmlTag("MktSpcfcAttr")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    public IsoRequestedIndicator? MarketSpecificAttribute { get; init; } 
    
    
    #nullable disable
    
}
