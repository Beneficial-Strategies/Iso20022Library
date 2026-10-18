// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction8"/>
[IsoId("_VOSH0Xh1EeidzqjNEfehPg")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction8
{
    /// <inheritdoc cref="ISettlementInstruction8.SettlementMethod"/>
    [IsoId("_VdkhB3h1EeidzqjNEfehPg")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod2Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction8.SettlementAccount"/>
    [IsoId("_VdkhCXh1EeidzqjNEfehPg")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount38? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction8.ClearingSystem"/>
    [IsoId("_VdkhC3h1EeidzqjNEfehPg")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }
}
