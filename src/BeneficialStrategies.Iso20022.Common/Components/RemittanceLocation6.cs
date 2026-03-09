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
[IsoId("_9B7YUW4-EeiU9cctagi5ow")]
[DisplayName("Remittance Location")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceLocation6
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
    [IsoId("_9MDks24-EeiU9cctagi5ow")]
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
    /// Method used to deliver the remittance advice information.
    /// </summary>
    [IsoId("_9MDktW4-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Method")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnMtd")]
    #endif
    [IsoXmlTag("RmtLctnMtd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; init; } 
    #else
    public RemittanceLocationMethod2Code? RemittanceLocationMethod { get; set; } 
    #endif
    
    /// <summary>
    /// Electronic address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_9MDkt24-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Electronic Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnElctrncAdr")]
    #endif
    [IsoXmlTag("RmtLctnElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max2048Text)]
    [StringLength(maximumLength: 2048 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax2048Text? RemittanceLocationElectronicAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RemittanceLocationElectronicAddress { get; init; } 
    #else
    public System.String? RemittanceLocationElectronicAddress { get; set; } 
    #endif
    
    /// <summary>
    /// Postal address to which an agent is to send the remittance information.
    /// </summary>
    [IsoId("_9MDkuW4-EeiU9cctagi5ow")]
    [DisplayName("Remittance Location Postal Address")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RmtLctnPstlAdr")]
    #endif
    [IsoXmlTag("RmtLctnPstlAdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NameAndAddress16? RemittanceLocationPostalAddress { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NameAndAddress16? RemittanceLocationPostalAddress { get; init; } 
    #else
    public NameAndAddress16? RemittanceLocationPostalAddress { get; set; } 
    #endif
    
    
    #nullable disable
    
}
