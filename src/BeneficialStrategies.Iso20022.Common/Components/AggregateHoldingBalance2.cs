// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Overall holding position, in a single financial instrument, held in a securities account at a specified place of safekeeping.
/// </summary>
[IsoId("_WsYrlIjiEeONZKAAW4pOaQ")]
[DisplayName("Aggregate Holding Balance")]
public record AggregateHoldingBalance2
{
    /// <summary>
    /// Identification of the financial instrument for which the balance information is specified.
    /// </summary>
    [IsoId("_WsYrl4jiEeONZKAAW4pOaQ")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Balance breakdown on the net position of a financial instrument.
    /// </summary>
    [IsoId("_WsYrlojiEeONZKAAW4pOaQ")]
    [DisplayName("Balance For Financial Instrument")]
    [IsoXmlTag("BalForFinInstrm")]
    public ValueList<FinancialInstrumentAggregateBalance1> BalanceForFinancialInstrument { get; init; } =
        [];

    // ID for the above is _WsYrlojiEeONZKAAW4pOaQ

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_gDcioaB9EeOEyO7fCl8lLA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
