// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the applicable Incoterm and associated location.
/// </summary>
[IsoId("_Sr_qMtp-Ed-ak6NoX_4Aeg_-645465697")]
[DisplayName("Incoterms")]
public partial record Incoterms1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the applicable Incoterm by means of a code.
    /// </summary>
    [IsoId("_Sr_qM9p-Ed-ak6NoX_4Aeg_-492735774")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required Incoterms1Code Code { get; init; } 
    
    /// <summary>
    /// Specifies Incoterm not present in code list.
    /// </summary>
    [IsoId("_Sr_qNNp-Ed-ak6NoX_4Aeg_-492735462")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Other { get; init; } 
    
    /// <summary>
    /// Location where the Incoterms are actioned.
    /// </summary>
    [IsoId("_Sr_qNdp-Ed-ak6NoX_4Aeg_-244656079")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Location { get; init; } 
    
    
    #nullable disable
    
}
