// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the withdrawal transaction.
/// </summary>
[IsoId("_-wXU0YqOEeSRT5rEzcAHEw")]
[DisplayName("ATM Environment")]
public record ATMEnvironment3
{
    /// <summary>
    /// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_-8u84YqOEeSRT5rEzcAHEw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; }

    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_-8u844qOEeSRT5rEzcAHEw")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; }

    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_-8u85YqOEeSRT5rEzcAHEw")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; }

    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_-8u854qOEeSRT5rEzcAHEw")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine1 ATM { get; init; }

    /// <summary>
    /// Customer involved in the transaction.
    /// </summary>
    [IsoId("_-8u86YqOEeSRT5rEzcAHEw")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer3 Customer { get; init; }

    /// <summary>
    /// Card performing the transaction.
    /// </summary>
    [IsoId("_-8u864qOEeSRT5rEzcAHEw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard17? Card { get; init; }
}
