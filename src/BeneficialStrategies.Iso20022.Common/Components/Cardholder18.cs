// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the cardholder.
/// </summary>
[IsoId("_IeDr0VFDEeyApZmLzm74zA")]
[DisplayName("Cardholder")]
public partial record Cardholder18
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_IkSPoVFDEeyApZmLzm74zA")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification15? Identification { get; init; } 
    
    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_IkSPo1FDEeyApZmLzm74zA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45 ,MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; } 
    
    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_IkSPpVFDEeyApZmLzm74zA")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_IkSPp1FDEeyApZmLzm74zA")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress22? BillingAddress { get; init; } 
    
    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_IkSPqVFDEeyApZmLzm74zA")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress22? ShippingAddress { get; init; } 
    
    /// <summary>
    /// Identification of the trip.
    /// </summary>
    [IsoId("_IkSPq1FDEeyApZmLzm74zA")]
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TripNumber { get; init; } 
    
    /// <summary>
    /// Information related to the vehicle used for the transaction.
    /// </summary>
    [IsoId("_IkSPrVFDEeyApZmLzm74zA")]
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle1? Vehicle { get; init; } 
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    [IsoId("_IkSPr1FDEeyApZmLzm74zA")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public CardholderAuthentication15? Authentication { get; init; } 
    
    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_IkSPsVFDEeyApZmLzm74zA")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    
    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_IkSPs1FDEeyApZmLzm74zA")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; } 
    
    /// <summary>
    /// Data related to the mobile of stakeholder.
    /// </summary>
    [IsoId("_IkSPtVFDEeyApZmLzm74zA")]
    [DisplayName("Mobile Data")]
    [IsoXmlTag("MobData")]
    public MobileData4? MobileData { get; init; } 
    
    
    #nullable disable
    
}
