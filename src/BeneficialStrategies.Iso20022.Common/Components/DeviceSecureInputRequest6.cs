// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Device Secure Input Request6.
/// </summary>
[IsoId("_Cni7kZCXEe6zroekBXoFoQ")]
[DisplayName("Device Secure Input Request6")]
public partial record DeviceSecureInputRequest6
{
    #nullable enable

    /// <summary>
    /// Beep Key Flag.
    /// </summary>
    [DisplayName("Beep Key Flag")]
    [IsoXmlTag("BeepKeyFlg")]
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 

    /// <summary>
    /// Cardholder PIN.
    /// </summary>
    [DisplayName("Cardholder PIN")]
    [IsoXmlTag("CrdhldrPIN")]
    public OnLinePIN11? CardholderPIN { get; init; } 

    /// <summary>
    /// Maximum Waiting Time.
    /// </summary>
    [DisplayName("Maximum Waiting Time")]
    [IsoXmlTag("MaxWtgTm")]
    public IsoNumber? MaximumWaitingTime { get; init; } 

    /// <summary>
    /// PIN Request Type.
    /// </summary>
    [DisplayName("PIN Request Type")]
    [IsoXmlTag("PINReqTp")]
    public required PINRequestType1Code PINRequestType { get; init; } 

    /// <summary>
    /// PIN Verification Method.
    /// </summary>
    [DisplayName("PIN Verification Method")]
    [IsoXmlTag("PINVrfctnMtd")]
    public IsoMax35Text? PINVerificationMethod { get; init; } 

    
    #nullable disable
    
}
