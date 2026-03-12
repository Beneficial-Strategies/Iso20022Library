// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the interest that applies to the account at a particular moment in time.
/// </summary>
[IsoId("_tws_MFkyEeGeoaLUQk__nA_100420323")]
[DisplayName("Account Interest")]
public partial record AccountInterest3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of interest.
    /// </summary>
    [IsoId("_tw2wMFkyEeGeoaLUQk__nA_-24517520")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public InterestType1Choice_? Type { get; init; } 
    
    /// <summary>
    /// Set of elements used to qualify the interest rate.
    /// </summary>
    [IsoId("_tw_6IFkyEeGeoaLUQk__nA_-831981101")]
    [DisplayName("Rate")]
    [IsoXmlTag("Rate")]
    public Rate3? Rate { get; init; } 
    
    /// <summary>
    /// Range of time between a start date and an end date for the calculation of the interest.
    /// </summary>
    [IsoId("_tw_6IVkyEeGeoaLUQk__nA_-820119769")]
    [DisplayName("From To Date")]
    [IsoXmlTag("FrToDt")]
    public DateTimePeriodDetails? FromToDate { get; init; } 
    
    /// <summary>
    /// Specifies the reason for the interest.
    /// </summary>
    [IsoId("_tw_6IlkyEeGeoaLUQk__nA_1324300654")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reason { get; init; } 
    
    /// <summary>
    /// Provides details on the tax applied to charges.
    /// </summary>
    [IsoId("_tw_6I1kyEeGeoaLUQk__nA_-1157307689")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxCharges2? Tax { get; init; } 
    
    
    #nullable disable
    
}
