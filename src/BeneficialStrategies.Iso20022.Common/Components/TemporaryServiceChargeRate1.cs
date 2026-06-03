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
    [IsoId("_O_NroVXcEfC0lMwgjvMClw-typ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TemporaryServicesCharge2Code? Type { get; init; }

    [IsoId("_O_NroVXcEfC0lMwgjvMClw-rate")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public ImpliedCurrencyAndAmount? Rate { get; init; }

    [IsoId("_O_NroVXcEfC0lMwgjvMClw-hrs")]
    [DisplayName("Hours")]
    [IsoXmlTag("Hrs")]
    public IsoMax6NumericText? Hours { get; init; }
}
