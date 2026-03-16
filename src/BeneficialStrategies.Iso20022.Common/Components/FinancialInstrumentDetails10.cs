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
[IsoId("_mKkkMf7xEeCvPoRGOxRobQ")]
[DisplayName("Financial Instrument Details")]
public record FinancialInstrumentDetails10
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_mKkkN_7xEeCvPoRGOxRobQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_mKkkQf7xEeCvPoRGOxRobQ")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes36? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    [IsoId("_mKkkS_7xEeCvPoRGOxRobQ")]
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public ValueList<IntraPositionDetails20> SubBalance { get; init; } = [];
    // ID for the above is _mKkkS_7xEeCvPoRGOxRobQ
}
