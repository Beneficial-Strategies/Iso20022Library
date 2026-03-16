// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Environment21.
/// </summary>
[IsoId("_ePAPUaazEe-s1ZClExRjdw")]
[DisplayName("ATM Environment21")]
public partial record ATMEnvironment21
{
    #nullable enable

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
    public required AutomatedTellerMachine2 ATM { get; init; } 

    /// <summary>
    /// ATM Manager.
    /// </summary>
    [DisplayName("ATM Manager")]
    [IsoXmlTag("ATMMgr")]
    public Acquirer8? ATMManager { get; init; } 

    /// <summary>
    /// Customer.
    /// </summary>
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer9 Customer { get; init; } 

    /// <summary>
    /// Hosting Entity.
    /// </summary>
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; } 

    /// <summary>
    /// Plain Card Data.
    /// </summary>
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData24? PlainCardData { get; init; } 

    /// <summary>
    /// Protected Card Data.
    /// </summary>
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; } 

    
    #nullable disable
    
}
