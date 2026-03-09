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
/// Additional information about a request (e.g. financing request).
/// </summary>
[IsoId("_RX8oYtp-Ed-ak6NoX_4Aeg_-2024158417")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AdditionalInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AdditionalInformation1( InformationType1Choice_ reqInformationType,System.String reqInformationValue )
    {
        InformationType = reqInformationType;
        InformationValue = reqInformationValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the type of additional information.
    /// </summary>
    [IsoId("_RX8oY9p-Ed-ak6NoX_4Aeg_-2024158415")]
    [DisplayName("Information Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfTp")]
    #endif
    [IsoXmlTag("InfTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InformationType1Choice_ InformationType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InformationType1Choice_ InformationType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InformationType1Choice_ InformationType { get; init; } 
    #else
    public InformationType1Choice_ InformationType { get; set; } 
    #endif
    
    /// <summary>
    /// Contents of the additional information.
    /// </summary>
    [IsoId("_RX8oZNp-Ed-ak6NoX_4Aeg_-2024158399")]
    [DisplayName("Information Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InfVal")]
    #endif
    [IsoXmlTag("InfVal")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text InformationValue { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String InformationValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String InformationValue { get; init; } 
    #else
    public System.String InformationValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}
