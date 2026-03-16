// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the cancellation request.
/// </summary>
[IsoId("_fzdu8cDQEeic67MXUoeXWA")]
[DisplayName("Payment Cancellation Reason")]
public record PaymentCancellationReason5
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_f_Xc88DQEeic67MXUoeXWA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_f_Xc9cDQEeic67MXUoeXWA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationReason33Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_f_Xc98DQEeic67MXUoeXWA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; }
}
