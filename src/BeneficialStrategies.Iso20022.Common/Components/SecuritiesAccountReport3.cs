// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to report information about securities account reference data.
/// </summary>
[IsoId("_x4sjhTp1Eemk2e6qGBk8IQ")]
[DisplayName("Securities Account Report")]
public record SecuritiesAccountReport3
{
    /// <summary>
    /// Unique and unambiguous identification for the system security account.
    /// </summary>
    [IsoId("_yC-g4Tp1Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Identification")]
    [IsoXmlTag("SctiesAcctId")]
    public required SecuritiesAccount19 SecuritiesAccountIdentification { get; init; }

    /// <summary>
    /// Specifies the returned securities account reference data or error information.
    /// </summary>
    [IsoId("_yC-g4zp1Eemk2e6qGBk8IQ")]
    [DisplayName("Securities Account Or Error")]
    [IsoXmlTag("SctiesAcctOrErr")]
    public required SecuritiesAccountOrBusinessError3Choice_ SecuritiesAccountOrError { get; init; }
}
