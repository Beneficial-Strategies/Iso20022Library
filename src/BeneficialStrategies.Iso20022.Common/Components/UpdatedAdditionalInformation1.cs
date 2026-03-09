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
/// Additional information with update description and date.
/// </summary>
[IsoId("_Q1YG2Np-Ed-ak6NoX_4Aeg_997043012")]
[DisplayName("Updated Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UpdatedAdditionalInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the amendments made to the narrative since the last message.
    /// </summary>
    [IsoId("_Q1YG2dp-Ed-ak6NoX_4Aeg_1035828557")]
    [DisplayName("Update Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdDesc")]
    #endif
    [IsoXmlTag("UpdDesc")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? UpdateDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UpdateDescription { get; init; } 
    #else
    public System.String? UpdateDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the date at which the narrative has been updated.
    /// </summary>
    [IsoId("_Q1YG2tp-Ed-ak6NoX_4Aeg_1407084730")]
    [DisplayName("Update Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UpdDt")]
    #endif
    [IsoXmlTag("UpdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? UpdateDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? UpdateDate { get; init; } 
    #else
    public System.DateOnly? UpdateDate { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional textual information.
    /// </summary>
    [IsoId("_Q1YG29p-Ed-ak6NoX_4Aeg_1667518614")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    public SimpleValueList<System.String> AdditionalInformation { get; init; } = new SimpleValueList<System.String>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _Q1YG29p-Ed-ak6NoX_4Aeg_1667518614
    
    
    #nullable disable
    
}
