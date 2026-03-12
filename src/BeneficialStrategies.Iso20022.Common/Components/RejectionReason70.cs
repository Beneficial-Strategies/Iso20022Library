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
[IsoId("_oYN5QU2UEe2bQ-Ksk8mwQg")]
[DisplayName("Rejection Reason")]
public partial record RejectionReason70
{
    #nullable enable
    
    /// <summary>
    /// Identification of the report.
    /// </summary>
    [IsoId("_oZjWAU2UEe2bQ-Ksk8mwQg")]
    [DisplayName("Message Report Identification")]
    [IsoXmlTag("MsgRptId")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text MessageReportIdentification { get; init; } 
    
    /// <summary>
    /// Information on status of submitted transactions.
    /// </summary>
    [IsoId("_oZjWA02UEe2bQ-Ksk8mwQg")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required ReportingMessageStatus2Code Status { get; init; } 
    
    /// <summary>
    /// Acceptance criteria of the transaction.
    /// </summary>
    [IsoId("_oZjWBU2UEe2bQ-Ksk8mwQg")]
    [DisplayName("Detailed Validation Rule")]
    [IsoXmlTag("DtldVldtnRule")]
    public GenericValidationRuleIdentification1? DetailedValidationRule { get; init; } 
    
    
    #nullable disable
    
}
