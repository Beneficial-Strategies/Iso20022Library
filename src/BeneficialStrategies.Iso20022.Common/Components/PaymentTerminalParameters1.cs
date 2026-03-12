// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Manufacturer configuration parameters of the point of interaction (POI).
/// </summary>
[IsoId("_yQlkAEeSEeODR7vDcYOqmg")]
[DisplayName("Payment Terminal Parameters")]
public partial record PaymentTerminalParameters1
{
    #nullable enable
    
    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    [IsoId("_O7L_4EeWEeODR7vDcYOqmg")]
    [DisplayName("Clock Synchronisation")]
    [IsoXmlTag("ClckSynctn")]
    public ClockSynchronisation1? ClockSynchronisation { get; init; } 
    
    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    [IsoId("_JFopIEeTEeODR7vDcYOqmg")]
    [DisplayName("Time Zone Line")]
    [IsoXmlTag("TmZoneLine")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? TimeZoneLine { get; init; } 
    
    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    [IsoId("_QbW5gEeTEeODR7vDcYOqmg")]
    [DisplayName("Other Parameters")]
    [IsoXmlTag("OthrParams")]
    [IsoSimpleType(IsoSimpleType.Max10000Binary)]
    public IsoMax10000Binary? OtherParameters { get; init; } 
    
    
    #nullable disable
    
}
