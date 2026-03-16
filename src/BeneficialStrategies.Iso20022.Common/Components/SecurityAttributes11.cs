// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tangible items of value to a business.
/// </summary>
[IsoId("_P-BGdZJKEeuAlLVx8pyt3w")]
[DisplayName("Security Attributes")]
public record SecurityAttributes11
{
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_QAKbgZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Provides additional details about the financial instrument.
    /// </summary>
    [IsoId("_QAKbg5JKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Type")]
    [IsoXmlTag("FinInstrmTp")]
    public FinancialInstrument97? FinancialInstrumentType { get; init; }

    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_QAKbhZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public CommonFinancialInstrumentAttributes11? FinancialInstrumentAttributes { get; init; }
}
