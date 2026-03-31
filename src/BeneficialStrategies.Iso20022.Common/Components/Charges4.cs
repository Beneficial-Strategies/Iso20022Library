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
[IsoId("_eoALASHCEeK_0OuuIoS2mw")]
[DisplayName("Charges")]
public record Charges4
{
    /// <summary>
    /// Total of all charges and taxes applied to the entry.
    /// </summary>
    [IsoId("_e8RK1SHCEeK_0OuuIoS2mw")]
    [DisplayName("Total Charges And Tax Amount")]
    [IsoXmlTag("TtlChrgsAndTaxAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalChargesAndTaxAmount { get; init; }

    /// <summary>
    /// Provides details of the individual charges record.
    /// </summary>
    [IsoId("_e8RK2SHCEeK_0OuuIoS2mw")]
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public ValueList<ChargesRecord2> Record { get; init; } = [];
}
