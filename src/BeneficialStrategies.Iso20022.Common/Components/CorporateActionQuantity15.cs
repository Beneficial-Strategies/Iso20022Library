// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the quantity of securities related to a corporate action option.
/// </summary>
[IsoId("_JDUOwaj7EfCG_LQaXOxwew")]
[DisplayName("Corporate Action Quantity15")]
public record CorporateActionQuantity15
{
    /// <summary>
    /// Maximum number of securities that can be instructed.
    /// </summary>
    [IsoId("_JDUOxaj7EfCG_LQaXOxwew")]
    [DisplayName("Maximum Quantity")]
    [IsoXmlTag("MaxQty")]
    public FinancialInstrumentQuantity34Choice? MaximumQuantity { get; init; }

    /// <summary>
    /// Minimum number of securities that must be instructed.
    /// </summary>
    [IsoId("_JDUOyaj7EfCG_LQaXOxwew")]
    [DisplayName("Minimum Quantity Sought")]
    [IsoXmlTag("MinQtySght")]
    public FinancialInstrumentQuantity34Choice? MinimumQuantitySought { get; init; }

    /// <summary>
    /// New board lot quantity of shares.
    /// </summary>
    [IsoId("_JDUOzaj7EfCG_LQaXOxwew")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity35Choice? NewBoardLotQuantity { get; init; }

    /// <summary>
    /// New denomination quantity of shares.
    /// </summary>
    [IsoId("_JDUO0aj7EfCG_LQaXOxwew")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity35Choice? NewDenominationQuantity { get; init; }

    /// <summary>
    /// Base denomination of securities.
    /// </summary>
    [IsoId("_JDUO1aj7EfCG_LQaXOxwew")]
    [DisplayName("Base Denomination")]
    [IsoXmlTag("BaseDnmtn")]
    public FinancialInstrumentQuantity35Choice? BaseDenomination { get; init; }

    /// <summary>
    /// Incremental denomination of securities.
    /// </summary>
    [IsoId("_JDUO2aj7EfCG_LQaXOxwew")]
    [DisplayName("Incremental Denomination")]
    [IsoXmlTag("IncrmtlDnmtn")]
    public FinancialInstrumentQuantity35Choice? IncrementalDenomination { get; init; }

    /// <summary>
    /// Quantity of securities called.
    /// </summary>
    [IsoId("_JDUO3aj7EfCG_LQaXOxwew")]
    [DisplayName("Security Called Quantity")]
    [IsoXmlTag("SctyClldQty")]
    public FinancialInstrumentQuantity35Choice? SecurityCalledQuantity { get; init; }

    /// <summary>
    /// New quantity of securities outstanding after the event.
    /// </summary>
    [IsoId("_JDUO4aj7EfCG_LQaXOxwew")]
    [DisplayName("New Outstanding Quantity")]
    [IsoXmlTag("NewOutsdngQty")]
    public FinancialInstrumentQuantity35Choice? NewOutstandingQuantity { get; init; }

    /// <summary>
    /// Total quantity of securities outstanding.
    /// </summary>
    [IsoId("_JDUO5aj7EfCG_LQaXOxwew")]
    [DisplayName("Total Outstanding Quantity")]
    [IsoXmlTag("TtlOutsdngQty")]
    public FinancialInstrumentQuantity35Choice? TotalOutstandingQuantity { get; init; }
}
