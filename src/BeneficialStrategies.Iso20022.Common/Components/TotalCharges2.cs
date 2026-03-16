// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Total amount of charges.
/// </summary>
[IsoId("_VI5xiNp-Ed-ak6NoX_4Aeg_-463850161")]
[DisplayName("Total Charges")]
public record TotalCharges2
{
    /// <summary>
    /// Total value of the charges for a specific order.
    /// </summary>
    [IsoId("_VI5xidp-Ed-ak6NoX_4Aeg_-463850125")]
    [DisplayName("Total Amount Of Charges")]
    [IsoXmlTag("TtlAmtOfChrgs")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCharges { get; init; }

    /// <summary>
    /// Information related to a specific charge.
    /// </summary>
    [IsoId("_VI5xitp-Ed-ak6NoX_4Aeg_-463850083")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge10> ChargeDetails { get; init; } = [];
    // ID for the above is _VI5xitp-Ed-ak6NoX_4Aeg_-463850083
}
