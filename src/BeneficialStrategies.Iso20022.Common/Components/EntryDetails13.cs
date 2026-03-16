// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entry Details13.
/// </summary>
[IsoId("_9LdOlzEsEe6GxLzpkVnWYg")]
[DisplayName("Entry Details13")]
public partial record EntryDetails13
{
    #nullable enable

    /// <summary>
    /// Batch.
    /// </summary>
    [DisplayName("Batch")]
    [IsoXmlTag("Btch")]
    public BatchInformation2? Batch { get; init; } 

    /// <summary>
    /// Transaction Details.
    /// </summary>
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public ValueList<EntryTransaction14> TransactionDetails { get; init; } = [];

    
    #nullable disable
    
}
