// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_08wX0YqxEeSIDtZ76p6McQ")]
[DisplayName("ATM Environment")]
public record ATMEnvironment5
{
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_1Jt1x4qxEeSIDtZ76p6McQ")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine2 ATM { get; init; }

    /// <summary>
    /// Customer involved in the withdrawal transaction.
    /// </summary>
    [IsoId("_1Jt1yYqxEeSIDtZ76p6McQ")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer2 Customer { get; init; }

    /// <summary>
    /// Encryption of the sensitive card data.
    /// </summary>
    [IsoId("_1Jt1y4qxEeSIDtZ76p6McQ")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_1Jt1zYqxEeSIDtZ76p6McQ")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData14? PlainCardData { get; init; }
}
