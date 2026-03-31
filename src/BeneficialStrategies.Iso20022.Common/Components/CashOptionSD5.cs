// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
[IsoId("_1fvcIjL3EeKU9IrkkToqcw_-1926320982")]
[DisplayName("Cash Option SD")]
public record CashOptionSD5
{
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1fvcIzL3EeKU9IrkkToqcw_-962139710")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; }

    /// <summary>
    /// Unique number associated with a payout within an option.
    /// </summary>
    [IsoId("_1fvcJDL3EeKU9IrkkToqcw_1452521946")]
    [DisplayName("Payout Number")]
    [IsoXmlTag("PyoutNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    public required IsoExact3NumericText PayoutNumber { get; init; }

    /// <summary>
    /// Describes the type of payout associated with the event.
    /// </summary>
    [IsoId("_1fvcJTL3EeKU9IrkkToqcw_341610527")]
    [DisplayName("Payout Type")]
    [IsoXmlTag("PyoutTp")]
    public required DTCCPayoutType1Code PayoutType { get; init; }

    /// <summary>
    /// Workflow status of the payout.
    /// </summary>
    [IsoId("_1fvcJjL3EeKU9IrkkToqcw_1640647389")]
    [DisplayName("Payout Status")]
    [IsoXmlTag("PyoutSts")]
    public required WorkflowStatus1Code PayoutStatus { get; init; }

    /// <summary>
    /// Maximum withholding rate based on the country of the sourced income.
    /// </summary>
    [IsoId("_1f4mEDL3EeKU9IrkkToqcw_836812695")]
    [DisplayName("Maximum Withholding Tax Percentage")]
    [IsoXmlTag("MaxWhldgTaxPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? MaximumWithholdingTaxPercentage { get; init; }
}
