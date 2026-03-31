// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Amount of money associated with a service.
/// </summary>
[IsoId("_RtQxFtp-Ed-ak6NoX_4Aeg_-308714560")]
[DisplayName("Charges Details")]
public record ChargesDetails1
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("_RtQxF9p-Ed-ak6NoX_4Aeg_-254223423")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType8Code Type { get; init; }

    /// <summary>
    /// Specifies the type of charge by means of a code.
    /// </summary>
    [IsoId("_RtQxGNp-Ed-ak6NoX_4Aeg_-1381603506")]
    [DisplayName("Other Charges Type")]
    [IsoXmlTag("OthrChrgsTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text OtherChargesType { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("_RtZ7ANp-Ed-ak6NoX_4Aeg_-2065921609")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required CurrencyAndAmount Amount { get; init; }

    /// <summary>
    /// Rate used to calculate the amount of the charge or fee.
    /// </summary>
    [IsoId("_RtZ7Adp-Ed-ak6NoX_4Aeg_594363543")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public required IsoPercentageRate Rate { get; init; }
}
