// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Credit Transfer Context1.
/// </summary>
[IsoId("_UC-MAJ2mEe-4seDr3Li2Ew")]
[DisplayName("Credit Transfer Context1")]
public partial record CreditTransferContext1
{
    #nullable enable

    /// <summary>
    /// Automatic Notification Of Cash Movement.
    /// </summary>
    [DisplayName("Automatic Notification Of Cash Movement")]
    [IsoXmlTag("AutomtcNtfctnOfCshMvmnt")]
    public IsoTrueFalseIndicator? AutomaticNotificationOfCashMovement { get; init; } 

    /// <summary>
    /// Creditor.
    /// </summary>
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification272? Creditor { get; init; } 

    /// <summary>
    /// Creditor Account.
    /// </summary>
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount40? CreditorAccount { get; init; } 

    /// <summary>
    /// Debtor.
    /// </summary>
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public PartyIdentification272? Debtor { get; init; } 

    /// <summary>
    /// Debtor Account.
    /// </summary>
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; } 

    /// <summary>
    /// Protected Creditor Account.
    /// </summary>
    [DisplayName("Protected Creditor Account")]
    [IsoXmlTag("PrtctdCdtrAcct")]
    public ContentInformationType39? ProtectedCreditorAccount { get; init; } 

    /// <summary>
    /// Protected Debtor Account.
    /// </summary>
    [DisplayName("Protected Debtor Account")]
    [IsoXmlTag("PrtctdDbtrAcct")]
    public ContentInformationType39? ProtectedDebtorAccount { get; init; } 

    /// <summary>
    /// System To Notify.
    /// </summary>
    [DisplayName("System To Notify")]
    [IsoXmlTag("SysToNtfy")]
    public IsoMax1025Text? SystemToNotify { get; init; } 

    /// <summary>
    /// Wait For Notification Before Ending.
    /// </summary>
    [DisplayName("Wait For Notification Before Ending")]
    [IsoXmlTag("WaitForNtfctnBfrEndg")]
    public IsoTrueFalseIndicator? WaitForNotificationBeforeEnding { get; init; } 

    
    #nullable disable
    
}
