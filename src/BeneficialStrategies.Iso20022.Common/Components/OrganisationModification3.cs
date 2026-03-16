// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Organisation Modification3.
/// </summary>
[IsoId("_y2PfcTEyEe6g-ffJsqGiSA")]
[DisplayName("Organisation Modification3")]
public partial record OrganisationModification3
{
    #nullable enable

    /// <summary>
    /// Billing Address.
    /// </summary>
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public AddressModification3? BillingAddress { get; init; } 

    /// <summary>
    /// Business Address.
    /// </summary>
    [DisplayName("Business Address")]
    [IsoXmlTag("BizAdr")]
    public AddressModification3? BusinessAddress { get; init; } 

    /// <summary>
    /// Country Of Operation.
    /// </summary>
    [DisplayName("Country Of Operation")]
    [IsoXmlTag("CtryOfOpr")]
    public required CountryCode CountryOfOperation { get; init; } 

    /// <summary>
    /// Full Legal Name.
    /// </summary>
    [DisplayName("Full Legal Name")]
    [IsoXmlTag("FullLglNm")]
    public required FullLegalNameModification1 FullLegalName { get; init; } 

    /// <summary>
    /// Legal Address.
    /// </summary>
    [DisplayName("Legal Address")]
    [IsoXmlTag("LglAdr")]
    public required AddressModification3 LegalAddress { get; init; } 

    /// <summary>
    /// Legal Representative.
    /// </summary>
    [DisplayName("Legal Representative")]
    [IsoXmlTag("LglRprtv")]
    public ValueList<PartyModification3> LegalRepresentative { get; init; } = [];

    /// <summary>
    /// Main Mandate Holder.
    /// </summary>
    [DisplayName("Main Mandate Holder")]
    [IsoXmlTag("MainMndtHldr")]
    public ValueList<PartyModification3> MainMandateHolder { get; init; } = [];

    /// <summary>
    /// Operational Address.
    /// </summary>
    [DisplayName("Operational Address")]
    [IsoXmlTag("OprlAdr")]
    public AddressModification3? OperationalAddress { get; init; } 

    /// <summary>
    /// Organisation Identification.
    /// </summary>
    [DisplayName("Organisation Identification")]
    [IsoXmlTag("OrgId")]
    public required OrganisationIdentification39 OrganisationIdentification { get; init; } 

    /// <summary>
    /// Registration Date.
    /// </summary>
    [DisplayName("Registration Date")]
    [IsoXmlTag("RegnDt")]
    public IsoISODate? RegistrationDate { get; init; } 

    /// <summary>
    /// Representative Officer.
    /// </summary>
    [DisplayName("Representative Officer")]
    [IsoXmlTag("RprtvOffcr")]
    public ValueList<PartyModification3> RepresentativeOfficer { get; init; } = [];

    /// <summary>
    /// Sender.
    /// </summary>
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public ValueList<PartyModification3> Sender { get; init; } = [];

    /// <summary>
    /// Trading Name.
    /// </summary>
    [DisplayName("Trading Name")]
    [IsoXmlTag("TradgNm")]
    public TradingNameModification1? TradingName { get; init; } 

    /// <summary>
    /// Treasury Manager.
    /// </summary>
    [DisplayName("Treasury Manager")]
    [IsoXmlTag("TrsrMgr")]
    public PartyModification3? TreasuryManager { get; init; } 

    
    #nullable disable
    
}
