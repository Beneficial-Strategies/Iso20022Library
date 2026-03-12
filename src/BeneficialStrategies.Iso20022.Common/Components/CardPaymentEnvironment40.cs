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
[IsoId("_l0OMYWmJEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment40
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_mBpkYWmJEeS7iYydEtv3Ug")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer4? Acquirer { get; init; } 
    
    /// <summary>
    /// Merchant performing the transaction.
    /// Usage: In some cases, merchant and acceptor may be regarded as the same entity.
    /// </summary>
    [IsoId("_mBpkY2mJEeS7iYydEtv3Ug")]
    [DisplayName("Merchant")]
    [IsoXmlTag("Mrchnt")]
    public Organisation8? Merchant { get; init; } 
    
    /// <summary>
    /// Point of interaction (POI) performing the transaction.
    /// </summary>
    [IsoId("_mBpkZWmJEeS7iYydEtv3Ug")]
    [DisplayName("POI")]
    [IsoXmlTag("POI")]
    public PointOfInteraction4? POI { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_mBpkZ2mJEeS7iYydEtv3Ug")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required PaymentCard11 Card { get; init; } 
    
    /// <summary>
    /// Device used by the customer to perform the payment.
    /// </summary>
    [IsoId("_Kh7DYGmKEeS7iYydEtv3Ug")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice1? CustomerDevice { get; init; } 
    
    /// <summary>
    /// Container of tenders used by the customer to perform the payment.
    /// </summary>
    [IsoId("_O-7aMGmKEeS7iYydEtv3Ug")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public CustomerDevice1? Wallet { get; init; } 
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_UPswQGmKEeS7iYydEtv3Ug")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken3? PaymentToken { get; init; } 
    
    /// <summary>
    /// Cardholder involved in the card payment.
    /// </summary>
    [IsoId("_mBpkaWmJEeS7iYydEtv3Ug")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder8? Cardholder { get; init; } 
    
    /// <summary>
    /// Replacement of the message element Cardholder by a digital envelope using a cryptographic key.
    /// </summary>
    [IsoId("_mBpka2mJEeS7iYydEtv3Ug")]
    [DisplayName("Protected Cardholder Data")]
    [IsoXmlTag("PrtctdCrdhldrData")]
    public ContentInformationType10? ProtectedCardholderData { get; init; } 
    
    
    #nullable disable
    
}
