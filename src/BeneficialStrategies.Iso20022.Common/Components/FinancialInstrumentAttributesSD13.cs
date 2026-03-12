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
[IsoId("_mB--0ZCLEeaSk9d1hvTrHg")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD13
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_mdDxQZCLEeaSk9d1hvTrHg")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the newly issued securities are transferable by the agent. This flag is specific to DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_mdDxQ5CLEeaSk9d1hvTrHg")]
    [DisplayName("DTC Security Transferable Flag")]
    [IsoXmlTag("DTCSctyTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCSecurityTransferableFlag { get; init; } 
    
    /// <summary>
    /// Details of security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_mdDxS5CLEeaSk9d1hvTrHg")]
    [DisplayName("Declared Disbursed Security Details")]
    [IsoXmlTag("DclrdDsbrsdSctyDtls")]
    public FinancialInstrumentAttributesSD2? DeclaredDisbursedSecurityDetails { get; init; } 
    
    /// <summary>
    /// Further classification of DTC disbursed security instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_mdDxU5CLEeaSk9d1hvTrHg")]
    [DisplayName("DTC Disbursed Security Asset Type")]
    [IsoXmlTag("DTCDsbrsdSctyAsstTp")]
    public DTCAssetType2Code? DTCDisbursedSecurityAssetType { get; init; } 
    
    /// <summary>
    /// Classification of DTC disbursed security instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_mdDxW5CLEeaSk9d1hvTrHg")]
    [DisplayName("DTC Disbursed Security Asset Class")]
    [IsoXmlTag("DTCDsbrsdSctyAsstClss")]
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; init; } 
    
    /// <summary>
    /// Dollar amount attributed to the bond when the par value is less than 1000.
    /// </summary>
    [IsoId("_mdDxY5CLEeaSk9d1hvTrHg")]
    [DisplayName("Baby Bond Denomination")]
    [IsoXmlTag("BabyBdDnmtn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? BabyBondDenomination { get; init; } 
    
    
    #nullable disable
    
}
