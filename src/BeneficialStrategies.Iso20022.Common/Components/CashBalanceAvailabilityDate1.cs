// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Indicates when the amount of money will become available.
/// </summary>
[IsoId("_TU0kytp-Ed-ak6NoX_4Aeg_1268888405")]
[DisplayName("Cash Balance Availability Date")]
public record CashBalanceAvailabilityDate1
{
    /// <summary>
    /// Indicates the number of float days attached to the balance.
    /// </summary>
    [IsoId("_TU0ky9p-Ed-ak6NoX_4Aeg_1379712355")]
    [DisplayName("Number Of Days")]
    [IsoXmlTag("NbOfDays")]
    [IsoSimpleType(IsoSimpleType.Max15PlusSignedNumericText)]
    public required IsoMax15PlusSignedNumericText NumberOfDays { get; init; }

    /// <summary>
    /// Identifies the actual availability date.
    /// </summary>
    [IsoId("_TU0kzNp-Ed-ak6NoX_4Aeg_1424965762")]
    [DisplayName("Actual Date")]
    [IsoXmlTag("ActlDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ActualDate { get; init; }
}
