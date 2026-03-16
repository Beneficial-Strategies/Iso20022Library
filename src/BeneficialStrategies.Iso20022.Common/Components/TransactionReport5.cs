// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the payment transactions.
/// </summary>
[IsoId("_WxDT3249EeiU9cctagi5ow")]
[DisplayName("Transaction Report")]
public record TransactionReport5
{
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    [IsoId("_W6b5U249EeiU9cctagi5ow")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification6Choice_ PaymentIdentification { get; init; }

    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    [IsoId("_W6b5VW49EeiU9cctagi5ow")]
    [DisplayName("Transaction Or Error")]
    [IsoXmlTag("TxOrErr")]
    public required TransactionOrError4Choice_ TransactionOrError { get; init; }
}
