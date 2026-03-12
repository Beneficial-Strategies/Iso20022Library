// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Relative distinguished name defined by X.500 and X.509.
/// </summary>
[IsoId("_Sw--ugEcEeCQm6a_G2yO_w_-2086938163")]
[DisplayName("Relative Distinguished Name")]
public partial record RelativeDistinguishedName1
{
    #nullable enable
    
    /// <summary>
    /// Type of attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_Sw--uwEcEeCQm6a_G2yO_w_2126667271")]
    [DisplayName("Attribute Type")]
    [IsoXmlTag("AttrTp")]
    public required AttributeType1Code AttributeType { get; init; } 
    
    /// <summary>
    /// Value of the attribute of a distinguished name (see X.500).
    /// </summary>
    [IsoId("_Sw--vAEcEeCQm6a_G2yO_w_-1820514760")]
    [DisplayName("Attribute Value")]
    [IsoXmlTag("AttrVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text AttributeValue { get; init; } 
    
    
    #nullable disable
    
}
