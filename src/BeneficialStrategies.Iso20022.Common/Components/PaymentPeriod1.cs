// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the payment terms by means of a code and a period.
/// </summary>
[IsoId("_RJpGp9p-Ed-ak6NoX_4Aeg_1939135068")]
[DisplayName("Payment Period")]
public record PaymentPeriod1
{
    /// <summary>
    /// Code for the payment.
    /// </summary>
    [IsoId("_RJy3oNp-Ed-ak6NoX_4Aeg_1978847357")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PaymentTime1Code Code { get; init; }

    /// <summary>
    /// Number of days after which the payment must be effected.
    /// </summary>
    [IsoId("_RJy3odp-Ed-ak6NoX_4Aeg_2065656376")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDays { get; init; }
}
