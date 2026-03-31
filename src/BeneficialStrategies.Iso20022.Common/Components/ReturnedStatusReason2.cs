// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Returned Status Reason2.
/// </summary>
[IsoId("_s2Ll2qGqEe-4O7NbwmwJkQ")]
[DisplayName("Returned Status Reason2")]
public record ReturnedStatusReason2
{
    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Reason Code.
    /// </summary>
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required ReturnedReason2Choice_ ReasonCode { get; init; }
}
