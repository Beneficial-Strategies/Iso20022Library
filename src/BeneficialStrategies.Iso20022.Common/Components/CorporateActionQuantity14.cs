// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies corporate action quantities.
/// </summary>
[IsoId("_p4XbMzi7Eeydid5dcNPKvg")]
[DisplayName("Corporate Action Quantity")]
public record CorporateActionQuantity14
{
    /// <summary>
    /// The maximum number of securities the offeror/issuer is ready to purchase or redeem. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_p4XbOTi7Eeydid5dcNPKvg")]
    [DisplayName("Maximum Quantity")]
    [IsoXmlTag("MaxQty")]
    public FinancialInstrumentQuantity44Choice_? MaximumQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of securities the offeror/issuer is ready to purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_p4XbQTi7Eeydid5dcNPKvg")]
    [DisplayName("Minimum Quantity Sought")]
    [IsoXmlTag("MinQtySght")]
    public FinancialInstrumentQuantity44Choice_? MinimumQuantitySought { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_p4XbSTi7Eeydid5dcNPKvg")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity43Choice_? NewBoardLotQuantity { get; init; }

    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_p4XbUTi7Eeydid5dcNPKvg")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity43Choice_? NewDenominationQuantity { get; init; }

    /// <summary>
    /// Minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    [IsoId("_p4XbWTi7Eeydid5dcNPKvg")]
    [DisplayName("Base Denomination")]
    [IsoXmlTag("BaseDnmtn")]
    public FinancialInstrumentQuantity43Choice_? BaseDenomination { get; init; }

    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    [IsoId("_p4XbYTi7Eeydid5dcNPKvg")]
    [DisplayName("Incremental Denomination")]
    [IsoXmlTag("IncrmtlDnmtn")]
    public FinancialInstrumentQuantity43Choice_? IncrementalDenomination { get; init; }
}
