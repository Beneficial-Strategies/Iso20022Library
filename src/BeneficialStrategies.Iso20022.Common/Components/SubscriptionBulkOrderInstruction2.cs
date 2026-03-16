// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a subscription bulk order.
/// </summary>
[IsoId("_RN-NBdp-Ed-ak6NoX_4Aeg_-836639222")]
[DisplayName("Subscription Bulk Order Instruction")]
public record SubscriptionBulkOrderInstruction2
{
    /// <summary>
    /// Common information related to all the orders to be cancelled.
    /// </summary>
    [IsoId("_RN-NBtp-Ed-ak6NoX_4Aeg_-836639101")]
    [DisplayName("Bulk Order Details")]
    [IsoXmlTag("BlkOrdrDtls")]
    public required SubscriptionBulkOrder3 BulkOrderDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RN-NB9p-Ed-ak6NoX_4Aeg_-836639136")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RN-NCNp-Ed-ak6NoX_4Aeg_-836639196")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
