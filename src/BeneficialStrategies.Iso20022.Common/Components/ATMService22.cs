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
[IsoId("_obPXIa4sEeWLdt0vLARX2Q")]
[DisplayName("ATM Service")]
public partial record ATMService22
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the customer session in which the transfer is performed.
    /// </summary>
    [IsoId("_om2xQa4sEeWLdt0vLARX2Q")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_om2xQ64sEeWLdt0vLARX2Q")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; } 
    
    /// <summary>
    /// Describes the type of fund transfer selected by the customer or the ATM.
    /// </summary>
    [IsoId("_om2xRa4sEeWLdt0vLARX2Q")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType9Code ServiceType { get; init; } 
    
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_om2xR64sEeWLdt0vLARX2Q")]
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    
    
    #nullable disable
    
}
