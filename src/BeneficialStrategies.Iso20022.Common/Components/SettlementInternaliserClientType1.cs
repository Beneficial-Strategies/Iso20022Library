// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Natural or legal person to whom an investment firm provides investment or ancillary services.
/// </summary>
[IsoId("_Yo3FgO3pEeaWjpoyrnG6Rw")]
[DisplayName("Settlement Internaliser Client Type")]
public record SettlementInternaliserClientType1
{
    /// <summary>
    /// Professional clients as defined in the relevant legislation.
    /// </summary>
    [IsoId("_dCfYMO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Professional")]
    [IsoXmlTag("Prfssnl")]
    public required InternalisationData1 Professional { get; init; }

    /// <summary>
    /// Clients other than professional clients.
    /// </summary>
    [IsoId("_eG7QsO3pEeaWjpoyrnG6Rw")]
    [DisplayName("Retail")]
    [IsoXmlTag("Rtl")]
    public required InternalisationData1 Retail { get; init; }
}
