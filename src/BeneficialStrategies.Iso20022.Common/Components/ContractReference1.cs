// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reference for the identification of an underlying contract.
/// </summary>
[IsoId("_gxMLOs--EemV7s8E008B2w")]
[DisplayName("Contract Reference")]
public partial record ContractReference1
{
    #nullable enable
    
    /// <summary>
    /// Type of the contract referred to.
    /// </summary>
    [IsoId("_gxMLPc--EemV7s8E008B2w")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public DocumentType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Reference of the contract.
    /// </summary>
    [IsoId("_eou0cM-_EemV7s8E008B2w")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max500Text)]
    [StringLength(maximumLength: 500 ,MinimumLength = 1)]
    public required IsoMax500Text Reference { get; init; } 
    
    
    #nullable disable
    
}
