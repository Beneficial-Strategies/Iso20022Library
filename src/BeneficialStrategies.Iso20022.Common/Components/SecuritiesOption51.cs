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
[IsoId("_m2kq4UEJEeWVgfuHGaKtRQ")]
[DisplayName("Securities Option")]
public record SecuritiesOption51
{
    /// <summary>
    /// Maximum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_nDqrtUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Maximum Quantity To Instruct")]
    [IsoXmlTag("MaxQtyToInst")]
    public FinancialInstrumentQuantity19Choice_? MaximumQuantityToInstruct { get; init; }

    /// <summary>
    /// Minimum quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_nDqrvUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Minimum Quantity To Instruct")]
    [IsoXmlTag("MinQtyToInst")]
    public FinancialInstrumentQuantity19Choice_? MinimumQuantityToInstruct { get; init; }

    /// <summary>
    /// Minimum multiple quantity of financial instrument that may be instructed.
    /// </summary>
    [IsoId("_nDqrxUEJEeWVgfuHGaKtRQ")]
    [DisplayName("Minimum Multiple Quantity To Instruct")]
    [IsoXmlTag("MinMltplQtyToInst")]
    public FinancialInstrumentQuantity20Choice_? MinimumMultipleQuantityToInstruct { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_nDqrzUEJEeWVgfuHGaKtRQ")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity20Choice_? NewBoardLotQuantity { get; init; }

    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_nDqr1UEJEeWVgfuHGaKtRQ")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity20Choice_? NewDenominationQuantity { get; init; }

    /// <summary>
    /// Specifies that if an order is prorated holders of odd lots who tender their full position will not have tendered position prorated but rather accepted in full.
    /// </summary>
    [IsoId("_nDqr3UEJEeWVgfuHGaKtRQ")]
    [DisplayName("Front End Odd Lot Quantity")]
    [IsoXmlTag("FrntEndOddLotQty")]
    public FinancialInstrumentQuantity20Choice_? FrontEndOddLotQuantity { get; init; }

    /// <summary>
    /// Represents the presence of a back end odd lot provision and the quantity of equity required after proration to be eligible for this privilege.
    /// </summary>
    [IsoId("_nDqr5UEJEeWVgfuHGaKtRQ")]
    [DisplayName("Back End Odd Lot Quantity")]
    [IsoXmlTag("BckEndOddLotQty")]
    public FinancialInstrumentQuantity20Choice_? BackEndOddLotQuantity { get; init; }
}
