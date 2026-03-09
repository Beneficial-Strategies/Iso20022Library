// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry information for the transaction.
/// </summary>
[IsoId("_-0kyoa4WEeW_TaP-ygI0SQ")]
[DisplayName("ATM Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMTransaction21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMTransaction21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMTransaction21( TransactionIdentifier1 reqTransactionIdentification,ResponseType7 reqTransactionResponse )
    {
        TransactionIdentification = reqTransactionIdentification;
        TransactionResponse = reqTransactionResponse;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    [IsoId("__Afuwa4WEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the inquiry service.
    /// </summary>
    [IsoId("__Afuw64WEeW_TaP-ygI0SQ")]
    [DisplayName("Transaction Response")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxRspn")]
    #endif
    [IsoXmlTag("TxRspn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ResponseType7 TransactionResponse { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ResponseType7 TransactionResponse { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ResponseType7 TransactionResponse { get; init; } 
    #else
    public ResponseType7 TransactionResponse { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    [IsoId("__Afuxa4WEeW_TaP-ygI0SQ")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action7? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action7? Action { get; init; } 
    #else
    public Action7? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Profile of the customer with the allowed services and restrictions.
    /// </summary>
    [IsoId("__Afux64WEeW_TaP-ygI0SQ")]
    [DisplayName("Customer Service Profile")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CstmrSvcPrfl")]
    #endif
    [IsoXmlTag("CstmrSvcPrfl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCustomerProfile5? CustomerServiceProfile { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCustomerProfile5? CustomerServiceProfile { get; init; } 
    #else
    public ATMCustomerProfile5? CustomerServiceProfile { get; set; } 
    #endif
    
    /// <summary>
    /// Dynamic currency conversion result.
    /// </summary>
    [IsoId("__Afuya4WEeW_TaP-ygI0SQ")]
    [DisplayName("Currency Conversion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvs")]
    #endif
    [IsoXmlTag("CcyConvs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion10? CurrencyConversion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion10? CurrencyConversion { get; init; } 
    #else
    public CurrencyConversion10? CurrencyConversion { get; set; } 
    #endif
    
    /// <summary>
    /// Account information associated to the customer.
    /// </summary>
    [IsoId("__Afuy64WEeW_TaP-ygI0SQ")]
    [DisplayName("Account Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctInf")]
    #endif
    [IsoXmlTag("AcctInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccount12? AccountInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccount12? AccountInformation { get; init; } 
    #else
    public CardAccount12? AccountInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Statement information of an account.
    /// </summary>
    [IsoId("__Afuza4WEeW_TaP-ygI0SQ")]
    [DisplayName("Account Statement Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctStmtData")]
    #endif
    [IsoXmlTag("AcctStmtData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMAccountStatement1? AccountStatementData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMAccountStatement1? AccountStatementData { get; init; } 
    #else
    public ATMAccountStatement1? AccountStatementData { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate and calculated amount to be presented to the customer when the dispense currency or the deposit currency (target currency) is different to account currency (source currency).
    /// </summary>
    [IsoId("__Afuz64WEeW_TaP-ygI0SQ")]
    [DisplayName("Currency Exchange")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyXchg")]
    #endif
    [IsoXmlTag("CcyXchg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion5? CurrencyExchange { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion5? CurrencyExchange { get; init; } 
    #else
    public CurrencyConversion5? CurrencyExchange { get; set; } 
    #endif
    
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    [IsoId("__Afu0a4WEeW_TaP-ygI0SQ")]
    [DisplayName("ICC Related Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ICCRltdData")]
    #endif
    [IsoXmlTag("ICCRltdData")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ICCRelatedData { get; init; } 
    #else
    public System.Byte[]? ICCRelatedData { get; set; } 
    #endif
    
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    [IsoId("__Afu064WEeW_TaP-ygI0SQ")]
    [DisplayName("Command")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cmd")]
    #endif
    [IsoXmlTag("Cmd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ATMCommand7? Command { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMCommand7? Command { get; init; } 
    #else
    public ATMCommand7? Command { get; set; } 
    #endif
    
    
    #nullable disable
    
}
