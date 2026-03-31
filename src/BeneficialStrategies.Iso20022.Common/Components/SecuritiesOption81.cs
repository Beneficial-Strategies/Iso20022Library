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
[IsoId("_k37ZsRu0EeyhRdHRjakS2w")]
[DisplayName("Securities Option")]
public record SecuritiesOption81
{
    /// <summary>
    /// Maximum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_lMyPYRu0EeyhRdHRjakS2w")]
    [DisplayName("Maximum Quantity To Instruct")]
    [IsoXmlTag("MaxQtyToInst")]
    public FinancialInstrumentQuantity34Choice_? MaximumQuantityToInstruct { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_lMyPaRu0EeyhRdHRjakS2w")]
    [DisplayName("Minimum Quantity To Instruct")]
    [IsoXmlTag("MinQtyToInst")]
    public FinancialInstrumentQuantity34Choice_? MinimumQuantityToInstruct { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_lMyPcRu0EeyhRdHRjakS2w")]
    [DisplayName("Minimum Multiple Quantity To Instruct")]
    [IsoXmlTag("MinMltplQtyToInst")]
    public FinancialInstrumentQuantity35Choice_? MinimumMultipleQuantityToInstruct { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_lMyPeRu0EeyhRdHRjakS2w")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity35Choice_? NewBoardLotQuantity { get; init; }

    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_lMyPgRu0EeyhRdHRjakS2w")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity35Choice_? NewDenominationQuantity { get; init; }

    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_lMyPiRu0EeyhRdHRjakS2w")]
    [DisplayName("Front End Odd Lot Quantity")]
    [IsoXmlTag("FrntEndOddLotQty")]
    public FinancialInstrumentQuantity35Choice_? FrontEndOddLotQuantity { get; init; }

    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_lMyPkRu0EeyhRdHRjakS2w")]
    [DisplayName("Back End Odd Lot Quantity")]
    [IsoXmlTag("BckEndOddLotQty")]
    public FinancialInstrumentQuantity35Choice_? BackEndOddLotQuantity { get; init; }
}
