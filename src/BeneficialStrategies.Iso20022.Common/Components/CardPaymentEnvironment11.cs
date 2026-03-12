// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction given in a response to a request.
/// </summary>
[IsoId("_JxSu8QvWEeKzJ69IWwzB9Q")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment11
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_KEMc0QvWEeKzJ69IWwzB9Q")]
    [DisplayName("Acquirer Identification")]
    [IsoXmlTag("AcqrrId")]
    public GenericIdentification32? AcquirerIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_KEMc1QvWEeKzJ69IWwzB9Q")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the POI performing the transaction.
    /// </summary>
    [IsoId("_KEMc2QvWEeKzJ69IWwzB9Q")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; } 
    
    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_KEMc3QvWEeKzJ69IWwzB9Q")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType5? ProtectedCardData { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_KEMc4QvWEeKzJ69IWwzB9Q")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData3? PlainCardData { get; init; } 
    
    
    #nullable disable
    
}
