// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_XaEGd_WfEemtd4wHZYvFUQ")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction10
{
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_XaEGefWfEemtd4wHZYvFUQ")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod1Code SettlementMethod { get; init; } 
    
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_XaEGffWfEemtd4wHZYvFUQ")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public TrackerClearingSystemIdentification1? ClearingSystem { get; init; } 
    
    
    #nullable disable
    
}
