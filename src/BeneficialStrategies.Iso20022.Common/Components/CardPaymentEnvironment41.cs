// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction given in a response to a request in a batch.
/// </summary>
[IsoId("_8oNkwWmNEeS7iYydEtv3Ug")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment41
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_81krUWmNEeS7iYydEtv3Ug")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification53? AcquirerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_81krU2mNEeS7iYydEtv3Ug")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the POI (Point Of Interaction) performing the transaction.
    /// </summary>
    [IsoId("_81krVWmNEeS7iYydEtv3Ug")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public GenericIdentification32? POIIdentification { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_LudyMGmOEeS7iYydEtv3Ug")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public PaymentCard10? Card { get; init; } 
    
    /// <summary>
    /// Payment token information.
    /// </summary>
    [IsoId("_afv1MGmOEeS7iYydEtv3Ug")]
    [DisplayName("Payment Token")]
    [IsoXmlTag("PmtTkn")]
    public CardPaymentToken2? PaymentToken { get; init; } 
    
    
    #nullable disable
    
}
