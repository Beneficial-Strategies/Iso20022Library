// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementInstruction2"/>
[IsoId("_tiGihVkyEeGeoaLUQk__nA_-836484348")]
[DisplayName("Settlement Instruction")]
public partial record SettlementInstruction2
{
    /// <inheritdoc cref="ISettlementInstruction2.SettlementMethod"/>
    [IsoId("_tiGihlkyEeGeoaLUQk__nA_-1763473932")]
    [DisplayName("Settlement Method")]
    [IsoXmlTag("SttlmMtd")]
    public required SettlementMethod2Code SettlementMethod { get; init; }

    /// <inheritdoc cref="ISettlementInstruction2.SettlementAccount"/>
    [IsoId("_tiPscFkyEeGeoaLUQk__nA_-1682525947")]
    [DisplayName("Settlement Account")]
    [IsoXmlTag("SttlmAcct")]
    public CashAccount24? SettlementAccount { get; init; }

    /// <inheritdoc cref="ISettlementInstruction2.ClearingSystem"/>
    [IsoId("_tiPscVkyEeGeoaLUQk__nA_-1300070839")]
    [DisplayName("Clearing System")]
    [IsoXmlTag("ClrSys")]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; }
}
