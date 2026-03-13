// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates how to register a proxy.
/// </summary>
[IsoId("_T44UEdp-Ed-ak6NoX_4Aeg_-1448448855")]
[DisplayName("Proxy Appointment Information")]
public partial record ProxyAppointmentInformation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates how to register a proxy.
    /// </summary>
    [IsoId("_T44UEtp-Ed-ak6NoX_4Aeg_-1448448846")]
    [DisplayName("Registration Method")]
    [IsoXmlTag("RegnMtd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? RegistrationMethod { get; init; } 
    
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the intermediary.
    /// </summary>
    [IsoId("_T44UE9p-Ed-ak6NoX_4Aeg_-1448448830")]
    [DisplayName("Deadline")]
    [IsoXmlTag("Ddln")]
    public DateFormat2Choice_? Deadline { get; init; } 
    
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the intermediary (STP mode).
    /// </summary>
    [IsoId("_T44UFNp-Ed-ak6NoX_4Aeg_-1447528841")]
    [DisplayName("STP Deadline")]
    [IsoXmlTag("STPDdln")]
    public DateFormat2Choice_? STPDeadline { get; init; } 
    
    /// <summary>
    /// Date by which the information on proxy assignment must be received by the issuer.
    /// </summary>
    [IsoId("_T44UFdp-Ed-ak6NoX_4Aeg_-1447528824")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat2Choice_? MarketDeadline { get; init; } 
    
    /// <summary>
    /// Specifies the proxy persons which are authorised by the issuer.
    /// </summary>
    [IsoId("_T44UFtp-Ed-ak6NoX_4Aeg_2093029164")]
    [DisplayName("Authorised Proxy")]
    [IsoXmlTag("AuthrsdPrxy")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Proxy1> AuthorisedProxy { get; init; } = [];
    
    
    #nullable disable
    
}
