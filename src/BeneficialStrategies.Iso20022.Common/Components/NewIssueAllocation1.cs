// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the investment account ownership with respect to new issue allocation for a hedge fund.
/// </summary>
[IsoId("_TUE97Np-Ed-ak6NoX_4Aeg_932071403")]
[DisplayName("New Issue Allocation")]
public partial record NewIssueAllocation1
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the investor is eligible to participate in the profits and losses from a new issue.
    /// </summary>
    [IsoId("_TUE97dp-Ed-ak6NoX_4Aeg_1017959443")]
    [DisplayName("Restricted")]
    [IsoXmlTag("Rstrctd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator Restricted { get; init; } 
    
    /// <summary>
    /// Reason for exemption.
    /// </summary>
    [IsoId("_TUOu4Np-Ed-ak6NoX_4Aeg_1035504314")]
    [DisplayName("Exempt Person Reason")]
    [IsoXmlTag("XmptPrsnRsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ExemptPersonReason { get; init; } 
    
    /// <summary>
    /// Conditions applicable when the investor is covered by the &quot;de minimis&quot; exemption.
    /// </summary>
    [IsoId("_TUOu4dp-Ed-ak6NoX_4Aeg_-197331579")]
    [DisplayName("De Minimus Applicable")]
    [IsoXmlTag("DeMnmsAplbl")]
    public DeMinimusApplicable1? DeMinimusApplicable { get; init; } 
    
    /// <summary>
    /// Conditions applicable when the investor is not covered by the &quot;de minimis&quot; exemption.
    /// </summary>
    [IsoId("_TUOu4tp-Ed-ak6NoX_4Aeg_158223027")]
    [DisplayName("De Minimus Not Applicable")]
    [IsoXmlTag("DeMnmsNotAplbl")]
    public DeMinimusNotApplicable1? DeMinimusNotApplicable { get; init; } 
    
    
    #nullable disable
    
}
