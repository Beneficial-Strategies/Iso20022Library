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
/// Information related to the liquid resources.
/// </summary>
[IsoId("_nNjvsESrEemM8-DVOYzdVQ")]
[DisplayName("Liquid Resource Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LiquidResourceInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LiquidResourceInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LiquidResourceInformation1( AmountAndDirection102 reqLiquidResourceValue,System.String reqSecured,System.String reqAssetEncumbered,System.String reqQualifyingResource,System.String reqAgencyArrangements )
    {
        LiquidResourceValue = reqLiquidResourceValue;
        Secured = reqSecured;
        AssetEncumbered = reqAssetEncumbered;
        QualifyingResource = reqQualifyingResource;
        AgencyArrangements = reqAgencyArrangements;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the facility provider.
    /// </summary>
    [IsoId("_xUlDAESrEemM8-DVOYzdVQ")]
    [DisplayName("Counter Party Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CntrPtyId")]
    #endif
    [IsoXmlTag("CntrPtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CounterPartyIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CounterPartyIdentification { get; init; } 
    #else
    public System.String? CounterPartyIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of liquid resources available to meet liquid requirements.
    /// </summary>
    [IsoId("_2i3s0ESrEemM8-DVOYzdVQ")]
    [DisplayName("Liquid Resource Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LqdRsrcVal")]
    #endif
    [IsoXmlTag("LqdRsrcVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection102 LiquidResourceValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection102 LiquidResourceValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102 LiquidResourceValue { get; init; } 
    #else
    public AmountAndDirection102 LiquidResourceValue { get; set; } 
    #endif
    
    /// <summary>
    /// The market value of the financial instruments being used to secure the facility.
    /// </summary>
    [IsoId("_FuOcsESsEemM8-DVOYzdVQ")]
    [DisplayName("Market Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MktVal")]
    #endif
    [IsoXmlTag("MktVal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection102? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection102? MarketValue { get; init; } 
    #else
    public AmountAndDirection102? MarketValue { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the facility is secured or not.
    /// </summary>
    [IsoId("_VvbPcESsEemM8-DVOYzdVQ")]
    [DisplayName("Secured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Scrd")]
    #endif
    [IsoXmlTag("Scrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator Secured { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Secured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Secured { get; init; } 
    #else
    public System.String Secured { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the financial instruments are encumbered or not. This includes where financial instruments must be pledged to secure liquidity facilities.
    /// </summary>
    [IsoId("_bFJ-AESsEemM8-DVOYzdVQ")]
    [DisplayName("Asset Encumbered")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AsstNcmbrd")]
    #endif
    [IsoXmlTag("AsstNcmbrd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator AssetEncumbered { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AssetEncumbered { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AssetEncumbered { get; init; } 
    #else
    public System.String AssetEncumbered { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the available liquid resource counts towards the liquid requirements in the scenario or not.
    /// </summary>
    [IsoId("_gVPXkESsEemM8-DVOYzdVQ")]
    [DisplayName("Qualifying Resource")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QlfygRsrc")]
    #endif
    [IsoXmlTag("QlfygRsrc")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator QualifyingResource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String QualifyingResource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String QualifyingResource { get; init; } 
    #else
    public System.String QualifyingResource { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the reliance on third party entities to settle payment obligations for the CCP or a clearing member. The article 32(4) of Commission Delegated Regulated 153/2013 includes a full list of third party entities which a CCP may have a liquidity exposure to. If the value is true, the portion of the liquid resource which is assumed to be unavailable due to a dependency on third party entities. If the value is false, the portion of the liquid resource which is assumed to be available as no dependency on third party entities.
    /// </summary>
    [IsoId("_lPmYwESsEemM8-DVOYzdVQ")]
    [DisplayName("Agency Arrangements")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgcyArrgmnts")]
    #endif
    [IsoXmlTag("AgcyArrgmnts")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoTrueFalseIndicator AgencyArrangements { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AgencyArrangements { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AgencyArrangements { get; init; } 
    #else
    public System.String AgencyArrangements { get; set; } 
    #endif
    
    
    #nullable disable
    
}
