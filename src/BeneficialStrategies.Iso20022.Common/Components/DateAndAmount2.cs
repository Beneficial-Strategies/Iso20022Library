// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Date and amount.
/// </summary>
[IsoId("_ByTSIU31EeiQHa-q1Uephw")]
[DisplayName("Date And Amount")]
public record DateAndAmount2
{
    /// <summary>
    /// Date on which the amount is declared or registered.
    /// </summary>
    [IsoId("_CB7CgU31EeiQHa-q1Uephw")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? Date { get; init; }

    /// <summary>
    /// Amount of money.
    /// </summary>
    [IsoId("_CB7Cg031EeiQHa-q1Uephw")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveOrHistoricCurrencyAndAmount Amount { get; init; }
}
