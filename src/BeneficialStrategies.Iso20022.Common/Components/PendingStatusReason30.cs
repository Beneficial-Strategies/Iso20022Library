// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Pending Status Reason30.
/// </summary>
[IsoId("_jWq6GZt3Ee-wQIOX0djF2w")]
[DisplayName("Pending Status Reason30")]
public partial record PendingStatusReason30
{
    #nullable enable

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
    public required PendingReason71Choice_ ReasonCode { get; init; } 

    
    #nullable disable
    
}
