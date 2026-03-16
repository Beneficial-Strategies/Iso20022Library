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
[IsoId("_UG466tp-Ed-ak6NoX_4Aeg_1242573777")]
[DisplayName("Securities Option")]
public record SecuritiesOption1
{
    /// <summary>
    /// Maximum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_UG4669p-Ed-ak6NoX_4Aeg_-2127502252")]
    [DisplayName("Maximum Exercisable Quantity")]
    [IsoXmlTag("MaxExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MaximumExercisableQuantity { get; init; }

    /// <summary>
    /// Minimum quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_UHCr4Np-Ed-ak6NoX_4Aeg_307238286")]
    [DisplayName("Minimum Exercisable Quantity")]
    [IsoXmlTag("MinExrcblQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableQuantity { get; init; }

    /// <summary>
    /// Minimum multiple quantity (or lot) of financial instrument that must be exercised or tendered.
    /// </summary>
    [IsoId("_UHCr4dp-Ed-ak6NoX_4Aeg_311856464")]
    [DisplayName("Minimum Exercisable Multiple Quantity")]
    [IsoXmlTag("MinExrcblMltplQty")]
    public FinancialInstrumentQuantity1Choice_? MinimumExercisableMultipleQuantity { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_UHCr4tp-Ed-ak6NoX_4Aeg_362647221")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity1Choice_? NewBoardLotQuantity { get; init; }

    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_UHCr49p-Ed-ak6NoX_4Aeg_380197264")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity1Choice_? NewDenominationQuantity { get; init; }

    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_UHCr5Np-Ed-ak6NoX_4Aeg_-1576913223")]
    [DisplayName("Front End Odd Lot Quantity")]
    [IsoXmlTag("FrntEndOddLotQty")]
    public FinancialInstrumentQuantity2Choice_? FrontEndOddLotQuantity { get; init; }

    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_UHCr5dp-Ed-ak6NoX_4Aeg_1720981720")]
    [DisplayName("Back End Odd Lot Quantity")]
    [IsoXmlTag("BckEndOddLotQty")]
    public FinancialInstrumentQuantity2Choice_? BackEndOddLotQuantity { get; init; }
}
