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
/// Vote options for a resolution.
/// </summary>
[IsoId("_ScucEK4JEemG7MmivSuE5g")]
[DisplayName("Vote Instruction Type")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record VoteInstructionType1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a VoteInstructionType1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public VoteInstructionType1( VoteInstructionType1Choice_ reqVoteInstructionTypeCode )
    {
        VoteInstructionTypeCode = reqVoteInstructionTypeCode;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Vote option allowed at the resolution level.
    /// </summary>
    [IsoId("_ov6xUK4JEemG7MmivSuE5g")]
    [DisplayName("Vote Instruction Type Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VoteInstrTpCd")]
    #endif
    [IsoXmlTag("VoteInstrTpCd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required VoteInstructionType1Choice_ VoteInstructionTypeCode { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required VoteInstructionType1Choice_ VoteInstructionTypeCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public VoteInstructionType1Choice_ VoteInstructionTypeCode { get; init; } 
    #else
    public VoteInstructionType1Choice_ VoteInstructionTypeCode { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the vote instruction type code when expressed as a proprietary code.
    /// </summary>
    [IsoId("_uWdjEK4JEemG7MmivSuE5g")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
