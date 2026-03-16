// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer involved in a withdrawal transaction.
/// </summary>
[IsoId("_ExNJ0Yp3EeS3NqNpgnMh2w")]
[DisplayName("ATM Customer")]
public record ATMCustomer2
{
    /// <summary>
    /// Profile of the customer selected to perform the withdrawal.
    /// </summary>
    [IsoId("_E9kx4Yp3EeS3NqNpgnMh2w")]
    [DisplayName("Profile")]
    [IsoXmlTag("Prfl")]
    public ATMCustomerProfile2? Profile { get; init; }

    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_E9kx54p3EeS3NqNpgnMh2w")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public TransactionVerificationResult5? AuthenticationResult { get; init; }
}
