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
[IsoId("_k9yHgWkkEeSTIuB9A-QJ6g")]
[DisplayName("Card Payment Transaction")]
public partial record CardPaymentTransaction39
{
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_lK-2AWkkEeSTIuB9A-QJ6g")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult4 AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_lK-2A2kkEeSTIuB9A-QJ6g")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult3? TransactionVerificationResult { get; init; } 
    
    /// <summary>
    /// Product code for which the authorisation was declined.
    /// </summary>
    [IsoId("_I9lWsGklEeSTIuB9A-QJ6g")]
    [DisplayName("Declined Product Code")]
    [IsoXmlTag("DclndPdctCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? DeclinedProductCode { get; init; } 
    
    /// <summary>
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_lK-2BWkkEeSTIuB9A-QJ6g")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public AmountAndDirection41? Balance { get; init; } 
    
    /// <summary>
    /// Encrypted balance of the account.
    /// </summary>
    [IsoId("_WbK9MGklEeSTIuB9A-QJ6g")]
    [DisplayName("Protected Balance")]
    [IsoXmlTag("PrtctdBal")]
    public ContentInformationType10? ProtectedBalance { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_lK-2B2kkEeSTIuB9A-QJ6g")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action3? Action { get; init; } 
    
    /// <summary>
    /// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be accepted by the cardholder.
    /// </summary>
    [IsoId("_lK-2CWkkEeSTIuB9A-QJ6g")]
    [DisplayName("Currency Conversion")]
    [IsoXmlTag("CcyConvs")]
    public CurrencyConversion3? CurrencyConversion { get; init; } 
    
    
    #nullable disable
    
}
