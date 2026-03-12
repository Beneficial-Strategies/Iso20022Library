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
[IsoId("_IHGxISCBEeWhHbfCMWc1cw")]
[DisplayName("Communication Address")]
public partial record CommunicationAddress6
{
    #nullable enable
    
    /// <summary>
    /// Type of communication address.
    /// </summary>
    [IsoId("_Uk0qgSCLEeWJd9HF2tO7BA")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public AddressType1Choice_? AddressType { get; init; } 
    
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    [IsoId("_Iid3cSCBEeWhHbfCMWc1cw")]
    [DisplayName("Email")]
    [IsoXmlTag("Email")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? Email { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_Iid3cyCBEeWhHbfCMWc1cw")]
    [DisplayName("Phone")]
    [IsoXmlTag("Phne")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? Phone { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a mobile phone number, as defined by telecom services.
    /// </summary>
    [IsoId("_Iid3dSCBEeWhHbfCMWc1cw")]
    [DisplayName("Mobile")]
    [IsoXmlTag("Mob")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? Mobile { get; init; } 
    
    /// <summary>
    /// Collection of information that identifies a FAX number, as defined by telecom services.
    /// </summary>
    [IsoId("_Iid3dyCBEeWhHbfCMWc1cw")]
    [DisplayName("Fax Number")]
    [IsoXmlTag("FaxNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? FaxNumber { get; init; } 
    
    /// <summary>
    /// Address for a telex machine.
    /// </summary>
    [IsoId("_Iid3eSCBEeWhHbfCMWc1cw")]
    [DisplayName("Telex Address")]
    [IsoXmlTag("TlxAdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TelexAddress { get; init; } 
    
    /// <summary>
    /// Address for the Universal Resource Locator (URL), for example, used over the www (HTTP) service.
    /// </summary>
    [IsoId("_Iid3eyCBEeWhHbfCMWc1cw")]
    [DisplayName("URL Address")]
    [IsoXmlTag("URLAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public IsoMax256Text? URLAddress { get; init; } 
    
    
    #nullable disable
    
}
