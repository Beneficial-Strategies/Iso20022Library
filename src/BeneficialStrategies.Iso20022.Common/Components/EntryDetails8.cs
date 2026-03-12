// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the underlying transaction(s) and/or batched entries.
/// </summary>
[IsoId("_7h_x0YarEeeUws0ZryHQ2w")]
[DisplayName("Entry Details")]
public partial record EntryDetails8
{
    #nullable enable
    
    /// <summary>
    /// Provides details on batched transactions.
    /// </summary>
    [IsoId("_7qLdc4arEeeUws0ZryHQ2w")]
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation2? Batch { get; init; } 
    
    /// <summary>
    /// Provides information on the underlying transaction(s).
    /// </summary>
    [IsoId("_7qLddYarEeeUws0ZryHQ2w")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public EntryTransaction9? TransactionDetails { get; init; } 
    
    
    #nullable disable
    
}
