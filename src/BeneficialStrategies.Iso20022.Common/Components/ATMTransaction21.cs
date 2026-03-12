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
[IsoId("_-0kyoa4WEeW_TaP-ygI0SQ")]
[DisplayName("ATM Transaction")]
public partial record ATMTransaction21
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("__Afuwa4WEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Result of the inquiry service.
    /// </summary>
    [IsoId("__Afuw64WEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction Response")]
    [IsoXmlTag("TxRspn")]
    public required ResponseType7 TransactionResponse { get; init; } 
    
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("__Afuxa4WEeW_TaP-ygI0SQ")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action7? Action { get; init; } 
    
    /// <summary>
    /// Profile of the customer with the allowed services and restrictions.
    /// </summary>
    [IsoId("__Afux64WEeW_TaP-ygI0SQ")]
    [DisplayName("Customer Service Profile")]
    [IsoXmlTag("CstmrSvcPrfl")]
    public ATMCustomerProfile5? CustomerServiceProfile { get; init; } 
    
    /// <summary>
    /// Dynamic currency conversion result.
    /// </summary>
    [IsoId("__Afuya4WEeW_TaP-ygI0SQ")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion10? CurrencyConversion { get; init; } 
    
    /// <summary>
    /// Account information associated to the customer.
    /// </summary>
    [IsoId("__Afuy64WEeW_TaP-ygI0SQ")]
    [DisplayName("Account Information")]
    [IsoXmlTag("AcctInf")]
    public CardAccount12? AccountInformation { get; init; } 
    
    /// <summary>
    /// Statement information of an account.
    /// </summary>
    [IsoId("__Afuza4WEeW_TaP-ygI0SQ")]
    [DisplayName("Account Statement Data")]
    [IsoXmlTag("AcctStmtData")]
    public ATMAccountStatement1? AccountStatementData { get; init; } 
    
    /// <summary>
    /// Exchange rate and calculated amount to be presented to the customer when the dispense currency or the deposit currency (target currency) is different to account currency (source currency).
    /// </summary>
    [IsoId("__Afuz64WEeW_TaP-ygI0SQ")]
    [DisplayName("Currency Exchange")]
    [IsoXmlTag("CcyXchg")]
    public CurrencyConversion5? CurrencyExchange { get; init; } 
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("__Afu0a4WEeW_TaP-ygI0SQ")]
    [DisplayName("ICC Related Data")]
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("__Afu064WEeW_TaP-ygI0SQ")]
    [DisplayName("Command")]
    [IsoXmlTag("Cmd")]
    public ATMCommand7? Command { get; init; } 
    
    
    #nullable disable
    
}
