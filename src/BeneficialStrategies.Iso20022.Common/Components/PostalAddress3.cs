// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information that locates and identifies a specific address, as defined by postal services.
/// </summary>
[IsoId("_QHMLJdp-Ed-ak6NoX_4Aeg_1886908463")]
[DisplayName("Postal Address")]
public partial record PostalAddress3
{
    #nullable enable
    
    /// <summary>
    /// Type of address.
    /// </summary>
    [IsoId("_QHMLJtp-Ed-ak6NoX_4Aeg_1886909524")]
    [DisplayName("Address Type")]
    [IsoXmlTag("AdrTp")]
    public required AddressType1Code AddressType { get; init; } 
    
    /// <summary>
    /// Indicates whether mail should be sent to an address.
    /// </summary>
    [IsoId("_QHMLJ9p-Ed-ak6NoX_4Aeg_1886909609")]
    [DisplayName("Mailing Indicator")]
    [IsoXmlTag("MlngInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator MailingIndicator { get; init; } 
    
    /// <summary>
    /// Indicates whether the address is the official address of the party.
    /// </summary>
    [IsoId("_QHMLKNp-Ed-ak6NoX_4Aeg_1886909661")]
    [DisplayName("Registration Address Indicator")]
    [IsoXmlTag("RegnAdrInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator RegistrationAddressIndicator { get; init; } 
    
    /// <summary>
    /// Information that locates and identifies a specific address, as defined by postal services.
    /// </summary>
    [IsoId("_QHVVENp-Ed-ak6NoX_4Aeg_1886909998")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public required NameAndAddress4 NameAndAddress { get; init; } 
    
    
    #nullable disable
    
}
