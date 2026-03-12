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
[IsoId("_1cnPoTL3EeKU9IrkkToqcw_-1946623556")]
[DisplayName("Corporate Action Notification SD")]
public partial record CorporateActionNotificationSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1cnPojL3EeKU9IrkkToqcw_-185294215")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) created the announcement record.
    /// </summary>
    [IsoId("_1cnPozL3EeKU9IrkkToqcw_1725505269")]
    [DisplayName("Create Date And Time")]
    [IsoXmlTag("CretDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreateDateAndTime { get; init; } 
    
    /// <summary>
    /// Date and time when DTCC (The Depository Trust and Clearing Corporation) last updated the announcement.
    /// </summary>
    [IsoId("_1cnPpDL3EeKU9IrkkToqcw_-897285003")]
    [DisplayName("Update Date And Time")]
    [IsoXmlTag("UpdDtAndTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? UpdateDateAndTime { get; init; } 
    
    
    #nullable disable
    
}
