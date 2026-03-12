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
[IsoId("_9DkU0WitEeS87LmvcA55sg")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment32
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_9QkPAWitEeS87LmvcA55sg")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_9QkPA2itEeS87LmvcA55sg")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_9QkPBWitEeS87LmvcA55sg")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction4 POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_9QkPB2itEeS87LmvcA55sg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard9 Card { get; init; } 
    
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_VFzqMGjMEeSHBr6v3XO0Mg")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_b1o_QGjMEeSHBr6v3XO0Mg")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; } 
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_5F5MoGkhEeSTIuB9A-QJ6g")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken1? PaymentToken { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_9QkPCWitEeS87LmvcA55sg")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder7? Cardholder { get; init; } 
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_9QkPC2itEeS87LmvcA55sg")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType10? ProtectedCardholderData { get; init; } 
    
    
    #nullable disable
    
}
