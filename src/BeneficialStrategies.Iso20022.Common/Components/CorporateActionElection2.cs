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
/// Provides information about a corporate action election amendment request.
/// </summary>
[IsoId("_UJ39ctp-Ed-ak6NoX_4Aeg_-1290336513")]
[DisplayName("Corporate Action Election")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionElection2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionElection2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionElection2( CorporateActionOption1FormatChoice_ reqOptionType,System.String reqOptionNumber,UnitOrFaceAmount1Choice_ reqNewInstructedQuantity )
    {
        OptionType = reqOptionType;
        OptionNumber = reqOptionNumber;
        NewInstructedQuantity = reqNewInstructedQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_UJ39c9p-Ed-ak6NoX_4Aeg_-1233077575")]
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
    [IsoId("_UJ39dNp-Ed-ak6NoX_4Aeg_-1233077544")]
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
    /// New instructed securities quantity after the amendment.
    /// </summary>
    [IsoId("_UJ39ddp-Ed-ak6NoX_4Aeg_-1233077543")]
    [DisplayName("New Instructed Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NewInstdQty")]
    #endif
    [IsoXmlTag("NewInstdQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required UnitOrFaceAmount1Choice_ NewInstructedQuantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required UnitOrFaceAmount1Choice_ NewInstructedQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public UnitOrFaceAmount1Choice_ NewInstructedQuantity { get; init; } 
    #else
    public UnitOrFaceAmount1Choice_ NewInstructedQuantity { get; set; } 
    #endif
    
    /// <summary>
    /// The reason for the amendment request.
    /// </summary>
    [IsoId("_UJ39dtp-Ed-ak6NoX_4Aeg_-1222919883")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Reason { get; init; } 
    #else
    public System.String? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
