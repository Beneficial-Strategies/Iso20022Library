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
/// Provides information on the remittance advice.
/// </summary>
[IsoId("_-BcUm24-EeiU9cctagi5ow")]
[DisplayName("Remittance Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceLocation7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the remittance information sent separately from the payment instruction, such as a remittance advice.
    /// </summary>
    [IsoId("_-LRmA24-EeiU9cctagi5ow")]
    [DisplayName("Remittance Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtId")]
    #endif
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RemittanceIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemittanceIdentification { get; init; } 
    #else
    public System.String? RemittanceIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the location and/or delivery of the remittance information.
    /// </summary>
    [IsoId("_-LRmBW4-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnDtls")]
    #endif
    [IsoXmlTag("RmtLctnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceLocationData1? RemittanceLocationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceLocationData1? RemittanceLocationDetails { get; init; } 
    #else
    public RemittanceLocationData1? RemittanceLocationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
