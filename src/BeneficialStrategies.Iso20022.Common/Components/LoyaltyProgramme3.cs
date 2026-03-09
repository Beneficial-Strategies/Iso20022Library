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
/// Loyalty programme used for partial payment in loyalty value (debit) and computation of loyalty value gained on the monetary value paid by the customer (credit).
/// </summary>
[IsoId("_bMhUgcW2EeuhguwJmlgagQ")]
[DisplayName("Loyalty Programme")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyProgramme3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Eligibility for loyalty.
    /// True: Eligible for loyalty
    /// False: Not eligible for loyalty
    /// Default: False.
    /// </summary>
    [IsoId("_bQ4QEcW2EeuhguwJmlgagQ")]
    [DisplayName("Programme Eligibility Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrgrmmElgbltyInd")]
    #endif
    [IsoXmlTag("PrgrmmElgbltyInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ProgrammeEligibilityIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProgrammeEligibilityIndicator { get; init; } 
    #else
    public System.String? ProgrammeEligibilityIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Entity issuing the loyalty programme.
    /// </summary>
    [IsoId("_bQ4QE8W2EeuhguwJmlgagQ")]
    [DisplayName("Programme Issuer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrgrmmIssr")]
    #endif
    [IsoXmlTag("PrgrmmIssr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ProgrammeIssuer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProgrammeIssuer { get; init; } 
    #else
    public System.String? ProgrammeIssuer { get; set; } 
    #endif
    
    /// <summary>
    /// Details about the member of the loyalty programme
    /// </summary>
    [IsoId("_bQ4QFcW2EeuhguwJmlgagQ")]
    [DisplayName("Loyalty Member")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LltyMmb")]
    #endif
    [IsoXmlTag("LltyMmb")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyMember2? LoyaltyMember { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyMember2? LoyaltyMember { get; init; } 
    #else
    public LoyaltyMember2? LoyaltyMember { get; set; } 
    #endif
    
    
    #nullable disable
    
}
