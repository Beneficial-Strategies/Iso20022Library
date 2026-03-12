// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes search criteria for party audit trail query.
/// </summary>
[IsoId("_W5x_8Z7iEeezh9vfeoBoQw")]
[DisplayName("Party Audit Trail Search Criteria")]
public partial record PartyAuditTrailSearchCriteria2
{
    #nullable enable
    
    /// <summary>
    /// Describes party to be queried.
    /// </summary>
    [IsoId("_XDwbUZ7iEeezh9vfeoBoQw")]
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public SystemPartyIdentification8? PartyIdentification { get; init; } 
    
    /// <summary>
    /// Describes date period for querying information.
    /// </summary>
    [IsoId("_XDwbU57iEeezh9vfeoBoQw")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
    
    
    #nullable disable
    
}
