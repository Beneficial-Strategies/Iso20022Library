// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of an underlying of a derivative or security that constitutes one lot of such derivative on an exchange.
/// </summary>
[IsoId("_SCZ9ILb6EeabfchHYoktpA")]
[DisplayName("Contract Size")]
public record ContractSize1
{
    /// <summary>
    /// Specifies the total quantity of financial product to be delivered as per the terms of the contract.
    /// </summary>
    [IsoId("_QTnOILb8EeabfchHYoktpA")]
    [DisplayName("Lot Size")]
    [IsoXmlTag("LotSz")]
    [IsoSimpleType(IsoSimpleType.PositiveNumber)]
    public required IsoPositiveNumber LotSize { get; init; }

    /// <summary>
    /// Specifies the unit of underlying.
    /// </summary>
    [IsoId("_O0sZELb8EeabfchHYoktpA")]
    [DisplayName("Unit")]
    [IsoXmlTag("Unit")]
    public UnitOfMeasure5Choice_? Unit { get; init; }
}
