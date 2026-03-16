// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Debtor Activation Cancellation3.
/// </summary>
[IsoId("_5eRjYTEyEe6g-ffJsqGiSA")]
[DisplayName("Debtor Activation Cancellation3")]
public record DebtorActivationCancellation3
{
    /// <summary>
    /// Cancellation Reason.
    /// </summary>
    [DisplayName("Cancellation Reason")]
    [IsoXmlTag("CxlRsn")]
    public DebtorActivationCancellationReason3? CancellationReason { get; init; }

    /// <summary>
    /// Original Activation.
    /// </summary>
    [DisplayName("Original Activation")]
    [IsoXmlTag("OrgnlActvtn")]
    public required OriginalActivation3Choice_ OriginalActivation { get; init; }

    /// <summary>
    /// Original Business Instruction.
    /// </summary>
    [DisplayName("Original Business Instruction")]
    [IsoXmlTag("OrgnlBizInstr")]
    public OriginalBusinessInstruction1? OriginalBusinessInstruction { get; init; }

    /// <summary>
    /// Supplementary Data.
    /// </summary>
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
