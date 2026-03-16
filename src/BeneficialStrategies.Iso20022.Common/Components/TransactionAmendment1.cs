// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction Amendment1.
/// </summary>
[IsoId("_q5EEoG8uEe2aW4iy-zispA")]
[DisplayName("Transaction Amendment1")]
public partial record TransactionAmendment1
{
    #nullable enable

    /// <summary>
    /// Path.
    /// </summary>
    [DisplayName("Path")]
    [IsoXmlTag("Pth")]
    public IsoMax2048Text? Path { get; init; } 

    /// <summary>
    /// Record.
    /// </summary>
    [DisplayName("Record")]
    [IsoXmlTag("Rcrd")]
    public required TransactionAmendment1Choice_ Record { get; init; } 

    
    #nullable disable
    
}
