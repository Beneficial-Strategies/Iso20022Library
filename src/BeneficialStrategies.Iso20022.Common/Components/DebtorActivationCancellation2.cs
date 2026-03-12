// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the creditor enrolment to be cancelled.
/// </summary>
[IsoId("_UVRG6-H7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Cancellation")]
public partial record DebtorActivationCancellation2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_UWtRUeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_UWtRU-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public DebtorActivationCancellationReason2? CancellationReason { get; init; } 
    
    /// <summary>
    /// Provides the original activation data.
    /// </summary>
    [IsoId("_UWtRVeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation")]
    [IsoXmlTag("OrgnlActvtn")]
    public required OriginalActivation2Choice_ OriginalActivation { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UWtRV-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
