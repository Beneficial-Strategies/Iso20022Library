// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pension scheme tax reference.
/// </summary>
[IsoId("_F77qMV29EeiFXdiLi_Nf4A")]
[DisplayName("Tax Reference")]
public partial record TaxReference2
{
    #nullable enable
    
    /// <summary>
    /// Type of tax reference.
    /// </summary>
    [IsoId("_GLZpkV29EeiFXdiLi_Nf4A")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TaxReferenceType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Pension scheme tax reference issued to the pension plan by a central organisation.
    /// </summary>
    [IsoId("_GLZpk129EeiFXdiLi_Nf4A")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    
    #nullable disable
    
}
