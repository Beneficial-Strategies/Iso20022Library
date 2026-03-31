// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request has a rejected status.
/// </summary>
[IsoId("_tzlZuekIEemm4qhb2yFPOw")]
[DisplayName("Rejection Reason")]
public record RejectionReason49
{
    /// <summary>
    /// Specifies the reason why the instruction/request has a rejected or repair status.
    /// </summary>
    [IsoId("_uaQ_MekIEemm4qhb2yFPOw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RejectionReason37Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_uaQ_NekIEemm4qhb2yFPOw")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
