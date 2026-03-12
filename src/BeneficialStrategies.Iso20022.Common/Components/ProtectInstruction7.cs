// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on protect and cover protect instructions.
/// </summary>
[IsoId("_FLSgEf0hEeiKOe8GCUL1Lg")]
[DisplayName("Protect Instruction")]
public partial record ProtectInstruction7
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_Fwe30f0hEeiKOe8GCUL1Lg")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ProtectTransactionType3Code TransactionType { get; init; } 
    
    /// <summary>
    /// Unique reference of the protect transaction assigned by the depository and used for cover protect validation.
    /// </summary>
    [IsoId("_Fwe30_0hEeiKOe8GCUL1Lg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax15Text)]
    [StringLength(maximumLength: 15 ,MinimumLength = 1)]
    public IsoRestrictedFINMax15Text? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Date at which the protect instruction was created and used for cover protect validation.
    /// </summary>
    [IsoId("_Fwe31f0hEeiKOe8GCUL1Lg")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; } 
    
    
    #nullable disable
    
}
