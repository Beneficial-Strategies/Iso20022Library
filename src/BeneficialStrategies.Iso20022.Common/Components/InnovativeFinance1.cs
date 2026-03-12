// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about an innovative finance product.
/// </summary>
[IsoId("_lM8GQE7bEeifNrXGwadPmg")]
[DisplayName("Innovative Finance")]
public partial record InnovativeFinance1
{
    #nullable enable
    
    /// <summary>
    /// Type of innovative finance product.
    /// </summary>
    [IsoId("_nqMy4E7bEeifNrXGwadPmg")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GenericIdentification36 Type { get; init; } 
    
    /// <summary>
    /// Details of an innovative finance product.
    /// </summary>
    [IsoId("_rBLVwE7bEeifNrXGwadPmg")]
    [DisplayName("Information")]
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text Information { get; init; } 
    
    
    #nullable disable
    
}
