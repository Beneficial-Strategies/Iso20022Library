// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement security details.
/// </summary>
[IsoId("_1T9p8TL3EeKU9IrkkToqcw_1018764700")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD1
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1T9p8jL3EeKU9IrkkToqcw_2098495270")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the newly issued securities are transferable by the agent. This flag is specific to DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1T9p8zL3EeKU9IrkkToqcw_1274549265")]
    [DisplayName("DTC Security Transferable Flag")]
    [IsoXmlTag("DTCSctyTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCSecurityTransferableFlag { get; init; } 
    
    /// <summary>
    /// Details of security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_1T9p9DL3EeKU9IrkkToqcw_-1128294739")]
    [DisplayName("Declared Disbursed Security Details")]
    [IsoXmlTag("DclrdDsbrsdSctyDtls")]
    public FinancialInstrumentAttributesSD2? DeclaredDisbursedSecurityDetails { get; init; } 
    
    /// <summary>
    /// Further classification of DTC disbursed security instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1T9p9TL3EeKU9IrkkToqcw_-180315812")]
    [DisplayName("DTC Disbursed Security Asset Type")]
    [IsoXmlTag("DTCDsbrsdSctyAsstTp")]
    public DTCAssetType1Code? DTCDisbursedSecurityAssetType { get; init; } 
    
    /// <summary>
    /// Classification of DTC disbursed security instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1UHa8DL3EeKU9IrkkToqcw_-1739490163")]
    [DisplayName("DTC Disbursed Security Asset Class")]
    [IsoXmlTag("DTCDsbrsdSctyAsstClss")]
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; init; } 
    
    /// <summary>
    /// Dollar amount attributed to the bond when the par value is less than 1000.
    /// </summary>
    [IsoId("_1UHa8TL3EeKU9IrkkToqcw_-1764347640")]
    [DisplayName("Baby Bond Denomination")]
    [IsoXmlTag("BabyBdDnmtn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? BabyBondDenomination { get; init; } 
    
    
    #nullable disable
    
}
