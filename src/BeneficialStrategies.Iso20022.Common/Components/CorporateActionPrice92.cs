// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Corporate Action Price92.
/// </summary>
[IsoId("_kv5-4Zt3Ee-wQIOX0djF2w")]
[DisplayName("Corporate Action Price92")]
public record CorporateActionPrice92
{
    /// <summary>
    /// Cash In Lieu Of Share Price.
    /// </summary>
    [DisplayName("Cash In Lieu Of Share Price")]
    [IsoXmlTag("CshInLieuOfShrPric")]
    public PriceFormat85Choice_? CashInLieuOfSharePrice { get; init; }

    /// <summary>
    /// Over Subscription Deposit Price.
    /// </summary>
    [DisplayName("Over Subscription Deposit Price")]
    [IsoXmlTag("OverSbcptDpstPric")]
    public PriceFormat85Choice_? OverSubscriptionDepositPrice { get; init; }
}
