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
/// Describes the error that is the cause of the rejection.
/// </summary>
[IsoId("_RFLdYdp-Ed-ak6NoX_4Aeg_-1930823301")]
[DisplayName("Validation Result")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValidationResult3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValidationResult3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValidationResult3( System.UInt64 reqSequenceNumber,System.String reqRuleIdentification,System.String reqRuleDescription )
    {
        SequenceNumber = reqSequenceNumber;
        RuleIdentification = reqRuleIdentification;
        RuleDescription = reqRuleDescription;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sequential number assigned to the error.
    /// </summary>
    [IsoId("_RFLdYtp-Ed-ak6NoX_4Aeg_-1930823223")]
    [DisplayName("Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SeqNb")]
    #endif
    [IsoXmlTag("SeqNb")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoNumber SequenceNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 SequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 SequenceNumber { get; init; } 
    #else
    public System.UInt64 SequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Coded identification of the rule that is violated by the rejected message.
    /// </summary>
    [IsoId("_RFLdY9p-Ed-ak6NoX_4Aeg_-1930823282")]
    [DisplayName("Rule Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RuleId")]
    #endif
    [IsoXmlTag("RuleId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RuleIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RuleIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RuleIdentification { get; init; } 
    #else
    public System.String RuleIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed description of the rule.
    /// </summary>
    [IsoId("_RFLdZNp-Ed-ak6NoX_4Aeg_-1930823266")]
    [DisplayName("Rule Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RuleDesc")]
    #endif
    [IsoXmlTag("RuleDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text RuleDescription { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RuleDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RuleDescription { get; init; } 
    #else
    public System.String RuleDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Description of the elements that violated the rule.
    /// </summary>
    [IsoId("_RFLdZdp-Ed-ak6NoX_4Aeg_-1930823205")]
    [DisplayName("Element")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Elmt")]
    #endif
    [IsoXmlTag("Elmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ElementIdentification3? Element { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ElementIdentification3? Element { get; init; } 
    #else
    public ElementIdentification3? Element { get; set; } 
    #endif
    
    
    #nullable disable
    
}
