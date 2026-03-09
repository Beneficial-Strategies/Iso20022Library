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
/// Payment token information.
/// </summary>
[IsoId("_5yLZUWltEeSGkpGpjm7tzg")]
[DisplayName("Card Payment Token")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentToken3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Additional payment token information.
    /// </summary>
    [IsoId("_AXb2EGluEeSGkpGpjm7tzg")]
    [DisplayName("Token Characteristic")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknChrtc")]
    #endif
    [IsoXmlTag("TknChrtc")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TokenCharacteristic { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TokenCharacteristic { get; init; } 
    #else
    public System.String? TokenCharacteristic { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier of a token provider requestor.
    /// </summary>
    [IsoId("_GODrMGluEeSGkpGpjm7tzg")]
    [DisplayName("Token Requestor")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknRqstr")]
    #endif
    [IsoXmlTag("TknRqstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTokenIdentifiers1? TokenRequestor { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTokenIdentifiers1? TokenRequestor { get; init; } 
    #else
    public PaymentTokenIdentifiers1? TokenRequestor { get; set; } 
    #endif
    
    /// <summary>
    /// Level of confidence resulting of the identification and authentication of the cardholder performed and the entity that performed it.
    /// </summary>
    [IsoId("_5-sLUWltEeSGkpGpjm7tzg")]
    [DisplayName("Token Assurance Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TknAssrncLvl")]
    #endif
    [IsoXmlTag("TknAssrncLvl")]
    [IsoSimpleType(IsoSimpleType.Number)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoNumber? TokenAssuranceLevel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? TokenAssuranceLevel { get; init; } 
    #else
    public System.UInt64? TokenAssuranceLevel { get; set; } 
    #endif
    
    
    #nullable disable
    
}
