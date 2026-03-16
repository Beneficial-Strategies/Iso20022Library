// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Linkages75.
/// </summary>
[IsoId("_r4RdNYb9Ee-6cOl7zMpJaA")]
[DisplayName("Linkages75")]
public partial record Linkages75
{
    #nullable enable

    /// <summary>
    /// Securities Settlement Transaction Identification.
    /// </summary>
    [DisplayName("Securities Settlement Transaction Identification")]
    [IsoXmlTag("SctiesSttlmTxId")]
    public required IsoMax35Text SecuritiesSettlementTransactionIdentification { get; init; } 

    
    #nullable disable
    
}
