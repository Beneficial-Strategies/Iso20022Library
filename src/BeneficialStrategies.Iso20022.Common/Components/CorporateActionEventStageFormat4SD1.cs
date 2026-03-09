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
/// Extension to specify the stage in the corporate action event life cycle.
/// </summary>
[IsoId("_G3BX4DFpEeGKkIZzgd38VA")]
[DisplayName("Corporate Action Event Stage Format 4 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionEventStageFormat4SD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionEventStageFormat4SD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionEventStageFormat4SD1( FinancialInstrumentQuantity15Choice_ reqSecuritiesPurchased )
    {
        SecuritiesPurchased = reqSecuritiesPurchased;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_qWadUFPGEeGs_NnqHXQZkw")]
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
    /// The number of securities purchased.
    /// The value should be the actual number, or 0 (if, as a result, TEND or BIDS will not take place).
    /// 買付株式数／未定／非設定
    /// ※買付前の通知において、「非設定」のデータが1件あり。未定との違いは不明。&quot;.
    /// </summary>
    [IsoId("_lJLu0DFpEeGKkIZzgd38VA")]
    [DisplayName("Securities Purchased")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesPurchsd")]
    #endif
    [IsoXmlTag("SctiesPurchsd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancialInstrumentQuantity15Choice_ SecuritiesPurchased { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancialInstrumentQuantity15Choice_ SecuritiesPurchased { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_ SecuritiesPurchased { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_ SecuritiesPurchased { get; set; } 
    #endif
    
    
    #nullable disable
    
}
