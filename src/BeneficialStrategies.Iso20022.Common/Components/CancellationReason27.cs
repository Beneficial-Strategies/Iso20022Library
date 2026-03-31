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
[IsoId("_XGEdy_fZEeiNZp_PtLohLw")]
[DisplayName("Cancellation Reason")]
public record CancellationReason27
{
    /// <summary>
    /// Specifies the reason why the instruction is cancelled.
    /// </summary>
    [IsoId("_XGEdzffZEeiNZp_PtLohLw")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required CancellationReason37Choice_ Code { get; init; }

    /// <summary>
    /// Provides the corporate action event identification of the event that triggered the cancellation.
    /// </summary>
    [IsoId("_XGEd1ffZEeiNZp_PtLohLw")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax16Text)]
    [StringLength(maximumLength: 16, MinimumLength = 1)]
    public IsoRestrictedFINMax16Text? CorporateActionEventIdentification { get; init; }
}
