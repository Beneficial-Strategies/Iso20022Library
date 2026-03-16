// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the type of the documents referred by the creditor.
/// </summary>
[IsoId("_T31ySNp-Ed-ak6NoX_4Aeg_96960704")]
[DisplayName("Creditor Reference Type")]
public record CreditorReferenceType1
{
    /// <summary>
    /// Coded creditor reference type.
    /// </summary>
    [IsoId("_T31ySdp-Ed-ak6NoX_4Aeg_96961291")]
    [DisplayName("Code")]
    [IsoXmlTag("Cd")]
    public required DocumentType3Code Code { get; init; }

    /// <summary>
    /// Creditor reference type not avilable in a coded format.
    /// </summary>
    [IsoId("_T31yStp-Ed-ak6NoX_4Aeg_96961652")]
    [DisplayName("Proprietary")]
    [IsoXmlTag("Prtry")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text Proprietary { get; init; }

    /// <summary>
    /// Identification of the issuer of the credit reference type.
    /// </summary>
    [IsoId("_T3_jQNp-Ed-ak6NoX_4Aeg_96961712")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Issuer { get; init; }
}
