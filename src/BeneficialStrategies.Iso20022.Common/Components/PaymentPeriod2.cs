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
[IsoId("_RbrR0Np-Ed-ak6NoX_4Aeg_1806126505")]
[DisplayName("Payment Period")]
public record PaymentPeriod2
{
    /// <summary>
    /// Code for the payment.
    /// </summary>
    [IsoId("_RbrR0dp-Ed-ak6NoX_4Aeg_1806126537")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required PaymentTime2Code Code { get; init; }

    /// <summary>
    /// Number of days after which the payment must be effected.
    /// </summary>
    [IsoId("_RbrR0tp-Ed-ak6NoX_4Aeg_1806126567")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? NumberOfDays { get; init; }
}
