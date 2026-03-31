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
[IsoId("_NAXwT5lPEee-Zps0fZQaFQ")]
[DisplayName("Transaction Report")]
public record TransactionReport4
{
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    [IsoId("_NI2W05lPEee-Zps0fZQaFQ")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification5Choice_ PaymentIdentification { get; init; }

    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    [IsoId("_NI2W1ZlPEee-Zps0fZQaFQ")]
    [DisplayName("Transaction Or Error")]
    [IsoXmlTag("TxOrErr")]
    public required TransactionOrError3Choice_ TransactionOrError { get; init; }
}
