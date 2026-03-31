// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account35.
/// </summary>
[IsoId("_2b9rHRwMEe6O0NdiBuX__w")]
[DisplayName("Account35")]
public record Account35
{
    /// <summary>
    /// Account Servicer.
    /// </summary>
    [DisplayName("Account Servicer")]
    [IsoXmlTag("AcctSvcr")]
    public PartyIdentification139? AccountServicer { get; init; }

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required IsoMax35Text Identification { get; init; }
}
