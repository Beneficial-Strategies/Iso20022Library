// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the inquiry.
/// </summary>
[IsoId("_M18pQYqsEeSIDtZ76p6McQ")]
[DisplayName("ATM Environment")]
public record ATMEnvironment4
{
    /// <summary>
    /// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_NCwWMYqsEeSIDtZ76p6McQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; }

    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_NCwWM4qsEeSIDtZ76p6McQ")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; }

    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_NCwWNYqsEeSIDtZ76p6McQ")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; }

    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_NCwWN4qsEeSIDtZ76p6McQ")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine4 ATM { get; init; }

    /// <summary>
    /// Customer involved in the withdrawal transaction.
    /// </summary>
    [IsoId("_NCwWOYqsEeSIDtZ76p6McQ")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public ATMCustomer1? Customer { get; init; }

    /// <summary>
    /// Card performing the withdrawal transaction.
    /// </summary>
    [IsoId("_NCwWO4qsEeSIDtZ76p6McQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard16? Card { get; init; }
}
