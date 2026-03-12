// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request a secure input for a PIN.
/// </summary>
[IsoId("_3Q3kMS_FEeugIJ3Gvoevmg")]
[DisplayName("Device Secure Input Request")]
public partial record DeviceSecureInputRequest3
{
    #nullable enable
    
    /// <summary>
    /// Type of PIN Service.
    /// </summary>
    [IsoId("_3f3pgS_FEeugIJ3Gvoevmg")]
    [DisplayName("PIN Request Type")]
    [IsoXmlTag("PINReqTp")]
    public required PINRequestType1Code PINRequestType { get; init; } 
    
    /// <summary>
    /// Identify the PIN verification method and keys.
    /// </summary>
    [IsoId("_3f3pgy_FEeugIJ3Gvoevmg")]
    [DisplayName("PIN Verification Method")]
    [IsoXmlTag("PINVrfctnMtd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? PINVerificationMethod { get; init; } 
    
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    [IsoId("_3f3phS_FEeugIJ3Gvoevmg")]
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? MaximumWaitingTime { get; init; } 
    
    /// <summary>
    /// Indicates, when the user press a key, if a beep has to be generated.
    /// </summary>
    [IsoId("_3f3phy_FEeugIJ3Gvoevmg")]
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    
    /// <summary>
    /// Enciphered PIN and related information.
    /// </summary>
    [IsoId("_3f3piS_FEeugIJ3Gvoevmg")]
    [DisplayName("Cardholder PIN")]
    [IsoXmlTag("CrdhldrPIN")]
    public OnLinePIN8? CardholderPIN { get; init; } 
    
    
    #nullable disable
    
}
