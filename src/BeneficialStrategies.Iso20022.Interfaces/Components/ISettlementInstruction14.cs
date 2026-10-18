// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the settlement of the instruction.
/// </summary>
[IsoId("_g2NR-9cZEeqRFcf2R4bPBw")]
public interface ISettlementInstruction14 : IIsoComponent
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_g38-VdcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    SettlementMethod2Code SettlementMethod { get; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_g38-V9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    ICashAccount40? SettlementAccount { get; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_g38-WdcZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    IClearingSystemIdentification3Choice? ClearingSystem { get; }
}
