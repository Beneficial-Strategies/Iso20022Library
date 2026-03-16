// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the mandate cancellation request.
/// </summary>
[IsoId("_t4JrBVkyEeGeoaLUQk__nA_-1435065297")]
[DisplayName("Payment Cancellation Reason")]
public record PaymentCancellationReason1
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_t4TcAFkyEeGeoaLUQk__nA_1434167759")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_t4TcAVkyEeGeoaLUQk__nA_2020114785")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_t4TcAlkyEeGeoaLUQk__nA_463313170")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; }
}
