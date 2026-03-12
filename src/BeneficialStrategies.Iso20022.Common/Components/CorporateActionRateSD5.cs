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
[IsoId("_1jnPgjL3EeKU9IrkkToqcw_1739416264")]
[DisplayName("Corporate Action Rate SD")]
public partial record CorporateActionRateSD5
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1jnPgzL3EeKU9IrkkToqcw_-1908624945")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Applicable to structured securities where there is a set schedule of principal and interest payments for the life of the issue. A portion of the scheduled interest payment will not be paid at the time of distribution.
    /// </summary>
    [IsoId("_1jnPhDL3EeKU9IrkkToqcw_506036711")]
    [DisplayName("Deferred Interest Rate")]
    [IsoXmlTag("DfrrdIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? DeferredInterestRate { get; init; } 
    
    /// <summary>
    /// American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_1jnPhTL3EeKU9IrkkToqcw_-1443672460")]
    [DisplayName("American Or Global Deposit Receipt Ratio")]
    [IsoXmlTag("AmrcnOrGblDpstRctRatio")]
    public CorporateActionRateSD2? AmericanOrGlobalDepositReceiptRatio { get; init; } 
    
    
    #nullable disable
    
}
