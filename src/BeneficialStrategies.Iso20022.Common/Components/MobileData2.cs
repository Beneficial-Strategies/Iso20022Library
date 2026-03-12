// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data related to the mobile of stakeholder.
/// </summary>
[IsoId("_G1x6EQxvEeqdx6buGpCCQw")]
[DisplayName("Mobile Data")]
public partial record MobileData2
{
    #nullable enable
    
    /// <summary>
    /// Identifies the country of a mobile phone operator.
    /// </summary>
    [IsoId("_HCfgYQxvEeqdx6buGpCCQw")]
    [DisplayName("Mobile Country Code")]
    [IsoXmlTag("MobCtryCd")]
    [IsoSimpleType(IsoSimpleType.Min2Max3AlphaText)]
    public IsoMin2Max3AlphaText? MobileCountryCode { get; init; } 
    
    /// <summary>
    /// Identifies the mobile phone operator inside a country.
    /// </summary>
    [IsoId("_HCfgYwxvEeqdx6buGpCCQw")]
    [DisplayName("Mobile Network Code")]
    [IsoXmlTag("MobNtwkCd")]
    [IsoSimpleType(IsoSimpleType.Min2Max3NumericText)]
    public IsoMin2Max3NumericText? MobileNetworkCode { get; init; } 
    
    /// <summary>
    /// Masked Mobile Subscriber Integrated Service Digital Network.
    /// </summary>
    [IsoId("_HCfgZQxvEeqdx6buGpCCQw")]
    [DisplayName("Mobile Masked MSISDN")]
    [IsoXmlTag("MobMskdMSISDN")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MobileMaskedMSISDN { get; init; } 
    
    /// <summary>
    /// Geographic location specified by geographic or UTM coordinates.
    /// </summary>
    [IsoId("_HCfgZwxvEeqdx6buGpCCQw")]
    [DisplayName("Geolocation")]
    [IsoXmlTag("Glctn")]
    public Geolocation1? Geolocation { get; init; } 
    
    /// <summary>
    /// Sensitive information related to the mobile phone.
    /// </summary>
    [IsoId("_HCfgaQxvEeqdx6buGpCCQw")]
    [DisplayName("Sensitive Mobile Data")]
    [IsoXmlTag("SnstvMobData")]
    public SensitiveMobileData1? SensitiveMobileData { get; init; } 
    
    /// <summary>
    /// Sensitive information related to the mobile phone, protected by CMS.
    /// </summary>
    [IsoId("_HCfgawxvEeqdx6buGpCCQw")]
    [DisplayName("Protected Mobile Data")]
    [IsoXmlTag("PrtctdMobData")]
    public ContentInformationType22? ProtectedMobileData { get; init; } 
    
    
    #nullable disable
    
}
