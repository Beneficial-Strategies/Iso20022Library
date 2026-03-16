// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial loan (instalment) or a recurring transaction.
/// </summary>
[IsoId("_SpYh7gEcEeCQm6a_G2yO_w_-569860423")]
[DisplayName("Recurring Transaction")]
public record RecurringTransaction1
{
    /// <summary>
    /// Indicates the recurring/instalment occurrence of the transaction (1 = 1st instalment, 2 = 2nd instalment, etc.).
    /// </summary>
    [IsoId("_SpiS4AEcEeCQm6a_G2yO_w_295359691")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Max2NumericText)]
    public required IsoMax2NumericText SequenceNumber { get; init; }

    /// <summary>
    /// Period unit between consecutive payments (for example day, month, year).
    /// </summary>
    [IsoId("_SpiS4QEcEeCQm6a_G2yO_w_1632462586")]
    [DisplayName("Period Unit")]
    [IsoXmlTag("PrdUnit")]
    public required Frequency4Code PeriodUnit { get; init; }

    /// <summary>
    /// Number of period units between consecutive payments.
    /// </summary>
    [IsoId("_SpiS4gEcEeCQm6a_G2yO_w_-377494272")]
    [DisplayName("Instalment Period")]
    [IsoXmlTag("InstlmtPrd")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber InstalmentPeriod { get; init; }

    /// <summary>
    /// Total number of instalment payments.
    /// </summary>
    [IsoId("_SpiS4wEcEeCQm6a_G2yO_w_-1926232913")]
    [DisplayName("Total Number Of Payments")]
    [IsoXmlTag("TtlNbOfPmts")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public required IsoNumber TotalNumberOfPayments { get; init; }

    /// <summary>
    /// Interest charged in percentage for the total amount of payments.
    /// </summary>
    [IsoId("_SpiS5AEcEeCQm6a_G2yO_w_993672809")]
    [DisplayName("Interest Charges")]
    [IsoXmlTag("IntrstChrgs")]
    public ImpliedCurrencyAndAmount? InterestCharges { get; init; }
}
