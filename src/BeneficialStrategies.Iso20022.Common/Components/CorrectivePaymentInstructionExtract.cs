// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corrective Payment Instruction Extract.
/// </summary>
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
[IsoId("_Ph7h8Np-Ed-ak6NoX_4Aeg_-537051220")]
[DisplayName("Corrective Payment Instruction Extract")]
public record CorrectivePaymentInstructionExtract
{
    /// <summary>
    /// Instructed Amount.
    /// </summary>
    [DisplayName("Instructed Amount")]
    [IsoXmlTag("InstdAmt")]
    public required CurrencyAndAmount InstructedAmount { get; init; }

    /// <summary>
    /// Instruction Identification.
    /// </summary>
    [DisplayName("Instruction Identification")]
    [IsoXmlTag("InstrId")]
    public required IsoMax35Text InstructionIdentification { get; init; }

    /// <summary>
    /// Interbank Settlement Amount.
    /// </summary>
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <summary>
    /// Interbank Settlement Date.
    /// </summary>
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    public required IsoISODate InterbankSettlementDate { get; init; }

    /// <summary>
    /// Requested Execution Date.
    /// </summary>
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public required IsoISODate RequestedExecutionDate { get; init; }
}
