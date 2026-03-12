// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the compensation data of an incorrect billing.
/// </summary>
[IsoId("_6PzSsJqlEeGSON8vddiWzQ_-1213048629")]
[DisplayName("Billing Compensation")]
public partial record BillingCompensation1
{
    #nullable enable
    
    /// <summary>
    /// Defines the type of billing compensation.
    /// </summary>
    [IsoId("_6PzSsZqlEeGSON8vddiWzQ_-1034929957")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required BillingCompensationType1Choice_ Type { get; init; } 
    
    /// <summary>
    /// Defines the value of compensation.
    /// </summary>
    [IsoId("_6PzSspqlEeGSON8vddiWzQ_2084846314")]
    [DisplayName("Value")]
    [IsoXmlTag("Val")]
    public required AmountAndDirection34 Value { get; init; } 
    
    /// <summary>
    /// Identifies the currency type used to report the value or total, in a coded form, such as Settlement (STLM).
    /// </summary>
    [IsoId("_6PzSs5qlEeGSON8vddiWzQ_-564853547")]
    [DisplayName("Currency Type")]
    [IsoXmlTag("CcyTp")]
    public BillingCurrencyType2Code? CurrencyType { get; init; } 
    
    
    #nullable disable
    
}
