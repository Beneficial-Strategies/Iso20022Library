// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle rental service provides detailed vehicle rental information.
/// </summary>
[IsoId("_8BPF0ayeEeuupt0UCH5uiw")]
[DisplayName("Vehicle Rental Service")]
public record VehicleRentalService2
{
    /// <summary>
    /// Company in charge of a vehicle rental service.
    /// </summary>
    [IsoId("_8F2gEayeEeuupt0UCH5uiw")]
    [DisplayName("Vehicle Rental Company")]
    [IsoXmlTag("VhclRntlCpny")]
    public VehicleRentalCompany2? VehicleRentalCompany { get; init; }

    /// <summary>
    /// Customer renting a vehicle.
    /// </summary>
    [IsoId("_8F2gE6yeEeuupt0UCH5uiw")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public VehicleRentalCustomer2? Customer { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_8F2gFayeEeuupt0UCH5uiw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Agreement (contract) related to a vehicle rental service.
    /// </summary>
    [IsoId("_8F2gF6yeEeuupt0UCH5uiw")]
    [DisplayName("Rental Agreement")]
    [IsoXmlTag("RntlAgrmt")]
    public VehicleRentalAgreement2? RentalAgreement { get; init; }

    /// <summary>
    /// Invoice related to a vehicle rental service.
    /// </summary>
    [IsoId("_8F2gGayeEeuupt0UCH5uiw")]
    [DisplayName("Rental Invoice")]
    [IsoXmlTag("RntlInvc")]
    public VehicleRentalInvoice2? RentalInvoice { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the vehicle rental.
    /// </summary>
    [IsoId("_8F2gG6yeEeuupt0UCH5uiw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
