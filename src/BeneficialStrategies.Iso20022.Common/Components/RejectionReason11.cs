// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// The status of an instruction, advice or request.
/// </summary>
[IsoId("_0kRD0AlIEeGATtfOBToyew_-890564690")]
[DisplayName("Rejection Reason")]
public record RejectionReason11
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_0kRD0QlIEeGATtfOBToyew_35630539")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required RejectionReason11Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_0kRD0glIEeGATtfOBToyew_-1532269853")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
