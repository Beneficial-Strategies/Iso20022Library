// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status of the cheque presentment cancellation request.
/// </summary>
[IsoId("_PJJT97tyEeq_cfXrH83Rcw")]
[DisplayName("Cheque Cancellation Status")]
public record ChequeCancellationStatus1
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_PJJT-btyEeq_cfXrH83Rcw")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public ChequePartyRole1Code? Originator { get; init; }

    /// <summary>
    /// Specifies the status for the cancellation request.
    /// </summary>
    [IsoId("_PJJT-rtyEeq_cfXrH83Rcw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ChequeCancellationStatus1Choice_ Status { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_PJJT-LtyEeq_cfXrH83Rcw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? AdditionalInformation { get; init; }
}
