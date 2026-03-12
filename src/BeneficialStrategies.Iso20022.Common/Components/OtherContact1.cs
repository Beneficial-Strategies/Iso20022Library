// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Communication device number or electronic address used for communication.
/// </summary>
[IsoId("_6SokSZqlEeGSON8vddiWzQ_1969673172")]
[DisplayName("Other Contact")]
public partial record OtherContact1
{
    #nullable enable
    
    /// <summary>
    /// Method used to contact the financial institution’s contact for the specific tax region.
    /// </summary>
    [IsoId("_6SokSpqlEeGSON8vddiWzQ_444512870")]
    [DisplayName("Channel Type")]
    [IsoXmlTag("ChanlTp")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public required IsoMax4Text ChannelType { get; init; } 
    
    /// <summary>
    /// Communication value such as phone number or email address.
    /// </summary>
    [IsoId("_6SokS5qlEeGSON8vddiWzQ_938910947")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max128Text)]
    [StringLength(maximumLength: 128 ,MinimumLength = 1)]
    public IsoMax128Text? Identification { get; init; } 
    
    
    #nullable disable
    
}
