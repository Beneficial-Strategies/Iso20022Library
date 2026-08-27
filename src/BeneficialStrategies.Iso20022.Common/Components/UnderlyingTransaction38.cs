// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the request(s) to which the cancellation applies.
/// </summary>
[IsoId("_ICIBEHgzEfCdoODv2ypKfw")]
[DisplayName("Underlying Transaction38")]
public record UnderlyingTransaction38
{
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    [IsoId("_dXAT8ngzEfCdoODv2ypKfw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public required OriginalGroupInformation29 OriginalGroupInformation { get; init; }

    /// <summary>
    /// Identification of the original CashDepositRequest or CashWithdrawalRequest.
    /// </summary>
    [IsoId("_dXAT83gzEfCdoODv2ypKfw")]
    [DisplayName("Original Request Identification")]
    [IsoXmlTag("OrgnlReqId")]
    public required RequestIdentification2 OriginalRequestIdentification { get; init; }

    /// <summary>
    /// Provides detailed information on the cancellation reason.
    /// </summary>
    [IsoId("_KjfVIHg0EfCdoODv2ypKfw")]
    [DisplayName("Cancellation Reason Information")]
    [IsoXmlTag("CxlRsnInf")]
    public required PaymentCancellationReason6 CancellationReasonInformation { get; init; }
}
