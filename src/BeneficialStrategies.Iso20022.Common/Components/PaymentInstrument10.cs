// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
[IsoId("_ZwdwcRQxEeKebsB9eKJSkA")]
[DisplayName("Payment Instrument")]
public partial record PaymentInstrument10
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    [IsoId("_aFLcPRQxEeKebsB9eKJSkA")]
    [DisplayName("Settlement Currency")]
    [IsoXmlTag("SttlmCcy")]
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    
    /// <summary>
    /// Choice of payment instruments.
    /// </summary>
    [IsoId("_95deABdJEeK5g-3oYI0_9Q")]
    [DisplayName("Payment Instrument")]
    [IsoXmlTag("PmtInstrm")]
    public required PaymentInstrument16Choice_ PaymentInstrument { get; init; } 
    
    /// <summary>
    /// Percentage of the dividend payment not to be reinvested.
    /// </summary>
    [IsoId("_kPDPMBQxEeKebsB9eKJSkA")]
    [DisplayName("Dividend Percentage")]
    [IsoXmlTag("DvddPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageBoundedRate)]
    public IsoPercentageBoundedRate? DividendPercentage { get; init; } 
    
    
    #nullable disable
    
}
