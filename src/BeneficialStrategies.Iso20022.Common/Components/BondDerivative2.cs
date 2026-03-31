// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transparency calculation specific details on a bond derivative.
/// </summary>
[IsoId("_s736gWlJEeaLAKoEUNsD9g")]
[DisplayName("Bond Derivative")]
public record BondDerivative2
{
    /// <summary>
    /// Legal Entity Identifier (LEI) code of the issuer of the direct or ultimate underlying bond.
    /// </summary>
    [IsoId("_tFkCAWlJEeaLAKoEUNsD9g")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public required IsoLEIIdentifier Issuer { get; init; }

    /// <summary>
    /// Date of maturity of the underlying bond. This field applies to debt instruments with defined maturity.
    /// </summary>
    [IsoId("_tFkCA2lJEeaLAKoEUNsD9g")]
    [DisplayName("Maturity Date")]
    [IsoXmlTag("MtrtyDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MaturityDate { get; init; }

    /// <summary>
    /// Populated with the issuance date of the underlying bond.
    /// </summary>
    [IsoId("_zoY10GlJEeaLAKoEUNsD9g")]
    [DisplayName("Issuance Date")]
    [IsoXmlTag("IssncDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? IssuanceDate { get; init; }
}
