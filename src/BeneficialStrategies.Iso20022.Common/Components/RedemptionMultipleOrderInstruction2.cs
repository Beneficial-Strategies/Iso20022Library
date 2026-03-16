// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a redemption multiple order.
/// </summary>
[IsoId("_RO291dp-Ed-ak6NoX_4Aeg_-632605196")]
[DisplayName("Redemption Multiple Order Instruction")]
public record RedemptionMultipleOrderInstruction2
{
    /// <summary>
    /// General information related to the order.
    /// </summary>
    [IsoId("_RO291tp-Ed-ak6NoX_4Aeg_-632605014")]
    [DisplayName("Multiple Order Details")]
    [IsoXmlTag("MltplOrdrDtls")]
    public required RedemptionMultipleOrder3 MultipleOrderDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RO2919p-Ed-ak6NoX_4Aeg_-632605134")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary8> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RO292Np-Ed-ak6NoX_4Aeg_-632605169")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
