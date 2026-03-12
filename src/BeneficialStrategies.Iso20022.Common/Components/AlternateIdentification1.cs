// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Alternate identification of a security.
/// </summary>
[IsoId("_TBTL0tp-Ed-ak6NoX_4Aeg_1536045465")]
[DisplayName("Alternate Identification")]
public partial record AlternateIdentification1
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a security.
    /// </summary>
    [IsoId("_TBTL09p-Ed-ak6NoX_4Aeg_2021814610")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Source of the security identification.
    /// </summary>
    [IsoId("_TBTL1Np-Ed-ak6NoX_4Aeg_-1724730736")]
    [DisplayName("Identification Source")]
    [IsoXmlTag("IdSrc")]
    public required IdentificationSource1Choice_ IdentificationSource { get; init; } 
    
    
    #nullable disable
    
}
