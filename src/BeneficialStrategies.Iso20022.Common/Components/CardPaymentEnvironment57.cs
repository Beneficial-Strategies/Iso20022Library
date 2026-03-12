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
[IsoId("_STWccapzEeanIZ10Ka8PnA")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment57
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_Sey3capzEeanIZ10Ka8PnA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the card payment transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_SezegapzEeanIZ10Ka8PnA")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation25? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_Sezeg6pzEeanIZ10Ka8PnA")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public required PointOfInteraction7 POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_SezehapzEeanIZ10Ka8PnA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard21 Card { get; init; } 
    
    /// <summary>
    /// Device used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_Sezeh6pzEeanIZ10Ka8PnA")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_SezeiapzEeanIZ10Ka8PnA")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; } 
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_Sezei6pzEeanIZ10Ka8PnA")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken1? PaymentToken { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_SezejapzEeanIZ10Ka8PnA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder12? Cardholder { get; init; } 
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_Sezej6pzEeanIZ10Ka8PnA")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType10? ProtectedCardholderData { get; init; } 
    
    
    #nullable disable
    
}
