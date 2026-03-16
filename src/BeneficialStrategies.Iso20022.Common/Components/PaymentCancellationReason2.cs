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
[IsoId("_t3j1I1kyEeGeoaLUQk__nA_1924238897")]
[DisplayName("Payment Cancellation Reason")]
public record PaymentCancellationReason2
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_t3j1JFkyEeGeoaLUQk__nA_1574092631")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation.
    /// </summary>
    [IsoId("_t3s_EFkyEeGeoaLUQk__nA_-981671889")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public CancellationReason14Choice_? Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_t3s_EVkyEeGeoaLUQk__nA_712732373")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; }
}
