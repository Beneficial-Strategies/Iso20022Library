// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer involved in a withdrawal transaction.
/// </summary>
[IsoId("_bGwbsIoYEeSirOZJBRz_nA")]
[DisplayName("ATM Customer")]
public partial record ATMCustomer1
{
    #nullable enable
    
    /// <summary>
    /// Profile of the customer selected to perform the withdrawal.
    /// </summary>
    [IsoId("_KMy_gIoZEeSirOZJBRz_nA")]
    [DisplayName("Profile")]
    [IsoXmlTag("Prfl")]
    public ATMCustomerProfile1? Profile { get; init; } 
    
    /// <summary>
    /// Language selected by the customer at the ATM for the customer session. Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_DnJrwIoaEeSirOZJBRz_nA")]
    [DisplayName("Selected Language")]
    [IsoXmlTag("SelctdLang")]
    public LanguageCode? SelectedLanguage { get; init; } 
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the customer and its card.
    /// </summary>
    [IsoId("_eMgZwIoaEeSirOZJBRz_nA")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public ValueList<CardholderAuthentication8> Authentication { get; init; } = [];
    // ID for the above is _eMgZwIoaEeSirOZJBRz_nA
    
    /// <summary>
    /// Result of the customer authentication for this transaction.
    /// </summary>
    [IsoId("_DxkrsIodEeSirOZJBRz_nA")]
    [DisplayName("Authentication Result")]
    [IsoXmlTag("AuthntcnRslt")]
    public TransactionVerificationResult5? AuthenticationResult { get; init; } 
    
    
    #nullable disable
    
}
