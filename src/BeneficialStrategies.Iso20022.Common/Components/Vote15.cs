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
/// Vote expressed for one resolution.
/// </summary>
[IsoId("_XbSmmfNoEeqRfth943bvEA")]
[DisplayName("Vote")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Vote15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Vote15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Vote15( System.String reqIssuerLabel,VoteInstructionType2Choice_ reqVoteOption )
    {
        IssuerLabel = reqIssuerLabel;
        VoteOption = reqVoteOption;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Number of the resolution as specified by the issuer or its agent.
    /// </summary>
    [IsoId("_XuyKUfNoEeqRfth943bvEA")]
    [DisplayName("Issuer Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="IssrLabl")]
    #endif
    [IsoXmlTag("IssrLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text IssuerLabel { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String IssuerLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String IssuerLabel { get; init; } 
    #else
    public System.String IssuerLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Vote instructed.
    /// </summary>
    [IsoId("_XuyKU_NoEeqRfth943bvEA")]
    [DisplayName("Vote Option")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteOptn")]
    #endif
    [IsoXmlTag("VoteOptn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VoteInstructionType2Choice_ VoteOption { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VoteInstructionType2Choice_ VoteOption { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstructionType2Choice_ VoteOption { get; init; } 
    #else
    public VoteInstructionType2Choice_ VoteOption { get; set; } 
    #endif
    
    
    #nullable disable
    
}
