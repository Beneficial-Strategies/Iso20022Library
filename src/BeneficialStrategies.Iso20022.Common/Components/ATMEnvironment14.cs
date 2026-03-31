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
[IsoId("_cfqNYa4VEeW_TaP-ygI0SQ")]
[DisplayName("ATM Environment")]
public record ATMEnvironment14
{
    /// <summary>
    /// Acquirer of the transactions, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_csoSYa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; }

    /// <summary>
    /// Identification of the ATM manager.
    /// </summary>
    [IsoId("_csoSY64VEeW_TaP-ygI0SQ")]
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ATMManagerIdentification { get; init; }

    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_csoSZa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; }

    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_csoSZ64VEeW_TaP-ygI0SQ")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine10 ATM { get; init; }

    /// <summary>
    /// Customer involved in the withdrawal transaction.
    /// </summary>
    [IsoId("_csoSaa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public ATMCustomer4? Customer { get; init; }

    /// <summary>
    /// Card performing the withdrawal transaction.
    /// </summary>
    [IsoId("_csoSa64VEeW_TaP-ygI0SQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard22? Card { get; init; }
}
