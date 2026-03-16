// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Status And Reason47.
/// </summary>
[IsoId("_xNvfMYYPEe-Pv9KR9bv9IA")]
[DisplayName("Status And Reason47")]
public partial record StatusAndReason47
{
    #nullable enable

    /// <summary>
    /// Status And Reason.
    /// </summary>
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public required Status38Choice_ StatusAndReason { get; init; } 

    /// <summary>
    /// Transaction.
    /// </summary>
    [DisplayName("Transaction")]
    [IsoXmlTag("Tx")]
    public ValueList<Transaction162> Transaction { get; init; } = [];

    
    #nullable disable
    
}
