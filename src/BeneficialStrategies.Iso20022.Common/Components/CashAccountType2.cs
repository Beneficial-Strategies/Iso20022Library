// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICashAccountType2"/>
[IsoId("_T4SeN9p-Ed-ak6NoX_4Aeg_-1717865628")]
[DisplayName("Cash Account Type")]
public partial record CashAccountType2
{
    /// <inheritdoc cref="ICashAccountType2.Code"/>
    [IsoId("_T4SeONp-Ed-ak6NoX_4Aeg_-1686465493")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CashAccountType4Code Code { get; init; }

    /// <inheritdoc cref="ICashAccountType2.Proprietary"/>
    [IsoId("_T4SeOdp-Ed-ak6NoX_4Aeg_-1643987013")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Proprietary { get; init; }
}
