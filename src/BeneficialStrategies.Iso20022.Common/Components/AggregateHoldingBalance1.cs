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
[IsoId("_-x81hmZ5EeSPkYKcdPbJxw")]
[DisplayName("Aggregate Holding Balance")]
public record AggregateHoldingBalance1
{
    /// <summary>
    /// Identification of the financial instrument for which the balance information is specified.
    /// </summary>
    [IsoId("_-x81iGZ5EeSPkYKcdPbJxw")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification19 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Form of ownership of the holding.
    /// </summary>
    [IsoId("_-x81iWZ5EeSPkYKcdPbJxw")]
    [DisplayName("Holding Form")]
    [IsoXmlTag("HldgForm")]
    public FormOfSecurity1Code? HoldingForm { get; init; }

    /// <summary>
    /// Specifies whether the holding is physically delivered or is a book entry only.
    /// </summary>
    [IsoId("_-x81i2Z5EeSPkYKcdPbJxw")]
    [DisplayName("Holding Physical Type")]
    [IsoXmlTag("HldgPhysTp")]
    public PhysicalTransferType1Code? HoldingPhysicalType { get; init; }

    /// <summary>
    /// Balance breakdown on the net position of the financial instrument.
    /// </summary>
    [IsoId("_-x81imZ5EeSPkYKcdPbJxw")]
    [DisplayName("Balance For Financial Instrument")]
    [IsoXmlTag("BalForFinInstrm")]
    public ValueList<FinancialInstrumentAggregateBalance1> BalanceForFinancialInstrument { get; init; } =
        [];

    // ID for the above is _-x81imZ5EeSPkYKcdPbJxw

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_-x81h2Z5EeSPkYKcdPbJxw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
