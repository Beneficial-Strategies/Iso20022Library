// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements providing information specific to the individual direct debit(s).
/// </summary>
[IsoId("_U68zAAbvEearf7_vc3OyqQ")]
[DisplayName("FI To FI Direct Debit Transaction Information Details")]
public partial record FIToFIDirectDebitTransactionInformationDetails1
{
    #nullable enable
    
    /// <summary>
    /// Common characteristics for all individual transactions included in the message.
    /// </summary>
    [IsoId("_eLGvwAbvEearf7_vc3OyqQ")]
    [DisplayName("Group Header")]
    [IsoXmlTag("GrpHdr")]
    public required GroupHeader63 GroupHeader { get; init; } 
    
    /// <summary>
    /// Characteristics that apply to the credit side of the payment transaction(s) included in the message.
    /// </summary>
    [IsoId("_iCkJgAbvEearf7_vc3OyqQ")]
    [DisplayName("Credit Instruction")]
    [IsoXmlTag("CdtInstr")]
    public ValueList<CreditTransferTransaction9> CreditInstruction { get; init; } = new ValueList<CreditTransferTransaction9>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _iCkJgAbvEearf7_vc3OyqQ
    
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_7HBTgBkZEeapYKOltfjd7A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; } 
    
    
    #nullable disable
    
}
