// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer involved in a transaction.
/// </summary>
[IsoId("_-NgEca16EeWMg5rOByfExw")]
[DisplayName("ATM Customer")]
public record ATMCustomer5
{
    /// <summary>
    /// Profile of the customer selected to perform the transaction.
    /// </summary>
    [IsoId("_-ZR2oa16EeWMg5rOByfExw")]
    [DisplayName("Profile")]
    [IsoXmlTag("Prfl")]
    public ATMCustomerProfile2? Profile { get; init; }

    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_-ZR2o616EeWMg5rOByfExw")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public ValueList<TransactionVerificationResult5> AuthenticationResult { get; init; } = [];
}
