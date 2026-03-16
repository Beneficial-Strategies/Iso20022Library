// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide details of the credit line.
/// </summary>
[IsoId("_SZgzGNp-Ed-ak6NoX_4Aeg_-630126227")]
[DisplayName("Credit Line")]
public record CreditLine2
{
    /// <summary>
    /// Indicates whether or not the credit line is included in the balance.||Usage: If not present, credit line is not included in the balance amount.
    /// </summary>
    [IsoId("_SZgzGdp-Ed-ak6NoX_4Aeg_-630126197")]
    [DisplayName("Included")]
    [IsoXmlTag("Incl")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator Included { get; init; }

    /// <summary>
    /// Amount of money of the credit line.
    /// </summary>
    [IsoId("_SZgzGtp-Ed-ak6NoX_4Aeg_-630126166")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ActiveOrHistoricCurrencyAndAmount? Amount { get; init; }
}
