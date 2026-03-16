// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle Rental Invoice3.
/// </summary>
[IsoId("_D8WlsXToEe6h-4AZRg9sVg")]
[DisplayName("Vehicle Rental Invoice3")]
public record VehicleRentalInvoice3
{
    /// <summary>
    /// Additional Amount.
    /// </summary>
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<Amount21> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Adjusted.
    /// </summary>
    [DisplayName("Adjusted")]
    [IsoXmlTag("Adjstd")]
    public IsoTrueFalseIndicator? Adjusted { get; init; }

    /// <summary>
    /// Charge.
    /// </summary>
    [DisplayName("Charge")]
    [IsoXmlTag("Chrg")]
    public ValueList<RentalRate1> Charge { get; init; } = [];

    /// <summary>
    /// Check In Date.
    /// </summary>
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    public IsoISODate? CheckInDate { get; init; }

    /// <summary>
    /// Check In Time.
    /// </summary>
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    public IsoISOTime? CheckInTime { get; init; }

    /// <summary>
    /// Check Out Date.
    /// </summary>
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    public IsoISODate? CheckOutDate { get; init; }

    /// <summary>
    /// Check Out Time.
    /// </summary>
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    public IsoISOTime? CheckOutTime { get; init; }

    /// <summary>
    /// Class Invoiced.
    /// </summary>
    [DisplayName("Class Invoiced")]
    [IsoXmlTag("ClssInvcd")]
    public IsoMax35Text? ClassInvoiced { get; init; }

    /// <summary>
    /// Class Provided.
    /// </summary>
    [DisplayName("Class Provided")]
    [IsoXmlTag("ClssPrvdd")]
    public IsoMax35Text? ClassProvided { get; init; }

    /// <summary>
    /// Distance Rate.
    /// </summary>
    [DisplayName("Distance Rate")]
    [IsoXmlTag("DstncRate")]
    public ImpliedCurrencyAndAmount? DistanceRate { get; init; }

    /// <summary>
    /// Distance Unit.
    /// </summary>
    [DisplayName("Distance Unit")]
    [IsoXmlTag("DstncUnit")]
    public UnitOfMeasure10Code? DistanceUnit { get; init; }

    /// <summary>
    /// Duration.
    /// </summary>
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Free Distance.
    /// </summary>
    [DisplayName("Free Distance")]
    [IsoXmlTag("FreeDstnc")]
    public IsoMax10NumericText? FreeDistance { get; init; }

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Make Invoiced.
    /// </summary>
    [DisplayName("Make Invoiced")]
    [IsoXmlTag("MakeInvcd")]
    public IsoMax35NumericText? MakeInvoiced { get; init; }

    /// <summary>
    /// Make Provided.
    /// </summary>
    [DisplayName("Make Provided")]
    [IsoXmlTag("MakePrvdd")]
    public IsoMax35NumericText? MakeProvided { get; init; }

    /// <summary>
    /// Model Invoiced.
    /// </summary>
    [DisplayName("Model Invoiced")]
    [IsoXmlTag("MdlInvcd")]
    public IsoMax35NumericText? ModelInvoiced { get; init; }

    /// <summary>
    /// Model Provided.
    /// </summary>
    [DisplayName("Model Provided")]
    [IsoXmlTag("MdlPrvdd")]
    public IsoMax35NumericText? ModelProvided { get; init; }

    /// <summary>
    /// No Show.
    /// </summary>
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Odometer Return.
    /// </summary>
    [DisplayName("Odometer Return")]
    [IsoXmlTag("OdmtrRtr")]
    public IsoMax10NumericText? OdometerReturn { get; init; }

    /// <summary>
    /// Odometer Start.
    /// </summary>
    [DisplayName("Odometer Start")]
    [IsoXmlTag("OdmtrStart")]
    public IsoMax10NumericText? OdometerStart { get; init; }

    /// <summary>
    /// Registration Number Invoiced.
    /// </summary>
    [DisplayName("Registration Number Invoiced")]
    [IsoXmlTag("RegnNbInvcd")]
    public IsoMax35Text? RegistrationNumberInvoiced { get; init; }

    /// <summary>
    /// Registration Number Provided.
    /// </summary>
    [DisplayName("Registration Number Provided")]
    [IsoXmlTag("RegnNbPrvdd")]
    public IsoMax35Text? RegistrationNumberProvided { get; init; }

    /// <summary>
    /// Return Location.
    /// </summary>
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address2? ReturnLocation { get; init; }

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax41> Tax { get; init; } = [];

    /// <summary>
    /// Total Distance.
    /// </summary>
    [DisplayName("Total Distance")]
    [IsoXmlTag("TtlDstnc")]
    public IsoMax10NumericText? TotalDistance { get; init; }
}
