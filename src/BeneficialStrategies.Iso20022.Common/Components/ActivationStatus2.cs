// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the status of a debtor activation.
/// </summary>
[IsoId("_Ug_1x-H7Eeqbls7Gk4-ckA")]
[DisplayName("Activation Status")]
public partial record ActivationStatus2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the original instruction.
    /// </summary>
    [IsoId("_UiH3I-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status of the request.
    /// </summary>
    [IsoId("_UiH3JeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ServiceStatus1Choice_ Status { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the status of the debtor activation request.
    /// </summary>
    [IsoId("_UiH3J-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public DebtorActivationStatusReason2? StatusReason { get; init; } 
    
    /// <summary>
    /// Provides the reference of the original activation request.
    /// </summary>
    [IsoId("_UiH3KeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Original Activation Reference")]
    [IsoXmlTag("OrgnlActvtnRef")]
    public OriginalActivation2Choice_? OriginalActivationReference { get; init; } 
    
    /// <summary>
    /// Effective date when the debtor has been activated.
    /// </summary>
    [IsoId("_17LFgeIGEeqbls7Gk4-ckA")]
    [DisplayName("Effective Activation Date")]
    [IsoXmlTag("FctvActvtnDt")]
    public DateAndDateTime2Choice_? EffectiveActivationDate { get; init; } 
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_UiH3K-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
