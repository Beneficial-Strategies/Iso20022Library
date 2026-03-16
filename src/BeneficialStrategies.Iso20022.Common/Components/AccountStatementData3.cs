// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account Statement Data3.
/// </summary>
[IsoId("_n3D-MYJJEe6dZ_jHhjXHQg")]
[DisplayName("Account Statement Data3")]
public partial record AccountStatementData3
{
    #nullable enable

    /// <summary>
    /// Date.
    /// </summary>
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public IsoISODate? Date { get; init; } 

    /// <summary>
    /// Details.
    /// </summary>
    [DisplayName("Details")]
    [IsoXmlTag("Dtls")]
    public ValueList<AccountStatementDetails3> Details { get; init; } = [];

    /// <summary>
    /// Time.
    /// </summary>
    [DisplayName("Time")]
    [IsoXmlTag("Tm")]
    public IsoISOTime? Time { get; init; } 

    
    #nullable disable
    
}
