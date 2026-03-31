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
[IsoId("_tiGihVkyEeGeoaLUQk__nA_-836484348")]
[DisplayName("Settlement Instruction")]
public record SettlementInstruction2
{
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [IsoId("_tiGihlkyEeGeoaLUQk__nA_-1763473932")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod2Code SettlementMethod { get; init; }

    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [IsoId("_tiPscFkyEeGeoaLUQk__nA_-1682525947")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount24? SettlementAccount { get; init; }

    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [IsoId("_tiPscVkyEeGeoaLUQk__nA_-1300070839")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }
}
