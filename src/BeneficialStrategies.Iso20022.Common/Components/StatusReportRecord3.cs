// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the per record status details.
/// </summary>
[IsoId("_YZkjQdHEEeaokquJJ-K6uA")]
[DisplayName("Status Report Record")]
public partial record StatusReportRecord3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous technical identification of the original data for which the status is provided.
    /// </summary>
    [IsoId("_Yiw7gdHEEeaokquJJ-K6uA")]
    [DisplayName("Original Record Identification")]
    [IsoXmlTag("OrgnlRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text OriginalRecordIdentification { get; init; } 
    
    /// <summary>
    /// Defines status of the reported transaction.
    /// </summary>
    [IsoId("_Yiw7g9HEEeaokquJJ-K6uA")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportingRecordStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Provides the details of the rule which could not be validated.
    /// </summary>
    [IsoId("_Yiw7hdHEEeaokquJJ-K6uA")]
    [DisplayName("Validation Rule")]
    [IsoXmlTag("VldtnRule")]
    public GenericValidationRuleIdentification1? ValidationRule { get; init; } 
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_Yiw7h9HEEeaokquJJ-K6uA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
