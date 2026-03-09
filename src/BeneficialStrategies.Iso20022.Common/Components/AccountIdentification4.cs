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
/// Unique identifier of an account, as assigned by the account servicer.
/// </summary>
[IsoId("_WO8MiNp-Ed-ak6NoX_4Aeg_672442635")]
[DisplayName("Account Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AccountIdentification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AccountIdentification4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AccountIdentification4( SimpleIdentificationInformation1 reqProprietary )
    {
        Proprietary = reqProprietary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier for an account. It is assigned by the account servicer using a proprietary identification scheme.
    /// </summary>
    [IsoId("_WO8Midp-Ed-ak6NoX_4Aeg_-1613659809")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SimpleIdentificationInformation1 Proprietary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SimpleIdentificationInformation1 Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SimpleIdentificationInformation1 Proprietary { get; init; } 
    #else
    public SimpleIdentificationInformation1 Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
