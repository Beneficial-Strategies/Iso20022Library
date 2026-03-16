// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the tax amount(s) of tax record.
/// </summary>
[IsoId("_yeA_Fa9fEeen6L7OP7lnvg")]
[DisplayName("Tax Amount")]
public record TaxAmount2
{
    /// <summary>
    /// Rate used to calculate the tax.
    /// </summary>
    [IsoId("_yv3kA69fEeen6L7OP7lnvg")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? Rate { get; init; }

    /// <summary>
    /// Amount of money on which the tax is based.
    /// </summary>
    [IsoId("_yv3kBa9fEeen6L7OP7lnvg")]
    [DisplayName("Taxable Base Amount")]
    [IsoXmlTag("TaxblBaseAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TaxableBaseAmount { get; init; }

    /// <summary>
    /// Total amount that is the result of the calculation of the tax for the record.
    /// </summary>
    [IsoId("_yv3kB69fEeen6L7OP7lnvg")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ActiveOrHistoricCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Set of elements used to provide details on the tax period and amount.
    /// </summary>
    [IsoId("_yv3kCa9fEeen6L7OP7lnvg")]
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public TaxRecordDetails2? Details { get; init; }
}
