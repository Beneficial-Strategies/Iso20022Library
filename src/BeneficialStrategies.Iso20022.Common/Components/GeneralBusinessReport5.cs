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
/// Reports either on the business information or on a business error.
/// </summary>
[IsoId("_MP5s5ZlgEeeE1Ya-LgRsuQ")]
[DisplayName("General Business Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record GeneralBusinessReport5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a GeneralBusinessReport5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public GeneralBusinessReport5( System.String reqBusinessInformationReference,GeneralBusinessOrError6Choice_ reqGeneralBusinessOrError )
    {
        BusinessInformationReference = reqBusinessInformationReference;
        GeneralBusinessOrError = reqGeneralBusinessOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identification of a general business information system, as assigned by the system transaction administrator.
    /// </summary>
    [IsoId("_MYGmo5lgEeeE1Ya-LgRsuQ")]
    [DisplayName("Business Information Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BizInfRef")]
    #endif
    [IsoXmlTag("BizInfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text BusinessInformationReference { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String BusinessInformationReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String BusinessInformationReference { get; init; } 
    #else
    public System.String BusinessInformationReference { get; set; } 
    #endif
    
    /// <summary>
    /// Requested business information.
    /// </summary>
    [IsoId("_MYGmpZlgEeeE1Ya-LgRsuQ")]
    [DisplayName("General Business Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GnlBizOrErr")]
    #endif
    [IsoXmlTag("GnlBizOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; init; } 
    #else
    public GeneralBusinessOrError6Choice_ GeneralBusinessOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
