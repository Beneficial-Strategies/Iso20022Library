// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details rates and amounts details.
/// </summary>
[IsoId("_wA70wb5WEeexmbB7KsjCwA")]
[DisplayName("Corporate Action Rate SD")]
public partial record CorporateActionRateSD9
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_wRTMAb5WEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Applicable to structured securities where there is a set schedule of principal and interest payments for the life of the issue. A portion of the scheduled interest payment will not be paid at the time of distribution.
    /// </summary>
    [IsoId("_wRTMA75WEeexmbB7KsjCwA")]
    [DisplayName("Deferred Interest Rate")]
    [IsoXmlTag("DfrrdIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? DeferredInterestRate { get; init; } 
    
    /// <summary>
    /// American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_wRTMC75WEeexmbB7KsjCwA")]
    [DisplayName("American Or Global Deposit Receipt Ratio")]
    [IsoXmlTag("AmrcnOrGblDpstRctRatio")]
    public CorporateActionRateSD2? AmericanOrGlobalDepositReceiptRatio { get; init; } 
    
    
    #nullable disable
    
}
