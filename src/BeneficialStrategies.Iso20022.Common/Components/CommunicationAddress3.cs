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
[IsoId("_QKBcuNp-Ed-ak6NoX_4Aeg_-46881250")]
[DisplayName("Communication Address")]
public partial record CommunicationAddress3
{
    #nullable enable
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_QKBcudp-Ed-ak6NoX_4Aeg_-46881232")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QKKmoNp-Ed-ak6NoX_4Aeg_-45959803")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? Phone { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_QKKmodp-Ed-ak6NoX_4Aeg_-1695039266")]
    [DisplayName("Mobile")]
    [IsoXmlTag("Mob")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? Mobile { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_QKKmotp-Ed-ak6NoX_4Aeg_-45959726")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; } 
    
    /// <summary>
    /// Address for a telex machine.
    /// </summary>
    [IsoId("_QKKmo9p-Ed-ak6NoX_4Aeg_-46879947")]
    [DisplayName("Telex Address")]
    [IsoXmlTag("TlxAdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TelexAddress { get; init; } 
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example an address used over the www (HTTP) service.
    /// </summary>
    [IsoId("_QKKmpNp-Ed-ak6NoX_4Aeg_-45959863")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; } 
    
    
    #nullable disable
    
}
