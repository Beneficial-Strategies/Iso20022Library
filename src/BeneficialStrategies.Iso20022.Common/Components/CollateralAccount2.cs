// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information on the collateral account of the party delivering/receiving the collateral.
/// </summary>
[IsoId("_Ymh6kYFxEeWtPe6Crjmeug")]
[DisplayName("Collateral Account")]
public partial record CollateralAccount2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the collateral account.
    /// </summary>
    [IsoId("_Y-LlkYFxEeWtPe6Crjmeug")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Indicates the type of collateral account.
    /// </summary>
    [IsoId("_Y-Llk4FxEeWtPe6Crjmeug")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CollateralAccountIdentificationType2Choice_? Type { get; init; } 
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_Y-LllYFxEeWtPe6Crjmeug")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    
    #nullable disable
    
}
