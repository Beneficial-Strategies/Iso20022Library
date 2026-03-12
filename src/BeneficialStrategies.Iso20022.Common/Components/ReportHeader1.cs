// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General properties of the report.
/// </summary>
[IsoId("_UsI9ANp-Ed-ak6NoX_4Aeg_-265750880")]
[DisplayName("Report Header")]
public partial record ReportHeader1
{
    #nullable enable
    
    /// <summary>
    /// Date and time at which the report was created.
    /// </summary>
    [IsoId("_UsI9Adp-Ed-ak6NoX_4Aeg_222794550")]
    [DisplayName("Creation Date Time")]
    [IsoXmlTag("CreDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime CreationDateTime { get; init; } 
    
    /// <summary>
    /// Identification of the type of report.
    /// </summary>
    [IsoId("_UsI9Atp-Ed-ak6NoX_4Aeg_606054530")]
    [DisplayName("Contents Type")]
    [IsoXmlTag("CntsTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ContentsType { get; init; } 
    
    
    #nullable disable
    
}
