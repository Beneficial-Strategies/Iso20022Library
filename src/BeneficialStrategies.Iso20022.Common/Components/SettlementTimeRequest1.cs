// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementTimeRequest1"/>
[IsoId("_QHyBEdp-Ed-ak6NoX_4Aeg_564730971")]
[DisplayName("Settlement Time Request")]
public partial record SettlementTimeRequest1
{
    /// <inheritdoc cref="ISettlementTimeRequest1.CLSTime"/>
    [IsoId("_QHyBEtp-Ed-ak6NoX_4Aeg_605366498")]
    [DisplayName("CLS Time")]
    [IsoXmlTag("CLSTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public required IsoISOTime CLSTime { get; init; }
}
