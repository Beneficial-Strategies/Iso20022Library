// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding notification general information details.
/// </summary>
[IsoId("_vkOZsb5NEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Notification SD")]
public partial record CorporateActionNotificationSD9
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_v2q0kb5NEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) created the announcement record.
    /// </summary>
    [IsoId("_v2q0k75NEeexmbB7KsjCwA")]
    [DisplayName("Create Date And Time")]
    [IsoXmlTag("CretDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreateDateAndTime { get; init; } 
    
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) last updated the announcement.
    /// </summary>
    [IsoId("_v2q0m75NEeexmbB7KsjCwA")]
    [DisplayName("Update Date And Time")]
    [IsoXmlTag("UpdDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? UpdateDateAndTime { get; init; } 
    
    
    #nullable disable
    
}
