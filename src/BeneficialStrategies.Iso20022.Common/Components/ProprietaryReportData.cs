// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Full report data or reporting data of a single tranche of the full report.
/// </summary>
[IsoId("_UsI9Btp-Ed-ak6NoX_4Aeg_1382074733")]
[DisplayName("Proprietary Report Data")]
public partial record ProprietaryReportData
{
    #nullable enable
    
    /// <summary>
    /// IMPLEMENTORS WARNING - This element is replaced by the ANY XML type in the schema. Therefore, the XML tag &lt;Data&gt; does not appear in an actual XML instance.
    /// </summary>
    [IsoId("_UsI9B9p-Ed-ak6NoX_4Aeg_1926953180")]
    [DisplayName("Data")]
    [IsoXmlTag("Data")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Data { get; init; } 
    
    
    #nullable disable
    
}
