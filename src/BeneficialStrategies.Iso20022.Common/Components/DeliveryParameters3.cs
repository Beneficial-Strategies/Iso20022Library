// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Parameters of a physical delivery.
/// </summary>
[IsoId("_T6YI7tp-Ed-ak6NoX_4Aeg_152223563")]
[DisplayName("Delivery Parameters")]
public partial record DeliveryParameters3
{
    #nullable enable
    
    /// <summary>
    /// Address for physical delivery.
    /// </summary>
    [IsoId("_T6hS0Np-Ed-ak6NoX_4Aeg_152223589")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public required NameAndAddress4 Address { get; init; } 
    
    /// <summary>
    /// Certificate representing a security that is delivered.
    /// </summary>
    [IsoId("_T6hS0dp-Ed-ak6NoX_4Aeg_152223605")]
    [DisplayName("Issued Certificate Number")]
    [IsoXmlTag("IssdCertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? IssuedCertificateNumber { get; init; } 
    
    
    #nullable disable
    
}
