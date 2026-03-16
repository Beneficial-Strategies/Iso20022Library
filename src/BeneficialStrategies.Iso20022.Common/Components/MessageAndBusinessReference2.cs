// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the message reference of the message for which the status is requested and the business reference of the order.
/// </summary>
[IsoId("_UvH_lNp-Ed-ak6NoX_4Aeg_-1303328661")]
[DisplayName("Message And Business Reference")]
public record MessageAndBusinessReference2
{
    /// <summary>
    /// Reference to a linked message sent in a proprietary way or reference of a system.
    /// </summary>
    [IsoId("_UvH_ldp-Ed-ak6NoX_4Aeg_1913296890")]
    [DisplayName("Other Reference")]
    [IsoXmlTag("OthrRef")]
    public required AdditionalReference3 OtherReference { get; init; }

    /// <summary>
    /// Reference to a linked message that was previously sent.
    /// </summary>
    [IsoId("_UvH_ltp-Ed-ak6NoX_4Aeg_1585446487")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required AdditionalReference3 PreviousReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for an order, as assigned by the instructing party.
    /// </summary>
    [IsoId("_UvH_l9p-Ed-ak6NoX_4Aeg_-1275621169")]
    [DisplayName("Individual Order Reference")]
    [IsoXmlTag("IndvOrdrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? IndividualOrderReference { get; init; }

    /// <summary>
    /// Account information of the order message for which the status is requested.
    /// </summary>
    [IsoId("_UvH_mNp-Ed-ak6NoX_4Aeg_608688577")]
    [DisplayName("Investment Account")]
    [IsoXmlTag("InvstmtAcct")]
    public InvestmentAccount13? InvestmentAccount { get; init; }
}
