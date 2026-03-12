// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the withdrawal transaction.
/// </summary>
[IsoId("_kXLj8Yp1EeS3NqNpgnMh2w")]
[DisplayName("ATM Environment")]
public partial record ATMEnvironment2
{
    #nullable enable
    
    /// <summary>
    /// Acquirer of the withdrawal transaction, in charge of the funds settlement with the issuer.
    /// </summary>
    [IsoId("_kk5P0Yp1EeS3NqNpgnMh2w")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer7? Acquirer { get; init; } 
    
    /// <summary>
    /// Institution in charge of managing the ATM.
    /// </summary>
    [IsoId("_kk5P04p1EeS3NqNpgnMh2w")]
    [DisplayName("ATM Manager")]
    [IsoXmlTag("ATMMgr")]
    public Acquirer8? ATMManager { get; init; } 
    
    /// <summary>
    /// Entity hosting the ATM terminal.
    /// </summary>
    [IsoId("_kk5P1Yp1EeS3NqNpgnMh2w")]
    [DisplayName("Hosting Entity")]
    [IsoXmlTag("HstgNtty")]
    public TerminalHosting1? HostingEntity { get; init; } 
    
    /// <summary>
    /// ATM information.
    /// </summary>
    [IsoId("_kk5P14p1EeS3NqNpgnMh2w")]
    [DisplayName("ATM")]
    [IsoXmlTag("ATM")]
    public required AutomatedTellerMachine2 ATM { get; init; } 
    
    /// <summary>
    /// Customer involved in the withdrawal transaction.
    /// </summary>
    [IsoId("_kk5P2Yp1EeS3NqNpgnMh2w")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public required ATMCustomer2 Customer { get; init; } 
    
    /// <summary>
    /// Encryption of the sensitive card data.
    /// </summary>
    [IsoId("_irWCUIp3EeS3NqNpgnMh2w")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType10? ProtectedCardData { get; init; } 
    
    /// <summary>
    /// Sensitive data associated with the card performing the transaction.
    /// </summary>
    [IsoId("_kk5P24p1EeS3NqNpgnMh2w")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData14? PlainCardData { get; init; } 
    
    
    #nullable disable
    
}
