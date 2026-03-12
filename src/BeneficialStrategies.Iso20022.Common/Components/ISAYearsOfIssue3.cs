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
[IsoId("_SvuToNp-Ed-ak6NoX_4Aeg_-852630950")]
[DisplayName("ISA Years Of Issue")]
public partial record ISAYearsOfIssue3
{
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_SvuTodp-Ed-ak6NoX_4Aeg_-852630907")]
    [DisplayName("Current Year Type")]
    [IsoXmlTag("CurYrTp")]
    public ISAType1Code? CurrentYearType { get; init; } 
    
    /// <summary>
    /// Current year ISA is an ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_SvuTotp-Ed-ak6NoX_4Aeg_-484143046")]
    [DisplayName("Extended Current Year Type")]
    [IsoXmlTag("XtndedCurYrTp")]
    [IsoSimpleType(IsoSimpleType.Extended350Code)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoExtended350Code? ExtendedCurrentYearType { get; init; } 
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_SvuTo9p-Ed-ak6NoX_4Aeg_-484142768")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    /// <summary>
    /// Specifies the amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_SvuTpNp-Ed-ak6NoX_4Aeg_-115002919")]
    [DisplayName("Current Year Subscription Details")]
    [IsoXmlTag("CurYrSbcptDtls")]
    public required SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_SvuTpdp-Ed-ak6NoX_4Aeg_375718367")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear1? PreviousYears { get; init; } 
    
    
    #nullable disable
    
}
