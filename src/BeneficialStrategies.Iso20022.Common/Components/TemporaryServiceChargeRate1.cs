// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Charge rate for a temporary service.
/// </summary>
[IsoId("_O_NroVXcEfC0lMwgjvMClw")]
[DisplayName("Temporary Service Charge Rate1")]
public record TemporaryServiceChargeRate1
{
    /// <summary>
    /// Type of hours worked. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_O_NroVXcEfC0lMwgjvMClw-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TemporaryServicesCharge2Code? Type { get; init; }

    /// <summary>
    /// Contains the rate per hour.
    /// </summary>
    [IsoId("_O_NroVXcEfC0lMwgjvMClw-rate")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public ImpliedCurrencyAndAmount? Rate { get; init; }

    /// <summary>
    /// Contains the number of hours worked.
    /// </summary>
    [IsoId("_O_NroVXcEfC0lMwgjvMClw-hrs")]
    [DisplayName("Hours")]
    [IsoXmlTag("Hrs")]
    public IsoMax6NumericText? Hours { get; init; }
}
