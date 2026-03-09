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
[IsoId("_52zPwNwoEeeKpa-yxjuKzQ")]
[DisplayName("Trigger Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TriggerInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TriggerInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TriggerInformation1( PartyType5Code reqTriggerSource,System.String reqSourceIdentification,ExchangePolicy1Code reqTriggerType )
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
    [IsoId("_LTOqYNwpEeeKpa-yxjuKzQ")]
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
    [IsoId("_P5d1sNwpEeeKpa-yxjuKzQ")]
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
    [IsoId("_VQ0U4NwpEeeKpa-yxjuKzQ")]
    [DisplayName("Trigger Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrggrTp")]
    #endif
    [IsoXmlTag("TrggrTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ExchangePolicy1Code TriggerType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ExchangePolicy1Code TriggerType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExchangePolicy1Code TriggerType { get; init; } 
    #else
    public ExchangePolicy1Code TriggerType { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to request.
    /// </summary>
    [IsoId("_d7oI4NwpEeeKpa-yxjuKzQ")]
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
