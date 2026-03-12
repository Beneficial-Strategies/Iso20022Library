// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to identify a proprietary reference.
/// </summary>
[IsoId("_RUrR8dp-Ed-ak6NoX_4Aeg_-121377116")]
[DisplayName("Proprietary Reference")]
public partial record ProprietaryReference1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of reference reported.
    /// </summary>
    [IsoId("_RUrR8tp-Ed-ak6NoX_4Aeg_139056847")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Proprietary reference specification related to the underlying transaction.
    /// </summary>
    [IsoId("_RUrR89p-Ed-ak6NoX_4Aeg_164916968")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Reference { get; init; } 
    
    
    #nullable disable
    
}
