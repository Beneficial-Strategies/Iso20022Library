// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation reason sub type, as published in an external investigation reason code sub type set.
/// </summary>
/// <remarks>
/// The list of valid codes is an external code set published separately.
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("__DHuwFEUEe2YkcF60skG_A")]
[Description(@"Specifies the investigation reason sub type, as published in an external investigation reason code sub type set.|The list of valid codes is an external code set published separately.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationReasonSubType1Code>))]
public readonly struct ExternalInvestigationReasonSubType1Code : IIsoExternalCode, IEquatable<ExternalInvestigationReasonSubType1Code>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation reason sub type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationReasonSubType1Code(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationReasonSubType1Code), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationReasonSubType1Code result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationReasonSubType1Code"/>.</summary>
    public static implicit operator ExternalInvestigationReasonSubType1Code(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationReasonSubType1Code code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationReasonSubType1Code other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationReasonSubType1Code other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReasonSubType1Code a, ExternalInvestigationReasonSubType1Code b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReasonSubType1Code a, ExternalInvestigationReasonSubType1Code b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReasonSubType1Code a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReasonSubType1Code a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationReasonSubType1Code b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationReasonSubType1Code b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Alien Registration Number is requested.</summary>
    [IsoId("___asVdYUEe68t8Cw380-tA")]
    [Description(@"Alien Registration Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestAlienRegistrationNumber = new("ARNU");

    /// <summary>Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.</summary>
    [IsoId("___asZ9YUEe68t8Cw380-tA")]
    [Description(@"Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestBankPartyIdentification = new("BANK");

    /// <summary>Identifier of the business domain in which the organisation is active is requested.</summary>
    [IsoId("___ase9YUEe68t8Cw380-tA")]
    [Description(@"Identifier of the business domain in which the organisation is active is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestBusinessDomainIdentifier = new("BDID");

    /// <summary>Other identification of the organisation is requested.</summary>
    [IsoId("___asfdYUEe68t8Cw380-tA")]
    [Description(@"Other identification of the organisation is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestBusinessOtherIdentification = new("BOID");

    /// <summary>Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.</summary>
    [IsoId("___asadYUEe68t8Cw380-tA")]
    [Description(@"Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCentralBankIdentificationNumber = new("CBID");

    /// <summary>Passport Number is requested.</summary>
    [IsoId("___asV9YUEe68t8Cw380-tA")]
    [Description(@"Passport Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPassportNumber = new("CCPT");

    /// <summary>Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation</summary>
    [IsoId("___asa9YUEe68t8Cw380-tA")]
    [Description(@"Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestClearingIdentificationNumber = new("CHID");

    /// <summary>Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.</summary>
    [IsoId("___asbdYUEe68t8Cw380-tA")]
    [Description(@"Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCertificateOfIncorporationNumber = new("CINC");

    /// <summary>Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number)</summary>
    [IsoId("___asb9YUEe68t8Cw380-tA")]
    [Description(@"Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number)")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCountryIdentificationCode = new("COID");

    /// <summary>Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.</summary>
    [IsoId("___ascdYUEe68t8Cw380-tA")]
    [Description(@"Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCustomerNumber = new("CUST");

    /// <summary>Drivers License Number is requested.</summary>
    [IsoId("___asWdYUEe68t8Cw380-tA")]
    [Description(@"Drivers License Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDriversLicenseNumber = new("DRLC");

    /// <summary>Data universal number is requested. This is a unique identification number provided by Dun &amp; Bradstreet to identify an organisation.</summary>
    [IsoId("___asc9YUEe68t8Cw380-tA")]
    [Description(@"Data universal number is requested. This is a unique identification number provided by Dun & Bradstreet to identify an organisation.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDataUniversalNumberingSystem = new("DUNS");

    /// <summary>Employee Identification Number is requested.</summary>
    [IsoId("___asW9YUEe68t8Cw380-tA")]
    [Description(@"Employee Identification Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestEmployeeIdentificationNumber = new("EMPL");

    /// <summary>GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules.The number is used to retrieve detailed information that is linked to it.</summary>
    [IsoId("___asddYUEe68t8Cw380-tA")]
    [Description(@"GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules.The number is used to retrieve detailed information that is linked to it.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestGS1GLNIdentifier = new("GS1G");

    /// <summary>Information is incomplete.</summary>
    [IsoId("_fI_MQsnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is incomplete.")]
    public static readonly ExternalInvestigationReasonSubType1Code Incomplete = new("ICOM");

    /// <summary>Information is invalid.</summary>
    [IsoId("_ZhRV0snzEfCY0M4eFzOwyQ")]
    [Description(@"Information is invalid.")]
    public static readonly ExternalInvestigationReasonSubType1Code Invalid = new("INVA");

    /// <summary>Information is missing.</summary>
    [IsoId("_Ss--ksnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is missing.")]
    public static readonly ExternalInvestigationReasonSubType1Code Missing = new("MISS");

    /// <summary>Name and account are not matching.</summary>
    [IsoId("___asH9YUEe68t8Cw380-tA")]
    [Description(@"Name and account are not matching.")]
    public static readonly ExternalInvestigationReasonSubType1Code MismatchNameAndAccount = new("MMNA");

    /// <summary>National Identity Number is requested.</summary>
    [IsoId("___asXdYUEe68t8Cw380-tA")]
    [Description(@"National Identity Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestNationalIdentityNumber = new("NIDN");

    /// <summary>Person Commercial Identification is requested.</summary>
    [IsoId("___asZdYUEe68t8Cw380-tA")]
    [Description(@"Person Commercial Identification is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPersonCommercialIdentification = new("POID");

    /// <summary>Countries of all business/operations locations are requested.</summary>
    [IsoId("___asj9YUEe68t8Cw380-tA")]
    [Description(@"Countries of all business/operations locations are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCountriesofAllBusinessLocations = new("RCBL");

    /// <summary>Country of origination is requested.</summary>
    [IsoId("___ass9YUEe68t8Cw380-tA")]
    [Description(@"Country of origination is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCountryOfOrigination = new("RCOO");

    /// <summary>Incorporation country/country of registration is requested.</summary>
    [IsoId("___asjdYUEe68t8Cw380-tA")]
    [Description(@"Incorporation country/country of registration is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestIncorporationCountry = new("RICC");

    /// <summary>Incorporation date is requested.</summary>
    [IsoId("___asi9YUEe68t8Cw380-tA")]
    [Description(@"Incorporation date is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestIncorporationDate = new("RICD");

    /// <summary>Ports of call are requested.</summary>
    [IsoId("___asu9YUEe68t8Cw380-tA")]
    [Description(@"Ports of call are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPortsOfCall = new("RPOC");

    /// <summary>Airway bill is requested.</summary>
    [IsoId("___asrdYUEe68t8Cw380-tA")]
    [Description(@"Airway bill is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestAirwayBill = new("RQAB");

    /// <summary>Account is requested.</summary>
    [IsoId("___asIdYUEe68t8Cw380-tA")]
    [Description(@"Account is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestAccount = new("RQAC");

    /// <summary>Postal address line is requested.</summary>
    [IsoId("___asT9YUEe68t8Cw380-tA")]
    [Description(@"Postal address line is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressLine = new("RQAL");

    /// <summary>Postal address sub department is requested.</summary>
    [IsoId("___asNdYUEe68t8Cw380-tA")]
    [Description(@"Postal address sub department is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressSubDepartment = new("RQAS");

    /// <summary>Postal address type is requested.</summary>
    [IsoId("___asMdYUEe68t8Cw380-tA")]
    [Description(@"Postal address type is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressType = new("RQAT");

    /// <summary>Postal address building number is requested.</summary>
    [IsoId("___asOdYUEe68t8Cw380-tA")]
    [Description(@"Postal address building number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressBuildingNumber = new("RQB1");

    /// <summary>Bill of lading is requested.</summary>
    [IsoId("___aspdYUEe68t8Cw380-tA")]
    [Description(@"Bill of lading is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestBillOfLading = new("RQBL");

    /// <summary>Postal address building name is requested.</summary>
    [IsoId("___asO9YUEe68t8Cw380-tA")]
    [Description(@"Postal address building name is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressBuildingName = new("RQBN");

    /// <summary>Business website requested.</summary>
    [IsoId("_tz4v4cnyEfCY0M4eFzOwyQ")]
    [Description(@"Business website requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestBusinessWebsite = new("RQBW");

    /// <summary>City of birth is requested.</summary>
    [IsoId("___asK9YUEe68t8Cw380-tA")]
    [Description(@"City of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCityOfBirth = new("RQCB");

    /// <summary>Postal address country is requested.</summary>
    [IsoId("___asTdYUEe68t8Cw380-tA")]
    [Description(@"Postal address country is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressCountry = new("RQCC");

    /// <summary>Customs declaration is requested.</summary>
    [IsoId("___asp9YUEe68t8Cw380-tA")]
    [Description(@"Customs declaration is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCustomsDeclaration = new("RQCD");

    /// <summary>Details of all countries involved in the transaction are requested.</summary>
    [IsoId("___asldYUEe68t8Cw380-tA")]
    [Description(@"Details of all countries involved in the transaction are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCountriesInvolvedInTransaction = new("RQCI");

    /// <summary>Confirmation of whether transaction is civil or military in nature is requested.</summary>
    [IsoId("___asvdYUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether transaction is civil or military in nature is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestIfPaymentCivilOrMilitaryInNature = new("RQCM");

    /// <summary>Country of birth is requested.</summary>
    [IsoId("___asL9YUEe68t8Cw380-tA")]
    [Description(@"Country of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCountryOfBirth = new("RQCO");

    /// <summary>Postal address country sub division is requested.</summary>
    [IsoId("___asS9YUEe68t8Cw380-tA")]
    [Description(@"Postal address country sub division is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressCountrySubDivision = new("RQCS");

    /// <summary>Countries of transit between the debtor and creditor are requested.</summary>
    [IsoId("___ast9YUEe68t8Cw380-tA")]
    [Description(@"Countries of transit between the debtor and creditor are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCountriesOfTransitBetweenDebtorAndCreditorInTransaction = new("RQCT");

    /// <summary>Citizenship is requested.</summary>
    [IsoId("___asg9YUEe68t8Cw380-tA")]
    [Description(@"Citizenship is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestCitizenship = new("RQCZ");

    /// <summary>Date of birth is requested.</summary>
    [IsoId("___asKdYUEe68t8Cw380-tA")]
    [Description(@"Date of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDateOfBirth = new("RQDB");

    /// <summary>Postal address department is requested.</summary>
    [IsoId("___asM9YUEe68t8Cw380-tA")]
    [Description(@"Postal address department is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressDepartment = new("RQDE");

    /// <summary>Details of goods are requested.</summary>
    [IsoId("___asmdYUEe68t8Cw380-tA")]
    [Description(@"Details of goods are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDetailsOfGoods = new("RQDG");

    /// <summary>Postal address district name is requested.</summary>
    [IsoId("___asSdYUEe68t8Cw380-tA")]
    [Description(@"Postal address district name is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressDistrictName = new("RQDN");

    /// <summary>Detailed purpose of payment requested.</summary>
    [IsoId("_Ie0W4snyEfCY0M4eFzOwyQ")]
    [Description(@"Detailed purpose of payment requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDetailedPurposeOfPayment = new("RQDP");

    /// <summary>Details of services are requested.</summary>
    [IsoId("___asl9YUEe68t8Cw380-tA")]
    [Description(@"Details of services are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDetailsOfServices = new("RQDS");

    /// <summary>Dates of voyage for goods or services are requested.</summary>
    [IsoId("___asudYUEe68t8Cw380-tA")]
    [Description(@"Dates of voyage for goods or services are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDatesOfVoyageForGoodServicesReferenceInTransaction = new("RQDV");

    /// <summary>Postal address floor is requested.</summary>
    [IsoId("___asPdYUEe68t8Cw380-tA")]
    [Description(@"Postal address floor is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressFloor = new("RQFL");

    /// <summary>Date upon which goods officially change ownership is requested.</summary>
    [IsoId("___asodYUEe68t8Cw380-tA")]
    [Description(@"Date upon which goods officially change ownership is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestGoodsDate = new("RQGD");

    /// <summary>Final destination of goods is requested.</summary>
    [IsoId("___asndYUEe68t8Cw380-tA")]
    [Description(@"Final destination of goods is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestGoodsFinalDestination = new("RQGF");

    /// <summary>General license copy is requested.</summary>
    [IsoId("___asx9YUEe68t8Cw380-tA")]
    [Description(@"General license copy is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestGeneralLicenseCopy = new("RQGL");

    /// <summary>HS code of goods is requested.</summary>
    [IsoId("___asq9YUEe68t8Cw380-tA")]
    [Description(@"HS code of goods is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestHSCodesOfGoodsProvided = new("RQHS");

    /// <summary>Confirmation of whether charitable sector is involved with transaction is requested.</summary>
    [IsoId("___asw9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether charitable sector is involved with transaction is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestIfInvolvementOfCharitySector = new("RQIC");

    /// <summary>Industry is requested.</summary>
    [IsoId("___asidYUEe68t8Cw380-tA")]
    [Description(@"Industry is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestIndustry = new("RQID");

    /// <summary>Vessel IMO is requested.</summary>
    [IsoId("___asr9YUEe68t8Cw380-tA")]
    [Description(@"Vessel IMO is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestIMOVesselInvolved = new("RQIM");

    /// <summary>Copy of invoice is requested.</summary>
    [IsoId("___asJdYUEe68t8Cw380-tA")]
    [Description(@"Copy of invoice is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestInvoiceCopy = new("RQIN");

    /// <summary>Kimberley certification is requested.</summary>
    [IsoId("___asxdYUEe68t8Cw380-tA")]
    [Description(@"Kimberley certification is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestKimberleyCertification = new("RQKC");

    /// <summary>Line of business is requested.</summary>
    [IsoId("___askdYUEe68t8Cw380-tA")]
    [Description(@"Line of business is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestLineOfBusiness = new("RQLB");

    /// <summary>Legal entity identifier is requested.</summary>
    [IsoId("___asf9YUEe68t8Cw380-tA")]
    [Description(@"Legal entity identifier is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestLEI = new("RQLE");

    /// <summary>Licence applicable or required for payment is requested.</summary>
    [IsoId("___aswdYUEe68t8Cw380-tA")]
    [Description(@"Licence applicable or required for payment is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestIfLicenceApplicableOrRequiredForPayment = new("RQLP");

    /// <summary>Location of where services are carried out is requested.</summary>
    [IsoId("___asm9YUEe68t8Cw380-tA")]
    [Description(@"Location of where services are carried out is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestServicesLocation = new("RQLS");

    /// <summary>Nationality is requested.</summary>
    [IsoId("___asgdYUEe68t8Cw380-tA")]
    [Description(@"Nationality is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestNationality = new("RQNA");

    /// <summary>Full name is requested.</summary>
    [IsoId("___asU9YUEe68t8Cw380-tA")]
    [Description(@"Full name is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestFullName = new("RQNM");

    /// <summary>Occupation is requested.</summary>
    [IsoId("___ash9YUEe68t8Cw380-tA")]
    [Description(@"Occupation is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestOccupation = new("RQOC");

    /// <summary>Origin of goods requested.</summary>
    [IsoId("_5_ZDcsnyEfCY0M4eFzOwyQ")]
    [Description(@"Origin of goods requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestOriginOfGoods = new("RQOG");

    /// <summary>Location of any onward trade of goods or services is requested.</summary>
    [IsoId("___ask9YUEe68t8Cw380-tA")]
    [Description(@"Location of any onward trade of goods or services is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestLocationOfAnyOnwardTradeOfGoodsOrServices = new("RQON");

    /// <summary>Confirmation of ownership is requested.</summary>
    [IsoId("___asJ9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of ownership is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestOwnershipConfirmation = new("RQOW");

    /// <summary>Full postal address is requested.</summary>
    [IsoId("___asUdYUEe68t8Cw380-tA")]
    [Description(@"Full postal address is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestFullPostalAddress = new("RQPA");

    /// <summary>Postal address post box is requested.</summary>
    [IsoId("___asP9YUEe68t8Cw380-tA")]
    [Description(@"Postal address post box is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressPostBox = new("RQPB");

    /// <summary>Postal address post code is requested.</summary>
    [IsoId("___asQ9YUEe68t8Cw380-tA")]
    [Description(@"Postal address post code is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressPostCode = new("RQPC");

    /// <summary>Province of birth is requested.</summary>
    [IsoId("___asLdYUEe68t8Cw380-tA")]
    [Description(@"Province of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestProvinceOfBirth = new("RQPO");

    /// <summary>Copy of passport is requested.</summary>
    [IsoId("___asI9YUEe68t8Cw380-tA")]
    [Description(@"Copy of passport is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPassportCopy = new("RQPP");

    /// <summary>Relationship between Debtor and Creditor is requested.</summary>
    [IsoId("___ashdYUEe68t8Cw380-tA")]
    [Description(@"Relationship between Debtor and Creditor is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestDebtorAndCreditorRelationship = new("RQRE");

    /// <summary>Postal address room is requested.</summary>
    [IsoId("___asQdYUEe68t8Cw380-tA")]
    [Description(@"Postal address room is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressRoom = new("RQRO");

    /// <summary>Date upon which services are carried out is requested.</summary>
    [IsoId("___asn9YUEe68t8Cw380-tA")]
    [Description(@"Date upon which services are carried out is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestServicesDate = new("RQSD");

    /// <summary>Specific license copy is requested.</summary>
    [IsoId("___asydYUEe68t8Cw380-tA")]
    [Description(@"Specific license copy is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestSpecificLicenseCopy = new("RQSL");

    /// <summary>Postal address street name is requested.</summary>
    [IsoId("___asN9YUEe68t8Cw380-tA")]
    [Description(@"Postal address street name is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressStreetName = new("RQSN");

    /// <summary>Aircraft tail number is requested.</summary>
    [IsoId("___assdYUEe68t8Cw380-tA")]
    [Description(@"Aircraft tail number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestTailNumberAircraftInvolved = new("RQTA");

    /// <summary>Transport documentation is requested.</summary>
    [IsoId("___asqdYUEe68t8Cw380-tA")]
    [Description(@"Transport documentation is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestTransportDocumentation = new("RQTD");

    /// <summary>Postal address town location name is requested.</summary>
    [IsoId("___asR9YUEe68t8Cw380-tA")]
    [Description(@"Postal address town location name is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressTownLocationName = new("RQTL");

    /// <summary>Postal address town name is requested.</summary>
    [IsoId("___asRdYUEe68t8Cw380-tA")]
    [Description(@"Postal address town name is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestPostalAddressTownName = new("RQTN");

    /// <summary>Underlying owner is requested.</summary>
    [IsoId("___astdYUEe68t8Cw380-tA")]
    [Description(@"Underlying owner is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestUnderlyingOwner = new("RQUO");

    /// <summary>Ultimate parties and source of funds are requested.</summary>
    [IsoId("___asv9YUEe68t8Cw380-tA")]
    [Description(@"Ultimate parties and source of funds are requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestUltimatePartiesInvolvedIncludingSourceOfFunds = new("RQUP");

    /// <summary>Confirmation of whether US is nexus to transaction is requested.</summary>
    [IsoId("___aso9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether US is nexus to transaction is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestUSNexusStatus = new("RQUS");

    /// <summary>Final user and usage of goods or services requested.</summary>
    [IsoId("_L3MygcnzEfCY0M4eFzOwyQ")]
    [Description(@"Final user and usage of goods or services requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestFinalUserAndUsageOfGoodsOrServices = new("RQUU");

    /// <summary>Social Security Number is requested.</summary>
    [IsoId("___asX9YUEe68t8Cw380-tA")]
    [Description(@"Social Security Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestSocialSecurityNumber = new("SOSE");

    /// <summary>SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.</summary>
    [IsoId("___asd9YUEe68t8Cw380-tA")]
    [Description(@"SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestSIREN = new("SREN");

    /// <summary>SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity</summary>
    [IsoId("___asedYUEe68t8Cw380-tA")]
    [Description(@"SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestSIRET = new("SRET");

    /// <summary>Telephone Number is requested.</summary>
    [IsoId("___asYdYUEe68t8Cw380-tA")]
    [Description(@"Telephone Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestTelephoneNumber = new("TELE");

    /// <summary>Tax Identification Number is requested.</summary>
    [IsoId("___asY9YUEe68t8Cw380-tA")]
    [Description(@"Tax Identification Number is requested.")]
    public static readonly ExternalInvestigationReasonSubType1Code RequestTaxIdentificationNumber = new("TXID");
}
