// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Card Acquisition Response message.
/// </summary>
[IsoId("_MaApkQxtEeqdx6buGpCCQw")]
[DisplayName("Card Acquisition Response")]
public partial record CardAcquisitionResponse2
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of a POI transaction.
    /// </summary>
    [IsoId("_MkyWMQxtEeqdx6buGpCCQw")]
    [DisplayName("POI Transaction Identification")]
    [IsoXmlTag("POITxId")]
    public required TransactionIdentifier1 POITransactionIdentification { get; init; } 
    
    /// <summary>
    /// Type of payment card.
    /// </summary>
    [IsoId("_MkyWMwxtEeqdx6buGpCCQw")]
    [DisplayName("Payment Brand")]
    [IsoXmlTag("PmtBrnd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PaymentBrand { get; init; } 
    
    /// <summary>
    /// Language used to display messages to the customer.
    /// </summary>
    [IsoId("_MkyWNQxtEeqdx6buGpCCQw")]
    [DisplayName("Customer Language")]
    [IsoXmlTag("CstmrLang")]
    public LanguageCode? CustomerLanguage { get; init; } 
    
    /// <summary>
    /// Loyalty account information.
    /// </summary>
    [IsoId("_MkyWNwxtEeqdx6buGpCCQw")]
    [DisplayName("Loyalty Account")]
    [IsoXmlTag("LltyAcct")]
    public LoyaltyAccount2? LoyaltyAccount { get; init; } 
    
    /// <summary>
    /// Customer order attached to a customer, recorded in the POI system.
    /// </summary>
    [IsoId("_MkyWOQxtEeqdx6buGpCCQw")]
    [DisplayName("Customer Order")]
    [IsoXmlTag("CstmrOrdr")]
    public CustomerOrder1? CustomerOrder { get; init; } 
    
    
    #nullable disable
    
}
