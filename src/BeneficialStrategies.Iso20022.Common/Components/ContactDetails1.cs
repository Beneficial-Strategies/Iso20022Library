// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_QKUXpNp-Ed-ak6NoX_4Aeg_936147869")]
[DisplayName("Contact Details")]
public partial record ContactDetails1
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_QKUXpdp-Ed-ak6NoX_4Aeg_1087606013")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Name { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QKUXptp-Ed-ak6NoX_4Aeg_1470869687")]
    [DisplayName("Fund Manager Postal Address")]
    [IsoXmlTag("FndMgrPstlAdr")]
    public required PostalAddress1 FundManagerPostalAddress { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QKUXp9p-Ed-ak6NoX_4Aeg_1414534844")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public required IsoPhoneNumber PhoneNumber { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QKUXqNp-Ed-ak6NoX_4Aeg_1414534845")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QKdhkNp-Ed-ak6NoX_4Aeg_1414534813")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? EmailAddress { get; init; } 
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), eg, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_QKdhkdp-Ed-ak6NoX_4Aeg_1414534875")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identification of a financial institution, as assigned under a globally recognised or proprietary identification scheme.
    /// </summary>
    [IsoId("_QKdhktp-Ed-ak6NoX_4Aeg_1087606291")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.BICIdentifier)]
    public required IsoBICIdentifier Identification { get; init; } 
    
    
    #nullable disable
    
}
