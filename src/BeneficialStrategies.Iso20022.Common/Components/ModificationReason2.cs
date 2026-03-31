// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Modification reasons.
/// </summary>
[IsoId("_0jhc9AlIEeGATtfOBToyew_665393579")]
[DisplayName("Modification Reason")]
public record ModificationReason2
{
    /// <summary>
    /// Specifies the reason why the transaction is modified.
    /// </summary>
    [IsoId("_0jrN8QlIEeGATtfOBToyew_-1418560626")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required ModificationReason2Choice_ Code { get; init; }

    /// <summary>
    /// Provides additional reason information that cannot be provided in a structured field.
    /// </summary>
    [IsoId("_0jrN8AlIEeGATtfOBToyew_-1505570977")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210, MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; }
}
