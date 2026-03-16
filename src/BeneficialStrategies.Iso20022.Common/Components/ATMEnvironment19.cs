// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Environment19.
/// </summary>
[IsoId("_yAEqgaErEe-MRKYsaX6JDg")]
[DisplayName("ATM Environment19")]
public record ATMEnvironment19
{
    /// <summary>
    /// Acquirer.
    /// </summary>
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; }

    /// <summary>
    /// ATM.
    /// </summary>
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine12 ATM { get; init; }

    /// <summary>
    /// ATM Manager Identification.
    /// </summary>
    [DisplayName("ATM Manager Identification")]
    [IsoXmlTag("ATMMgrId")]
    public IsoMax35Text? ATMManagerIdentification { get; init; }

    /// <summary>
    /// Card.
    /// </summary>
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard37? Card { get; init; }

    /// <summary>
    /// Customer.
    /// </summary>
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer7 Customer { get; init; }

    /// <summary>
    /// Hosting Entity.
    /// </summary>
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; }
}
