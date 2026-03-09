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
/// Inquiry service provided by the ATM inside the session.
/// </summary>
[IsoId("_-C7vwa4VEeW_TaP-ygI0SQ")]
[DisplayName("ATM Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ATMService15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ATMService15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ATMService15( ATMServiceType3Code reqServiceType )
    {
        ServiceType = reqServiceType;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identification of the withdrawal service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_-N1YMa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Service Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcRef")]
    #endif
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceReference { get; init; } 
    #else
    public System.String? ServiceReference { get; set; } 
    #endif
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_-N1YM64VEeW_TaP-ygI0SQ")]
    [DisplayName("ATM Service Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ATMSvcCd")]
    #endif
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ATMServiceCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ATMServiceCode { get; init; } 
    #else
    public System.String? ATMServiceCode { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of inquiry selected by the customer or the ATM.
    /// </summary>
    [IsoId("_-N1YNa4VEeW_TaP-ygI0SQ")]
    [DisplayName("Service Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcTp")]
    #endif
    [IsoXmlTag("SvcTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ATMServiceType3Code ServiceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ATMServiceType3Code ServiceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ATMServiceType3Code ServiceType { get; init; } 
    #else
    public ATMServiceType3Code ServiceType { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_HUrn8K4WEeW_TaP-ygI0SQ")]
    [DisplayName("Service Variant Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcVarntId")]
    #endif
    [IsoXmlTag("SvcVarntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ServiceVariantIdentification { get; init; } 
    #else
    public System.String? ServiceVariantIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}
