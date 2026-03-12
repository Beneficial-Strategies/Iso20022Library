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
[IsoId("_3gXIVEXfEeGY6MkiuzuPOA_-1850431888")]
[DisplayName("ISA Years Of Issue")]
public partial record ISAYearsOfIssue5
{
    #nullable enable
    
    /// <summary>
    /// ISA that was issued during the current fiscal year.
    /// </summary>
    [IsoId("_3gXIVUXfEeGY6MkiuzuPOA_-1964270954")]
    [DisplayName("Current Year")]
    [IsoXmlTag("CurYr")]
    public CurrentYearType1Choice_? CurrentYear { get; init; } 
    
    /// <summary>
    /// Indicates whether the ISA contains a cash component asset for transfer.
    /// </summary>
    [IsoId("_3gXIVkXfEeGY6MkiuzuPOA_336551636")]
    [DisplayName("Cash Component Indicator")]
    [IsoXmlTag("CshCmpntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator CashComponentIndicator { get; init; } 
    
    /// <summary>
    /// Selection of investment plans issued during previous years.
    /// </summary>
    [IsoId("_3gg5UUXfEeGY6MkiuzuPOA_-1543754004")]
    [DisplayName("Previous Years")]
    [IsoXmlTag("PrvsYrs")]
    public PreviousYear3? PreviousYears { get; init; } 
    
    /// <summary>
    /// Specifies the amounts already subscribed for the current year.
    /// </summary>
    [IsoId("_3gg5UEXfEeGY6MkiuzuPOA_-546681651")]
    [DisplayName("Current Year Subscription Details")]
    [IsoXmlTag("CurYrSbcptDtls")]
    public required SubscriptionInformation1 CurrentYearSubscriptionDetails { get; init; } 
    
    
    #nullable disable
    
}
