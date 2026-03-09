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
/// Set of elements providing information specific to the individual direct debit(s).
/// </summary>
[IsoId("_U68zAAbvEearf7_vc3OyqQ")]
[DisplayName("FI To FI Direct Debit Transaction Information Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FIToFIDirectDebitTransactionInformationDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FIToFIDirectDebitTransactionInformationDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FIToFIDirectDebitTransactionInformationDetails1( GroupHeader63 reqGroupHeader )
    {
        GroupHeader = reqGroupHeader;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Common characteristics for all individual transactions included in the message.
    /// </summary>
    [IsoId("_eLGvwAbvEearf7_vc3OyqQ")]
    [DisplayName("Group Header")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrpHdr")]
    #endif
    [IsoXmlTag("GrpHdr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GroupHeader63 GroupHeader { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GroupHeader63 GroupHeader { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GroupHeader63 GroupHeader { get; init; } 
    #else
    public GroupHeader63 GroupHeader { get; set; } 
    #endif
    
    /// <summary>
    /// Characteristics that apply to the credit side of the payment transaction(s) included in the message.
    /// </summary>
    [IsoId("_iCkJgAbvEearf7_vc3OyqQ")]
    [DisplayName("Credit Instruction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtInstr")]
    #endif
    [IsoXmlTag("CdtInstr")]
    public ValueList<CreditTransferTransaction9> CreditInstruction { get; init; } = new ValueList<CreditTransferTransaction9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _iCkJgAbvEearf7_vc3OyqQ
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HBTgBkZEeapYKOltfjd7A")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
