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
[IsoId("_t-2j8R0GEeK5OKMB21JFBg")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment18
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_uK6C9R0GEeK5OKMB21JFBg")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("AcqrrId")]
    public Acquirer2? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_uK6C_B0GEeK5OKMB21JFBg")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_uK6DAx0GEeK5OKMB21JFBg")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction2 POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_uK6DCh0GEeK5OKMB21JFBg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard6 Card { get; init; } 
    
    
    #nullable disable
    
}
