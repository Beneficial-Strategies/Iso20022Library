// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction14"/>
[IsoId("_g2NR-9cZEeqRFcf2R4bPBw")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction14
{
    /// <inheritdoc cref="ISettlementInstruction14.SettlementMethod"/>
    [IsoId("_g38-VdcZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod2Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction14.SettlementAccount"/>
    [IsoId("_g38-V9cZEeqRFcf2R4bPBw")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount40? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction14.ClearingSystem"/>
    [IsoId("_g38-WdcZEeqRFcf2R4bPBw")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }
}
