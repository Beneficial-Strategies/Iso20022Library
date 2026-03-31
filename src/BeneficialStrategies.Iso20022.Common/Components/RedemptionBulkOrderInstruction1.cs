// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a redemption bulk order.
/// </summary>
[IsoId("_U2kratp-Ed-ak6NoX_4Aeg_1088875951")]
[DisplayName("Redemption Bulk Order Instruction")]
public record RedemptionBulkOrderInstruction1
{
    /// <summary>
    /// Common information related to all the orders.
    /// </summary>
    [IsoId("_U2ucYNp-Ed-ak6NoX_4Aeg_611069175")]
    [DisplayName("Bulk Order Details")]
    [IsoXmlTag("BlkOrdrDtls")]
    public required RedemptionBulkOrder2 BulkOrderDetails { get; init; }

    /// <summary>
    /// Information related to an intermediary.
    /// </summary>
    [IsoId("_U2ucYdp-Ed-ak6NoX_4Aeg_956464123")]
    [DisplayName("Intermediary Details")]
    [IsoXmlTag("IntrmyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary4> IntermediaryDetails { get; init; } = [];

    /// <summary>
    /// Message is a copy.
    /// </summary>
    [IsoId("_U2ucYtp-Ed-ak6NoX_4Aeg_954618121")]
    [DisplayName("Copy Details")]
    [IsoXmlTag("CpyDtls")]
    public CopyInformation1? CopyDetails { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_U2ucY9p-Ed-ak6NoX_4Aeg_-256538472")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public ValueList<Extension1> Extension { get; init; } = [];
}
