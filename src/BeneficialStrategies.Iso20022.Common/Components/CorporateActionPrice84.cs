// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price84.
/// </summary>
[IsoId("_DcqX4YV6Ee-oeNhl-Tk6YQ")]
[DisplayName("Corporate Action Price84")]
public record CorporateActionPrice84
{
    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat77Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Over Subscription Deposit Price.
    /// </summary>
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat77Choice_? OverSubscriptionDepositPrice { get; init; }
}
