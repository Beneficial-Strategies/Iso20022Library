// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status and reason of an instructed order.
/// </summary>
[IsoId("_UaaT1tp-Ed-ak6NoX_4Aeg_-595941310")]
[DisplayName("Status And Reason")]
public record StatusAndReason2
{
    /// <summary>
    /// Status and reason for the transaction.
    /// </summary>
    [IsoId("_UaaT19p-Ed-ak6NoX_4Aeg_116718986")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status2Choice_ StatusAndReason { get; init; }
}
