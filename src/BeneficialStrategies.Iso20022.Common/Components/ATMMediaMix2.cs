// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Media mix selected.
/// </summary>
[IsoId("_SOOfEYq4EeSIDtZ76p6McQ")]
[DisplayName("ATM Media Mix")]
public partial record ATMMediaMix2
{
    #nullable enable
    
    /// <summary>
    /// Number of notes or coins.
    /// </summary>
    [IsoId("_SbVuA4q4EeSIDtZ76p6McQ")]
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber Number { get; init; } 
    
    /// <summary>
    /// Unit value.
    /// </summary>
    [IsoId("_SbVuBYq4EeSIDtZ76p6McQ")]
    [DisplayName("Unit Value")]
    [IsoXmlTag("UnitVal")]
    public required ImpliedCurrencyAndAmount UnitValue { get; init; } 
    
    
    #nullable disable
    
}
