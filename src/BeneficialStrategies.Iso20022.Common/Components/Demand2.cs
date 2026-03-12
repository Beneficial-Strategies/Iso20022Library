// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the demand.
/// </summary>
[IsoId("_-BGHRHltEeG7BsjMvd1mEw_-404786743")]
[DisplayName("Demand")]
public partial record Demand2
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier assigned by the presenting party to the demand.
    /// </summary>
    [IsoId("_-BPRMHltEeG7BsjMvd1mEw_-714323342")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Identification { get; init; } 
    
    /// <summary>
    /// Date and time the demand is submitted.
    /// </summary>
    [IsoId("_-BPRMXltEeG7BsjMvd1mEw_-2132678643")]
    [DisplayName("Submission Date Time")]
    [IsoXmlTag("SubmissnDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public required IsoISODateTime SubmissionDateTime { get; init; } 
    
    /// <summary>
    /// Amount and currency of the demand.
    /// </summary>
    [IsoId("_-BPRMnltEeG7BsjMvd1mEw_-657005259")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Additional information related to the demand.
    /// </summary>
    [IsoId("_AE2bQxVMEeKVqNjC36CBuQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max2000Text)]
    [MinLength(0)]
    [MaxLength(5)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
