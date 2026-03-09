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
/// Information important for the users of the message/service, which cannot be captured in any other message component/element. For example: Warehouse number.
/// </summary>
[IsoId("_RKFyldp-Ed-ak6NoX_4Aeg_-1294803117")]
[DisplayName("User Defined Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UserDefinedInformation1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a UserDefinedInformation1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public UserDefinedInformation1( System.String reqLabel,System.String reqInformation )
    {
        Label = reqLabel;
        Information = reqInformation;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifies the nature of the user information.
    /// </summary>
    [IsoId("_RKFyltp-Ed-ak6NoX_4Aeg_-1252319958")]
    [DisplayName("Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Labl")]
    #endif
    [IsoXmlTag("Labl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text Label { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Label { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Label { get; init; } 
    #else
    public System.String Label { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the content of the user information.
    /// </summary>
    [IsoId("_RKFyl9p-Ed-ak6NoX_4Aeg_-978956797")]
    [DisplayName("Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Inf")]
    #endif
    [IsoXmlTag("Inf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax140Text Information { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Information { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Information { get; init; } 
    #else
    public System.String Information { get; set; } 
    #endif
    
    
    #nullable disable
    
}
