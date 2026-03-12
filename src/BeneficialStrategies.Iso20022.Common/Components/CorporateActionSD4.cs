// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action details.
/// </summary>
[IsoId("_1dzicDL3EeKU9IrkkToqcw_-1985913164")]
[DisplayName("Corporate Action SD")]
public partial record CorporateActionSD4
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1dzicTL3EeKU9IrkkToqcw_1311981779")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// New par value of a security.
    /// </summary>
    [IsoId("_1dzicjL3EeKU9IrkkToqcw_-1252990966")]
    [DisplayName("New Par Value")]
    [IsoXmlTag("NewParVal")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? NewParValue { get; init; } 
    
    /// <summary>
    /// Old par value of the event security represents the previously established par value that has changed in par value event. Used in combination with new par value element to represent the difference.
    /// </summary>
    [IsoId("_1dziczL3EeKU9IrkkToqcw_1931064911")]
    [DisplayName("Old Par Value")]
    [IsoXmlTag("OdParVal")]
    public RestrictedFINActiveCurrencyAnd13DecimalAmount? OldParValue { get; init; } 
    
    /// <summary>
    /// Indicates whether the event agent is charging a cancellation and or issuance fee upon the exchange of securities.
    /// </summary>
    [IsoId("_1dzidDL3EeKU9IrkkToqcw_-1824148456")]
    [DisplayName("Exchange Fee Required Flag")]
    [IsoXmlTag("XchgFeeReqrdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ExchangeFeeRequiredFlag { get; init; } 
    
    /// <summary>
    /// GCA VS-specific flag that indicates whether a composite record has been generated as a result of custodian information that has not yet been confirmed in the market.
    /// </summary>
    [IsoId("_1dzidTL3EeKU9IrkkToqcw_166643569")]
    [DisplayName("Custodian Shell Flag")]
    [IsoXmlTag("CtdnShellFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? CustodianShellFlag { get; init; } 
    
    /// <summary>
    /// Indicates whether the issuer requires a holder to present the entire account balance in order to be eligible for the offer.
    /// </summary>
    [IsoId("_1dzidjL3EeKU9IrkkToqcw_512871924")]
    [DisplayName("Must All Shares Be Submitted Flag")]
    [IsoXmlTag("MustAllShrsBeSubmittdFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? MustAllSharesBeSubmittedFlag { get; init; } 
    
    /// <summary>
    /// Provides details about the lottery that has been drawn as a part of the corporate action event.
    /// </summary>
    [IsoId("_1d8sYDL3EeKU9IrkkToqcw_-643503849")]
    [DisplayName("Lottery Details")]
    [IsoXmlTag("LtryDtls")]
    public CorporateActionSD6? LotteryDetails { get; init; } 
    
    /// <summary>
    /// Indicates whether the dividend as whole or in part qualifies for lower/ favourable tax rate.
    /// </summary>
    [IsoId("_1d8sYTL3EeKU9IrkkToqcw_-308326275")]
    [DisplayName("Qualified Dividend Tax Indicator")]
    [IsoXmlTag("QlfdDvddTaxInd")]
    public QualifiedDividendTax1Code? QualifiedDividendTaxIndicator { get; init; } 
    
    /// <summary>
    /// Name of the company that will remain (possibly a new name), usually designated after a merger.
    /// </summary>
    [IsoId("_1d8sYjL3EeKU9IrkkToqcw_-1163046817")]
    [DisplayName("Surviving Company")]
    [IsoXmlTag("SrvvgCpny")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? SurvivingCompany { get; init; } 
    
    /// <summary>
    /// Indicates when all or part of the distribution is paid from foreign sourced income of the issuer.
    /// </summary>
    [IsoId("_1d8sYzL3EeKU9IrkkToqcw_1468724564")]
    [DisplayName("Foreign Income Source Flag")]
    [IsoXmlTag("FrgnIncmSrcFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? ForeignIncomeSourceFlag { get; init; } 
    
    
    #nullable disable
    
}
