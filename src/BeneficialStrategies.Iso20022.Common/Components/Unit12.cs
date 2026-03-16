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
[IsoId("_ZxsRIZECEem7fvtoGpNpow")]
[DisplayName("Unit")]
public record Unit12
{
    /// <summary>
    /// Quantity of units.
    /// </summary>
    [IsoId("_aGhRo5ECEem7fvtoGpNpow")]
    [DisplayName("Units Number")]
    [IsoXmlTag("UnitsNb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public required IsoDecimalNumber UnitsNumber { get; init; }

    /// <summary>
    /// Date the investor or its agent placed the original order.
    /// </summary>
    [IsoId("_aGhRpZECEem7fvtoGpNpow")]
    [DisplayName("Order Date")]
    [IsoXmlTag("OrdrDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? OrderDate { get; init; }

    /// <summary>
    /// Date the investor purchased the financial instrument.
    /// </summary>
    [IsoId("_aGhRp5ECEem7fvtoGpNpow")]
    [DisplayName("Acquisition Date")]
    [IsoXmlTag("AcqstnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? AcquisitionDate { get; init; }

    /// <summary>
    /// Certificate representing the security that is delivered.
    /// </summary>
    [IsoId("_aGhRqZECEem7fvtoGpNpow")]
    [DisplayName("Certificate Number")]
    [IsoXmlTag("CertNb")]
    public SimpleValueList<IsoMax35Text> CertificateNumber { get; init; } = [];

    /// <summary>
    /// Tax group to which the purchased investment fund units belong. The investor indicates to the intermediary operating pooled nominees, which type of unit is to be sold.
    /// </summary>
    [IsoId("_aGhRq5ECEem7fvtoGpNpow")]
    [DisplayName("Group 1 Or 2 Units")]
    [IsoXmlTag("Grp1Or2Units")]
    public UKTaxGroupUnit1Code? Group1Or2Units { get; init; }

    /// <summary>
    /// Reference to the units number. This may be the order reference of the original acquisition, the identification of a lot, a client reference, a sub-position reference or other related reference.
    /// </summary>
    [IsoId("_aGhRrZECEem7fvtoGpNpow")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; }

    /// <summary>
    /// Information related to the price. This may specify the price of original order confirmation.
    /// </summary>
    [IsoId("_aGhRr5ECEem7fvtoGpNpow")]
    [DisplayName("Price Details")]
    [IsoXmlTag("PricDtls")]
    public UnitPrice23? PriceDetails { get; init; }

    /// <summary>
    /// Fees and taxes. This may specify the fees and taxes related to the original order confirmation.
    /// </summary>
    [IsoId("_aGhRsZECEem7fvtoGpNpow")]
    [DisplayName("Transaction Overhead")]
    [IsoXmlTag("TxOvrhd")]
    public TotalFeesAndTaxes42? TransactionOverhead { get; init; }

    /// <summary>
    /// Amounts not covered in price, fee or tax.
    /// </summary>
    [IsoId("_aGhRs5ECEem7fvtoGpNpow")]
    [DisplayName("Other Amount")]
    [IsoXmlTag("OthrAmt")]
    public ValueList<OtherAmount1> OtherAmount { get; init; } = [];
}
