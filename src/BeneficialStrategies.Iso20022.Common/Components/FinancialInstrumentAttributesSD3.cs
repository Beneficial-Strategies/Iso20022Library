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
[IsoId("_1goM8TL3EeKU9IrkkToqcw_-94344471")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD3
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1goM8jL3EeKU9IrkkToqcw_-1091416824")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the newly issued securities are transferable by the agent. This flag is specific to DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1goM8zL3EeKU9IrkkToqcw_-1900363734")]
    [DisplayName("DTC Security Transferable Flag")]
    [IsoXmlTag("DTCSctyTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCSecurityTransferableFlag { get; init; } 
    
    /// <summary>
    /// Details of security that DTC will distribute as part of the entitlement.
    /// </summary>
    [IsoId("_1goM9DL3EeKU9IrkkToqcw_949535018")]
    [DisplayName("CSD Disbursed Security Details")]
    [IsoXmlTag("CSDDsbrsdSctyDtls")]
    public FinancialInstrumentAttributesSD4? CSDDisbursedSecurityDetails { get; init; } 
    
    /// <summary>
    /// Further classification of DTC disbursed security instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1goM9TL3EeKU9IrkkToqcw_-1581934335")]
    [DisplayName("DTC Disbursed Security Asset Type")]
    [IsoXmlTag("DTCDsbrsdSctyAsstTp")]
    public DTCAssetType1Code? DTCDisbursedSecurityAssetType { get; init; } 
    
    /// <summary>
    /// Classification of DTC disbursed security instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1goM9jL3EeKU9IrkkToqcw_832727321")]
    [DisplayName("DTC Disbursed Security Asset Class")]
    [IsoXmlTag("DTCDsbrsdSctyAsstClss")]
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; init; } 
    
    /// <summary>
    /// Dollar amount attributed to the bond when the par value is less than 1000.
    /// </summary>
    [IsoId("_1gx98DL3EeKU9IrkkToqcw_1774241898")]
    [DisplayName("Baby Bond Denomination")]
    [IsoXmlTag("BabyBdDnmtn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? BabyBondDenomination { get; init; } 
    
    /// <summary>
    /// Indicates whether the disbursed security is eligible at CSD (for example in the US - DTC, The Depository Trust Corporation).
    /// </summary>
    [IsoId("_1gx98TL3EeKU9IrkkToqcw_-471022916")]
    [DisplayName("Disbursed Security Eligibility Flag")]
    [IsoXmlTag("DsbrsdSctyElgbltyFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DisbursedSecurityEligibilityFlag { get; init; } 
    
    
    #nullable disable
    
}
