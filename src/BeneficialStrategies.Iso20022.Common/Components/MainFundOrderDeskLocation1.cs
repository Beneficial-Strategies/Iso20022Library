// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// U-003-2009 Addition and Modification of choice component. S-009-2009 They are not valid business options in the redemption processing context. S-015-2009 Add new data elements to indicate time zone.
/// </summary>
[IsoId("_SsJbPdp-Ed-ak6NoX_4Aeg_2033258756")]
[DisplayName("Main Fund Order Desk Location")]
public partial record MainFundOrderDeskLocation1
{
    #nullable enable
    
    /// <summary>
    /// Country in which it is authorised to commercialise the fund.
    /// </summary>
    [IsoId("_SsJbPtp-Ed-ak6NoX_4Aeg_1855465345")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public required CountryCode Country { get; init; } 
    
    /// <summary>
    /// Offset of the reporting time before or after 00: 00 hour UTC.
    /// </summary>
    [IsoId("_SsJbP9p-Ed-ak6NoX_4Aeg_-559851982")]
    [DisplayName("Time Zone Off Set")]
    [IsoXmlTag("TmZoneOffSet")]
    public required UTCOffset1 TimeZoneOffSet { get; init; } 
    
    
    #nullable disable
    
}
