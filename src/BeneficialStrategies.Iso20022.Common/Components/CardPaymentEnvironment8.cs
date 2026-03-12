// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the diagnostic exchange.
/// </summary>
[IsoId("_TDwwxwEcEeCQm6a_G2yO_w_-51855289")]
[DisplayName("Card Payment Environment")]
public partial record CardPaymentEnvironment8
{
    #nullable enable
    
    /// <summary>
    /// Version of the payment application configuration parameters of the POI.
    /// </summary>
    [IsoId("_TDwwyAEcEeCQm6a_G2yO_w_-1444736902")]
    [DisplayName("Acquirer Parameters Version")]
    [IsoXmlTag("AcqrrParamsVrsn")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime AcquirerParametersVersion { get; init; } 
    
    /// <summary>
    /// Identification of the merchant requesting the diagnostic.
    /// </summary>
    [IsoId("_TDwwyQEcEeCQm6a_G2yO_w_-1440704983")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    public GenericIdentification32? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the POI requesting the diagnostic.
    /// </summary>
    [IsoId("_TDwwygEcEeCQm6a_G2yO_w_-1830436847")]
    [DisplayName("POI Identification")]
    [IsoXmlTag("POIId")]
    public required GenericIdentification32 POIIdentification { get; init; } 
    
    
    #nullable disable
    
}
