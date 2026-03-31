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
[IsoId("_c5S3i5KQEeWHWpTQn1FFVg")]
[DisplayName("Corporate Action Quantity")]
public record CorporateActionQuantity8
{
    /// <summary>
    /// The maximum number of securities the offeror/issuer is ready to purchase or redeem. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_c5S3j5KQEeWHWpTQn1FFVg")]
    [DisplayName("Maximum Quantity")]
    [IsoXmlTag("MaxQty")]
    public FinancialInstrumentQuantity21Choice_? MaximumQuantity { get; init; }

    /// <summary>
    /// Minimum quantity of securities the offeror/issuer is ready to purchase or redeem under the terms of the event. This can be a number or the term &quot;any and all&quot;.
    /// </summary>
    [IsoId("_c5S3l5KQEeWHWpTQn1FFVg")]
    [DisplayName("Minimum Quantity Sought")]
    [IsoXmlTag("MinQtySght")]
    public FinancialInstrumentQuantity21Choice_? MinimumQuantitySought { get; init; }

    /// <summary>
    /// Quantity of equity that makes up the new board lot.
    /// </summary>
    [IsoId("_c5S3n5KQEeWHWpTQn1FFVg")]
    [DisplayName("New Board Lot Quantity")]
    [IsoXmlTag("NewBrdLotQty")]
    public FinancialInstrumentQuantity22Choice_? NewBoardLotQuantity { get; init; }

    /// <summary>
    /// New denomination of the equity following, for example, an increase or decrease in nominal value.
    /// </summary>
    [IsoId("_c5S3p5KQEeWHWpTQn1FFVg")]
    [DisplayName("New Denomination Quantity")]
    [IsoXmlTag("NewDnmtnQty")]
    public FinancialInstrumentQuantity22Choice_? NewDenominationQuantity { get; init; }

    /// <summary>
    /// Minimum integral amount of securities that each account owner must have remaining after the called amounts are applied.
    /// </summary>
    [IsoId("_c5S3r5KQEeWHWpTQn1FFVg")]
    [DisplayName("Base Denomination")]
    [IsoXmlTag("BaseDnmtn")]
    public FinancialInstrumentQuantity22Choice_? BaseDenomination { get; init; }

    /// <summary>
    /// Amount used when the called amount is not met by running the lottery with the base denomination.
    /// </summary>
    [IsoId("_c5S3t5KQEeWHWpTQn1FFVg")]
    [DisplayName("Incremental Denomination")]
    [IsoXmlTag("IncrmtlDnmtn")]
    public FinancialInstrumentQuantity22Choice_? IncrementalDenomination { get; init; }
}
