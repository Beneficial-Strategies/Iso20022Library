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
/// Unless bilaterally agreed between the Sender and the Receiver, additional information must not contain information that can be provided in a structured field.
/// </summary>
[IsoId("_2xhasLzhEeivTd4NUfCi2g")]
[DisplayName("Additional Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalInformation24
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides additional information on the collateral instruction.
    /// </summary>
    [IsoId("_M3nIELziEeivTd4NUfCi2g")]
    [DisplayName("Collateral Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollInstr")]
    #endif
    [IsoXmlTag("CollInstr")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? CollateralInstruction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CollateralInstruction { get; init; } 
    #else
    public System.String? CollateralInstruction { get; set; } 
    #endif
    
    /// <summary>
    /// Narrative information visible to other parties.
    /// </summary>
    [IsoId("_dOOxMLziEeivTd4NUfCi2g")]
    [DisplayName("Note")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Note")]
    #endif
    [IsoXmlTag("Note")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? Note { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Note { get; init; } 
    #else
    public System.String? Note { get; set; } 
    #endif
    
    
    #nullable disable
    
}
