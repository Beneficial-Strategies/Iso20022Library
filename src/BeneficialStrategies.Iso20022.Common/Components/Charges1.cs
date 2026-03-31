// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of charge and the amont.
/// </summary>
[IsoId("_Ruv-1dp-Ed-ak6NoX_4Aeg_-799598981")]
[DisplayName("Charges")]
public record Charges1
{
    /// <summary>
    /// Type of charges.
    /// </summary>
    [IsoId("_Ruv-1tp-Ed-ak6NoX_4Aeg_1048365997")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ChargeType2FormatChoice_? Type { get; init; }

    /// <summary>
    /// Amount of charges.
    /// </summary>
    [IsoId("_Ruv-19p-Ed-ak6NoX_4Aeg_1034514718")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; }
}
