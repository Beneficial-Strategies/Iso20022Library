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
/// Summary information about the sale
/// </summary>
[IsoId("_rYJ6FvJoEeiJn9rM2Znz2w")]
[DisplayName("Sale Summary")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SaleSummary1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_rYJ6G_JoEeiJn9rM2Znz2w")]
    [DisplayName("Summary Commodity Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SummryCmmdtyId")]
    #endif
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SummaryCommodityIdentification { get; init; } 
    #else
    public System.String? SummaryCommodityIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains loyalty programme information. 
    /// </summary>
    [IsoId("_WbrOMPJqEeiJn9rM2Znz2w")]
    [DisplayName("Loyalty Programme")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyPrgrmm")]
    #endif
    [IsoXmlTag("LltyPrgrmm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    #else
    public LoyaltyProgramme2? LoyaltyProgramme { get; set; } 
    #endif
    
    /// <summary>
    /// Contains adjustment details of the transaction (for example, percentage, adjustment amount, etc.).
    /// </summary>
    [IsoId("_rYJ6GfJoEeiJn9rM2Znz2w")]
    [DisplayName("Adjustment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Adjstmnt")]
    #endif
    [IsoXmlTag("Adjstmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Adjustment9? Adjustment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Adjustment9? Adjustment { get; init; } 
    #else
    public Adjustment9? Adjustment { get; set; } 
    #endif
    
    
    #nullable disable
    
}
