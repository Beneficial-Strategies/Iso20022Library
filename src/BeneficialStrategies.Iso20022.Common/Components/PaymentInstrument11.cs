// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
[IsoId("_jKdmcRc2EeK5g-3oYI0_9Q")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument11
{
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_jf65HRc2EeK5g-3oYI0_9Q")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; }

    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [IsoId("_XWHl8BdHEeK5g-3oYI0_9Q")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument17Choice_ PaymentInstrument { get; init; }
}
