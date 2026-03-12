// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details related to the status of the order.
/// </summary>
[IsoId("_Oqd4sQd3Ee2fOITqoTnSLQ")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason46
{
    #nullable enable
    
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_O8WS5Qd3Ee2fOITqoTnSLQ")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public required AffirmationStatus10Choice_ AffirmationStatus { get; init; } 
    
    /// <summary>
    /// Specifies the reason why the instruction has an unaffirmed status.
    /// </summary>
    [IsoId("_O8WS7Qd3Ee2fOITqoTnSLQ")]
    [DisplayName("Unaffirmed Reason")]
    [IsoXmlTag("UaffrmdRsn")]
    public UnaffirmedReason3Choice_? UnaffirmedReason { get; init; } 
    
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_O8WS7wd3Ee2fOITqoTnSLQ")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
