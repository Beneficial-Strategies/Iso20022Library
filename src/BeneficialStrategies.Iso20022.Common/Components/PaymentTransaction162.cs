// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction162.
/// </summary>
[IsoId("_4-kKwxwMEe6O0NdiBuX__w")]
[DisplayName("Payment Transaction162")]
public record PaymentTransaction162
{
    /// <summary>
    /// Payment Instrument.
    /// </summary>
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument27Choice_ PaymentInstrument { get; init; }
}
