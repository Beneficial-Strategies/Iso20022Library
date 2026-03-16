// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Activation Status3.
/// </summary>
[IsoId("_6YV-8TEyEe6g-ffJsqGiSA")]
[DisplayName("Activation Status3")]
public partial record ActivationStatus3
{
    #nullable enable

    /// <summary>
    /// Effective Activation Date.
    /// </summary>
    [DisplayName("Effective Activation Date")]
    [IsoXmlTag("FctvActvtnDt")]
    public DateAndDateTime2Choice_? EffectiveActivationDate { get; init; } 

    /// <summary>
    /// Original Activation Reference.
    /// </summary>
    [DisplayName("Original Activation Reference")]
    [IsoXmlTag("OrgnlActvtnRef")]
    public OriginalActivation3Choice_? OriginalActivationReference { get; init; } 

    /// <summary>
    /// Original Business Instruction.
    /// </summary>
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; } 

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ServiceStatus1Choice_ Status { get; init; } 

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public DebtorActivationStatusReason3? StatusReason { get; init; } 

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];

    
    #nullable disable
    
}
