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
/// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the final agent.
/// </summary>
[IsoId("_Prd4cdp-Ed-ak6NoX_4Aeg_-1258143330")]
[DisplayName("Instruction For Final Agent")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InstructionForFinalAgent
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the final agent, in coded form.
    /// </summary>
    [IsoId("_Prd4ctp-Ed-ak6NoX_4Aeg_-357710298")]
    [DisplayName("Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Cd")]
    #endif
    [IsoXmlTag("Cd")]
    [MinLength(0)]
    [MaxLength(2)]
    public SimpleValueList<Instruction3Code> Code { get; init; } = new SimpleValueList<Instruction3Code>(){};
    
    /// <summary>
    /// Instruction to the final agent that is specific to a user community and is required for use within that user community.||Usage: The proprietary element should only be used when the coded element does not provide sufficient codes or when the selected code in the coded element needs to be supplemented by additional information such as a passport number or telephone number.
    /// </summary>
    [IsoId("_Prd4c9p-Ed-ak6NoX_4Aeg_-100044573")]
    [DisplayName("Proprietary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Prtry")]
    #endif
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Proprietary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Proprietary { get; init; } 
    #else
    public System.String? Proprietary { get; set; } 
    #endif
    
    
    #nullable disable
    
}
