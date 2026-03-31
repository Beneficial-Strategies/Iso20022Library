// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reporting per financial instrument.
/// </summary>
[IsoId("_LTEOugVVEeqjd8n6wD9JVw")]
[DisplayName("Financial Instrument Details")]
public record FinancialInstrumentDetails36
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_LTEOvgVVEeqjd8n6wD9JVw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_LTEOxgVVEeqjd8n6wD9JVw")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes95? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    [IsoId("_LTEOzgVVEeqjd8n6wD9JVw")]
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public ValueList<IntraPositionDetails54> SubBalance { get; init; } = [];
    // ID for the above is _LTEOzgVVEeqjd8n6wD9JVw
}
