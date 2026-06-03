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
    [IsoId("_MM6cQUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public IsoMax70Text? CompanyName { get; init; }

    [IsoId("_IlQ3xEh6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Identification")]
    [IsoXmlTag("CpnyId")]
    public IsoMax35Text? CompanyIdentification { get; init; }

    [IsoId("_IlQ3xUh6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Business Name")]
    [IsoXmlTag("CpnyBizNm")]
    public IsoMax35Text? CompanyBusinessName { get; init; }

    [IsoId("_IlQ3xkh6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Legal Corporate Name")]
    [IsoXmlTag("CpnyLglCorpNm")]
    public IsoMax99Text? CompanyLegalCorporateName { get; init; }

    [IsoId("_MM6cRUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Address")]
    [IsoXmlTag("CpnyAdr")]
    public Address4? CompanyAddress { get; init; }

    [IsoId("_IlQ3x0h6EfCMZJtj4J7UGQ")]
    [DisplayName("Company Local Data")]
    [IsoXmlTag("CpnyLclData")]
    public ValueList<LocalData20> CompanyLocalData { get; init; } = [];

    [IsoId("_MM6cR0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Contact")]
    [IsoXmlTag("CpnyCtct")]
    public ContactBusiness2? CompanyContact { get; init; }

    [IsoId("_MM6cSUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Company Type")]
    [IsoXmlTag("CpnyTp")]
    public CarRentalActivity2Code? CompanyType { get; init; }

    [IsoId("_MM6cTUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Name")]
    [IsoXmlTag("RntrNm")]
    public required IsoMax105Text RenterName { get; init; }

    [IsoId("_MM6cT0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Corporate Name")]
    [IsoXmlTag("RntrCorpNm")]
    public IsoMax70Text? RenterCorporateName { get; init; }

    [IsoId("_MM6cUUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Corporate Identifier")]
    [IsoXmlTag("RntrCorpIdr")]
    public required IsoMax35Text RenterCorporateIdentifier { get; init; }

    [IsoId("_MM6cU0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Renter Corporate Identifier Assigner")]
    [IsoXmlTag("RntrCorpIdrAssgnr")]
    public CustomerAssigner1Code? RenterCorporateIdentifierAssigner { get; init; }

    [IsoId("_MM6cVUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Primary Driver")]
    [IsoXmlTag("PmryDrvr")]
    public DriverInParty4? PrimaryDriver { get; init; }

    [IsoId("_MM6cV0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Additional Driver")]
    [IsoXmlTag("AddtlDrvr")]
    public ValueList<DriverInParty4> AdditionalDriver { get; init; } = [];

    [IsoId("_MM6cWUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public ValueList<LoyaltyProgramme4> LoyaltyProgramme { get; init; } = [];

    [IsoId("_MM6cW0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    [IsoId("_sQu4-0h-EfCMZJtj4J7UGQ")]
    [DisplayName("No Show")]
    [IsoXmlTag("NoShow")]
    public IsoTrueFalseIndicator? NoShow { get; init; }

    [IsoId("_vZGYAUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Rental Agreement Number")]
    [IsoXmlTag("RntlAgrmtNb")]
    public IsoMax35Text? RentalAgreementNumber { get; init; }

    [IsoId("_HfRt0kh_EfCMZJtj4J7UGQ")]
    [DisplayName("Rental Location")]
    [IsoXmlTag("RntlLctn")]
    public Address4? RentalLocation { get; init; }

    [IsoId("_sQu4_Eh-EfCMZJtj4J7UGQ")]
    [DisplayName("Adjusted")]
    [IsoXmlTag("Adjstd")]
    public IsoTrueFalseIndicator? Adjusted { get; init; }

    [IsoId("_HfRt00h_EfCMZJtj4J7UGQ")]
    [DisplayName("Pickup Location")]
    [IsoXmlTag("PckpLctn")]
    public ValueList<Address4> PickupLocation { get; init; } = [];

    [IsoId("_sQu4_kh-EfCMZJtj4J7UGQ")]
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    public IsoISODate? CheckOutDate { get; init; }

    [IsoId("_sQu4_0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    public IsoISOTime? CheckOutTime { get; init; }

    [IsoId("_sQu4_Uh-EfCMZJtj4J7UGQ")]
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address4? ReturnLocation { get; init; }

    [IsoId("_sQu5AEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    public IsoISODate? CheckInDate { get; init; }

    [IsoId("_sQu5AUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    public IsoISOTime? CheckInTime { get; init; }

    [IsoId("_sQu5Akh-EfCMZJtj4J7UGQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    [IsoId("_sQu5A0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Class Invoiced")]
    [IsoXmlTag("ClssInvcd")]
    public IsoMax35Text? ClassInvoiced { get; init; }

    [IsoId("_sQu5BEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Make Invoiced")]
    [IsoXmlTag("MakeInvcd")]
    public IsoMax35NumericText? MakeInvoiced { get; init; }

    [IsoId("_sQu5BUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Model Invoiced")]
    [IsoXmlTag("MdlInvcd")]
    public IsoMax35NumericText? ModelInvoiced { get; init; }

    [IsoId("_sQu5Bkh-EfCMZJtj4J7UGQ")]
    [DisplayName("Registration Number Invoiced")]
    [IsoXmlTag("RegnNbInvcd")]
    public IsoMax35Text? RegistrationNumberInvoiced { get; init; }

    [IsoId("_sQu5B0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Class Provided")]
    [IsoXmlTag("ClssPrvdd")]
    public IsoMax35Text? ClassProvided { get; init; }

    [IsoId("_sQu5CEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Make Provided")]
    [IsoXmlTag("MakePrvdd")]
    public IsoMax35NumericText? MakeProvided { get; init; }

    [IsoId("_sQu5CUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Model Provided")]
    [IsoXmlTag("MdlPrvdd")]
    public IsoMax35NumericText? ModelProvided { get; init; }

    [IsoId("_sQu5Ckh-EfCMZJtj4J7UGQ")]
    [DisplayName("Registration Number Provided")]
    [IsoXmlTag("RegnNbPrvdd")]
    public IsoMax35Text? RegistrationNumberProvided { get; init; }

    [IsoId("_sQu5C0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Distance Unit")]
    [IsoXmlTag("DstncUnit")]
    public UnitOfMeasure10Code? DistanceUnit { get; init; }

    [IsoId("_sQu5DEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Odometer Start")]
    [IsoXmlTag("OdmtrStart")]
    public IsoMax10NumericText? OdometerStart { get; init; }

    [IsoId("_sQu5DUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Odometer Return")]
    [IsoXmlTag("OdmtrRtr")]
    public IsoMax10NumericText? OdometerReturn { get; init; }

    [IsoId("_sQu5Dkh-EfCMZJtj4J7UGQ")]
    [DisplayName("Total Distance")]
    [IsoXmlTag("TtlDstnc")]
    public IsoMax10NumericText? TotalDistance { get; init; }

    [IsoId("_sQu5D0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Free Distance")]
    [IsoXmlTag("FreeDstnc")]
    public IsoMax10NumericText? FreeDistance { get; init; }

    [IsoId("_sQu5EEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Distance Rate")]
    [IsoXmlTag("DstncRate")]
    public ImpliedCurrencyAndAmount? DistanceRate { get; init; }

    [IsoId("_sQu5EUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Rental Rate")]
    [IsoXmlTag("RntlRate")]
    public ValueList<RentalRate3> RentalRate { get; init; } = [];

    [IsoId("_sQu5E0h-EfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    [IsoId("_sQu5FEh-EfCMZJtj4J7UGQ")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<VehicleRentalAdditionalAmount1> AdditionalAmount { get; init; } = [];

    [IsoId("_sQu5FUh-EfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    [IsoId("_GAPeokhsEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_GAPeo0hsEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
