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
[IsoId("_ALqDwYqzEeSIDtZ76p6McQ")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction7
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("_AYBr04qzEeSIDtZ76p6McQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Result of the inquiry service.
    /// </summary>
    [IsoId("_VhPFwCvLEeW-qbryg71zJw")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType3 TransactionResponse { get; init; } 
    
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("_cRUScCvLEeW-qbryg71zJw")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action5? Action { get; init; } 
    
    /// <summary>
    /// Profile of the customer with the allowed services and restrictions.
    /// </summary>
    [IsoId("_nPPNAIqzEeSIDtZ76p6McQ")]
    [DisplayName("Customer Service Profile")]
    [IsoXmlTag("CstmrSvcPrfl")]
    public ATMCustomerProfile3? CustomerServiceProfile { get; init; } 
    
    /// <summary>
    /// Dynamic currency conversion result.
    /// </summary>
    [IsoId("_AYBr34qzEeSIDtZ76p6McQ")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion3? CurrencyConversion { get; init; } 
    
    /// <summary>
    /// Account information associated to the customer.
    /// </summary>
    [IsoId("_AYBr14qzEeSIDtZ76p6McQ")]
    [DisplayName("Account Information")]
    [IsoXmlTag("AcctInf")]
    public CardAccount6? AccountInformation { get; init; } 
    
    /// <summary>
    /// Statement information of an account.
    /// </summary>
    [IsoId("_8fQUYIq7EeSHjtO_wHA7PQ")]
    [DisplayName("Account Statement Data")]
    [IsoXmlTag("AcctStmtData")]
    public ATMAccountStatement1? AccountStatementData { get; init; } 
    
    /// <summary>
    /// Exchange rate and calculated amount to be presented to the customer when the dispense currency or the deposit currency (target currency) is different to account currency (source currency).
    /// </summary>
    [IsoId("_dE4GQIq9EeSHjtO_wHA7PQ")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyConversion5? CurrencyExchange { get; init; } 
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("_AYBr54qzEeSIDtZ76p6McQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("_G4SFEIq5EeSIDtZ76p6McQ")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand1? Command { get; init; } 
    
    
    #nullable disable
    
}
