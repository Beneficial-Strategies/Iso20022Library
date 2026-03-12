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
[IsoId("_TF_lZwEcEeCQm6a_G2yO_w_-912290278")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment6
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_TF_laAEcEeCQm6a_G2yO_w_-440182318")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer1? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_TF_laQEcEeCQm6a_G2yO_w_-1818865261")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation5? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_TF_lagEcEeCQm6a_G2yO_w_1586282777")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction1? POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_TF_lawEcEeCQm6a_G2yO_w_856227117")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard3 Card { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_TF_lbAEcEeCQm6a_G2yO_w_343677043")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder2? Cardholder { get; init; } 
    
    
    #nullable disable
    
}
