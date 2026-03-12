// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specification of the taxation basis.
/// </summary>
[IsoId("_VSvC8tp-Ed-ak6NoX_4Aeg_526119979")]
[DisplayName("Taxation Basis")]
public partial record TaxationBasis1
{
    #nullable enable
    
    /// <summary>
    /// Structured format.
    /// </summary>
    [IsoId("_VSvC89p-Ed-ak6NoX_4Aeg_-799724773")]
    [DisplayName("Structured")]
    [IsoXmlTag("Strd")]
    public required TaxationBasis3Code Structured { get; init; } 
    
    /// <summary>
    /// Additional information about the type of taxation basis.
    /// </summary>
    [IsoId("_VSvC9Np-Ed-ak6NoX_4Aeg_-792339705")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
