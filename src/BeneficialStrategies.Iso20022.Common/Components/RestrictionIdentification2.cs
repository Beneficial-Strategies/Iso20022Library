// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Restriction References applied on the transaction for which the securities settlement condition modification is requested.
/// </summary>
[IsoId("_fhJyAf1MEeixXcHVEYIW2g")]
[DisplayName("Restriction Identification")]
public partial record RestrictionIdentification2
{
    #nullable enable
    
    /// <summary>
    /// Restriction identification removal or addition applied on the transaction expressed as a code.
    /// </summary>
    [IsoId("_gG7_of1MEeixXcHVEYIW2g")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RestrictionReference1Code Code { get; init; } 
    
    /// <summary>
    /// Restriction identification applied on the transaction.
    /// </summary>
    [IsoId("_gG7_o_1MEeixXcHVEYIW2g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public required IsoRestrictedFINXMax16Text Identification { get; init; } 
    
    
    #nullable disable
    
}
