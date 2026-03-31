// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charges15.
/// </summary>
[IsoId("_xv4UXzEyEe6g-ffJsqGiSA")]
[DisplayName("Charges15")]
public record Charges15
{
    /// <summary>
    /// Record.
    /// </summary>
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<ChargesRecord8> Record { get; init; } = [];

    /// <summary>
    /// Total Charges And Tax Amount.
    /// </summary>
    [DisplayName("Total Charges And Tax Amount")]
    [IsoXmlTag("TtlChrgsAndTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; }
}
