// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to define the balance type and sub-type.
/// </summary>
[IsoId("_1zHyMYalEeeUws0ZryHQ2w")]
[DisplayName("Balance Type")]
public partial record BalanceType13
{
    #nullable enable
    
    /// <summary>
    /// Coded or proprietary format balance type.
    /// </summary>
    [IsoId("_162x44alEeeUws0ZryHQ2w")]
    [DisplayName("Code Or Proprietary")]
    [IsoXmlTag("CdOrPrtry")]
    public required BalanceType10Choice_ CodeOrProprietary { get; init; } 
    
    /// <summary>
    /// Specifies the balance sub-type.
    /// </summary>
    [IsoId("_162x5YalEeeUws0ZryHQ2w")]
    [DisplayName("Sub Type")]
    [IsoXmlTag("SubTp")]
    public BalanceSubType1Choice_? SubType { get; init; } 
    
    
    #nullable disable
    
}
