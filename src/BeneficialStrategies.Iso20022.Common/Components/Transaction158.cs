// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of transaction for a file action.
/// </summary>
[IsoId("_DabH0YgqEeu8-LhY4KPfWg")]
[DisplayName("Transaction")]
public partial record Transaction158
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_Dfd_4YgqEeu8-LhY4KPfWg")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public TransactionIdentification12? TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_Dfd_44gqEeu8-LhY4KPfWg")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public AdditionalFee2? AdditionalFee { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_Dfd_5YgqEeu8-LhY4KPfWg")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    [IsoId("_coNuESxOEeyg-aG5nXcnfg")]
    [DisplayName("File Action Details")]
    [IsoXmlTag("FileActnDtls")]
    public required FileActionDetails2 FileActionDetails { get; init; } 
    
    
    #nullable disable
    
}
