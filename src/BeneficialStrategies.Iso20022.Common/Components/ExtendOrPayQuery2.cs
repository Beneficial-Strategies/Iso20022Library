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
/// Undertaking extend or pay query details.
/// </summary>
[IsoId("_-Dxn0nltEeG7BsjMvd1mEw_1814093000")]
[DisplayName("Extend Or Pay Query")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExtendOrPayQuery2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExtendOrPayQuery2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExtendOrPayQuery2( Undertaking9 reqUndertakingIdentification,Demand4 reqDemandDetails,DemandStatus1Code reqStatus )
    {
        UndertakingIdentification = reqUndertakingIdentification;
        DemandDetails = reqDemandDetails;
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Details related to the identification of the undertaking.
    /// </summary>
    [IsoId("_-Dxn03ltEeG7BsjMvd1mEw_1205315845")]
    [DisplayName("Undertaking Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UdrtkgId")]
    #endif
    [IsoXmlTag("UdrtkgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Undertaking9 UndertakingIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Undertaking9 UndertakingIdentification { get; init; } 
    #else
    public Undertaking9 UndertakingIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Details related to the demand.
    /// </summary>
    [IsoId("_-Dxn1HltEeG7BsjMvd1mEw_812048330")]
    [DisplayName("Demand Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DmndDtls")]
    #endif
    [IsoXmlTag("DmndDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Demand4 DemandDetails { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Demand4 DemandDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Demand4 DemandDetails { get; init; } 
    #else
    public Demand4 DemandDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Processing status reported by the applicant.
    /// </summary>
    [IsoId("_-Dxn1XltEeG7BsjMvd1mEw_-1345817899")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DemandStatus1Code Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DemandStatus1Code Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DemandStatus1Code Status { get; init; } 
    #else
    public DemandStatus1Code Status { get; set; } 
    #endif
    
    
    #nullable disable
    
}
