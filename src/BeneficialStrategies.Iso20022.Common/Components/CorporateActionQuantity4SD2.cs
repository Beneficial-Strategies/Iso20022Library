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
/// Extension to specify corporate action quantities.
/// </summary>
[IsoId("_o9JB5GCXEeK8P92abE6HIA")]
[DisplayName("Corporate Action Quantity 4 SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionQuantity4SD2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous reference to the location where the supplementary data must be inserted in the message instance. 
    /// In the case of XML, this is expressed by a valid XPath.
    /// </summary>
    [IsoId("_o9JB9WCXEeK8P92abE6HIA")]
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
    /// Planned number of shares to be purchased.
    ///  買付予定株式数.
    /// </summary>
    [IsoId("_o9JCBmCXEeK8P92abE6HIA")]
    [DisplayName("Planned Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlandQty")]
    #endif
    [IsoXmlTag("PlandQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlannedQuantity1Choice_? PlannedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlannedQuantity1Choice_? PlannedQuantity { get; init; } 
    #else
    public PlannedQuantity1Choice_? PlannedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Planned excess quantity of share purchase.
    /// 買付超過予定数
    /// </summary>
    [IsoId("_o9JCCWCXEeK8P92abE6HIA")]
    [DisplayName("Planned Excess Purchase Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlandXcssPurchsQty")]
    #endif
    [IsoXmlTag("PlandXcssPurchsQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PlannedQuantity1Choice_? PlannedExcessPurchaseQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PlannedQuantity1Choice_? PlannedExcessPurchaseQuantity { get; init; } 
    #else
    public PlannedQuantity1Choice_? PlannedExcessPurchaseQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// TSE/JASDEC code for the minimum number of shares to be purchased when the corporate action event type code is TEND or BIDS.
    /// 買付株数に係る下限設定が「下限設定あり」「未定」.
    /// </summary>
    [IsoId("_o9JCA2CXEeK8P92abE6HIA")]
    [DisplayName("Minimum Quantity Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MinQtyCd")]
    #endif
    [IsoXmlTag("MinQtyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesQuantity1Code? MinimumQuantityCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesQuantity1Code? MinimumQuantityCode { get; init; } 
    #else
    public SecuritiesQuantity1Code? MinimumQuantityCode { get; set; } 
    #endif
    
    /// <summary>
    /// TSE/JASDEC code for the maximum number of shares to be purchased when the corporate action event type code is TEND or BIDS.
    ///  買付株数に係る上限設定が「上限設定あり」「未定」.
    /// </summary>
    [IsoId("_o9JB-GCXEeK8P92abE6HIA")]
    [DisplayName("Maximum Quantity Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxQtyCd")]
    #endif
    [IsoXmlTag("MaxQtyCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesQuantity1Code? MaximumQuantityCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesQuantity1Code? MaximumQuantityCode { get; init; } 
    #else
    public SecuritiesQuantity1Code? MaximumQuantityCode { get; set; } 
    #endif
    
    /// <summary>
    /// Old share unit quantity.
    /// </summary>
    [IsoId("_o9JB72CXEeK8P92abE6HIA")]
    [DisplayName("Old Share Unit Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OdShrUnitQty")]
    #endif
    [IsoXmlTag("OdShrUnitQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? OldShareUnitQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? OldShareUnitQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? OldShareUnitQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// New share unit quantity.
    /// </summary>
    [IsoId("_o9JB6mCXEeK8P92abE6HIA")]
    [DisplayName("New Share Unit Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewShrUnitQty")]
    #endif
    [IsoXmlTag("NewShrUnitQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity15Choice_? NewShareUnitQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity15Choice_? NewShareUnitQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity15Choice_? NewShareUnitQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
