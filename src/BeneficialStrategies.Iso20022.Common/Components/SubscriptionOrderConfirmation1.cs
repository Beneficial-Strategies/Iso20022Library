// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Order confirmation details.
/// </summary>
[IsoId("_RNqrENp-Ed-ak6NoX_4Aeg_-910205350")]
[DisplayName("Subscription Order Confirmation")]
public record SubscriptionOrderConfirmation1
{
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_RN0cANp-Ed-ak6NoX_4Aeg_-1268607948")]
    [DisplayName("Amendment Indicator")]
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator AmendmentIndicator { get; init; }

    /// <summary>
    /// General information related to the execution of investment fund order.
    /// </summary>
    [IsoId("_RN0cAdp-Ed-ak6NoX_4Aeg_-909279847")]
    [DisplayName("Multiple Execution Details")]
    [IsoXmlTag("MltplExctnDtls")]
    public required SubscriptionMultipleExecution3 MultipleExecutionDetails { get; init; }

    /// <summary>
    /// Information about parties related to the transaction.
    /// </summary>
    [IsoId("_RN0cAtp-Ed-ak6NoX_4Aeg_-910202422")]
    [DisplayName("Related Party Details")]
    [IsoXmlTag("RltdPtyDtls")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<Intermediary9> RelatedPartyDetails { get; init; } = [];

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_RN0cA9p-Ed-ak6NoX_4Aeg_-909281259")]
    [DisplayName("Extension")]
    [IsoXmlTag("Xtnsn")]
    public Extension1? Extension { get; init; }
}
