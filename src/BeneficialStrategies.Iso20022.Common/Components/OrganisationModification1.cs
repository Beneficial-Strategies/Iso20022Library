// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information which describes the organisation.
/// </summary>
[IsoId("_PMqLQQ4iEeK3IMoVvcTkkg")]
[DisplayName("Organisation Modification")]
public partial record OrganisationModification1
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_Ph-T9Q4iEeK3IMoVvcTkkg")]
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    public required FullLegalNameModification1 FullLegalName { get; init; } 
    
    /// <summary>
    /// Name used by a business for commercial purposes, although its registered legal name, used for contracts and other formal situations, may be another.
    /// </summary>
    [IsoId("_Ph-T_A4iEeK3IMoVvcTkkg")]
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    public TradingNameModification1? TradingName { get; init; } 
    
    /// <summary>
    /// Country in which the organisation has its business activity.
    /// </summary>
    [IsoId("_Ph-UAw4iEeK3IMoVvcTkkg")]
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public required CountryCode CountryOfOperation { get; init; } 
    
    /// <summary>
    /// Date and time at which a given organisation was officially registered.
    /// </summary>
    [IsoId("_Ph-UCg4iEeK3IMoVvcTkkg")]
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? RegistrationDate { get; init; } 
    
    /// <summary>
    /// Is an operational address, for example, of a shared services center.
    /// </summary>
    [IsoId("_Ph-UEQ4iEeK3IMoVvcTkkg")]
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public AddressModification1? OperationalAddress { get; init; } 
    
    /// <summary>
    /// Is the address where the business activity is taking place.
    /// </summary>
    [IsoId("_Ph-UGA4iEeK3IMoVvcTkkg")]
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public AddressModification1? BusinessAddress { get; init; } 
    
    /// <summary>
    /// Is the address where the entity resides and is registered. More generically, it is the home address (Residential address).
    /// </summary>
    [IsoId("_Ph-UHw4iEeK3IMoVvcTkkg")]
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public required AddressModification1 LegalAddress { get; init; } 
    
    /// <summary>
    /// Address where invoices must be sent.
    /// </summary>
    [IsoId("_Ph-UJg4iEeK3IMoVvcTkkg")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public AddressModification1? BillingAddress { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous way of identifying an organisation.
    /// </summary>
    [IsoId("_Ph-ULQ4iEeK3IMoVvcTkkg")]
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification8 OrganisationIdentification { get; init; } 
    
    /// <summary>
    /// Person in the customer&apos;s organisation who can be contacted by the account servicer in relation to the account(s) identified in this instruction.
    /// </summary>
    [IsoId("_Ph-UNA4iEeK3IMoVvcTkkg")]
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public PartyModification1? RepresentativeOfficer { get; init; } 
    
    /// <summary>
    /// Person responsible of the treasury department within the customer’s organisation.
    /// </summary>
    [IsoId("_Ph-UOw4iEeK3IMoVvcTkkg")]
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyModification1? TreasuryManager { get; init; } 
    
    /// <summary>
    /// Person that has the mandate to delegate authority, to assign mandates to other individuals (mandate holders) to perform specific bank operations on the account.
    /// </summary>
    [IsoId("_Ph-UQg4iEeK3IMoVvcTkkg")]
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public PartyModification1? MainMandateHolder { get; init; } 
    
    /// <summary>
    /// Person that may be the potential sender of a message related to the life cycle of the account.
    /// </summary>
    [IsoId("_Ph-USQ4iEeK3IMoVvcTkkg")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyModification1? Sender { get; init; } 
    
    /// <summary>
    /// Person that is officially and legally mandated to represent the organisation. Depending on legislation, the legal representative(s) might for instance be assigned by the Board, identified in the by-laws of the organisation, be publicly announced in the official journal of a country, etc.
    /// </summary>
    [IsoId("_Ph-UUA4iEeK3IMoVvcTkkg")]
    [DisplayName("Legal Representative")]
    [IsoXmlTag("LglRprtv")]
    public PartyModification1? LegalRepresentative { get; init; } 
    
    
    #nullable disable
    
}
