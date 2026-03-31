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
[IsoId("_2LQFQa16EeWMg5rOByfExw")]
[DisplayName("ATM Environment")]
public record ATMEnvironment12
{
    /// <summary>
    /// Acquirer of the transactions, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_2XLBYa16EeWMg5rOByfExw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; }

    /// <summary>
    /// Institution in charge of managing the ATM.
    /// </summary>
    [IsoId("_2XLBY616EeWMg5rOByfExw")]
    [DisplayName("ATM Manager")]
    [IsoXmlTag("ATMMgr")]
    public Acquirer8? ATMManager { get; init; }

    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_2XLBZa16EeWMg5rOByfExw")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; }

    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_2XLBZ616EeWMg5rOByfExw")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine2 ATM { get; init; }

    /// <summary>
    /// Customer involved in the transaction.
    /// </summary>
    [IsoId("_2XLBaa16EeWMg5rOByfExw")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer5 Customer { get; init; }

    /// <summary>
    /// Encryption of the sensitive card data.
    /// </summary>
    [IsoId("_2XLBa616EeWMg5rOByfExw")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; }

    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_2XLBba16EeWMg5rOByfExw")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData19? PlainCardData { get; init; }
}
