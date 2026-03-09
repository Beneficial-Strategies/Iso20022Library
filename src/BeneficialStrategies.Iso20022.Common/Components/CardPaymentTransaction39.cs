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
/// Authorisation response from the acquirer.
/// </summary>
[IsoId("_k9yHgWkkEeSTIuB9A-QJ6g")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction39
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction39 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction39( AuthorisationResult4 reqAuthorisationResult )
    {
        AuthorisationResult = reqAuthorisationResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_lK-2AWkkEeSTIuB9A-QJ6g")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthorisationResult4 AuthorisationResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthorisationResult4 AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult4 AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult4 AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_lK-2A2kkEeSTIuB9A-QJ6g")]
    [DisplayName("Transaction Verification Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxVrfctnRslt")]
    #endif
    [IsoXmlTag("TxVrfctnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionVerificationResult3? TransactionVerificationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionVerificationResult3? TransactionVerificationResult { get; init; } 
    #else
    public TransactionVerificationResult3? TransactionVerificationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Product code for which the authorisation was declined.
    /// </summary>
    [IsoId("_I9lWsGklEeSTIuB9A-QJ6g")]
    [DisplayName("Declined Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclndPdctCd")]
    #endif
    [IsoXmlTag("DclndPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? DeclinedProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeclinedProductCode { get; init; } 
    #else
    public System.String? DeclinedProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_lK-2BWkkEeSTIuB9A-QJ6g")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection41? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection41? Balance { get; init; } 
    #else
    public AmountAndDirection41? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_WbK9MGklEeSTIuB9A-QJ6g")]
    [DisplayName("Protected Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdBal")]
    #endif
    [IsoXmlTag("PrtctdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType10? ProtectedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType10? ProtectedBalance { get; init; } 
    #else
    public ContentInformationType10? ProtectedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_lK-2B2kkEeSTIuB9A-QJ6g")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action3? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action3? Action { get; init; } 
    #else
    public Action3? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be accepted by the cardholder.
    /// </summary>
    [IsoId("_lK-2CWkkEeSTIuB9A-QJ6g")]
    [DisplayName("Currency Conversion")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvs")]
    #endif
    [IsoXmlTag("CcyConvs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion3? CurrencyConversion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion3? CurrencyConversion { get; init; } 
    #else
    public CurrencyConversion3? CurrencyConversion { get; set; } 
    #endif
    
    
    #nullable disable
    
}
