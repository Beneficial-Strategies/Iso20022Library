// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies security rate details.
/// </summary>
[IsoId("_l5a7ceGcEd-1Ktb5rVaajw")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate17
{
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_l5a7c-GcEd-1Ktb5rVaajw")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat11Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_l5a7deGcEd-1Ktb5rVaajw")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat11Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_l5a7d-GcEd-1Ktb5rVaajw")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat12Choice_? NewToOld { get; init; }

    /// <summary>
    /// Rate used to determine the cash consideration split across outturn settlement transactions that are the result of a transformation of the parent transaction.
    /// </summary>
    [IsoId("_l5a7e-GcEd-1Ktb5rVaajw")]
    [DisplayName("Transformation Rate")]
    [IsoXmlTag("TrfrmatnRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? TransformationRate { get; init; }
}
