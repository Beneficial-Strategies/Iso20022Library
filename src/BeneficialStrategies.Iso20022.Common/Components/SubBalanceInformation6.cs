// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_QYU-d9p-Ed-ak6NoX_4Aeg_1429230934")]
[DisplayName("Sub Balance Information")]
public record SubBalanceInformation6
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_QYU-eNp-Ed-ak6NoX_4Aeg_367878975")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType5Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_QYU-edp-Ed-ak6NoX_4Aeg_254039909")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity3Choice_ Quantity { get; init; }

    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [IsoId("_QYU-etp-Ed-ak6NoX_4Aeg_432158581")]
    [DisplayName("Sub Balance Additional Details")]
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; }

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_QYeIYNp-Ed-ak6NoX_4Aeg_-564913772")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public ValueList<AdditionalBalanceInformation6> AdditionalBalanceBreakdownDetails { get; init; } =
        [];
}
