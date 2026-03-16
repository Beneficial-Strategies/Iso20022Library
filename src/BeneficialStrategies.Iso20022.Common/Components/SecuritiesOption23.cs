// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the security option of a corporate event.
/// </summary>
[IsoId("_4_WVcfmZEeCju-AyqEOrHg")]
[DisplayName("Securities Option")]
public record SecuritiesOption23
{
    /// <summary>
    /// Maximum quantity (or lot) of financial instrument that may be exercised or tendered.
    /// </summary>
    [IsoId("_4_WVe_mZEeCju-AyqEOrHg")]
    [DisplayName("Maximum Exercisable Quantity")]
    [IsoXmlTag("MaxExrcblQty")]
    public FinancialInstrumentQuantity19Choice_? MaximumExercisableQuantity { get; init; }

    /// <summary>
    /// Minimum quantity (or lot) of financial instrument that may be exercised or tendered.
    /// </summary>
    [IsoId("_4_WVhfmZEeCju-AyqEOrHg")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity19Choice_? MinimumExercisableQuantity { get; init; }

    /// <summary>
    /// Minimum multiple quantity (or lot) of financial instrument that may be exercised or tendered.
    /// </summary>
    [IsoId("_4_WVj_mZEeCju-AyqEOrHg")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    [IsoXmlTag("MinExrcblMltplQty")]
    public FinancialInstrumentQuantity20Choice_? MinimumExercisableMultipleQuantity { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_4_WVmfmZEeCju-AyqEOrHg")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity20Choice_? NewBoardLotQuantity { get; init; }

    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_4_WVo_mZEeCju-AyqEOrHg")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity20Choice_? NewDenominationQuantity { get; init; }

    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_4_WVrfmZEeCju-AyqEOrHg")]
    [DisplayName("Front End Odd Lot Quantity")]
    [IsoXmlTag("FrntEndOddLotQty")]
    public FinancialInstrumentQuantity20Choice_? FrontEndOddLotQuantity { get; init; }

    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_4_WVt_mZEeCju-AyqEOrHg")]
    [DisplayName("Back End Odd Lot Quantity")]
    [IsoXmlTag("BckEndOddLotQty")]
    public FinancialInstrumentQuantity20Choice_? BackEndOddLotQuantity { get; init; }
}
