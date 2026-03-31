// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of the amendment.
/// </summary>
[IsoId("_9_wDcHltEeG7BsjMvd1mEw_-868509945")]
[DisplayName("Amendment")]
public record Amendment9
{
    /// <summary>
    /// Contents of the related UndertakingAmendmentResponse message.
    /// </summary>
    [IsoId("_9_wDcXltEeG7BsjMvd1mEw_-1238548049")]
    [DisplayName("Undertaking Amendment Response Message")]
    [IsoXmlTag("UdrtkgAmdmntRspnMsg")]
    public required UndertakingAmendmentResponseMessage1 UndertakingAmendmentResponseMessage { get; init; }
}
