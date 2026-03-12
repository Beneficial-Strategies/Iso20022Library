// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Structured call details with address.
/// </summary>
[IsoId("_VvH_sR1CEey8XKHwKquEQw")]
[DisplayName("Telecom Call Details")]
public partial record TelecomCallDetails2
{
    #nullable enable
    
    /// <summary>
    /// Contains call type values.
    /// </summary>
    [IsoId("_V25boR1CEey8XKHwKquEQw")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public TelephonyCallType1Code? Type { get; init; } 
    
    /// <summary>
    /// Contains other call type values.
    /// </summary>
    [IsoId("_V25box1CEey8XKHwKquEQw")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? OtherType { get; init; } 
    
    /// <summary>
    /// Origination or destination phone number.
    /// </summary>
    [IsoId("_V25bpR1CEey8XKHwKquEQw")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public IsoPhoneNumber? PhoneNumber { get; init; } 
    
    /// <summary>
    /// City from which or to which the call was made.
    /// </summary>
    [IsoId("_V25bpx1CEey8XKHwKquEQw")]
    [DisplayName("City")]
    [IsoXmlTag("City")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? City { get; init; } 
    
    /// <summary>
    /// State from which or to which the call was made.
    /// </summary>
    [IsoId("_V25bqR1CEey8XKHwKquEQw")]
    [DisplayName("State")]
    [IsoXmlTag("Stat")]
    [IsoSimpleType(IsoSimpleType.Max16Text)]
    [StringLength(maximumLength: 16 ,MinimumLength = 1)]
    public IsoMax16Text? State { get; init; } 
    
    /// <summary>
    /// Province from which or to which the call was made.
    /// </summary>
    [IsoId("_V25bqx1CEey8XKHwKquEQw")]
    [DisplayName("Province")]
    [IsoXmlTag("Prvc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Province { get; init; } 
    
    /// <summary>
    /// Country from which or to which the call was made.
    /// </summary>
    [IsoId("_V25brR1CEey8XKHwKquEQw")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; } 
    
    
    #nullable disable
    
}
