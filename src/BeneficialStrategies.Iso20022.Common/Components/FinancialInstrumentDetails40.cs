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
[IsoId("_59ea0SgPEeym1_Zp1BTvEw")]
[DisplayName("Financial Instrument Details")]
public record FinancialInstrumentDetails40
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_6TYZYygPEeym1_Zp1BTvEw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Elements characterising a financial instrument.
    /// </summary>
    [IsoId("_6TYZaygPEeym1_Zp1BTvEw")]
    [DisplayName("Financial Instrument Attributes")]
    [IsoXmlTag("FinInstrmAttrbts")]
    public FinancialInstrumentAttributes112? FinancialInstrumentAttributes { get; init; }

    /// <summary>
    /// Identification of the sub-balance.
    /// </summary>
    [IsoId("_6TYZcygPEeym1_Zp1BTvEw")]
    [DisplayName("Sub Balance")]
    [IsoXmlTag("SubBal")]
    public ValueList<IntraPositionDetails57> SubBalance { get; init; } = [];
    // ID for the above is _6TYZcygPEeym1_Zp1BTvEw
}
