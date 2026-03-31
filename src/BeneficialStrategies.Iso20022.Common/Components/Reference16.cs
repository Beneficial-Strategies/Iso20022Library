// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the identification of the collateral message cancellation request.
/// </summary>
[IsoId("_QmevMNp-Ed-ak6NoX_4Aeg_386196874")]
[DisplayName("Reference")]
public record Reference16
{
    /// <summary>
    /// Identification of the collateral message cancellation request.
    /// </summary>
    [IsoId("_QmevMdp-Ed-ak6NoX_4Aeg_2144150903")]
    [DisplayName("Collateral Message Cancellation Request Identification")]
    [IsoXmlTag("CollMsgCxlReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CollateralMessageCancellationRequestIdentification { get; init; }
}
