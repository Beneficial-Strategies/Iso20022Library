// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Business status of the party for processing in the system.
/// </summary>
[IsoId("_3L62cXHeEeG8t-w1mFnmhg_-127584604")]
[DisplayName("Account Link Status")]
public record AccountLinkStatus1
{
    /// <summary>
    /// Status of the account link instruction.
    /// </summary>
    [IsoId("_3L62cnHeEeG8t-w1mFnmhg_-241423670")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required Status6Code Status { get; init; }

    /// <summary>
    /// Underlying reason related to the creation of a transaction.
    /// </summary>
    [IsoId("_3L62c3HeEeG8t-w1mFnmhg_-1124656957")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public StatusReasonInformation10? StatusReason { get; init; }
}
