// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Financial Instrument Details47.
/// </summary>
[IsoId("_m75jsYybEe-PVZsedaAGaA")]
[DisplayName("Financial Instrument Details47")]
public record FinancialInstrumentDetails47
{
    /// <summary>
    /// Financial Instrument Attributes.
    /// </summary>
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes112? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Financial Instrument Identification.
    /// </summary>
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Sub Balance.
    /// </summary>
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public ValueList<IntraPositionDetails66> SubBalance { get; init; } = [];
}
