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
[IsoId("_xBbp4S8qEeu125Ip9zFcsQ")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction109
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction109 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction109( AuthorisationResult14 reqAuthorisationResult )
    {
        AuthorisationResult = reqAuthorisationResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_xNcsoS8qEeu125Ip9zFcsQ")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthorisationResult14 AuthorisationResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthorisationResult14 AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult14 AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult14 AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_xNcsoy8qEeu125Ip9zFcsQ")]
    [DisplayName("Transaction Verification Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxVrfctnRslt")]
    #endif
    [IsoXmlTag("TxVrfctnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    #else
    public TransactionVerificationResult4? TransactionVerificationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Product code which are allowed by the payment card.
    /// </summary>
    [IsoId("_xNcspS8qEeu125Ip9zFcsQ")]
    [DisplayName("Allowed Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AllwdPdctCd")]
    #endif
    [IsoXmlTag("AllwdPdctCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product4? AllowedProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product4? AllowedProductCode { get; init; } 
    #else
    public Product4? AllowedProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Product code not allowed by the payment card.
    /// </summary>
    [IsoId("_xNcspy8qEeu125Ip9zFcsQ")]
    [DisplayName("Not Allowed Product Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NotAllwdPdctCd")]
    #endif
    [IsoXmlTag("NotAllwdPdctCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product4? NotAllowedProductCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product4? NotAllowedProductCode { get; init; } 
    #else
    public Product4? NotAllowedProductCode { get; set; } 
    #endif
    
    /// <summary>
    /// Products that may be added to the purchase after the authorisation.
    /// </summary>
    [IsoId("_xNcsqS8qEeu125Ip9zFcsQ")]
    [DisplayName("Additional Available Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAvlblPdct")]
    #endif
    [IsoXmlTag("AddtlAvlblPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product5? AdditionalAvailableProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product5? AdditionalAvailableProduct { get; init; } 
    #else
    public Product5? AdditionalAvailableProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Balance and currency code of the account, related to the payment.
    /// </summary>
    [IsoId("_xNcsqy8qEeu125Ip9zFcsQ")]
    [DisplayName("Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Bal")]
    #endif
    [IsoXmlTag("Bal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection93? Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection93? Balance { get; init; } 
    #else
    public AmountAndDirection93? Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_xNcsrS8qEeu125Ip9zFcsQ")]
    [DisplayName("Protected Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrtctdBal")]
    #endif
    [IsoXmlTag("PrtctdBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ContentInformationType28? ProtectedBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ContentInformationType28? ProtectedBalance { get; init; } 
    #else
    public ContentInformationType28? ProtectedBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_xNcsry8qEeu125Ip9zFcsQ")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action11? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action11? Action { get; init; } 
    #else
    public Action11? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be proposed to the cardholder.
    /// </summary>
    [IsoId("_xNcssS8qEeu125Ip9zFcsQ")]
    [DisplayName("Currency Conversion Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsElgblty")]
    #endif
    [IsoXmlTag("CcyConvsElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion20? CurrencyConversionEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion20? CurrencyConversionEligibility { get; init; } 
    #else
    public CurrencyConversion20? CurrencyConversionEligibility { get; set; } 
    #endif
    
    
    #nullable disable
    
}
