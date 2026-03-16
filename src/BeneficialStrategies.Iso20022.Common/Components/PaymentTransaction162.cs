// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment Transaction162.
/// </summary>
[IsoId("_4-kKwxwMEe6O0NdiBuX__w")]
[DisplayName("Payment Transaction162")]
public partial record PaymentTransaction162
{
    #nullable enable

    /// <summary>
    /// Payment Instrument.
    /// </summary>
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument27Choice_ PaymentInstrument { get; init; } 

    
    #nullable disable
    
}
