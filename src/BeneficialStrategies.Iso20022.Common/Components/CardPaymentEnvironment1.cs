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
[IsoId("_TFP-jgEcEeCQm6a_G2yO_w_-1511988492")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment1
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_TFP-jwEcEeCQm6a_G2yO_w_-1972659597")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer1? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_TFZvgAEcEeCQm6a_G2yO_w_1888981246")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation5? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_TFZvgQEcEeCQm6a_G2yO_w_-488677299")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction1 POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_TFZvggEcEeCQm6a_G2yO_w_1227665369")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard1 Card { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_TFZvgwEcEeCQm6a_G2yO_w_47262148")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder1? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
