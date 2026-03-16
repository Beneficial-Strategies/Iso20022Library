// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Travel Agency Package2.
/// </summary>
[IsoId("_a4o5UXQ6Ee6Y1uOeeiF_Eg")]
[DisplayName("Travel Agency Package2")]
public record TravelAgencyPackage2
{
    /// <summary>
    /// Credit Card Slip Number.
    /// </summary>
    [DisplayName("Credit Card Slip Number")]
    [IsoXmlTag("CdtCardSlipNb")]
    public IsoMax35Text? CreditCardSlipNumber { get; init; }

    /// <summary>
    /// Customer Reference.
    /// </summary>
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    public ValueList<CustomerReference1> CustomerReference { get; init; } = [];

    /// <summary>
    /// Data Source.
    /// </summary>
    [DisplayName("Data Source")]
    [IsoXmlTag("DataSrc")]
    public IsoMax35Text? DataSource { get; init; }

    /// <summary>
    /// Delivery Order Number.
    /// </summary>
    [DisplayName("Delivery Order Number")]
    [IsoXmlTag("DlvryOrdrNb")]
    public IsoMax35Text? DeliveryOrderNumber { get; init; }

    /// <summary>
    /// Fee.
    /// </summary>
    [DisplayName("Fee")]
    [IsoXmlTag("Fee")]
    public ImpliedCurrencyAndAmount? Fee { get; init; }

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Insurance Amount.
    /// </summary>
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Number In Party.
    /// </summary>
    [DisplayName("Number In Party")]
    [IsoXmlTag("NbInPty")]
    public IsoMax10NumericText? NumberInParty { get; init; }

    /// <summary>
    /// Reservation Number.
    /// </summary>
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    public IsoMax35Text? ReservationNumber { get; init; }

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax70Text? Type { get; init; }
}
