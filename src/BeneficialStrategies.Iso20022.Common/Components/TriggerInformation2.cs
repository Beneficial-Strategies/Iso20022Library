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
/// Element containing all information needed to identify who triggered the request.
/// </summary>
[IsoId("_Bn_c4RBcEeqgJK7e3n_EXA")]
[DisplayName("Trigger Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TriggerInformation2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TriggerInformation2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TriggerInformation2( PartyType5Code reqTriggerSource,System.String reqSourceIdentification,ExchangePolicy2Code reqTriggerType )
    {
        TriggerSource = reqTriggerSource;
        SourceIdentification = reqSourceIdentification;
        TriggerType = reqTriggerType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Actor who trigger the request.
    /// </summary>
    [IsoId("_By5FURBcEeqgJK7e3n_EXA")]
    [DisplayName("Trigger Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrggrSrc")]
    #endif
    [IsoXmlTag("TrggrSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyType5Code TriggerSource { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyType5Code TriggerSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyType5Code TriggerSource { get; init; } 
    #else
    public PartyType5Code TriggerSource { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the trigger source.
    /// </summary>
    [IsoId("_By5FUxBcEeqgJK7e3n_EXA")]
    [DisplayName("Source Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SrcId")]
    #endif
    [IsoXmlTag("SrcId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text SourceIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String SourceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String SourceIdentification { get; init; } 
    #else
    public System.String SourceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the type of the call.
    /// </summary>
    [IsoId("_By5FVRBcEeqgJK7e3n_EXA")]
    [DisplayName("Trigger Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrggrTp")]
    #endif
    [IsoXmlTag("TrggrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExchangePolicy2Code TriggerType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExchangePolicy2Code TriggerType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangePolicy2Code TriggerType { get; init; } 
    #else
    public ExchangePolicy2Code TriggerType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to request.
    /// </summary>
    [IsoId("_By5FVxBcEeqgJK7e3n_EXA")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
