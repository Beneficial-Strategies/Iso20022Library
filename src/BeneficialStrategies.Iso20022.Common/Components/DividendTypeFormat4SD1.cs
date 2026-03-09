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
/// Extension to specify additional information related to the type of dividend.
/// </summary>
[IsoId("_hZyZszLOEeGkgP4mOiMAHQ")]
[DisplayName("Dividend Type Format 4 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DividendTypeFormat4SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DividendTypeFormat4SD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DividendTypeFormat4SD1( System.String reqProvisionalDividendFlag,System.String reqCommemorativeDividendFlag,System.String reqSpecialDividendFlag )
    {
        ProvisionalDividendFlag = reqProvisionalDividendFlag;
        CommemorativeDividendFlag = reqCommemorativeDividendFlag;
        SpecialDividendFlag = reqSpecialDividendFlag;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_TTCoUFPGEeGs_NnqHXQZkw")]
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
    /// Specifies whether the dividend is provisional 予想区分.
    /// If the value is No, then the dividend is actual.
    /// ProvisionalDividendFlag can only be used with corporate action event type code DVCA.
    /// </summary>
    [IsoId("_M9HrwDLPEeGkgP4mOiMAHQ")]
    [DisplayName("Provisional Dividend Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsnlDvddFlg")]
    #endif
    [IsoXmlTag("PrvsnlDvddFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ProvisionalDividendFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ProvisionalDividendFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ProvisionalDividendFlag { get; init; } 
    #else
    public System.String ProvisionalDividendFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the dividend includes commemorative dividend. 記念配当区分
    /// CommemorativeDividendFlag can only be used with corporate action event type code DVCA.
    /// </summary>
    [IsoId("_0OHUADLREeGkgP4mOiMAHQ")]
    [DisplayName("Commemorative Dividend Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CommrtvDvddFlg")]
    #endif
    [IsoXmlTag("CommrtvDvddFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator CommemorativeDividendFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String CommemorativeDividendFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String CommemorativeDividendFlag { get; init; } 
    #else
    public System.String CommemorativeDividendFlag { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the dividend includes special dividend.
    /// 特別配当区分
    /// SpecialDividendFlag can only be used with corporate action event type code DVCA.
    /// </summary>
    [IsoId("_f6l7ADLSEeGkgP4mOiMAHQ")]
    [DisplayName("Special Dividend Flag")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclDvddFlg")]
    #endif
    [IsoXmlTag("SpclDvddFlg")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator SpecialDividendFlag { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SpecialDividendFlag { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SpecialDividendFlag { get; init; } 
    #else
    public System.String SpecialDividendFlag { get; set; } 
    #endif
    
    
    #nullable disable
    
}
