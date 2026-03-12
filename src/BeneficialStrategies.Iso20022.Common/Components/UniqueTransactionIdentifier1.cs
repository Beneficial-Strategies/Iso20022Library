// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the unique transaction identifier (UTI) that was created at the time a transaction was first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime and optionally, the prior unique transaction identifier (PUTI). These identifiers can also be known as the Unique Swap Identifier (USI) or the Prior Unique Swap Identifier (PUSI).
/// </summary>
[IsoId("_GeUUQ4JkEeKmtdhZXgREOQ")]
[DisplayName("Unique Transaction Identifier")]
public partial record UniqueTransactionIdentifier1
{
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier will be created at the time a transaction is first executed, shared with all registered entities and counterparties involved in the transaction, and used to track that particular transaction during its lifetime. This identifier can also be known as the Unique Swap Identifier (USI).
    /// </summary>
    [IsoId("_NCP7UIJkEeKmtdhZXgREOQ")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public required IsoMax105Text UniqueTransactionIdentifier { get; init; } 
    
    /// <summary>
    /// Prior unique transaction identifier specifies the previous unique transaction identifier (UTI) that was created at the time the transaction was executed. This identifier can also be known as the Prior Unique Swap Identifier (PUSI).
    /// </summary>
    [IsoId("_PVnsIIJkEeKmtdhZXgREOQ")]
    [DisplayName("Prior Unique Transaction Identifier")]
    [IsoXmlTag("PrrUnqTxIdr")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? PriorUniqueTransactionIdentifier { get; init; } 
    
    
    #nullable disable
    
}
