// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to identify a proprietary price.
/// </summary>
[IsoId("_RUhg89p-Ed-ak6NoX_4Aeg_1544655401")]
[DisplayName("Proprietary Price")]
public record ProprietaryPrice1
{
    /// <summary>
    /// Identifies the type of price reported.
    /// </summary>
    [IsoId("_RUhg9Np-Ed-ak6NoX_4Aeg_1603762562")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; }

    /// <summary>
    /// Proprietary price specification related to the underlying transaction.
    /// </summary>
    [IsoId("_RUhg9dp-Ed-ak6NoX_4Aeg_426005158")]
    [DisplayName("Price")]
    [IsoXmlTag("Pric")]
    public required CurrencyAndAmount Price { get; init; }
}
