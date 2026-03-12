// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the designation of a currency.
/// </summary>
[IsoId("_k2wBgQdzEeSPHJIdUs1USg")]
[DisplayName("Currency Designation")]
public partial record CurrencyDesignation1
{
    #nullable enable
    
    /// <summary>
    /// Specifies whether the currency is settled offshore or onshore.
    /// </summary>
    [IsoId("_vCZ9MAdzEeSPHJIdUs1USg")]
    [DisplayName("Currency Designation")]
    [IsoXmlTag("CcyDsgnt")]
    public CurrencyDesignation1Code? CurrencyDesignation { get; init; } 
    
    /// <summary>
    /// Offshore location of the currency.
    /// </summary>
    [IsoId("_aIsRcAd1EeSPHJIdUs1USg")]
    [DisplayName("Location")]
    [IsoXmlTag("Lctn")]
    public CountryCode? Location { get; init; } 
    
    /// <summary>
    /// Additional information about the off-shore currency.
    /// </summary>
    [IsoId("_dhnVEAd1EeSPHJIdUs1USg")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
