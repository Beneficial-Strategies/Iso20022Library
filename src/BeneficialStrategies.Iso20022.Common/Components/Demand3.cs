// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details related to the demand.
/// </summary>
[IsoId("_-BPRM3ltEeG7BsjMvd1mEw_-593670886")]
[DisplayName("Demand")]
public partial record Demand3
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the presenting party to the demand.
    /// </summary>
    [IsoId("_-BPRNHltEeG7BsjMvd1mEw_485925889")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date and time of demand submission.
    /// </summary>
    [IsoId("_-BZCMHltEeG7BsjMvd1mEw_18772739")]
    [DisplayName("Submission Date Time")]
    [IsoXmlTag("SubmissnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime SubmissionDateTime { get; init; } 
    
    /// <summary>
    /// Amount and currency of the demand.
    /// </summary>
    [IsoId("_-BZCMXltEeG7BsjMvd1mEw_-66128484")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    
    #nullable disable
    
}
