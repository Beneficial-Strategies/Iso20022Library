// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines the criteria used to search for calendar data.
/// </summary>
[IsoId("_w9W9hYm5Eeipw6hHPgB4Sw")]
[DisplayName("Calendar Search Criteria")]
public partial record CalendarSearchCriteria1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the year for which the calendar information must be returned.
    /// </summary>
    [IsoId("_4unTUIm5Eeipw6hHPgB4Sw")]
    [DisplayName("Year")]
    [IsoXmlTag("Yr")]
    [IsoSimpleType(IsoSimpleType.ISOYear)]
    public IsoISOYear? Year { get; init; } 
    
    /// <summary>
    /// Specifies the month for which the calendar information must be returned.
    /// </summary>
    [IsoId("_6zc44Im5Eeipw6hHPgB4Sw")]
    [DisplayName("Month")]
    [IsoXmlTag("Mnth")]
    [IsoSimpleType(IsoSimpleType.ISOMonth)]
    public IsoISOMonth? Month { get; init; } 
    
    /// <summary>
    /// Specifies the service or system for which the calendar information must be returned.
    /// </summary>
    [IsoId("_kKD0sIm6Eeipw6hHPgB4Sw")]
    [DisplayName("Service")]
    [IsoXmlTag("Svc")]
    public SystemAndCurrency1? Service { get; init; } 
    
    
    #nullable disable
    
}
