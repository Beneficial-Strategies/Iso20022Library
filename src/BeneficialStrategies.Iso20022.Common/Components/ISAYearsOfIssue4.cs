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
[IsoId("_3gENYkXfEeGY6MkiuzuPOA_-1915079820")]
[DisplayName("ISA Years Of Issue")]
public partial record ISAYearsOfIssue4
{
    #nullable enable
    
    /// <summary>
    /// Current year of the Investment Saving Plan (ISA) that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_3gENY0XfEeGY6MkiuzuPOA_1731435670")]
    [DisplayName("Current Year")]
    [IsoXmlTag("CurYr")]
    public CurrentYearType1Choice_? CurrentYear { get; init; } 
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_3gENZEXfEeGY6MkiuzuPOA_271903704")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_3gNXUEXfEeGY6MkiuzuPOA_-611329583")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear2? PreviousYears { get; init; } 
    
    /// <summary>
    /// Specifies the amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_3gNXUUXfEeGY6MkiuzuPOA_-1608401936")]
    [DisplayName("Current Year Subscription Details")]
    [IsoXmlTag("CurYrSbcptDtls")]
    public SubscriptionInformation1? CurrentYearSubscriptionDetails { get; init; } 
    
    
    #nullable disable
    
}
