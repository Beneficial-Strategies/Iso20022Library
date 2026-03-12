// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional action to perform.
/// </summary>
[IsoId("_rz-88EXVEeegp_DADCe7HQ")]
[DisplayName("Additional Action")]
public partial record AdditionalAction1
{
    #nullable enable
    
    /// <summary>
    /// Type of additional action to perform.
    /// </summary>
    [IsoId("__xUOEEXVEeegp_DADCe7HQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public ActionType10Code? Type { get; init; } 
    
    /// <summary>
    /// Destination of the additional action to perform.
    /// </summary>
    [IsoId("_E87XUEXWEeegp_DADCe7HQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyType21Code? Destination { get; init; } 
    
    /// <summary>
    /// Other destination of action.
    /// </summary>
    [IsoId("_Hk9cMFKdEeeFcfYfFkVztg")]
    [DisplayName("Other Destination")]
    [IsoXmlTag("OthrDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherDestination { get; init; } 
    
    /// <summary>
    /// Type of destination of the additional action to perform.
    /// </summary>
    [IsoId("_LyI7oEXWEeegp_DADCe7HQ")]
    [DisplayName("Destination Type")]
    [IsoXmlTag("DstnTp")]
    public ActionDestination1Code? DestinationType { get; init; } 
    
    /// <summary>
    /// Other type of destination.
    /// </summary>
    [IsoId("_W88S0FKdEeeFcfYfFkVztg")]
    [DisplayName("Other Destination Type")]
    [IsoXmlTag("OthrDstnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherDestinationType { get; init; } 
    
    /// <summary>
    /// Physical destination address of the additional action to perform (for example, URL, mobile phone number, IP address, file name, etc.).
    /// </summary>
    [IsoId("_aK9bUEXWEeegp_DADCe7HQ")]
    [DisplayName("Destination Address")]
    [IsoXmlTag("DstnAdr")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? DestinationAddress { get; init; } 
    
    /// <summary>
    /// Format of the message associated with the additional action to perform.
    /// </summary>
    [IsoId("_gy7N0EXWEeegp_DADCe7HQ")]
    [DisplayName("Format")]
    [IsoXmlTag("Frmt")]
    public OutputFormat4Code? Format { get; init; } 
    
    /// <summary>
    /// Other type of format for action data.
    /// </summary>
    [IsoId("_kIV9IFKdEeeFcfYfFkVztg")]
    [DisplayName("Other Format")]
    [IsoXmlTag("OthrFrmt")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherFormat { get; init; } 
    
    /// <summary>
    /// Content of or reference to the message.
    /// </summary>
    [IsoId("_REnvoEXbEeegp_DADCe7HQ")]
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public Content1? Content { get; init; } 
    
    
    #nullable disable
    
}
