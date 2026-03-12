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
[IsoId("_FkrDAb5XEeexmbB7KsjCwA")]
[DisplayName("Financial Instrument Attributes SD")]
public partial record FinancialInstrumentAttributesSD16
{
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_F1VVMb5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; } 
    
    /// <summary>
    /// Indicates whether or not the newly issued securities are transferable by the agent. This flag is specific to DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_F1VVM75XEeexmbB7KsjCwA")]
    [DisplayName("DTC Security Transferable Flag")]
    [IsoXmlTag("DTCSctyTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public IsoYesNoIndicator? DTCSecurityTransferableFlag { get; init; } 
    
    /// <summary>
    /// Details of security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_F1VVO75XEeexmbB7KsjCwA")]
    [DisplayName("Declared Disbursed Security Details")]
    [IsoXmlTag("DclrdDsbrsdSctyDtls")]
    public FinancialInstrumentAttributesSD18? DeclaredDisbursedSecurityDetails { get; init; } 
    
    /// <summary>
    /// Further classification of DTC disbursed security instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_F1VVQ75XEeexmbB7KsjCwA")]
    [DisplayName("DTC Disbursed Security Asset Type")]
    [IsoXmlTag("DTCDsbrsdSctyAsstTp")]
    public DTCAssetType3Code? DTCDisbursedSecurityAssetType { get; init; } 
    
    /// <summary>
    /// Classification of DTC disbursed security instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_F1VVS75XEeexmbB7KsjCwA")]
    [DisplayName("DTC Disbursed Security Asset Class")]
    [IsoXmlTag("DTCDsbrsdSctyAsstClss")]
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; init; } 
    
    /// <summary>
    /// Dollar amount attributed to the bond when the par value is less than 1000.
    /// </summary>
    [IsoId("_F1VVU75XEeexmbB7KsjCwA")]
    [DisplayName("Baby Bond Denomination")]
    [IsoXmlTag("BabyBdDnmtn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? BabyBondDenomination { get; init; } 
    
    
    #nullable disable
    
}
