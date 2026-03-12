// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the registration of a proxy.
/// </summary>
[IsoId("_fCkadfM7EeqRfth943bvEA")]
[DisplayName("Proxy Appointment Information")]
public partial record ProxyAppointmentInformation5
{
    #nullable enable
    
    /// <summary>
    /// Specifies how to register the proxy.
    /// </summary>
    [IsoId("_fWW5I_M7EeqRfth943bvEA")]
    [DisplayName("Registration Method")]
    [IsoXmlTag("RegnMtd")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? RegistrationMethod { get; init; } 
    
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the intermediary.
    /// </summary>
    [IsoId("_fWW5JfM7EeqRfth943bvEA")]
    [DisplayName("Deadline")]
    [IsoXmlTag("Ddln")]
    public DateFormat58Choice_? Deadline { get; init; } 
    
    /// <summary>
    /// Date by which the information on the proxy assignment must be received by the issuer.
    /// </summary>
    [IsoId("_fWW5J_M7EeqRfth943bvEA")]
    [DisplayName("Market Deadline")]
    [IsoXmlTag("MktDdln")]
    public DateFormat58Choice_? MarketDeadline { get; init; } 
    
    /// <summary>
    /// Proxy person that is authorised by the issuer.
    /// </summary>
    [IsoId("_fWW5KfM7EeqRfth943bvEA")]
    [DisplayName("Authorised Proxy")]
    [IsoXmlTag("AuthrsdPrxy")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Proxy9> AuthorisedProxy { get; init; } = new ValueList<Proxy9>(){};
    
    
    #nullable disable
    
}
