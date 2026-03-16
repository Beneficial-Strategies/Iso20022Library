// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response of a requested service.
/// </summary>
[IsoId("_SwsDyQEcEeCQm6a_G2yO_w_811768700")]
[DisplayName("Response Type")]
public record ResponseType1
{
    /// <summary>
    /// Result of the transaction.
    /// </summary>
    [IsoId("_SwsDygEcEeCQm6a_G2yO_w_1498682566")]
    [DisplayName("Response")]
    [IsoXmlTag("Rspn")]
    public required Response1Code Response { get; init; }

    /// <summary>
    /// Detailed result of the transaction.
    /// </summary>
    [IsoId("_SwsDywEcEeCQm6a_G2yO_w_-2061338500")]
    [DisplayName("Response Reason")]
    [IsoXmlTag("RspnRsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ResponseReason { get; init; }
}
