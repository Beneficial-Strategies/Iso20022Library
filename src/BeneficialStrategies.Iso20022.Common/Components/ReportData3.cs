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
[IsoId("_S3i5sgEcEeCQm6a_G2yO_w_1955726096")]
[DisplayName("Report Data")]
public partial record ReportData3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the report as assigned by the sender.
    /// </summary>
    [IsoId("_S3i5swEcEeCQm6a_G2yO_w_1841887030")]
    [DisplayName("Message Identification")]
    [IsoXmlTag("MsgId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text MessageIdentification { get; init; } 
    
    /// <summary>
    /// Value date for which the pay-in schedule is generated.
    /// </summary>
    [IsoId("_S3i5tAEcEeCQm6a_G2yO_w_958653743")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate ValueDate { get; init; } 
    
    /// <summary>
    /// Date and time on which the report is generated. The offset with UTC may also be specified.
    /// </summary>
    [IsoId("_S3i5tQEcEeCQm6a_G2yO_w_844814677")]
    [DisplayName("Date And Time Stamp")]
    [IsoXmlTag("DtAndTmStmp")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime DateAndTimeStamp { get; init; } 
    
    /// <summary>
    /// Type of pay-in schedule.
    /// </summary>
    [IsoId("_S3i5tgEcEeCQm6a_G2yO_w_-1725885432")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required Entry2Code Type { get; init; } 
    
    /// <summary>
    /// Identifies the settlement session to which the report applies. The first session of the day is 1.
    /// </summary>
    [IsoId("_S3i5twEcEeCQm6a_G2yO_w_-952737875")]
    [DisplayName("Settlement Session")]
    [IsoXmlTag("SttlmSsn")]
    [IsoSimpleType(IsoSimpleType.Number)]
    public IsoNumber? SettlementSession { get; init; } 
    
    
    #nullable disable
    
}
