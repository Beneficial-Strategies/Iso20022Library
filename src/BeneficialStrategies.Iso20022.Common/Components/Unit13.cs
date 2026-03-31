// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about units to transfer.
/// </summary>
[IsoId("_cFAuQXwhEeuQY_68iqAoCQ")]
[DisplayName("Unit")]
public record Unit13
{
    /// <summary>
    /// Quantity of units.
    /// </summary>
    [IsoId("_cbpFk3whEeuQY_68iqAoCQ")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber UnitsNumber { get; init; }

    /// <summary>
    /// Date the investor or its agent placed the original order.
    /// </summary>
    [IsoId("_cbpFlXwhEeuQY_68iqAoCQ")]
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OrderDate { get; init; }

    /// <summary>
    /// Date the investor purchased the financial instrument.
    /// </summary>
    [IsoId("_cbpFl3whEeuQY_68iqAoCQ")]
    [DisplayName("Acquisition Date")]
    [IsoXmlTag("AcqstnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AcquisitionDate { get; init; }

    /// <summary>
    /// Certificate representing the security.
    /// </summary>
    [IsoId("_cbpFmXwhEeuQY_68iqAoCQ")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SimpleValueList<IsoMax35Text> CertificateNumber { get; init; } = [];

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_cbpFm3whEeuQY_68iqAoCQ")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Reference to the units number. This may be the order reference of the original acquisition, the identification of a lot, a client reference, a sub-position reference or other related reference.
    /// </summary>
    [IsoId("_cbpFnXwhEeuQY_68iqAoCQ")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }
}
