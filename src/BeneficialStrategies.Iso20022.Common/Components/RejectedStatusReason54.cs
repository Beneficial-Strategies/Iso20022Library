// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Rejected Status Reason54.
/// </summary>
[IsoId("_BgiaIX_WEe6NNIFrPQqloA")]
[DisplayName("Rejected Status Reason54")]
public partial record RejectedStatusReason54
{
    #nullable enable

    /// <summary>
    /// Additional Reason Information.
    /// </summary>
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    public IsoMax350Text? AdditionalReasonInformation { get; init; } 

    /// <summary>
    /// Reason Code.
    /// </summary>
    [DisplayName("Reason Code")]
    [IsoXmlTag("RsnCd")]
    public required RejectedReason57Choice_ ReasonCode { get; init; } 

    
    #nullable disable
    
}
