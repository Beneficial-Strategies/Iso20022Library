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
[IsoId("_TgYswazjEeaS8qpTeYtFzA")]
[DisplayName("Card Payment Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransaction67
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransaction67 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransaction67( AuthorisationResult10 reqAuthorisationResult )
    {
        AuthorisationResult = reqAuthorisationResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_Trja8azjEeaS8qpTeYtFzA")]
    [DisplayName("Authorisation Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnRslt")]
    #endif
    [IsoXmlTag("AuthstnRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AuthorisationResult10 AuthorisationResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AuthorisationResult10 AuthorisationResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AuthorisationResult10 AuthorisationResult { get; init; } 
    #else
    public AuthorisationResult10 AuthorisationResult { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_Trja86zjEeaS8qpTeYtFzA")]
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
    [IsoId("_Trja9azjEeaS8qpTeYtFzA")]
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
    [IsoId("_Trja96zjEeaS8qpTeYtFzA")]
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
    [IsoId("_Trja-azjEeaS8qpTeYtFzA")]
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
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_Trja-6zjEeaS8qpTeYtFzA")]
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
    [IsoId("_Trja_azjEeaS8qpTeYtFzA")]
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
    [IsoId("_Trja_6zjEeaS8qpTeYtFzA")]
    [DisplayName("Action")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Actn")]
    #endif
    [IsoXmlTag("Actn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Action8? Action { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Action8? Action { get; init; } 
    #else
    public Action8? Action { get; set; } 
    #endif
    
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be proposed to the cardholder.
    /// </summary>
    [IsoId("_TrjbAazjEeaS8qpTeYtFzA")]
    [DisplayName("Currency Conversion Eligibility")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsElgblty")]
    #endif
    [IsoXmlTag("CcyConvsElgblty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion12? CurrencyConversionEligibility { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion12? CurrencyConversionEligibility { get; init; } 
    #else
    public CurrencyConversion12? CurrencyConversionEligibility { get; set; } 
    #endif
    
    
    #nullable disable
    
}
