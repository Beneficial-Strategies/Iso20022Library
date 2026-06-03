// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instructed units are returned or partially returned to the instructing party.
/// </summary>
[IsoId("_r9uog473EfCbNJ3GwkFTcw")]
[DisplayName("Returned Status1")]
public record ReturnedStatus1
{
    /// <summary>
    /// Quantity of securities that have been returned.
    /// </summary>
    [IsoId("_r9uohY73EfCbNJ3GwkFTcw")]
    [DisplayName("Returned Quantity")]
    [IsoXmlTag("RtrdQty")]
    public Quantity51Choice? ReturnedQuantity { get; init; }

    /// <summary>
    /// Reason for the pending status.
    /// </summary>
    [IsoId("_r9uohI73EfCbNJ3GwkFTcw")]
    [DisplayName("Returned Reason")]
    [IsoXmlTag("RtrdRsn")]
    public required ReturnedStatus2Choice ReturnedReason { get; init; }
}
