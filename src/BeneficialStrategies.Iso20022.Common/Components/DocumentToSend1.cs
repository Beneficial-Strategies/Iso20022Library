// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Determine the type of document and the type of communication method to be used to notify a Party.
/// </summary>
[IsoId("_RTCTPtp-Ed-ak6NoX_4Aeg_436078909")]
[DisplayName("Document To Send")]
public partial record DocumentToSend1
{
    #nullable enable
    
    /// <summary>
    /// Type of document.
    /// </summary>
    [IsoId("_RTCTP9p-Ed-ak6NoX_4Aeg_1009585509")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Type { get; init; } 
    
    /// <summary>
    /// Party that should receive the document.
    /// </summary>
    [IsoId("_RTCTQNp-Ed-ak6NoX_4Aeg_1020668296")]
    [DisplayName("Recipient")]
    [IsoXmlTag("Rcpt")]
    public required PartyIdentification2Choice_ Recipient { get; init; } 
    
    /// <summary>
    /// Communication method to be used.
    /// </summary>
    [IsoId("_RTCTQdp-Ed-ak6NoX_4Aeg_1018819949")]
    [DisplayName("Method Of Transmission")]
    [IsoXmlTag("MtdOfTrnsmssn")]
    public required CommunicationMethod1Code MethodOfTransmission { get; init; } 
    
    /// <summary>
    /// Communication means used to send information.
    /// </summary>
    [IsoId("_RTLdINp-Ed-ak6NoX_4Aeg_-506656279")]
    [DisplayName("Extended Method Of Transmission")]
    [IsoXmlTag("XtndedMtdOfTrnsmssn")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoExtended350Code ExtendedMethodOfTransmission { get; init; } 
    
    
    #nullable disable
    
}
