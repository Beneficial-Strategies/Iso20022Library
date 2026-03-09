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
/// Specifies a threshold level and a threshold basis for passing resolutions at general meetings.
/// </summary>
[IsoId("_IyKJABuMEeyhRdHRjakS2w")]
[DisplayName("Voting Rights Threshold")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VotingRightsThreshold1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VotingRightsThreshold1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VotingRightsThreshold1( NumberOrPercentage1Choice_ reqThreshold )
    {
        Threshold = reqThreshold;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Voting rights threshold required for a resolution to pass in percentage or in quantity.
    /// </summary>
    [IsoId("_hM2WQBuMEeyhRdHRjakS2w")]
    [DisplayName("Threshold")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Thrshld")]
    #endif
    [IsoXmlTag("Thrshld")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required NumberOrPercentage1Choice_ Threshold { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required NumberOrPercentage1Choice_ Threshold { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberOrPercentage1Choice_ Threshold { get; init; } 
    #else
    public NumberOrPercentage1Choice_ Threshold { get; set; } 
    #endif
    
    /// <summary>
    /// Nature of the quantity used as a basis to set a threshold for voting on resolutions at general meetings.
    /// </summary>
    [IsoId("_lbAYwBuMEeyhRdHRjakS2w")]
    [DisplayName("Threshold Basis")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ThrshldBsis")]
    #endif
    [IsoXmlTag("ThrshldBsis")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ThresholdBasis1Choice_? ThresholdBasis { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ThresholdBasis1Choice_? ThresholdBasis { get; init; } 
    #else
    public ThresholdBasis1Choice_? ThresholdBasis { get; set; } 
    #endif
    
    
    #nullable disable
    
}
