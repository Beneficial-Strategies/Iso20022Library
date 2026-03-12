// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry service provided by the ATM inside the session.
/// </summary>
[IsoId("_o9gH8a4yEeWpsoxRhdX-8A")]
[DisplayName("ATM Service")]
public partial record ATMService23
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the transfer is performed.
    /// </summary>
    [IsoId("_pJkOAa4yEeWpsoxRhdX-8A")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_pJkOA64yEeWpsoxRhdX-8A")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the host.
    /// </summary>
    [IsoId("_zaHQwK4yEeWpsoxRhdX-8A")]
    [DisplayName("Host Service Code")]
    [IsoXmlTag("HstSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? HostServiceCode { get; init; } 
    
    /// <summary>
    /// Describes the type of fund transfer selected by the customer or the ATM.
    /// </summary>
    [IsoId("_pJkOBa4yEeWpsoxRhdX-8A")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType9Code ServiceType { get; init; } 
    
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_pJkOB64yEeWpsoxRhdX-8A")]
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    
    
    #nullable disable
    
}
