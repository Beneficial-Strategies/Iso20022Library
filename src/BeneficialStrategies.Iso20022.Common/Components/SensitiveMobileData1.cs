// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Sensitive information related to the mobile phone.
/// </summary>
[IsoId("_U6ri8NtoEeipuvJHTHIw9A")]
[DisplayName("Sensitive Mobile Data")]
public partial record SensitiveMobileData1
{
    #nullable enable
    
    /// <summary>
    /// identifies the mobile - Mobile Subscriber Integrated Service Digital Network (The SIM identifier).
    /// </summary>
    [IsoId("_q4gFINtoEeipuvJHTHIw9A")]
    [DisplayName("MSISDN")]
    [IsoXmlTag("MSISDN")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public required IsoMax35NumericText MSISDN { get; init; } 
    
    /// <summary>
    /// International Mobile Subscriber Identity is a unique number associated with the mobile phone user, containing the Mobile Country Code (MCC), the Mobile Network Code (MNC), and the Mobile Identification Number (MSIN).
    /// </summary>
    [IsoId("_w87FsNtoEeipuvJHTHIw9A")]
    [DisplayName("IMSI")]
    [IsoXmlTag("IMSI")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? IMSI { get; init; } 
    
    /// <summary>
    /// International Mobile Equipment Identity is a number usually unique to identify a mobile phone.
    /// </summary>
    [IsoId("_1pDdoNtoEeipuvJHTHIw9A")]
    [DisplayName("IMEI")]
    [IsoXmlTag("IMEI")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    public IsoMax35NumericText? IMEI { get; init; } 
    
    
    #nullable disable
    
}
