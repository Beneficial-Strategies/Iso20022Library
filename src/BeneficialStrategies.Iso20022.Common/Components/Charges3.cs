// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the charges related to the payment transaction.
/// </summary>
[IsoId("_tisYa1kyEeGeoaLUQk__nA_-1567404898")]
[DisplayName("Charges")]
public record Charges3
{
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    [IsoId("_ti2JYFkyEeGeoaLUQk__nA_307776817")]
    [DisplayName("Total Charges And Tax Amount")]
    [IsoXmlTag("TtlChrgsAndTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; }

    /// <summary>
    /// Provides details of the individual charges record.
    /// </summary>
    [IsoId("_ti2JYVkyEeGeoaLUQk__nA_313328146")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ChargesRecord1? Record { get; init; }
}
