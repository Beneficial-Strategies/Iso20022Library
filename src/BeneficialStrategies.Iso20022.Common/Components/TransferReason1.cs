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
/// Choice of format for the transfer reason.
/// </summary>
[IsoId("_kgcvYPr5EeCu2Z1WwxJVWA")]
[DisplayName("Transfer Reason")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransferReason1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransferReason1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransferReason1( TransferReason1Code reqCode,GenericIdentification27 reqProprietary )
    {
        Code = reqCode;
        Proprietary = reqProprietary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Transfer reason expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_nUBDQfr5EeCu2Z1WwxJVWA")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransferReason1Code Code { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransferReason1Code Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferReason1Code Code { get; init; } 
    #else
    public TransferReason1Code Code { get; set; } 
    #endif
    
    /// <summary>
    /// Transfer reason expressed as a proprietary code.
    /// </summary>
    [IsoId("_rZ-zEfr5EeCu2Z1WwxJVWA")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification27 Proprietary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification27 Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification27 Proprietary { get; init; } 
    #else
    public GenericIdentification27 Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
