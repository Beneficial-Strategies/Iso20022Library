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
[IsoId("bbb29f63-3e09-4224-a614-22f18a7abe05")]
[DisplayName("Charge33")]
public record Charge33
{
    /// <summary>
    /// Type of service for which a charge is asked or paid.
    /// </summary>
    [IsoId("beeaad6d-ef37-44ac-8e24-cc9361fd5fa2")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required ChargeType11Choice_ Type { get; init; }

    /// <summary>
    /// Amount of money asked or paid for the charge.
    /// </summary>
    [IsoId("86436412-ec30-4811-a092-3a01d23568cd")]
    [DisplayName("Charges Fees")]
    [IsoXmlTag("ChrgsFees")]
    public required PriceRateOrAmount3Choice_ ChargesFees { get; init; }

    /// <summary>
    /// Calculation basis for the charge or fee.
    /// </summary>
    [IsoId("eca67237-3e1a-4655-9028-d2e8997b693b")]
    [DisplayName("Calculation Basis")]
    [IsoXmlTag("ClctnBsis")]
    public CalculationBasis2Choice_? CalculationBasis { get; init; }
}
