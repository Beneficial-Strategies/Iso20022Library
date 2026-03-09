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
/// Net position of a segregated holding of a single security within the overall position held in the securities account, eg, sub-balance per status.
/// </summary>
[IsoId("_VDPOYNp-Ed-ak6NoX_4Aeg_-1623978641")]
[DisplayName("Sub Balance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubBalanceInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubBalanceInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubBalanceInformation1( SubBalanceQuantity1Choice_ reqQuantity,SecuritiesBalanceType1Choice_ reqSubBalanceType )
    {
        Quantity = reqQuantity;
        SubBalanceType = reqSubBalanceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_VDPOYdp-Ed-ak6NoX_4Aeg_-1293358634")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubBalanceQuantity1Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceQuantity1Choice_ Quantity { get; init; } 
    #else
    public SubBalanceQuantity1Choice_ Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_VDPOYtp-Ed-ak6NoX_4Aeg_-1293357608")]
    [DisplayName("Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubBalTp")]
    #endif
    [IsoXmlTag("SubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecuritiesBalanceType1Choice_ SubBalanceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecuritiesBalanceType1Choice_ SubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesBalanceType1Choice_ SubBalanceType { get; init; } 
    #else
    public SecuritiesBalanceType1Choice_ SubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Net position of a segregated holding of a single security within the overall position held in a securities account, eg, sub-balance per status.
    /// </summary>
    [IsoId("_VDPOY9p-Ed-ak6NoX_4Aeg_534538364")]
    [DisplayName("Additional Balance Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBalBrkdwnDtls")]
    #endif
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; init; } 
    #else
    public AdditionalBalanceInformation? AdditionalBalanceBreakdownDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
