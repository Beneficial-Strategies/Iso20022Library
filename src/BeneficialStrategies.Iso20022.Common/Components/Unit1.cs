// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about the units to settle.
/// </summary>
[IsoId("_VPBAkNp-Ed-ak6NoX_4Aeg_868389886")]
[DisplayName("Unit")]
public record Unit1
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_VPBAkdp-Ed-ak6NoX_4Aeg_1097423556")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Date upon which the investor purchased the financial instrument.
    /// </summary>
    [IsoId("_VPBAktp-Ed-ak6NoX_4Aeg_1368013707")]
    [DisplayName("Acquisition Date")]
    [IsoXmlTag("AcqstnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AcquisitionDate { get; init; }

    /// <summary>
    /// Certificate representing the security that is delivered.
    /// </summary>
    [IsoId("_VPBAk9p-Ed-ak6NoX_4Aeg_-596382257")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CertificateNumber { get; init; }

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_VPBAlNp-Ed-ak6NoX_4Aeg_-542682069")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Information related to the price of the transferred units.
    /// </summary>
    [IsoId("_VPBAldp-Ed-ak6NoX_4Aeg_552546812")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice3? PriceDetails { get; init; }
}
