// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction151.
/// </summary>
[IsoId("_zv4fURwMEe6O0NdiBuX__w")]
[DisplayName("Payment Transaction151")]
public record PaymentTransaction151
{
    /// <summary>
    /// Payment Instrument.
    /// </summary>
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument26Choice_ PaymentInstrument { get; init; }
}
