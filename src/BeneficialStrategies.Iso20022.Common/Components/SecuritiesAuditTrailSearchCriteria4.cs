// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes search criteria for securities audit trail query.
/// </summary>
[IsoId("_QOJ0N5JKEeuAlLVx8pyt3w")]
[DisplayName("Securities Audit Trail Search Criteria")]
public partial record SecuritiesAuditTrailSearchCriteria4
{
    #nullable enable
    
    /// <summary>
    /// Describes security to be queried.
    /// </summary>
    [IsoId("_QQL0gZJKEeuAlLVx8pyt3w")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public SecurityIdentification39? FinancialInstrumentIdentification { get; init; } 
    
    /// <summary>
    /// Describes date period for querying information.
    /// </summary>
    [IsoId("_QQL0g5JKEeuAlLVx8pyt3w")]
    [DisplayName("Date Period")]
    [IsoXmlTag("DtPrd")]
    public DatePeriodSearch1Choice_? DatePeriod { get; init; } 
    
    
    #nullable disable
    
}
