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
/// Information about a related settlement instruction.
/// </summary>
[IsoId("_oefNAC2sEeuVt5XRmyhHiA")]
[DisplayName("Related Settlement Instruction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RelatedSettlementInstruction1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RelatedSettlementInstruction1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RelatedSettlementInstruction1( System.String reqRelatedSettlementInstructionIdentification )
    {
        RelatedSettlementInstructionIdentification = reqRelatedSettlementInstructionIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unambiguous identification of the related settlement instruction assigned by the account holder.
    /// </summary>
    [IsoId("_cx_1YNvWEeqmdMJWobugpw")]
    [DisplayName("Related Settlement Instruction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdSttlmInstrId")]
    #endif
    [IsoXmlTag("RltdSttlmInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text RelatedSettlementInstructionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String RelatedSettlementInstructionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String RelatedSettlementInstructionIdentification { get; init; } 
    #else
    public System.String RelatedSettlementInstructionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities for which the market claim has been raised.
    /// </summary>
    [IsoId("_Fr_pAC2tEeuVt5XRmyhHiA")]
    [DisplayName("Related Settlement Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RltdSttlmQty")]
    #endif
    [IsoXmlTag("RltdSttlmQty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FinancialInstrumentQuantity18Choice_? RelatedSettlementQuantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancialInstrumentQuantity18Choice_? RelatedSettlementQuantity { get; init; } 
    #else
    public FinancialInstrumentQuantity18Choice_? RelatedSettlementQuantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}
