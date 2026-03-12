// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Year in which the ISA plan is issued.
/// </summary>
[IsoId("_Sv3dmNp-Ed-ak6NoX_4Aeg_98060804")]
[DisplayName("ISA Years Of Issue")]
public partial record ISAYearsOfIssue1
{
    #nullable enable
    
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_Sv3dmdp-Ed-ak6NoX_4Aeg_98062664")]
    [DisplayName("Current Year Type")]
    [IsoXmlTag("CurYrTp")]
    public ISAType1Code? CurrentYearType { get; init; } 
    
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_Sv3dmtp-Ed-ak6NoX_4Aeg_642016687")]
    [DisplayName("Extended Current Year Type")]
    [IsoXmlTag("XtndedCurYrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCurrentYearType { get; init; } 
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_Sv3dm9p-Ed-ak6NoX_4Aeg_1710283535")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_Sv3dnNp-Ed-ak6NoX_4Aeg_1898859737")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear1? PreviousYears { get; init; } 
    
    /// <summary>
    /// Specifies the amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_SwBOkNp-Ed-ak6NoX_4Aeg_1154359412")]
    [DisplayName("Current Year Subscription Details")]
    [IsoXmlTag("CurYrSbcptDtls")]
    public SubscriptionInformation1? CurrentYearSubscriptionDetails { get; init; } 
    
    
    #nullable disable
    
}
