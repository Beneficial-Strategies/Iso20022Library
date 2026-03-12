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
[IsoId("_TEzSlwEcEeCQm6a_G2yO_w_1408119868")]
[DisplayName("Card Payment Transaction")]
public partial record CardPaymentTransaction9
{
    #nullable enable
    
    /// <summary>
    /// Outcome of the authorisation, and actions to perform.
    /// </summary>
    [IsoId("_TEzSmAEcEeCQm6a_G2yO_w_1571684538")]
    [DisplayName("Authorisation Result")]
    [IsoXmlTag("AuthstnRslt")]
    public required AuthorisationResult1 AuthorisationResult { get; init; } 
    
    /// <summary>
    /// Result of the verifications performed by the issuer to deliver or decline the authorisation.
    /// </summary>
    [IsoId("_TEzSmQEcEeCQm6a_G2yO_w_1806123263")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult1? TransactionVerificationResult { get; init; } 
    
    /// <summary>
    /// Balance of the account, related to the payment.
    /// </summary>
    [IsoId("_TEzSmgEcEeCQm6a_G2yO_w_-1524805732")]
    [DisplayName("Balance")]
    [IsoXmlTag("Bal")]
    public ImpliedCurrencyAndAmount? Balance { get; init; } 
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_TEzSmwEcEeCQm6a_G2yO_w_-1107641463")]
    [DisplayName("Currency")]
    [IsoXmlTag("Ccy")]
    public CurrencyCode? Currency { get; init; } 
    
    /// <summary>
    /// Set of actions to be performed by the POI (Point Of Interaction) system.
    /// </summary>
    [IsoId("_TEzSnAEcEeCQm6a_G2yO_w_344251506")]
    [DisplayName("Action")]
    [IsoXmlTag("Actn")]
    public Action1? Action { get; init; } 
    
    
    #nullable disable
    
}
