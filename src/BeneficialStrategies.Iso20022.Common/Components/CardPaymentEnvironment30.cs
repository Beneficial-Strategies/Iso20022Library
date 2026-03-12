// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_MDuQMTTiEeOLr8wG_Q16kw")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment30
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment transaction.
    /// </summary>
    [IsoId("_anpMoDTiEeOLr8wG_Q16kw")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification32? AcquirerIdentification { get; init; } 
    
    /// <summary>
    /// Merchant involved in the card payment transaction.
    /// </summary>
    [IsoId("_rwtmYDTiEeOLr8wG_Q16kw")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_MTM2pTTiEeOLr8wG_Q16kw")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction3 POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_MTM2pzTiEeOLr8wG_Q16kw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard7 Card { get; init; } 
    
    /// <summary>
    /// Language selected for the cardholder interface during the transaction.
    /// </summary>
    [IsoId("_5n_fQDTiEeOLr8wG_Q16kw")]
    [DisplayName("Cardholder Language")]
    [IsoXmlTag("CrdhldrLang")]
    public ISO2ALanguageCode? CardholderLanguage { get; init; } 
    
    
    #nullable disable
    
}
