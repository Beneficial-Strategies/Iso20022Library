// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the card payment transaction.
/// </summary>
[IsoId("_EsWHAQvZEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment14
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_E3XEMQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer2? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_E3XENQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_E3XEOQvZEeKzJ69IWwzB9Q")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction2? POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_E3XEPQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard6 Card { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_E3XEQQvZEeKzJ69IWwzB9Q")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder4? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
