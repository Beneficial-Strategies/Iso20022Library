// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the content of a report.
/// </summary>
[IsoId("_dItHIMlVEeuJ35KoBRZFOg")]
[DisplayName("Report Content")]
public partial record ReportContent1
{
    #nullable enable
    
    /// <summary>
    /// Sequence number of the report line in the report.
    /// </summary>
    [IsoId("_3xe8kMlVEeuJ35KoBRZFOg")]
    [DisplayName("Report Line Sequence")]
    [IsoXmlTag("RptLineSeq")]
    [IsoSimpleType(IsoSimpleType.Max10NumericText)]
    public IsoMax10NumericText? ReportLineSequence { get; init; } 
    
    /// <summary>
    /// Formatted or unformatted report content.
    /// </summary>
    [IsoId("_GZ00EMlYEeuJ35KoBRZFOg")]
    [DisplayName("Formatted Content")]
    [IsoXmlTag("FrmtdCntt")]
    public required ReportContent1Choice_ FormattedContent { get; init; } 
    
    
    #nullable disable
    
}
