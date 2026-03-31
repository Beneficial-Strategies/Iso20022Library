// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rate details.
/// </summary>
[IsoId("_DjSNsfPwEd-_UpPm03UNGQ")]
[DisplayName("Corporate Action Rate")]
public record CorporateActionRate21
{
    /// <summary>
    /// Quantity of additional intermediate securities/new equities awarded for a given quantity of securities derived from subscription.
    /// </summary>
    [IsoId("_DjSNs_PwEd-_UpPm03UNGQ")]
    [DisplayName("Additional Quantity For Subscribed Resultant Securities")]
    [IsoXmlTag("AddtlQtyForSbcbdRsltntScties")]
    public RatioFormat3Choice_? AdditionalQuantityForSubscribedResultantSecurities { get; init; }

    /// <summary>
    /// Quantity of additional securities for a given quantity of underlying securities where underlying securities are not exchanged or debited, for example, 1 for 1: 1 new equity credited for every 1 underlying equity = 2 resulting equities.
    /// </summary>
    [IsoId("_DjSNtfPwEd-_UpPm03UNGQ")]
    [DisplayName("Additional Quantity For Existing Securities")]
    [IsoXmlTag("AddtlQtyForExstgScties")]
    public RatioFormat3Choice_? AdditionalQuantityForExistingSecurities { get; init; }

    /// <summary>
    /// Quantity of new securities for a given quantity of underlying securities, where the underlying securities will be exchanged or debited, for example, 2 for 1: 2 new equities credited for every 1 underlying equity debited = 2 resulting equities.
    /// </summary>
    [IsoId("_DjSNt_PwEd-_UpPm03UNGQ")]
    [DisplayName("New To Old")]
    [IsoXmlTag("NewToOd")]
    public RatioFormat4Choice_? NewToOld { get; init; }
}
