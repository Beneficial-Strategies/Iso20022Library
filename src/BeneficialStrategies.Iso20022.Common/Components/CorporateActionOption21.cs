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
/// Provides information about the corporate action option.
/// </summary>
[IsoId("_bk5qcezbEd-Z2q4-Bbm3ZA")]
[DisplayName("Corporate Action Option")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionOption21
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionOption21 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionOption21( OptionNumber1Choice_ reqOptionNumber,CorporateActionOption4Choice_ reqOptionType,InstructedOrQuantityToReceive1Choice_ reqInstructedOrQuantityToReceive )
    {
        OptionNumber = reqOptionNumber;
        OptionType = reqOptionType;
        InstructedOrQuantityToReceive = reqInstructedOrQuantityToReceive;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number identifying the available corporate action options.
    /// </summary>
    [IsoId("_blDbcezbEd-Z2q4-Bbm3ZA")]
    [DisplayName("Option Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnNb")]
    #endif
    [IsoXmlTag("OptnNb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OptionNumber1Choice_ OptionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OptionNumber1Choice_ OptionNumber { get; init; } 
    #else
    public OptionNumber1Choice_ OptionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the corporate action options available to the account owner.
    /// </summary>
    [IsoId("_blDbc-zbEd-Z2q4-Bbm3ZA")]
    [DisplayName("Option Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnTp")]
    #endif
    [IsoXmlTag("OptnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CorporateActionOption4Choice_ OptionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CorporateActionOption4Choice_ OptionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionOption4Choice_ OptionType { get; init; } 
    #else
    public CorporateActionOption4Choice_ OptionType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies whether the quantity of financial instrument is a quantity of securities instructed or a quantity to receive.
    /// </summary>
    [IsoId("_blDbdezbEd-Z2q4-Bbm3ZA")]
    [DisplayName("Instructed Or Quantity To Receive")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdOrQtyToRcv")]
    #endif
    [IsoXmlTag("InstdOrQtyToRcv")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; init; } 
    #else
    public InstructedOrQuantityToReceive1Choice_ InstructedOrQuantityToReceive { get; set; } 
    #endif
    
    
    #nullable disable
    
}
