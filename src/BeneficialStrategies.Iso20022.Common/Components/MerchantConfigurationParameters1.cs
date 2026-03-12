// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acceptor parameters dedicated to the merchant.
/// </summary>
[IsoId("_m-dkUGptEeSMqvBfBY1c9A")]
[DisplayName("Merchant Configuration Parameters")]
public partial record MerchantConfigurationParameters1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the merchant for the MTM, if the POI manages several merchants.
    /// </summary>
    [IsoId("_1I9UIGptEeSMqvBfBY1c9A")]
    [DisplayName("Merchant Identification")]
    [IsoXmlTag("MrchntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MerchantIdentification { get; init; } 
    
    /// <summary>
    /// Version of the merchant parameters.
    /// </summary>
    [IsoId("_9oWiUGptEeSMqvBfBY1c9A")]
    [DisplayName("Version")]
    [IsoXmlTag("Vrsn")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text Version { get; init; } 
    
    /// <summary>
    /// Merchant parameters.
    /// </summary>
    [IsoId("_CqXqsGpuEeSMqvBfBY1c9A")]
    [DisplayName("Parameters")]
    [IsoXmlTag("Params")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public required IsoMax10000Binary Parameters { get; init; } 
    
    
    #nullable disable
    
}
