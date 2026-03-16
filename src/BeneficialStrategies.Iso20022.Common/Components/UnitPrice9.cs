// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money for which goods or services are offered, sold, or bought.
/// </summary>
[Obsolete("Marked obsolete in the ISO 20022 2025-04-24 snapshot. No removal date recorded.")]
[IsoId("_Qfn5Qtp-Ed-ak6NoX_4Aeg_-214178771")]
[DisplayName("Unit Price")]
public record UnitPrice9
{
    /// <summary>
    /// Specifies the unit of measurement. For example, kilo, tons.
    /// </summary>
    [IsoId("_Qfn5Q9p-Ed-ak6NoX_4Aeg_-214178648")]
    [DisplayName("Unit Of Measure Code")]
    [IsoXmlTag("UnitOfMeasrCd")]
    public required UnitOfMeasure4Code UnitOfMeasureCode { get; init; }

    /// <summary>
    /// Identifies the unit of measure not present in the code list.
    /// </summary>
    [IsoId("_Qfn5RNp-Ed-ak6NoX_4Aeg_-214178370")]
    [DisplayName("Other Unit Of Measure")]
    [IsoXmlTag("OthrUnitOfMeasr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OtherUnitOfMeasure { get; init; }

    /// <summary>
    /// Price expressed as a currency and value.
    /// </summary>
    [IsoId("_Qfn5Rdp-Ed-ak6NoX_4Aeg_-214178739")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Multiplication factor of measurement values. For example: goods that can be ordered by 36 pieces.
    /// </summary>
    [IsoId("_Qfn5Rtp-Ed-ak6NoX_4Aeg_-214178679")]
    [DisplayName("Factor")]
    [IsoXmlTag("Fctr")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? Factor { get; init; }
}
