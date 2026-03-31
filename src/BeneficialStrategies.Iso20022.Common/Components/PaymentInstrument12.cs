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
[IsoId("_g7QKsRRfEeOKWo1NF21OVw")]
[DisplayName("Payment Instrument")]
public record PaymentInstrument12
{
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_hTMwoxRfEeOKWo1NF21OVw")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; }

    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [IsoId("_hTMwpRRfEeOKWo1NF21OVw")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument16Choice_ PaymentInstrument { get; init; }

    /// <summary>
    /// Percentage of the dividend payment not to be reinvested, that is, to be paid in cash.
    /// </summary>
    [IsoId("_hTMwpxRfEeOKWo1NF21OVw")]
    [DisplayName("Dividend Percentage")]
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    public IsoPercentageBoundedRate? DividendPercentage { get; init; }
}
