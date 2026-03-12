// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the underlying statement entry, to which the investigation message refers.
/// </summary>
[IsoId("_eQujoc4zEeis464yZacv2g")]
[DisplayName("Underlying Statement Entry")]
public partial record UnderlyingStatementEntry3
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    [IsoId("_ebdM8c4zEeis464yZacv2g")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    
    /// <summary>
    /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
    /// </summary>
    [IsoId("_ebdM884zEeis464yZacv2g")]
    [DisplayName("Original Statement Identification")]
    [IsoXmlTag("OrgnlStmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalStatementIdentification { get; init; } 
    
    /// <summary>
    /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
    /// </summary>
    [IsoId("_ebdM9c4zEeis464yZacv2g")]
    [DisplayName("Original Entry Identification")]
    [IsoXmlTag("OrgnlNtryId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OriginalEntryIdentification { get; init; } 
    
    /// <summary>
    /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
    /// </summary>
    [IsoId("_afVVoc4zEeis464yZacv2g")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; } 
    
    
    #nullable disable
    
}
