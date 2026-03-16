// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the reason of the cancellation request.
/// </summary>
[IsoId("_TPmtmNp-Ed-ak6NoX_4Aeg_103845327")]
[DisplayName("Cancellation Reason Information")]
public record CancellationReasonInformation3
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_TPwekNp-Ed-ak6NoX_4Aeg_103846001")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification32? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_TPwekdp-Ed-ak6NoX_4Aeg_103845699")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationReason2Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_TPwektp-Ed-ak6NoX_4Aeg_103845576")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
