// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action option securities movement security details.
/// </summary>
[IsoId("_mB--0ZCLEeaSk9d1hvTrHg")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD13
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancialInstrumentAttributesSD13 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancialInstrumentAttributesSD13( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_mdDxQZCLEeaSk9d1hvTrHg")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the newly issued securities are transferable by the agent. This flag is specific to DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_mdDxQ5CLEeaSk9d1hvTrHg")]
    [DisplayName("DTC Security Transferable Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCSctyTrfblFlg")]
    #endif
    [IsoXmlTag("DTCSctyTrfblFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoYesNoIndicator? DTCSecurityTransferableFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DTCSecurityTransferableFlag { get; init; } 
    #else
    public System.String? DTCSecurityTransferableFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Details of security that is being distributed as a result of a corporate action as declared by the issuer or offeror on the market.
    /// </summary>
    [IsoId("_mdDxS5CLEeaSk9d1hvTrHg")]
    [DisplayName("Declared Disbursed Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdDsbrsdSctyDtls")]
    #endif
    [IsoXmlTag("DclrdDsbrsdSctyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD2? DeclaredDisbursedSecurityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD2? DeclaredDisbursedSecurityDetails { get; init; } 
    #else
    public FinancialInstrumentAttributesSD2? DeclaredDisbursedSecurityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Further classification of DTC disbursed security instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_mdDxU5CLEeaSk9d1hvTrHg")]
    [DisplayName("DTC Disbursed Security Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCDsbrsdSctyAsstTp")]
    #endif
    [IsoXmlTag("DTCDsbrsdSctyAsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAssetType2Code? DTCDisbursedSecurityAssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAssetType2Code? DTCDisbursedSecurityAssetType { get; init; } 
    #else
    public DTCAssetType2Code? DTCDisbursedSecurityAssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of DTC disbursed security instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_mdDxW5CLEeaSk9d1hvTrHg")]
    [DisplayName("DTC Disbursed Security Asset Class")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCDsbrsdSctyAsstClss")]
    #endif
    [IsoXmlTag("DTCDsbrsdSctyAsstClss")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; init; } 
    #else
    public AssetClass1Code? DTCDisbursedSecurityAssetClass { get; set; } 
    #endif
    
    /// <summary>
    /// Dollar amount attributed to the bond when the par value is less than 1000.
    /// </summary>
    [IsoId("_mdDxY5CLEeaSk9d1hvTrHg")]
    [DisplayName("Baby Bond Denomination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BabyBdDnmtn")]
    #endif
    [IsoXmlTag("BabyBdDnmtn")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? BabyBondDenomination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? BabyBondDenomination { get; init; } 
    #else
    public System.UInt64? BabyBondDenomination { get; set; } 
    #endif
    
    
    #nullable disable
    
}
