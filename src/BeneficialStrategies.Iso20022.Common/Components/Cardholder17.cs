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
[IsoId("_z02qYS9DEeu125Ip9zFcsQ")]
[DisplayName("Cardholder")]
public partial record Cardholder17
{
    #nullable enable
    
    /// <summary>
    /// Identification of the cardholder involved in a transaction.
    /// </summary>
    [IsoId("_0BKBAS9DEeu125Ip9zFcsQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PersonIdentification15? Identification { get; init; } 
    
    /// <summary>
    /// Cardholder name associated with the card.
    /// </summary>
    [IsoId("_0BKBAy9DEeu125Ip9zFcsQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max45Text)]
    [StringLength(maximumLength: 45 ,MinimumLength = 1)]
    public IsoMax45Text? Name { get; init; } 
    
    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// Reference ISO 639-1 (alpha-2) et ISO 639-2 (alpha-3).
    /// </summary>
    [IsoId("_0BKBBS9DEeu125Ip9zFcsQ")]
    [DisplayName("Language")]
    [IsoXmlTag("Lang")]
    public LanguageCode? Language { get; init; } 
    
    /// <summary>
    /// Postal address of the owner of the payment card.
    /// </summary>
    [IsoId("_0BKBBy9DEeu125Ip9zFcsQ")]
    [DisplayName("Billing Address")]
    [IsoXmlTag("BllgAdr")]
    public PostalAddress22? BillingAddress { get; init; } 
    
    /// <summary>
    /// Postal address for delivery of goods or services.
    /// </summary>
    [IsoId("_0BKBCS9DEeu125Ip9zFcsQ")]
    [DisplayName("Shipping Address")]
    [IsoXmlTag("ShppgAdr")]
    public PostalAddress22? ShippingAddress { get; init; } 
    
    /// <summary>
    /// Identification of the trip.
    /// </summary>
    [IsoId("_0BKBCy9DEeu125Ip9zFcsQ")]
    [DisplayName("Trip Number")]
    [IsoXmlTag("TripNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TripNumber { get; init; } 
    
    /// <summary>
    /// Information related to the vehicle used for the transaction.
    /// </summary>
    [IsoId("_0BKBDS9DEeu125Ip9zFcsQ")]
    [DisplayName("Vehicle")]
    [IsoXmlTag("Vhcl")]
    public Vehicle1? Vehicle { get; init; } 
    
    /// <summary>
    /// Method and data intended to be used for this transaction to authenticate the cardholder and its card.
    /// </summary>
    [IsoId("_0BKBDy9DEeu125Ip9zFcsQ")]
    [DisplayName("Authentication")]
    [IsoXmlTag("Authntcn")]
    public CardholderAuthentication14? Authentication { get; init; } 
    
    /// <summary>
    /// Result of performed verifications for the transaction.
    /// </summary>
    [IsoId("_0BKBES9DEeu125Ip9zFcsQ")]
    [DisplayName("Transaction Verification Result")]
    [IsoXmlTag("TxVrfctnRslt")]
    public TransactionVerificationResult4? TransactionVerificationResult { get; init; } 
    
    /// <summary>
    /// Identifies personal data related to the cardholder.
    /// </summary>
    [IsoId("_0BKBEy9DEeu125Ip9zFcsQ")]
    [DisplayName("Personal Data")]
    [IsoXmlTag("PrsnlData")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? PersonalData { get; init; } 
    
    /// <summary>
    /// Data related to the mobile of stakeholder.
    /// </summary>
    [IsoId("_0BKBFS9DEeu125Ip9zFcsQ")]
    [DisplayName("Mobile Data")]
    [IsoXmlTag("MobData")]
    public MobileData3? MobileData { get; init; } 
    
    
    #nullable disable
    
}
