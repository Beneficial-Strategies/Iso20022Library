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
/// Content of the Logout Request message.
/// </summary>
[IsoId("_pv3ZIN6JEeiwsev40qZGEQ")]
[DisplayName("Logout Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LogoutRequest1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates that the POI terminal is able to go(or have to go) to maintenance.
    /// </summary>
    [IsoId("_z9QaMN6JEeiwsev40qZGEQ")]
    [DisplayName("Maintenance Allowed")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MntncAllwd")]
    #endif
    [IsoXmlTag("MntncAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? MaintenanceAllowed { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MaintenanceAllowed { get; init; } 
    #else
    public System.String? MaintenanceAllowed { get; set; } 
    #endif
    
    
    #nullable disable
    
}
