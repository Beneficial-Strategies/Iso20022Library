// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Physical packaging of goods for transport.
/// </summary>
[IsoId("_S-_lgQEcEeCQm6a_G2yO_w_809159669")]
[DisplayName("Packaging")]
public partial record Packaging1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of packaging as a code.
    /// </summary>
    [IsoId("_S-_lggEcEeCQm6a_G2yO_w_-915366691")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ExternalPackagingType1Code? Type { get; init; } 
    
    /// <summary>
    /// Specifies the type of packaging as text. For instance, halogenated resin (PVC).
    /// </summary>
    [IsoId("_S-_lgwEcEeCQm6a_G2yO_w_71439375")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Name { get; init; } 
    
    
    #nullable disable
    
}
