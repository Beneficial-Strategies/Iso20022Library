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
/// Disposition of previously submitted fraud report message.
/// </summary>
[IsoId("_tyAHATHUEeyTT91yHXSlSQ")]
[DisplayName("Fraud Disposition Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FraudDispositionStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FraudDispositionStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FraudDispositionStatus2( ActionTaken1Code reqActionTaken )
    {
        ActionTaken = reqActionTaken;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates the action taken as a disposition of the previously fraud report message.
    /// </summary>
    [IsoId("_t4meQTHUEeyTT91yHXSlSQ")]
    [DisplayName("Action Taken")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTaken")]
    #endif
    [IsoXmlTag("ActnTaken")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActionTaken1Code ActionTaken { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActionTaken1Code ActionTaken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionTaken1Code ActionTaken { get; init; } 
    #else
    public ActionTaken1Code ActionTaken { get; set; } 
    #endif
    
    /// <summary>
    /// Other action taken as defined at national or private level.
    /// </summary>
    [IsoId("_t4meQzHUEeyTT91yHXSlSQ")]
    [DisplayName("Other Action Taken")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrActnTaken")]
    #endif
    [IsoXmlTag("OthrActnTaken")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherActionTaken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherActionTaken { get; init; } 
    #else
    public System.String? OtherActionTaken { get; set; } 
    #endif
    
    /// <summary>
    /// Contains errors found in the submitted fraud report message.
    /// </summary>
    [IsoId("_t4meRTHUEeyTT91yHXSlSQ")]
    [DisplayName("Error Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ErrData")]
    #endif
    [IsoXmlTag("ErrData")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? ErrorData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ErrorData { get; init; } 
    #else
    public System.String? ErrorData { get; set; } 
    #endif
    
    /// <summary>
    /// Contains warnings found in the submitted fraud report message.
    /// </summary>
    [IsoId("_t4meRzHUEeyTT91yHXSlSQ")]
    [DisplayName("Warning Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="WrngData")]
    #endif
    [IsoXmlTag("WrngData")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax256Text? WarningData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? WarningData { get; init; } 
    #else
    public System.String? WarningData { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information
    /// </summary>
    [IsoId("_t4meSTHUEeyTT91yHXSlSQ")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation30? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation30? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation30? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
