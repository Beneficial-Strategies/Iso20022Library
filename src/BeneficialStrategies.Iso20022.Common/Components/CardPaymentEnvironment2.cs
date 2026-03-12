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
[IsoId("_TEqIqgEcEeCQm6a_G2yO_w_1274559508")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment2
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_TEqIqwEcEeCQm6a_G2yO_w_2038625206")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer1? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_TEqIrAEcEeCQm6a_G2yO_w_83386860")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation5? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_TEqIrQEcEeCQm6a_G2yO_w_1518975286")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction1 POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_TEqIrgEcEeCQm6a_G2yO_w_183210541")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard3 Card { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_TEqIrwEcEeCQm6a_G2yO_w_-1992737319")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder2? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
