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
[IsoId("_AYEXMtokEeC60axPepSq7g_-1155773451")]
[DisplayName("Status And Reason")]
public partial record StatusAndReason10
{
    #nullable enable
    
    /// <summary>
    /// Status of affirmation of a trade.
    /// </summary>
    [IsoId("_AYEXM9okEeC60axPepSq7g_-1696321282")]
    [DisplayName("Affirmation Status")]
    [IsoXmlTag("AffirmSts")]
    public required AffirmationStatus7Choice_ AffirmationStatus { get; init; } 
    
    /// <summary>
    /// Specifies the reason why the instruction has an unaffirmed status.
    /// </summary>
    [IsoId("_AYEXNNokEeC60axPepSq7g_1078389926")]
    [DisplayName("Unaffirmed Reason")]
    [IsoXmlTag("UaffrmdRsn")]
    public UnaffirmedReason2Choice_? UnaffirmedReason { get; init; } 
    
    /// <summary>
    /// Provides additional information about the reason in narrative form.
    /// </summary>
    [IsoId("_AYEXNdokEeC60axPepSq7g_1323167811")]
    [DisplayName("Additional Reason Information")]
    [IsoXmlTag("AddtlRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max210Text)]
    [StringLength(maximumLength: 210 ,MinimumLength = 1)]
    public IsoMax210Text? AdditionalReasonInformation { get; init; } 
    
    
    #nullable disable
    
}
