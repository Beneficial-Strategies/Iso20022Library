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
/// Funds related service such as a payment or a transfer related to the transaction.
/// </summary>
[IsoId("_eC8lMYKxEeu4svNQ5N-l6w")]
[DisplayName("Funding Service")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FundingService2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Funding service details.
    /// </summary>
    [IsoId("_eH_dQYKxEeu4svNQ5N-l6w")]
    [DisplayName("Funding Service")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndgSvc")]
    #endif
    [IsoXmlTag("FndgSvc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransferService2? FundingService { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransferService2? FundingService { get; init; } 
    #else
    public TransferService2? FundingService { get; set; } 
    #endif
    
    /// <summary>
    /// Source of funding.
    /// </summary>
    [IsoId("_eH_dQ4KxEeu4svNQ5N-l6w")]
    [DisplayName("Funding Source")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FndgSrc")]
    #endif
    [IsoXmlTag("FndgSrc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FundingSource2? FundingSource { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FundingSource2? FundingSource { get; init; } 
    #else
    public FundingSource2? FundingSource { get; set; } 
    #endif
    
    /// <summary>
    /// Information for claiming funds.
    /// </summary>
    [IsoId("_eH_dRYKxEeu4svNQ5N-l6w")]
    [DisplayName("Claim Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClmInf")]
    #endif
    [IsoXmlTag("ClmInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ClaimInformation1? ClaimInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ClaimInformation1? ClaimInformation { get; init; } 
    #else
    public ClaimInformation1? ClaimInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
