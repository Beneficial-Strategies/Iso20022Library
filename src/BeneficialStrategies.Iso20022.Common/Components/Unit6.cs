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
[IsoId("_TW_CkSVmEeWV8IT-SD_UOg")]
[DisplayName("Unit")]
public record Unit6
{
    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_TzjCwyVmEeWV8IT-SD_UOg")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    public required FinancialInstrumentQuantity1 UnitsNumber { get; init; }

    /// <summary>
    /// Date upon which the investor purchased the financial instrument.
    /// </summary>
    [IsoId("_TzjCxSVmEeWV8IT-SD_UOg")]
    [DisplayName("Acquisition Date")]
    [IsoXmlTag("AcqstnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AcquisitionDate { get; init; }

    /// <summary>
    /// Certificate representing the security that is delivered.
    /// </summary>
    [IsoId("_TzjCxyVmEeWV8IT-SD_UOg")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SimpleValueList<IsoMax35Text> CertificateNumber { get; init; } = [];

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_TzjCySVmEeWV8IT-SD_UOg")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnitCode? Group1Or2Units { get; init; }

    /// <summary>
    /// Information related to the price of the transferred units.
    /// </summary>
    [IsoId("_TzjCyyVmEeWV8IT-SD_UOg")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice21? PriceDetails { get; init; }
}
