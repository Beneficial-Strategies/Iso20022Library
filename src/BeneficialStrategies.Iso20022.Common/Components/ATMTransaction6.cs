// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry information for the transaction.
/// </summary>
[IsoId("_9qsqQYqvEeSIDtZ76p6McQ")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_93gXM4qvEeSIDtZ76p6McQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    [IsoId("_93gXN4qvEeSIDtZ76p6McQ")]
    [DisplayName("Account Data")]
    [IsoXmlTag("AcctData")]
    public CardAccount3? AccountData { get; init; } 
    
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    [IsoId("_93gXOYqvEeSIDtZ76p6McQ")]
    [DisplayName("Protected Account Data")]
    [IsoXmlTag("PrtctdAcctData")]
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    
    /// <summary>
    /// Amount to be authorised by the issuer.
    /// </summary>
    [IsoId("_93gXPYqvEeSIDtZ76p6McQ")]
    [DisplayName("Total Requested Amount")]
    [IsoXmlTag("TtlReqdAmt")]
    public AmountAndCurrency1? TotalRequestedAmount { get; init; } 
    
    /// <summary>
    /// Amounts of the withdrawal transaction.
    /// </summary>
    [IsoId("_93gXO4qvEeSIDtZ76p6McQ")]
    [DisplayName("Detailed Requested Amount")]
    [IsoXmlTag("DtldReqdAmt")]
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_93gXR4qvEeSIDtZ76p6McQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    
    #nullable disable
    
}
