// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example sub-balance per status.
/// </summary>
[IsoId("_LNcYgTnGEeWV5sr121Fc8A")]
[DisplayName("Sub Balance Information")]
public record SubBalanceInformation14
{
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_LsPNRznGEeWV5sr121Fc8A")]
    [DisplayName("Sub Balance Type")]
    [IsoXmlTag("SubBalTp")]
    public required SubBalanceType11Choice_ SubBalanceType { get; init; }

    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_LsPNTznGEeWV5sr121Fc8A")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required SubBalanceQuantity6Choice_ Quantity { get; init; }

    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [IsoId("_LsPNVznGEeWV5sr121Fc8A")]
    [DisplayName("Sub Balance Additional Details")]
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? SubBalanceAdditionalDetails { get; init; }

    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_LsPNXznGEeWV5sr121Fc8A")]
    [DisplayName("Additional Balance Breakdown Details")]
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    public ValueList<AdditionalBalanceInformation14> AdditionalBalanceBreakdownDetails { get; init; } =
        [];
}
