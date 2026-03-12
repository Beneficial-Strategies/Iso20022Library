// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the cancellation.
/// </summary>
[IsoId("_ZtSRkQvWEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment12
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_Z4TOwQvWEeKzJ69IWwzB9Q")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer2? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment cancellation.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_Z4TOxQvWEeKzJ69IWwzB9Q")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_Z4TOyQvWEeKzJ69IWwzB9Q")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction2 POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_Z4TOzQvWEeKzJ69IWwzB9Q")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard6 Card { get; init; } 
    
    
    #nullable disable
    
}
