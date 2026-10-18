// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISettlementTimeRequest2"/>
[IsoId("_QIrY6dp-Ed-ak6NoX_4Aeg_2050617089")]
[DisplayName("Settlement Time Request")]
public partial record SettlementTimeRequest2
{
    /// <inheritdoc cref="ISettlementTimeRequest2.CLSTime"/>
    [IsoId("_QIrY6tp-Ed-ak6NoX_4Aeg_2050617120")]
    [DisplayName("CLS Time")]
    [IsoXmlTag("CLSTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CLSTime { get; init; }

    /// <inheritdoc cref="ISettlementTimeRequest2.TillTime"/>
    [IsoId("_QIrY69p-Ed-ak6NoX_4Aeg_2142970270")]
    [DisplayName("Till Time")]
    [IsoXmlTag("TillTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? TillTime { get; init; }

    /// <inheritdoc cref="ISettlementTimeRequest2.FromTime"/>
    [IsoId("_QIrY7Np-Ed-ak6NoX_4Aeg_2123575201")]
    [DisplayName("From Time")]
    [IsoXmlTag("FrTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? FromTime { get; init; }

    /// <inheritdoc cref="ISettlementTimeRequest2.RejectTime"/>
    [IsoId("_QI1J4Np-Ed-ak6NoX_4Aeg_2138351566")]
    [DisplayName("Reject Time")]
    [IsoXmlTag("RjctTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? RejectTime { get; init; }
}
