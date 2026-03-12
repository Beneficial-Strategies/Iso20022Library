// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details on the settlement fails split per intra-CSD and cross-CSD instructions.
/// </summary>
[IsoId("_MTNhaTOmEeqX8uoQQ3KffQ")]
[DisplayName("Settlement Fails Daily CSD")]
public partial record SettlementFailsDailyCSD3
{
    #nullable enable
    
    /// <summary>
    /// Intra-CSD settlement instructions data.
    /// </summary>
    [IsoId("_MUG5QTOmEeqX8uoQQ3KffQ")]
    [DisplayName("Intra CSD")]
    [IsoXmlTag("IntraCSD")]
    public required SettlementFailsDailyInstructionType1Choice_ IntraCSD { get; init; } 
    
    /// <summary>
    /// Cross-CSD settlement instructions data.
    /// </summary>
    [IsoId("_MUG5QzOmEeqX8uoQQ3KffQ")]
    [DisplayName("Cross CSD")]
    [IsoXmlTag("CrossCSD")]
    public required SettlementFailsDailyInstructionType1Choice_ CrossCSD { get; init; } 
    
    
    #nullable disable
    
}
