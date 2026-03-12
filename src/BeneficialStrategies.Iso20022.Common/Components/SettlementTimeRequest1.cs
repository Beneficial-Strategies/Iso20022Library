// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the requested settlement time of the instruction.
/// </summary>
[IsoId("_QHyBEdp-Ed-ak6NoX_4Aeg_564730971")]
[DisplayName("Settlement Time Request")]
public partial record SettlementTimeRequest1
{
    #nullable enable
    
    /// <summary>
    /// Time by which the funds must be credited, with confirmation, to the CLS Bank&apos;s account at the central bank, expressed in Central European Time (CET).
    /// </summary>
    [IsoId("_QHyBEtp-Ed-ak6NoX_4Aeg_605366498")]
    [DisplayName("CLS Time")]
    [IsoXmlTag("CLSTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime CLSTime { get; init; } 
    
    
    #nullable disable
    
}
