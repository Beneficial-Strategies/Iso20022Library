// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_g2NR-9cZEeqRFcf2R4bPBw")]
[DisplayName("Settlement Instruction")]
public record SettlementInstruction14
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_g38-VdcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod2Code SettlementMethod { get; init; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_g38-V9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount40? SettlementAccount { get; init; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_g38-WdcZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }
}
