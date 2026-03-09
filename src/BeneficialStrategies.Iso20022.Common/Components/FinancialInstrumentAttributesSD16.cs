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
[IsoId("_FkrDAb5XEeexmbB7KsjCwA")]
[DisplayName("Financial Instrument Attributes SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancialInstrumentAttributesSD16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_F1VVMb5XEeexmbB7KsjCwA")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PlaceAndName { get; init; } 
    #else
    public System.String? PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether or not the newly issued securities are transferable by the agent. This flag is specific to DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_F1VVM75XEeexmbB7KsjCwA")]
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
    [IsoId("_F1VVO75XEeexmbB7KsjCwA")]
    [DisplayName("Declared Disbursed Security Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdDsbrsdSctyDtls")]
    #endif
    [IsoXmlTag("DclrdDsbrsdSctyDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentAttributesSD18? DeclaredDisbursedSecurityDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentAttributesSD18? DeclaredDisbursedSecurityDetails { get; init; } 
    #else
    public FinancialInstrumentAttributesSD18? DeclaredDisbursedSecurityDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Further classification of DTC disbursed security instruments into (issue) asset types at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_F1VVQ75XEeexmbB7KsjCwA")]
    [DisplayName("DTC Disbursed Security Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCDsbrsdSctyAsstTp")]
    #endif
    [IsoXmlTag("DTCDsbrsdSctyAsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCAssetType3Code? DTCDisbursedSecurityAssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCAssetType3Code? DTCDisbursedSecurityAssetType { get; init; } 
    #else
    public DTCAssetType3Code? DTCDisbursedSecurityAssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Classification of DTC disbursed security instruments into asset classes at DTC (The Depository Trust Corporation).
    /// </summary>
    [IsoId("_F1VVS75XEeexmbB7KsjCwA")]
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
    [IsoId("_F1VVU75XEeexmbB7KsjCwA")]
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
