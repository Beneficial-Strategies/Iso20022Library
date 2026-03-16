// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status Report Data Set Request5.
/// </summary>
[IsoId("_PdzGsZREEe6mHLZGMDWxvg")]
[DisplayName("Status Report Data Set Request5")]
public partial record StatusReportDataSetRequest5
{
    #nullable enable

    /// <summary>
    /// Content.
    /// </summary>
    [DisplayName("Content")]
    [IsoXmlTag("Cntt")]
    public required StatusReportContent13 Content { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required DataSetIdentification10 Identification { get; init; } 

    /// <summary>
    /// Last Sequence.
    /// </summary>
    [DisplayName("Last Sequence")]
    [IsoXmlTag("LastSeq")]
    public IsoTrueFalseIndicator? LastSequence { get; init; } 

    /// <summary>
    /// Sequence Counter.
    /// </summary>
    [DisplayName("Sequence Counter")]
    [IsoXmlTag("SeqCntr")]
    public IsoMax9NumericText? SequenceCounter { get; init; } 

    
    #nullable disable
    
}
