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
/// Natural or legal person to whom an investment firm provides investment or ancillary services.
/// </summary>
[IsoId("_Yo3FgO3pEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Client Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementInternaliserClientType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementInternaliserClientType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementInternaliserClientType1( InternalisationData1 reqProfessional,InternalisationData1 reqRetail )
    {
        Professional = reqProfessional;
        Retail = reqRetail;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Professional clients as defined in the relevant legislation.
    /// </summary>
    [IsoId("_dCfYMO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Professional")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prfssnl")]
    #endif
    [IsoXmlTag("Prfssnl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 Professional { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 Professional { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 Professional { get; init; } 
    #else
    public InternalisationData1 Professional { get; set; } 
    #endif
    
    /// <summary>
    /// Clients other than professional clients.
    /// </summary>
    [IsoId("_eG7QsO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Retail")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rtl")]
    #endif
    [IsoXmlTag("Rtl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InternalisationData1 Retail { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InternalisationData1 Retail { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InternalisationData1 Retail { get; init; } 
    #else
    public InternalisationData1 Retail { get; set; } 
    #endif
    
    
    #nullable disable
    
}
