// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Numerical representation of the net increases and decreases in an account at a specific point in time. A cash balance is calculated from a sum of cash credits minus a sum of cash debits.
/// </summary>
[IsoId("_SXk5Zdp-Ed-ak6NoX_4Aeg_2029299011")]
[DisplayName("Report Data")]
public partial record ReportData2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the report assigned by the central system.
    /// </summary>
    [IsoId("_SXk5Ztp-Ed-ak6NoX_4Aeg_2029299072")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Value date for which the pay-in schedule is generated.
    /// </summary>
    [IsoId("_SXk5Z9p-Ed-ak6NoX_4Aeg_986016359")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the report is generated. The offset with UTC may also be specified.
    /// </summary>
    [IsoId("_SXk5aNp-Ed-ak6NoX_4Aeg_2029299042")]
    [DisplayName("Date And Time Stamp")]
    [IsoXmlTag("DtAndTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateAndTimeStamp { get; init; } 
    
    /// <summary>
    /// Type of pay-in schedule.
    /// </summary>
    [IsoId("_SXk5adp-Ed-ak6NoX_4Aeg_2029299156")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Entry2Code Type { get; init; } 
    
    
    #nullable disable
    
}
