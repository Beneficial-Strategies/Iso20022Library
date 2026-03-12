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
[IsoId("_1TX0EDL3EeKU9IrkkToqcw_1084559297")]
[DisplayName("Corporate Action Rate SD")]
public partial record CorporateActionRateSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1TX0ETL3EeKU9IrkkToqcw_51606085")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Applicable to structured securities where there is a set schedule of principal and interest payments for the life of the issue. A portion of the scheduled interest payment will not be paid at the time of distribution.
    /// </summary>
    [IsoId("_1TX0EjL3EeKU9IrkkToqcw_-5844361")]
    [DisplayName("Deferred Interest Rate")]
    [IsoXmlTag("DfrrdIntrstRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? DeferredInterestRate { get; init; } 
    
    /// <summary>
    /// Applicable for structured security issues where there is a set schedule of principal and interest payments for the life of the issue. An interest shortfall occurs when scheduled interest is not paid to the investor as scheduled.
    /// </summary>
    [IsoId("_1TX0EzL3EeKU9IrkkToqcw_1059130676")]
    [DisplayName("Interest Shortfall Rate")]
    [IsoXmlTag("IntrstShrtfllRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? InterestShortfallRate { get; init; } 
    
    /// <summary>
    /// Applicable to structured securities where there is a set schedule of principal and interest payments for the life of the issue. This term refers specifically to the principal payment of a mortgage. One or more mortgages within the pool are in default.
    /// </summary>
    [IsoId("_1TX0FDL3EeKU9IrkkToqcw_-1505398481")]
    [DisplayName("Realised Loss Rate")]
    [IsoXmlTag("RealsdLossRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    public IsoPercentageRate? RealisedLossRate { get; init; } 
    
    /// <summary>
    /// American or Global Depository Receipt(s) per ordinary share(s) ratio.
    /// </summary>
    [IsoId("_1TX0FTL3EeKU9IrkkToqcw_1510806012")]
    [DisplayName("American Or Global Deposit Receipt Ratio")]
    [IsoXmlTag("AmrcnOrGblDpstRctRatio")]
    public CorporateActionRateSD2? AmericanOrGlobalDepositReceiptRatio { get; init; } 
    
    
    #nullable disable
    
}
