// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the reason why the instruction or request is cancelled.
/// </summary>
[IsoId("_khfKEewOEeiazoAmcoGsBQ")]
[DisplayName("Cancellation Reason")]
public record CancellationReason23
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    [IsoId("_k1UFAewOEeiazoAmcoGsBQ")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CancellationReason36Choice_ Code { get; init; }

    /// <summary>
    /// Provides the corporate action event identification of the event that triggered the cancellation.
    /// </summary>
    [IsoId("_k1UFCewOEeiazoAmcoGsBQ")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }
}
