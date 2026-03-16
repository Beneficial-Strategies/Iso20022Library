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
[IsoId("_RttdDNp-Ed-ak6NoX_4Aeg_-26727186")]
[DisplayName("Total Charges")]
public record TotalCharges3
{
    /// <summary>
    /// Total value of the charges for a specific order.
    /// </summary>
    [IsoId("_RttdDdp-Ed-ak6NoX_4Aeg_-26725711")]
    [DisplayName("Total Amount Of Charges")]
    [IsoXmlTag("TtlAmtOfChrgs")]
    public ActiveCurrencyAnd13DecimalAmount? TotalAmountOfCharges { get; init; }

    /// <summary>
    /// Information related to a specific charge.
    /// </summary>
    [IsoId("_RttdDtp-Ed-ak6NoX_4Aeg_-26724668")]
    [DisplayName("Charge Details")]
    [IsoXmlTag("ChrgDtls")]
    public ValueList<Charge18> ChargeDetails { get; init; } = [];
    // ID for the above is _RttdDtp-Ed-ak6NoX_4Aeg_-26724668
}
