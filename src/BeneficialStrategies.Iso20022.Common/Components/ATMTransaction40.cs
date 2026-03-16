// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// ATM Transaction40.
/// </summary>
[IsoId("_MAsZ8aEPEe-MRKYsaX6JDg")]
[DisplayName("ATM Transaction40")]
public partial record ATMTransaction40
{
    #nullable enable

    /// <summary>
    /// Electronic Purse Balance.
    /// </summary>
    [DisplayName("Electronic Purse Balance")]
    [IsoXmlTag("ElctrncPrsBal")]
    public CurrencyAndAmount? ElectronicPurseBalance { get; init; } 

    /// <summary>
    /// Exception.
    /// </summary>
    [DisplayName("Exception")]
    [IsoXmlTag("Xcptn")]
    public ValueList<FailureReason8Code> Exception { get; init; } = [];

    /// <summary>
    /// Exception Detail.
    /// </summary>
    [DisplayName("Exception Detail")]
    [IsoXmlTag("XcptnDtl")]
    public ValueList<IsoMax70Text> ExceptionDetail { get; init; } = [];

    /// <summary>
    /// Reconciliation Identification.
    /// </summary>
    [DisplayName("Reconciliation Identification")]
    [IsoXmlTag("RcncltnId")]
    public IsoMax35Text? ReconciliationIdentification { get; init; } 

    /// <summary>
    /// Transaction Identification.
    /// </summary>
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentifier3? TransactionIdentification { get; init; } 

    
    #nullable disable
    
}
