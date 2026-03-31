// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information specific to an amendment or cancellation.
/// </summary>
[IsoId("_RVa40tp-Ed-ak6NoX_4Aeg_-1270467118")]
[DisplayName("Amend Information")]
public record AmendInformation1
{
    /// <summary>
    /// Identifies the linked message which was previously sent.
    /// </summary>
    [IsoId("_RVa409p-Ed-ak6NoX_4Aeg_1071515411")]
    [DisplayName("Previous Reference")]
    [IsoXmlTag("PrvsRef")]
    public required MessageIdentification PreviousReference { get; init; }

    /// <summary>
    /// Indicates whether instructions must be resent (in case of modification of the parameters of a meeting for which instructions have already been sent).
    /// </summary>
    [IsoId("_RVa41Np-Ed-ak6NoX_4Aeg_-1270467116")]
    [DisplayName("Reconfirm Instructions")]
    [IsoXmlTag("RcnfrmInstrs")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ReconfirmInstructions { get; init; }
}
