// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount pertaining to a transaction.
/// </summary>
[IsoId("_e9mKMZzHEembF9M4GR6EAA")]
[DisplayName("Other Amount")]
public record OtherAmount3
{
    /// <summary>
    /// Type of amount.
    /// </summary>
    [IsoId("_fR-ewZzHEembF9M4GR6EAA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required GenericIdentification1 Type { get; init; }

    /// <summary>
    /// Currency and amount.
    /// </summary>
    [IsoId("_fR-ew5zHEembF9M4GR6EAA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
