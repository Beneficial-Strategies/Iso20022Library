// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Mobile Data6.
/// </summary>
[IsoId("_2kGeAZB5Ee6FLLjWp95ntQ")]
[DisplayName("Mobile Data6")]
public partial record MobileData6
{
    #nullable enable

    /// <summary>
    /// Geolocation.
    /// </summary>
    [DisplayName("Geolocation")]
    [IsoXmlTag("Glctn")]
    public Geolocation1? Geolocation { get; init; } 

    /// <summary>
    /// Mobile Country Code.
    /// </summary>
    [DisplayName("Mobile Country Code")]
    [IsoXmlTag("MobCtryCd")]
    public IsoMin2Max3AlphaText? MobileCountryCode { get; init; } 

    /// <summary>
    /// Mobile Masked MSISDN.
    /// </summary>
    [DisplayName("Mobile Masked MSISDN")]
    [IsoXmlTag("MobMskdMSISDN")]
    public IsoMax35Text? MobileMaskedMSISDN { get; init; } 

    /// <summary>
    /// Mobile Network Code.
    /// </summary>
    [DisplayName("Mobile Network Code")]
    [IsoXmlTag("MobNtwkCd")]
    public IsoMin2Max3NumericText? MobileNetworkCode { get; init; } 

    /// <summary>
    /// Protected Mobile Data.
    /// </summary>
    [DisplayName("Protected Mobile Data")]
    [IsoXmlTag("PrtctdMobData")]
    public ContentInformationType40? ProtectedMobileData { get; init; } 

    /// <summary>
    /// Sensitive Mobile Data.
    /// </summary>
    [DisplayName("Sensitive Mobile Data")]
    [IsoXmlTag("SnstvMobData")]
    public SensitiveMobileData1? SensitiveMobileData { get; init; } 

    
    #nullable disable
    
}
