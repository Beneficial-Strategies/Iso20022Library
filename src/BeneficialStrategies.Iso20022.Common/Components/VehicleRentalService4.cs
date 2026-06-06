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
[IsoId("_MKCHYUhsEfCMZJtj4J7UGQ")]
[DisplayName("Vehicle Rental Service4")]
public record VehicleRentalService4
{
    /// <summary>
    /// Name of the vehicle rental company.
    /// </summary>
    [IsoId("_MM6cQUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public IsoMax70Text? CompanyName { get; init; }

    /// <summary>
    /// Identification of the vehicle rental company.
    /// </summary>
    [IsoId("_IlQ3xEh6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Identification")]
    [IsoXmlTag("CpnyId")]
    public IsoMax35Text? CompanyIdentification { get; init; }

    /// <summary>
    /// Business name of the vehicle rental company.
    /// </summary>
    [IsoId("_IlQ3xUh6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Business Name")]
    [IsoXmlTag("CpnyBizNm")]
    public IsoMax35Text? CompanyBusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the vehicle rental company.
    /// </summary>
    [IsoId("_IlQ3xkh6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Legal Corporate Name")]
    [IsoXmlTag("CpnyLglCorpNm")]
    public IsoMax99Text? CompanyLegalCorporateName { get; init; }

    /// <summary>
    /// Address of the vehicle rental company.
    /// </summary>
    [IsoId("_MM6cRUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Address")]
    [IsoXmlTag("CpnyAdr")]
    public Address4? CompanyAddress { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of the vehicle rental company data.
    /// </summary>
    [IsoId("_IlQ3x0h6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Local Data")]
    [IsoXmlTag("CpnyLclData")]
    public ValueList<LocalData20> CompanyLocalData { get; init; } = [];

    /// <summary>
    /// Contact details at vehicle rental company location.
    /// </summary>
    [IsoId("_MM6cR0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Contact")]
    [IsoXmlTag("CpnyCtct")]
    public ContactBusiness2? CompanyContact { get; init; }

    /// <summary>
    /// Type of vehicle rental activity.
    /// </summary>
    [IsoId("_MM6cSUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Type")]
    [IsoXmlTag("CpnyTp")]
    public CarRentalActivity2Code? CompanyType { get; init; }

    /// <summary>
    /// Name of the vehicle rental customer.
    /// </summary>
    [IsoId("_MM6cTUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Name")]
    [IsoXmlTag("RntrNm")]
    public required IsoMax105Text RenterName { get; init; }

    /// <summary>
    /// Corporate name of the vehicle rental customer.
    /// </summary>
    [IsoId("_MM6cT0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Corporate Name")]
    [IsoXmlTag("RntrCorpNm")]
    public IsoMax70Text? RenterCorporateName { get; init; }

    /// <summary>
    /// Corporate identifier of the vehicle rental customer.
    /// </summary>
    [IsoId("_MM6cUUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Corporate Identifier")]
    [IsoXmlTag("RntrCorpIdr")]
    public required IsoMax35Text RenterCorporateIdentifier { get; init; }

    /// <summary>
    /// Party assigning an identification to a vehicle rental customer.
    /// </summary>
    [IsoId("_MM6cU0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Corporate Identifier Assigner")]
    [IsoXmlTag("RntrCorpIdrAssgnr")]
    public CustomerAssigner1Code? RenterCorporateIdentifierAssigner { get; init; }

    /// <summary>
    /// Vehicle rental driver.
    /// </summary>
    [IsoId("_MM6cVUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Primary Driver")]
    [IsoXmlTag("PmryDrvr")]
    public DriverInParty4? PrimaryDriver { get; init; }

    /// <summary>
    /// Type of identification of the additional vehicle rental customer.
    /// </summary>
    [IsoId("_MM6cV0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Additional Driver")]
    [IsoXmlTag("AddtlDrvr")]
    public ValueList<DriverInParty4> AdditionalDriver { get; init; } = [];

    /// <summary>
    /// Loyalty programme of car rental applied.
    /// </summary>
    [IsoId("_MM6cWUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public ValueList<LoyaltyProgramme4> LoyaltyProgramme { get; init; } = [];

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_MM6cW0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to pick up the vehicle and was therefore charged a no-show fee; vehicle was not actually rented. 
    /// </summary>
    [IsoId("_sQu4-0h-EfCMZJtj4J7UGQ")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    /// <summary>
    /// Contains the original vehicle rental agreement, invoice or contract number.
    /// </summary>
    [IsoId("_vZGYAUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Rental Agreement Number")]
    [IsoXmlTag("RntlAgrmtNb")]
    public IsoMax35Text? RentalAgreementNumber { get; init; }

    /// <summary>
    /// Contains the vehicle rental location. 
    /// </summary>
    [IsoId("_HfRt0kh_EfCMZJtj4J7UGQ")]
    [DisplayName("Rental Location")]
    [IsoXmlTag("RntlLctn")]
    public Address4? RentalLocation { get; init; }

    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added). 
    /// </summary>
    [IsoId("_sQu4_Eh-EfCMZJtj4J7UGQ")]
    [DisplayName("Adjusted")]
    [IsoXmlTag("Adjstd")]
    public IsoTrueFalseIndicator? Adjusted { get; init; }

    /// <summary>
    /// Used when different than rental location
    /// </summary>
    [IsoId("_HfRt00h_EfCMZJtj4J7UGQ")]
    [DisplayName("Pickup Location")]
    [IsoXmlTag("PckpLctn")]
    public ValueList<Address4> PickupLocation { get; init; } = [];

    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_sQu4_kh-EfCMZJtj4J7UGQ")]
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    public IsoISODate? CheckOutDate { get; init; }

    /// <summary>
    /// Time the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup time.
    /// </summary>
    [IsoId("_sQu4_0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    public IsoISOTime? CheckOutTime { get; init; }

    /// <summary>
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_sQu4_Uh-EfCMZJtj4J7UGQ")]
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address4? ReturnLocation { get; init; }

    /// <summary>
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_sQu5AEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    public IsoISODate? CheckInDate { get; init; }

    /// <summary>
    /// Time when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_sQu5AUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    public IsoISOTime? CheckInTime { get; init; }

    /// <summary>
    /// Duration of rental in days.
    /// </summary>
    [IsoId("_sQu5Akh-EfCMZJtj4J7UGQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Contains the classification of the vehicle (for example, economy, intermediate, luxury, etc.) on invoice
    /// </summary>
    [IsoId("_sQu5A0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Class Invoiced")]
    [IsoXmlTag("ClssInvcd")]
    public IsoMax35Text? ClassInvoiced { get; init; }

    /// <summary>
    /// Brand or manufacturer of the vehicle on invoice.
    /// </summary>
    [IsoId("_sQu5BEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Make Invoiced")]
    [IsoXmlTag("MakeInvcd")]
    public IsoMax35NumericText? MakeInvoiced { get; init; }

    /// <summary>
    /// Product line of vehicle within the make on invoice.
    /// </summary>
    [IsoId("_sQu5BUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Model Invoiced")]
    [IsoXmlTag("MdlInvcd")]
    public IsoMax35NumericText? ModelInvoiced { get; init; }

    /// <summary>
    /// Registration number of vehicle on invoice.
    /// </summary>
    [IsoId("_sQu5Bkh-EfCMZJtj4J7UGQ")]
    [DisplayName("Registration Number Invoiced")]
    [IsoXmlTag("RegnNbInvcd")]
    public IsoMax35Text? RegistrationNumberInvoiced { get; init; }

    /// <summary>
    /// Contains the classification of the provide vehicle (for example, economy, intermediate, luxury, etc.)
    /// </summary>
    [IsoId("_sQu5B0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Class Provided")]
    [IsoXmlTag("ClssPrvdd")]
    public IsoMax35Text? ClassProvided { get; init; }

    /// <summary>
    /// Brand or manufacturer of the provided vehicle.
    /// </summary>
    [IsoId("_sQu5CEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Make Provided")]
    [IsoXmlTag("MakePrvdd")]
    public IsoMax35NumericText? MakeProvided { get; init; }

    /// <summary>
    /// Product line of provided vehicle within the make. 
    /// </summary>
    [IsoId("_sQu5CUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Model Provided")]
    [IsoXmlTag("MdlPrvdd")]
    public IsoMax35NumericText? ModelProvided { get; init; }

    /// <summary>
    /// Registration number of the provided vehicle.
    /// </summary>
    [IsoId("_sQu5Ckh-EfCMZJtj4J7UGQ")]
    [DisplayName("Registration Number Provided")]
    [IsoXmlTag("RegnNbPrvdd")]
    public IsoMax35Text? RegistrationNumberProvided { get; init; }

    /// <summary>
    /// Unit of measure used to compute the distance.
    /// </summary>
    [IsoId("_sQu5C0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Distance Unit")]
    [IsoXmlTag("DstncUnit")]
    public UnitOfMeasure10Code? DistanceUnit { get; init; }

    /// <summary>
    /// Odometer reading at start of rental (at the time of vehicle check-out). 
    /// </summary>
    [IsoId("_sQu5DEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Odometer Start")]
    [IsoXmlTag("OdmtrStart")]
    public IsoMax10NumericText? OdometerStart { get; init; }

    /// <summary>
    /// Odometer reading at return of rental (at the time of vehicle check-in). 
    /// </summary>
    [IsoId("_sQu5DUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Odometer Return")]
    [IsoXmlTag("OdmtrRtr")]
    public IsoMax10NumericText? OdometerReturn { get; init; }

    /// <summary>
    /// Total distance expressed in unit of measure.
    /// </summary>
    [IsoId("_sQu5Dkh-EfCMZJtj4J7UGQ")]
    [DisplayName("Total Distance")]
    [IsoXmlTag("TtlDstnc")]
    public IsoMax10NumericText? TotalDistance { get; init; }

    /// <summary>
    /// Maximum free miles or kilometres for the car rental period.
    /// </summary>
    [IsoId("_sQu5D0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Free Distance")]
    [IsoXmlTag("FreeDstnc")]
    public IsoMax10NumericText? FreeDistance { get; init; }

    /// <summary>
    /// Defines the rate in relation to a specific distance. 
    /// </summary>
    [IsoId("_sQu5EEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Distance Rate")]
    [IsoXmlTag("DstncRate")]
    public ImpliedCurrencyAndAmount? DistanceRate { get; init; }

    /// <summary>
    /// Vehicle rental rate.
    /// </summary>
    [IsoId("_sQu5EUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Rental Rate")]
    [IsoXmlTag("RntlRate")]
    public ValueList<RentalRate3> RentalRate { get; init; } = [];

    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_sQu5E0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Contains the details of additional amount for a specific vehicle rental service type. 
    /// </summary>
    [IsoId("_sQu5FEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<VehicleRentalAdditionalAmount1> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_sQu5FUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_GAPeokhsEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_GAPeo0hsEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
