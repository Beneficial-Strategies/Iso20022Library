// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation reason sub type, as published in an external investigation reason sub type code set.
/// </summary>
/// <remarks>
/// External code sets can be downloaded from www.iso20022.org.
/// </remarks>
[DataContract]
[Serializable]
[IsoId("_i8TyUElDEe2sNe7Wx9q_CQ")]
[Description(@"Specifies the investigation reason sub type, as published in an external investigation reason sub type code set.|External code sets can be downloaded from www.iso20022.org.")]
[JsonConverter(typeof(Iso20022ExternalCodeJsonConverter<ExternalInvestigationReasonSubTypeCode>))]
public readonly struct ExternalInvestigationReasonSubTypeCode : IIsoExternalCode, IEquatable<ExternalInvestigationReasonSubTypeCode>
{
    /// <summary>ISO 20022 format constraint — 1 to 4 characters.</summary>
    public const string Pattern = @"^.{1,4}$";

    /// <inheritdoc/>
    public string Value { get; }

    /// <summary>Initializes a new instance with the given investigation reason sub type code.</summary>
    /// <exception cref="Iso20022FormatException">Thrown when <paramref name="value"/> does not satisfy <see cref="Pattern"/>.</exception>
    public ExternalInvestigationReasonSubTypeCode(string value)
    {
        if (!Regex.IsMatch(value, Pattern))
            throw new Iso20022FormatException(typeof(ExternalInvestigationReasonSubTypeCode), value, Pattern);
        Value = value;
    }

    /// <summary>Returns <see langword="true"/> and a valid instance when <paramref name="value"/> satisfies <see cref="Pattern"/>; otherwise <see langword="false"/>.</summary>
    public static bool TryCreate(string value, [NotNullWhen(true)] out ExternalInvestigationReasonSubTypeCode result)
    {
        if (Regex.IsMatch(value, Pattern))
        { result = new(value); return true; }
        result = default;
        return false;
    }

    /// <summary>Implicitly wraps a string as a <see cref="ExternalInvestigationReasonSubTypeCode"/>.</summary>
    public static implicit operator ExternalInvestigationReasonSubTypeCode(string value) => new(value);
    /// <summary>Implicitly unwraps the code to its string value.</summary>
    public static implicit operator string(ExternalInvestigationReasonSubTypeCode code) => code.Value;

    /// <inheritdoc/>
    public override string ToString() => Value ?? string.Empty;
    /// <inheritdoc/>
    public bool Equals(ExternalInvestigationReasonSubTypeCode other) => Value == other.Value;
    /// <inheritdoc/>
    public override bool Equals(object? obj) => obj is ExternalInvestigationReasonSubTypeCode other && Equals(other);
    /// <inheritdoc/>
    public override int GetHashCode() => Value?.GetHashCode() ?? 0;

    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReasonSubTypeCode a, ExternalInvestigationReasonSubTypeCode b) => a.Equals(b);
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReasonSubTypeCode a, ExternalInvestigationReasonSubTypeCode b) => !a.Equals(b);
    /// <inheritdoc/>
    public static bool operator ==(ExternalInvestigationReasonSubTypeCode a, string? b) => a.Value == b;
    /// <inheritdoc/>
    public static bool operator !=(ExternalInvestigationReasonSubTypeCode a, string? b) => a.Value != b;
    /// <inheritdoc/>
    public static bool operator ==(string? a, ExternalInvestigationReasonSubTypeCode b) => a == b.Value;
    /// <inheritdoc/>
    public static bool operator !=(string? a, ExternalInvestigationReasonSubTypeCode b) => a != b.Value;

    // ── Known values (per ISO 20022 external registry snapshot, via MCP get_code_set_details) ──
    // Convenience only — the constructor above still accepts any value satisfying Pattern,
    // including future registry additions not listed here.

    /// <summary>Alien Registration Number is requested.</summary>
    [IsoId("__-hUL9YUEe68t8Cw380-tA")]
    [Description(@"Alien Registration Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestAlienRegistrationNumber = new("ARNU");

    /// <summary>Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.</summary>
    [IsoId("__-hUONYUEe68t8Cw380-tA")]
    [Description(@"Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestBankPartyIdentification = new("BANK");

    /// <summary>Identifier of the business domain in which the organisation is active is requested.</summary>
    [IsoId("__-hUQtYUEe68t8Cw380-tA")]
    [Description(@"Identifier of the business domain in which the organisation is active is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestBusinessDomainIdentifier = new("BDID");

    /// <summary>Other identification of the organisation is requested.</summary>
    [IsoId("__-hUQ9YUEe68t8Cw380-tA")]
    [Description(@"Other identification of the organisation is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestBusinessOtherIdentification = new("BOID");

    /// <summary>Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.</summary>
    [IsoId("__-hUOdYUEe68t8Cw380-tA")]
    [Description(@"Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCentralBankIdentificationNumber = new("CBID");

    /// <summary>Passport Number is requested.</summary>
    [IsoId("__-hUMNYUEe68t8Cw380-tA")]
    [Description(@"Passport Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPassportNumber = new("CCPT");

    /// <summary>Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation</summary>
    [IsoId("__-hUOtYUEe68t8Cw380-tA")]
    [Description(@"Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestClearingIdentificationNumber = new("CHID");

    /// <summary>Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.</summary>
    [IsoId("__-hUO9YUEe68t8Cw380-tA")]
    [Description(@"Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCertificateOfIncorporationNumber = new("CINC");

    /// <summary>Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number)</summary>
    [IsoId("__-hUPNYUEe68t8Cw380-tA")]
    [Description(@"Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number)")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCountryIdentificationCode = new("COID");

    /// <summary>Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.</summary>
    [IsoId("__-hUPdYUEe68t8Cw380-tA")]
    [Description(@"Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCustomerNumber = new("CUST");

    /// <summary>Drivers License Number is requested.</summary>
    [IsoId("__-hUMdYUEe68t8Cw380-tA")]
    [Description(@"Drivers License Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDriversLicenseNumber = new("DRLC");

    /// <summary>Data universal number is requested. This is a unique identification number provided by Dun &amp; Bradstreet to identify an organisation.</summary>
    [IsoId("__-hUPtYUEe68t8Cw380-tA")]
    [Description(@"Data universal number is requested. This is a unique identification number provided by Dun & Bradstreet to identify an organisation.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDataUniversalNumberingSystem = new("DUNS");

    /// <summary>Employee Identification Number is requested.</summary>
    [IsoId("__-hUMtYUEe68t8Cw380-tA")]
    [Description(@"Employee Identification Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestEmployeeIdentificationNumber = new("EMPL");

    /// <summary>GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules.The number is used to retrieve detailed information that is linked to it.</summary>
    [IsoId("__-hUP9YUEe68t8Cw380-tA")]
    [Description(@"GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules.The number is used to retrieve detailed information that is linked to it.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestGS1GLNIdentifier = new("GS1G");

    /// <summary>Information is incomplete.</summary>
    [IsoId("_fI_MQMnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is incomplete.")]
    public static readonly ExternalInvestigationReasonSubTypeCode Incomplete = new("ICOM");

    /// <summary>Information is invalid.</summary>
    [IsoId("_ZhRV0MnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is invalid.")]
    public static readonly ExternalInvestigationReasonSubTypeCode Invalid = new("INVA");

    /// <summary>Information is missing.</summary>
    [IsoId("_Ss--kMnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is missing.")]
    public static readonly ExternalInvestigationReasonSubTypeCode Missing = new("MISS");

    /// <summary>Name and account are not matching.</summary>
    [IsoId("__-hUFNYUEe68t8Cw380-tA")]
    [Description(@"Name and account are not matching.")]
    public static readonly ExternalInvestigationReasonSubTypeCode MismatchNameAndAccount = new("MMNA");

    /// <summary>National Identity Number is requested.</summary>
    [IsoId("__-hUM9YUEe68t8Cw380-tA")]
    [Description(@"National Identity Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestNationalIdentityNumber = new("NIDN");

    /// <summary>Person Commercial Identification is requested.</summary>
    [IsoId("__-hUN9YUEe68t8Cw380-tA")]
    [Description(@"Person Commercial Identification is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPersonCommercialIdentification = new("POID");

    /// <summary>Countries of all business/operations locations are requested.</summary>
    [IsoId("__-hUTNYUEe68t8Cw380-tA")]
    [Description(@"Countries of all business/operations locations are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCountriesofAllBusinessLocations = new("RCBL");

    /// <summary>Country of origination is requested.</summary>
    [IsoId("__-hUXtYUEe68t8Cw380-tA")]
    [Description(@"Country of origination is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCountryOfOrigination = new("RCOO");

    /// <summary>Incorporation country/country of registration is requested.</summary>
    [IsoId("__-hUS9YUEe68t8Cw380-tA")]
    [Description(@"Incorporation country/country of registration is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestIncorporationCountry = new("RICC");

    /// <summary>Incorporation date is requested.</summary>
    [IsoId("__-hUStYUEe68t8Cw380-tA")]
    [Description(@"Incorporation date is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestIncorporationDate = new("RICD");

    /// <summary>Ports of call are requested.</summary>
    [IsoId("__-hUYtYUEe68t8Cw380-tA")]
    [Description(@"Ports of call are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPortsOfCall = new("RPOC");

    /// <summary>Airway bill is requested.</summary>
    [IsoId("__-hUW9YUEe68t8Cw380-tA")]
    [Description(@"Airway bill is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestAirwayBill = new("RQAB");

    /// <summary>Account is requested.</summary>
    [IsoId("__-hUFdYUEe68t8Cw380-tA")]
    [Description(@"Account is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestAccount = new("RQAC");

    /// <summary>Postal address line is requested.</summary>
    [IsoId("__-hULNYUEe68t8Cw380-tA")]
    [Description(@"Postal address line is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressLine = new("RQAL");

    /// <summary>Postal address sub department is requested.</summary>
    [IsoId("__-hUH9YUEe68t8Cw380-tA")]
    [Description(@"Postal address sub department is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressSubDepartment = new("RQAS");

    /// <summary>Postal address type is requested.</summary>
    [IsoId("__-hUHdYUEe68t8Cw380-tA")]
    [Description(@"Postal address type is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressType = new("RQAT");

    /// <summary>Postal address building number is requested.</summary>
    [IsoId("__-hUIdYUEe68t8Cw380-tA")]
    [Description(@"Postal address building number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressBuildingNumber = new("RQB1");

    /// <summary>Bill of lading is requested.</summary>
    [IsoId("__-hUV9YUEe68t8Cw380-tA")]
    [Description(@"Bill of lading is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestBillOfLading = new("RQBL");

    /// <summary>Postal address building name is requested.</summary>
    [IsoId("__-hUItYUEe68t8Cw380-tA")]
    [Description(@"Postal address building name is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressBuildingName = new("RQBN");

    /// <summary>Business website requested.</summary>
    [IsoId("_tz4I0MnyEfCY0M4eFzOwyQ")]
    [Description(@"Business website requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestBusinessWebsite = new("RQBW");

    /// <summary>City of birth is requested.</summary>
    [IsoId("__-hUGtYUEe68t8Cw380-tA")]
    [Description(@"City of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCityOfBirth = new("RQCB");

    /// <summary>Postal address country is requested.</summary>
    [IsoId("__-hUK9YUEe68t8Cw380-tA")]
    [Description(@"Postal address country is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressCountry = new("RQCC");

    /// <summary>Customs declaration is requested.</summary>
    [IsoId("__-hUWNYUEe68t8Cw380-tA")]
    [Description(@"Customs declaration is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCustomsDeclaration = new("RQCD");

    /// <summary>Details of all countries involved in the transaction are requested.</summary>
    [IsoId("__-hUT9YUEe68t8Cw380-tA")]
    [Description(@"Details of all countries involved in the transaction are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCountriesInvolvedInTransaction = new("RQCI");

    /// <summary>Confirmation of whether transaction is civil or military in nature is requested.</summary>
    [IsoId("__-hUY9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether transaction is civil or military in nature is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestIfPaymentCivilOrMilitaryInNature = new("RQCM");

    /// <summary>Country of birth is requested.</summary>
    [IsoId("__-hUHNYUEe68t8Cw380-tA")]
    [Description(@"Country of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCountryOfBirth = new("RQCO");

    /// <summary>Postal address country sub division is requested.</summary>
    [IsoId("__-hUKtYUEe68t8Cw380-tA")]
    [Description(@"Postal address country sub division is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressCountrySubDivision = new("RQCS");

    /// <summary>Countries of transit between the debtor and creditor are requested.</summary>
    [IsoId("__-hUYNYUEe68t8Cw380-tA")]
    [Description(@"Countries of transit between the debtor and creditor are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCountriesOfTransitBetweenDebtorAndCreditorInTransaction = new("RQCT");

    /// <summary>Citizenship is requested.</summary>
    [IsoId("__-hURtYUEe68t8Cw380-tA")]
    [Description(@"Citizenship is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestCitizenship = new("RQCZ");

    /// <summary>Date of birth is requested.</summary>
    [IsoId("__-hUGdYUEe68t8Cw380-tA")]
    [Description(@"Date of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDateOfBirth = new("RQDB");

    /// <summary>Postal address department is requested.</summary>
    [IsoId("__-hUHtYUEe68t8Cw380-tA")]
    [Description(@"Postal address department is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressDepartment = new("RQDE");

    /// <summary>Details of goods are requested.</summary>
    [IsoId("__-hUUdYUEe68t8Cw380-tA")]
    [Description(@"Details of goods are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDetailsOfGoods = new("RQDG");

    /// <summary>Postal address district name is requested.</summary>
    [IsoId("__-hUKdYUEe68t8Cw380-tA")]
    [Description(@"Postal address district name is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressDistrictName = new("RQDN");

    /// <summary>Detailed purpose of payment requested.</summary>
    [IsoId("_Ie0W4MnyEfCY0M4eFzOwyQ")]
    [Description(@"Detailed purpose of payment requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDetailedPurposeOfPayment = new("RQDP");

    /// <summary>Details of services are requested.</summary>
    [IsoId("__-hUUNYUEe68t8Cw380-tA")]
    [Description(@"Details of services are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDetailsOfServices = new("RQDS");

    /// <summary>Dates of voyage for goods or services are requested.</summary>
    [IsoId("__-hUYdYUEe68t8Cw380-tA")]
    [Description(@"Dates of voyage for goods or services are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDatesOfVoyageForGoodServicesReferenceInTransaction = new("RQDV");

    /// <summary>Postal address floor is requested.</summary>
    [IsoId("__-hUI9YUEe68t8Cw380-tA")]
    [Description(@"Postal address floor is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressFloor = new("RQFL");

    /// <summary>Date upon which goods officially change ownership is requested.</summary>
    [IsoId("__-hUVdYUEe68t8Cw380-tA")]
    [Description(@"Date upon which goods officially change ownership is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestGoodsDate = new("RQGD");

    /// <summary>Final destination of goods is requested.</summary>
    [IsoId("__-hUU9YUEe68t8Cw380-tA")]
    [Description(@"Final destination of goods is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestGoodsFinalDestination = new("RQGF");

    /// <summary>General license copy is requested.</summary>
    [IsoId("__-hUaNYUEe68t8Cw380-tA")]
    [Description(@"General license copy is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestGeneralLicenseCopy = new("RQGL");

    /// <summary>HS code of goods is requested.</summary>
    [IsoId("__-hUWtYUEe68t8Cw380-tA")]
    [Description(@"HS code of goods is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestHSCodesOfGoodsProvided = new("RQHS");

    /// <summary>Confirmation of whether charitable sector is involved with transaction is requested.</summary>
    [IsoId("__-hUZtYUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether charitable sector is involved with transaction is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestIfInvolvementOfCharitySector = new("RQIC");

    /// <summary>Industry is requested.</summary>
    [IsoId("__-hUSdYUEe68t8Cw380-tA")]
    [Description(@"Industry is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestIndustry = new("RQID");

    /// <summary>Vessel IMO is requested.</summary>
    [IsoId("__-hUXNYUEe68t8Cw380-tA")]
    [Description(@"Vessel IMO is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestIMOVesselInvolved = new("RQIM");

    /// <summary>Copy of invoice is requested.</summary>
    [IsoId("__-hUF9YUEe68t8Cw380-tA")]
    [Description(@"Copy of invoice is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestInvoiceCopy = new("RQIN");

    /// <summary>Kimberley certification is requested.</summary>
    [IsoId("__-hUZ9YUEe68t8Cw380-tA")]
    [Description(@"Kimberley certification is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestKimberleyCertification = new("RQKC");

    /// <summary>Line of business is requested.</summary>
    [IsoId("__-hUTdYUEe68t8Cw380-tA")]
    [Description(@"Line of business is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestLineOfBusiness = new("RQLB");

    /// <summary>Legal entity identifier is requested.</summary>
    [IsoId("__-hURNYUEe68t8Cw380-tA")]
    [Description(@"Legal entity identifier is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestLEI = new("RQLE");

    /// <summary>Licence applicable or required for payment is requested.</summary>
    [IsoId("__-hUZdYUEe68t8Cw380-tA")]
    [Description(@"Licence applicable or required for payment is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestIfLicenceApplicableOrRequiredForPayment = new("RQLP");

    /// <summary>Location of where services are carried out is requested.</summary>
    [IsoId("__-hUUtYUEe68t8Cw380-tA")]
    [Description(@"Location of where services are carried out is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestServicesLocation = new("RQLS");

    /// <summary>Nationality is requested.</summary>
    [IsoId("__-hURdYUEe68t8Cw380-tA")]
    [Description(@"Nationality is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestNationality = new("RQNA");

    /// <summary>Full name is requested.</summary>
    [IsoId("__-hULtYUEe68t8Cw380-tA")]
    [Description(@"Full name is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestFullName = new("RQNM");

    /// <summary>Occupation is requested.</summary>
    [IsoId("__-hUSNYUEe68t8Cw380-tA")]
    [Description(@"Occupation is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestOccupation = new("RQOC");

    /// <summary>Origin of goods requested.</summary>
    [IsoId("_5_ZDcMnyEfCY0M4eFzOwyQ")]
    [Description(@"Origin of goods requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestOriginOfGoods = new("RQOG");

    /// <summary>Location of any onward trade of goods or services is requested.</summary>
    [IsoId("__-hUTtYUEe68t8Cw380-tA")]
    [Description(@"Location of any onward trade of goods or services is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestLocationOfAnyOnwardTradeOfGoodsOrServices = new("RQON");

    /// <summary>Confirmation of ownership is requested.</summary>
    [IsoId("__-hUGNYUEe68t8Cw380-tA")]
    [Description(@"Confirmation of ownership is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestOwnershipConfirmation = new("RQOW");

    /// <summary>Full postal address is requested.</summary>
    [IsoId("__-hULdYUEe68t8Cw380-tA")]
    [Description(@"Full postal address is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestFullPostalAddress = new("RQPA");

    /// <summary>Postal address post box is requested.</summary>
    [IsoId("__-hUJNYUEe68t8Cw380-tA")]
    [Description(@"Postal address post box is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressPostBox = new("RQPB");

    /// <summary>Postal address post code is requested.</summary>
    [IsoId("__-hUJtYUEe68t8Cw380-tA")]
    [Description(@"Postal address post code is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressPostCode = new("RQPC");

    /// <summary>Province of birth is requested.</summary>
    [IsoId("__-hUG9YUEe68t8Cw380-tA")]
    [Description(@"Province of birth is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestProvinceOfBirth = new("RQPO");

    /// <summary>Copy of passport is requested.</summary>
    [IsoId("__-hUFtYUEe68t8Cw380-tA")]
    [Description(@"Copy of passport is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPassportCopy = new("RQPP");

    /// <summary>Relationship between Debtor and Creditor is requested.</summary>
    [IsoId("__-hUR9YUEe68t8Cw380-tA")]
    [Description(@"Relationship between Debtor and Creditor is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestDebtorAndCreditorRelationship = new("RQRE");

    /// <summary>Postal address room is requested.</summary>
    [IsoId("__-hUJdYUEe68t8Cw380-tA")]
    [Description(@"Postal address room is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressRoom = new("RQRO");

    /// <summary>Date upon which services are carried out is requested.</summary>
    [IsoId("__-hUVNYUEe68t8Cw380-tA")]
    [Description(@"Date upon which services are carried out is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestServicesDate = new("RQSD");

    /// <summary>Specific license copy is requested.</summary>
    [IsoId("__-hUadYUEe68t8Cw380-tA")]
    [Description(@"Specific license copy is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestSpecificLicenseCopy = new("RQSL");

    /// <summary>Postal address street name is requested.</summary>
    [IsoId("__-hUINYUEe68t8Cw380-tA")]
    [Description(@"Postal address street name is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressStreetName = new("RQSN");

    /// <summary>Aircraft tail number is requested.</summary>
    [IsoId("__-hUXdYUEe68t8Cw380-tA")]
    [Description(@"Aircraft tail number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestTailNumberAircraftInvolved = new("RQTA");

    /// <summary>Transport documentation is requested.</summary>
    [IsoId("__-hUWdYUEe68t8Cw380-tA")]
    [Description(@"Transport documentation is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestTransportDocumentation = new("RQTD");

    /// <summary>Postal address town location name is requested.</summary>
    [IsoId("__-hUKNYUEe68t8Cw380-tA")]
    [Description(@"Postal address town location name is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressTownLocationName = new("RQTL");

    /// <summary>Postal address town name is requested.</summary>
    [IsoId("__-hUJ9YUEe68t8Cw380-tA")]
    [Description(@"Postal address town name is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestPostalAddressTownName = new("RQTN");

    /// <summary>Underlying owner is requested.</summary>
    [IsoId("__-hUX9YUEe68t8Cw380-tA")]
    [Description(@"Underlying owner is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestUnderlyingOwner = new("RQUO");

    /// <summary>Ultimate parties and source of funds are requested.</summary>
    [IsoId("__-hUZNYUEe68t8Cw380-tA")]
    [Description(@"Ultimate parties and source of funds are requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestUltimatePartiesInvolvedIncludingSourceOfFunds = new("RQUP");

    /// <summary>Confirmation of whether US is nexus to transaction is requested.</summary>
    [IsoId("__-hUVtYUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether US is nexus to transaction is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestUSNexusStatus = new("RQUS");

    /// <summary>Final user and usage of goods or services requested.</summary>
    [IsoId("_L3MLcMnzEfCY0M4eFzOwyQ")]
    [Description(@"Final user and usage of goods or services requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestFinalUserAndUsageOfGoodsOrServices = new("RQUU");

    /// <summary>Social Security Number is requested.</summary>
    [IsoId("__-hUNNYUEe68t8Cw380-tA")]
    [Description(@"Social Security Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestSocialSecurityNumber = new("SOSE");

    /// <summary>SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.</summary>
    [IsoId("__-hUQNYUEe68t8Cw380-tA")]
    [Description(@"SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestSIREN = new("SREN");

    /// <summary>SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity</summary>
    [IsoId("__-hUQdYUEe68t8Cw380-tA")]
    [Description(@"SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestSIRET = new("SRET");

    /// <summary>Telephone Number is requested.</summary>
    [IsoId("__-hUNdYUEe68t8Cw380-tA")]
    [Description(@"Telephone Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestTelephoneNumber = new("TELE");

    /// <summary>Tax Identification Number is requested.</summary>
    [IsoId("__-hUNtYUEe68t8Cw380-tA")]
    [Description(@"Tax Identification Number is requested.")]
    public static readonly ExternalInvestigationReasonSubTypeCode RequestTaxIdentificationNumber = new("TXID");
}
