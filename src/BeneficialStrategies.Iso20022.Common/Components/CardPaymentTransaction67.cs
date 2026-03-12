// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Authorisation response from the acquirer.
/// </summary>
[IsoId("_TgYswazjEeaS8qpTeYtFzA")]
[DisplayName("Card Payment Transaction")]
public partial record CardPaymentTransaction67
{
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_Trja8azjEeaS8qpTeYtFzA")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult10 AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_Trja86zjEeaS8qpTeYtFzA")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    
    /// <summary>
    /// Product code which are allowed by the payment card.
    /// </summary>
    [IsoId("_Trja9azjEeaS8qpTeYtFzA")]
    [DisplayName("Allowed Product Code")]
    [IsoXmlTag("AllwdPdctCd")]
    public Product4? AllowedProductCode { get; init; } 
    
    /// <summary>
    /// Product code not allowed by the payment card.
    /// </summary>
    [IsoId("_Trja96zjEeaS8qpTeYtFzA")]
    [DisplayName("Not Allowed Product Code")]
    [IsoXmlTag("NotAllwdPdctCd")]
    public Product4? NotAllowedProductCode { get; init; } 
    
    /// <summary>
    /// Products that may be added to the purchase after the authorisation.
    /// </summary>
    [IsoId("_Trja-azjEeaS8qpTeYtFzA")]
    [DisplayName("Additional Available Product")]
    [IsoXmlTag("AddtlAvlblPdct")]
    public Product5? AdditionalAvailableProduct { get; init; } 
    
    /// <summary>
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_Trja-6zjEeaS8qpTeYtFzA")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection41? Balance { get; init; } 
    
    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_Trja_azjEeaS8qpTeYtFzA")]
    [DisplayName("Protected Balance")]
    [IsoXmlTag("PrtctdBal")]
    public ContentInformationType10? ProtectedBalance { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_Trja_6zjEeaS8qpTeYtFzA")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action8? Action { get; init; } 
    
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be proposed to the cardholder.
    /// </summary>
    [IsoId("_TrjbAazjEeaS8qpTeYtFzA")]
    [DisplayName("Currency Conversion Eligibility")]
    [IsoXmlTag("CcyConvsElgblty")]
    public CurrencyConversion12? CurrencyConversionEligibility { get; init; } 
    
    
    #nullable disable
    
}
