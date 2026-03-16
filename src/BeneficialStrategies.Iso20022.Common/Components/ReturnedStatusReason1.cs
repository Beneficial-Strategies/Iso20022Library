// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Returned Status Reason1.
/// </summary>
[IsoId("_ohK2VoS_Ee-1WeOqsw_6eA")]
[DisplayName("Returned Status Reason1")]
public record ReturnedStatusReason1
{
    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; }

    /// <summary>
    /// Reason Code.
    /// </summary>
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required ReturnedReason1Choice_ ReasonCode { get; init; }
}
