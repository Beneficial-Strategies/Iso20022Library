// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the derogation related data of settlement fails instructions.
/// </summary>
[IsoId("_N2mR1L6ZEemHTLTzJg7M-A")]
[DisplayName("Settlement Fails Derogation")]
public partial record SettlementFailsDerogation1
{
    #nullable enable
    
    /// <summary>
    /// Defines whether the item is eligible for derogation or not.
    /// </summary>
    [IsoId("_N2mR176ZEemHTLTzJg7M-A")]
    [DisplayName("Eligibility Indicator")]
    [IsoXmlTag("ElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EligibilityIndicator { get; init; } 
    
    /// <summary>
    /// Justification for the derogation.
    /// </summary>
    [IsoId("_gDA-8L6ZEemHTLTzJg7M-A")]
    [DisplayName("Justification")]
    [IsoXmlTag("Justfn")]
    public SettlementFailsJustification1? Justification { get; init; } 
    
    
    #nullable disable
    
}
