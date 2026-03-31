// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the creditor enrolment cancellation request.
/// </summary>
[IsoId("_UWtRWeH7Eeqbls7Gk4-ckA")]
[DisplayName("Debtor Activation Cancellation Reason")]
public record DebtorActivationCancellationReason2
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_UX7ZUeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public RTPPartyIdentification1? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_UX7ZU-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required DebtorActivationCancellationReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_UX7ZVeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
