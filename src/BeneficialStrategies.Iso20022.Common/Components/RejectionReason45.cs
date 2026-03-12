// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides reasons of rejecting transactions.
/// </summary>
[IsoId("_Tr7yRcrdEeii_5g6VX90qQ")]
[DisplayName("Rejection Reason")]
public partial record RejectionReason45
{
    #nullable enable
    
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_T1Bc0crdEeii_5g6VX90qQ")]
    [DisplayName("Message Report Identification")]
    [IsoXmlTag("MsgRptId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text MessageReportIdentification { get; init; } 
    
    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_T1Bc08rdEeii_5g6VX90qQ")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportingMessageStatus1Code Status { get; init; } 
    
    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_T1Bc1crdEeii_5g6VX90qQ")]
    [DisplayName("Detailed Validation Rule")]
    [IsoXmlTag("DtldVldtnRule")]
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; } 
    
    
    #nullable disable
    
}
