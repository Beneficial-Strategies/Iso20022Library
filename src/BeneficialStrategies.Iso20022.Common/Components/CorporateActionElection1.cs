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
/// Provides information about an amended election instruction.
/// </summary>
[IsoId("_UJuMftp-Ed-ak6NoX_4Aeg_599123828")]
[DisplayName("Corporate Action Election")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionElection1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionElection1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionElection1( CorporateActionOption1FormatChoice_ reqOptionType,System.String reqOptionNumber,UnitOrFaceAmount1Choice_ reqOriginalInstructedQuantity,UnitOrFaceAmount1Choice_ reqRemainingQuantity )
    {
        OptionType = reqOptionType;
        OptionNumber = reqOptionNumber;
        OriginalInstructedQuantity = reqOriginalInstructedQuantity;
        RemainingQuantity = reqRemainingQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UJuMf9p-Ed-ak6NoX_4Aeg_873409748")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption1FormatChoice_ OptionType { get; init; } 
    #else
    public CorporateActionOption1FormatChoice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_UJuMgNp-Ed-ak6NoX_4Aeg_873409749")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String OptionNumber { get; init; } 
    #else
    public System.String OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the securities that was instructed in the original election advice.
    /// </summary>
    [IsoId("_UJ39cNp-Ed-ak6NoX_4Aeg_886341399")]
    [DisplayName("Original Instructed Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInstdQty")]
    #endif
    [IsoXmlTag("OrgnlInstdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ OriginalInstructedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ OriginalInstructedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ OriginalInstructedQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ OriginalInstructedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining instructed securities quantity after the amendment of the election.
    /// </summary>
    [IsoId("_UJ39cdp-Ed-ak6NoX_4Aeg_-1298580646")]
    [DisplayName("Remaining Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmngQty")]
    #endif
    [IsoXmlTag("RmngQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ RemainingQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ RemainingQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ RemainingQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ RemainingQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
