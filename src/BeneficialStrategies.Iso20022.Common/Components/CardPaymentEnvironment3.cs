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
[IsoId("_TFGNgQEcEeCQm6a_G2yO_w_-1132473632")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment3
{
    #nullable enable
    
    /// <summary>
    /// Acquirer involved in the card payment.
    /// </summary>
    [IsoId("_TFGNggEcEeCQm6a_G2yO_w_-657581548")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public Acquirer1? Acquirer { get; init; } 
    
    /// <summary>
    /// Identification of the merchant.
    /// </summary>
    [IsoId("_TFGNgwEcEeCQm6a_G2yO_w_382452747")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the POI performing the transaction.
    /// </summary>
    [IsoId("_TFGNhAEcEeCQm6a_G2yO_w_-1007328973")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; } 
    
    /// <summary>
    /// Sensitive data of the card (PlainCardData1 including the envelope), encrypted with a cryptographic key.
    /// </summary>
    [IsoId("_TFGNhQEcEeCQm6a_G2yO_w_-2057136478")]
    [DisplayName("Protected Card Data")]
    [IsoXmlTag("PrtctdCardData")]
    public ContentInformationType1? ProtectedCardData { get; init; } 
    
    /// <summary>
    /// Payment card performing the transaction.
    /// </summary>
    [IsoId("_TFGNhgEcEeCQm6a_G2yO_w_132607334")]
    [DisplayName("Plain Card Data")]
    [IsoXmlTag("PlainCardData")]
    public PlainCardData3? PlainCardData { get; init; } 
    
    
    #nullable disable
    
}
