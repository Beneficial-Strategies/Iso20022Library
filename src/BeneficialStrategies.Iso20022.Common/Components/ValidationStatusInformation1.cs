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
/// Information about the status of a specific message.
/// </summary>
[IsoId("_RXzec9p-Ed-ak6NoX_4Aeg_714459273")]
[DisplayName("Validation Status Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ValidationStatusInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ValidationStatusInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ValidationStatusInformation1( TechnicalValidationStatus1Code reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// The result of the technical validation (e.g. Accepted, Reception error) executed on the request message.
    /// </summary>
    [IsoId("_RXzedNp-Ed-ak6NoX_4Aeg_1118960492")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TechnicalValidationStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TechnicalValidationStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TechnicalValidationStatus1Code Status { get; init; } 
    #else
    public TechnicalValidationStatus1Code Status { get; set; } 
    #endif
    
    /// <summary>
    /// The reason for the validation status.
    /// </summary>
    [IsoId("_RXzeddp-Ed-ak6NoX_4Aeg_1535469525")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusReason4Choice_? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReason4Choice_? StatusReason { get; init; } 
    #else
    public StatusReason4Choice_? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the validation status reason.
    /// </summary>
    [IsoId("_RXzedtp-Ed-ak6NoX_4Aeg_1617662894")]
    [DisplayName("Additional Status Reason Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlStsRsnInf")]
    #endif
    [IsoXmlTag("AddtlStsRsnInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalStatusReasonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalStatusReasonInformation { get; init; } 
    #else
    public System.String? AdditionalStatusReasonInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
