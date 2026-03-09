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
/// Identification of a cash asset.
/// </summary>
[IsoId("_e2IPAEyHEeir2sRRVd9XhA")]
[DisplayName("Cash Asset")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashAsset1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashAsset1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashAsset1( CashAssetType1Choice_ reqCashAssetType )
    {
        CashAssetType = reqCashAssetType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of cash asset.
    /// </summary>
    [IsoId("_VrtRYEyIEeir2sRRVd9XhA")]
    [DisplayName("Cash Asset Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CshAsstTp")]
    #endif
    [IsoXmlTag("CshAsstTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CashAssetType1Choice_ CashAssetType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CashAssetType1Choice_ CashAssetType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAssetType1Choice_ CashAssetType { get; init; } 
    #else
    public CashAssetType1Choice_ CashAssetType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the cash asset.
    /// </summary>
    [IsoId("_cMk9YEyIEeir2sRRVd9XhA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
