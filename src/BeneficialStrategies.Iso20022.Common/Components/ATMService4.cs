// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Service provided by the ATM inside the session.
/// </summary>
[IsoId("_Dgx7kYqqEeS4a4abTJTSSw")]
[DisplayName("ATM Service")]
public partial record ATMService4
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_Ds2BoYqqEeS4a4abTJTSSw")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_Ds2Bo4qqEeS4a4abTJTSSw")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_Ds2BpYqqEeS4a4abTJTSSw")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; } 
    
    /// <summary>
    /// Describes the type of withdrawal selected by the customer.
    /// </summary>
    [IsoId("_Ds2Bp4qqEeS4a4abTJTSSw")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType5Code ServiceType { get; init; } 
    
    
    #nullable disable
    
}
