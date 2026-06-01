// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation reason sub type, as published in an external investigation reason sub type code set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_i8TyUElDEe2sNe7Wx9q_CQ")]
[Description(
    @"Specifies the investigation reason sub type, as published in an external investigation reason sub type code set.|External code sets can be downloaded from www.iso20022.org."
)]
[Derivations(typeof(ExternalInvestigationReasonSubType1Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationReasonSubTypeCode>))]
public enum ExternalInvestigationReasonSubTypeCode
{
    /// <summary>
    /// Alien Registration Number is requested.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("___asVdYUEe68t8Cw380-tA")]
    [Description(@"Alien Registration Number is requested.")]
    RequestAlienRegistrationNumber,

    /// <summary>
    /// Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("___asZ9YUEe68t8Cw380-tA")]
    [Description(@"Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.")]
    RequestBankPartyIdentification,

    /// <summary>
    /// Identifier of the business domain in which the organisation is active is requested.
    /// Encoded/decoded by serializers as &quot;BDID&quot;.
    /// </summary>
    [EnumMember(Value = "BDID")]
    [IsoId("___ase9YUEe68t8Cw380-tA")]
    [Description(@"Identifier of the business domain in which the organisation is active is requested.")]
    RequestBusinessDomainIdentifier,

    /// <summary>
    /// Other identification of the organisation is requested.
    /// Encoded/decoded by serializers as &quot;BOID&quot;.
    /// </summary>
    [EnumMember(Value = "BOID")]
    [IsoId("___asfdYUEe68t8Cw380-tA")]
    [Description(@"Other identification of the organisation is requested.")]
    RequestBusinessOtherIdentification,

    /// <summary>
    /// Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CBID&quot;.
    /// </summary>
    [EnumMember(Value = "CBID")]
    [IsoId("___asadYUEe68t8Cw380-tA")]
    [Description(@"Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.")]
    RequestCentralBankIdentificationNumber,

    /// <summary>
    /// Passport Number is requested.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("___asV9YUEe68t8Cw380-tA")]
    [Description(@"Passport Number is requested.")]
    RequestPassportNumber,

    /// <summary>
    /// Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CHID&quot;.
    /// </summary>
    [EnumMember(Value = "CHID")]
    [IsoId("___asa9YUEe68t8Cw380-tA")]
    [Description(@"Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation.")]
    RequestClearingIdentificationNumber,

    /// <summary>
    /// Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CINC&quot;.
    /// </summary>
    [EnumMember(Value = "CINC")]
    [IsoId("___asbdYUEe68t8Cw380-tA")]
    [Description(@"Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.")]
    RequestCertificateOfIncorporationNumber,

    /// <summary>
    /// Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number).
    /// Encoded/decoded by serializers as &quot;COID&quot;.
    /// </summary>
    [EnumMember(Value = "COID")]
    [IsoId("___asb9YUEe68t8Cw380-tA")]
    [Description(@"Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number).")]
    RequestCountryIdentificationCode,

    /// <summary>
    /// Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("___ascdYUEe68t8Cw380-tA")]
    [Description(@"Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.")]
    RequestCustomerNumber,

    /// <summary>
    /// Drivers License Number is requested.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("___asWdYUEe68t8Cw380-tA")]
    [Description(@"Drivers License Number is requested.")]
    RequestDriversLicenseNumber,

    /// <summary>
    /// Data universal number is requested. This is a unique identification number provided by Dun &amp; Bradstreet to identify an organisation.
    /// Encoded/decoded by serializers as &quot;DUNS&quot;.
    /// </summary>
    [EnumMember(Value = "DUNS")]
    [IsoId("___asc9YUEe68t8Cw380-tA")]
    [Description(@"Data universal number is requested. This is a unique identification number provided by Dun & Bradstreet to identify an organisation.")]
    RequestDataUniversalNumberingSystem,

    /// <summary>
    /// Employee Identification Number is requested.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("___asW9YUEe68t8Cw380-tA")]
    [Description(@"Employee Identification Number is requested.")]
    RequestEmployeeIdentificationNumber,

    /// <summary>
    /// GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules. The number is used to retrieve detailed information that is linked to it.
    /// Encoded/decoded by serializers as &quot;GS1G&quot;.
    /// </summary>
    [EnumMember(Value = "GS1G")]
    [IsoId("___asddYUEe68t8Cw380-tA")]
    [Description(@"GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules. The number is used to retrieve detailed information that is linked to it.")]
    RequestGS1GLNIdentifier,

    /// <summary>
    /// Information is incomplete.
    /// Encoded/decoded by serializers as &quot;ICOM&quot;.
    /// </summary>
    [EnumMember(Value = "ICOM")]
    [IsoId("_fI_MQsnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is incomplete.")]
    Incomplete,

    /// <summary>
    /// Information is invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_ZhRV0snzEfCY0M4eFzOwyQ")]
    [Description(@"Information is invalid.")]
    Invalid,

    /// <summary>
    /// Information is missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_Ss--ksnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is missing.")]
    Missing,

    /// <summary>
    /// Name and account are not matching.
    /// Encoded/decoded by serializers as &quot;MMNA&quot;.
    /// </summary>
    [EnumMember(Value = "MMNA")]
    [IsoId("___asH9YUEe68t8Cw380-tA")]
    [Description(@"Name and account are not matching.")]
    MismatchNameAndAccount,

    /// <summary>
    /// National Identity Number is requested.
    /// Encoded/decoded by serializers as &quot;NIDN&quot;.
    /// </summary>
    [EnumMember(Value = "NIDN")]
    [IsoId("___asXdYUEe68t8Cw380-tA")]
    [Description(@"National Identity Number is requested.")]
    RequestNationalIdentityNumber,

    /// <summary>
    /// Person Commercial Identification is requested.
    /// Encoded/decoded by serializers as &quot;POID&quot;.
    /// </summary>
    [EnumMember(Value = "POID")]
    [IsoId("___asZdYUEe68t8Cw380-tA")]
    [Description(@"Person Commercial Identification is requested.")]
    RequestPersonCommercialIdentification,

    /// <summary>
    /// Countries of all business/operations locations are requested.
    /// Encoded/decoded by serializers as &quot;RCBL&quot;.
    /// </summary>
    [EnumMember(Value = "RCBL")]
    [IsoId("___asj9YUEe68t8Cw380-tA")]
    [Description(@"Countries of all business/operations locations are requested.")]
    RequestCountriesofAllBusinessLocations,

    /// <summary>
    /// Country of origination is requested.
    /// Encoded/decoded by serializers as &quot;RCOO&quot;.
    /// </summary>
    [EnumMember(Value = "RCOO")]
    [IsoId("___ass9YUEe68t8Cw380-tA")]
    [Description(@"Country of origination is requested.")]
    RequestCountryOfOrigination,

    /// <summary>
    /// Incorporation country/country of registration is requested.
    /// Encoded/decoded by serializers as &quot;RICC&quot;.
    /// </summary>
    [EnumMember(Value = "RICC")]
    [IsoId("___asjdYUEe68t8Cw380-tA")]
    [Description(@"Incorporation country/country of registration is requested.")]
    RequestIncorporationCountry,

    /// <summary>
    /// Incorporation date is requested.
    /// Encoded/decoded by serializers as &quot;RICD&quot;.
    /// </summary>
    [EnumMember(Value = "RICD")]
    [IsoId("___asi9YUEe68t8Cw380-tA")]
    [Description(@"Incorporation date is requested.")]
    RequestIncorporationDate,

    /// <summary>
    /// Ports of call are requested.
    /// Encoded/decoded by serializers as &quot;RPOC&quot;.
    /// </summary>
    [EnumMember(Value = "RPOC")]
    [IsoId("___asu9YUEe68t8Cw380-tA")]
    [Description(@"Ports of call are requested.")]
    RequestPortsOfCall,

    /// <summary>
    /// Airway bill is requested.
    /// Encoded/decoded by serializers as &quot;RQAB&quot;.
    /// </summary>
    [EnumMember(Value = "RQAB")]
    [IsoId("___asrdYUEe68t8Cw380-tA")]
    [Description(@"Airway bill is requested.")]
    RequestAirwayBill,

    /// <summary>
    /// Account is requested.
    /// Encoded/decoded by serializers as &quot;RQAC&quot;.
    /// </summary>
    [EnumMember(Value = "RQAC")]
    [IsoId("___asIdYUEe68t8Cw380-tA")]
    [Description(@"Account is requested.")]
    RequestAccount,

    /// <summary>
    /// Postal address line is requested.
    /// Encoded/decoded by serializers as &quot;RQAL&quot;.
    /// </summary>
    [EnumMember(Value = "RQAL")]
    [IsoId("___asT9YUEe68t8Cw380-tA")]
    [Description(@"Postal address line is requested.")]
    RequestPostalAddressLine,

    /// <summary>
    /// Postal address sub department is requested.
    /// Encoded/decoded by serializers as &quot;RQAS&quot;.
    /// </summary>
    [EnumMember(Value = "RQAS")]
    [IsoId("___asNdYUEe68t8Cw380-tA")]
    [Description(@"Postal address sub department is requested.")]
    RequestPostalAddressSubDepartment,

    /// <summary>
    /// Postal address type is requested.
    /// Encoded/decoded by serializers as &quot;RQAT&quot;.
    /// </summary>
    [EnumMember(Value = "RQAT")]
    [IsoId("___asMdYUEe68t8Cw380-tA")]
    [Description(@"Postal address type is requested.")]
    RequestPostalAddressType,

    /// <summary>
    /// Postal address building number is requested.
    /// Encoded/decoded by serializers as &quot;RQB1&quot;.
    /// </summary>
    [EnumMember(Value = "RQB1")]
    [IsoId("___asOdYUEe68t8Cw380-tA")]
    [Description(@"Postal address building number is requested.")]
    RequestPostalAddressBuildingNumber,

    /// <summary>
    /// Bill of lading is requested.
    /// Encoded/decoded by serializers as &quot;RQBL&quot;.
    /// </summary>
    [EnumMember(Value = "RQBL")]
    [IsoId("___aspdYUEe68t8Cw380-tA")]
    [Description(@"Bill of lading is requested.")]
    RequestBillOfLading,

    /// <summary>
    /// Postal address building name is requested.
    /// Encoded/decoded by serializers as &quot;RQBN&quot;.
    /// </summary>
    [EnumMember(Value = "RQBN")]
    [IsoId("___asO9YUEe68t8Cw380-tA")]
    [Description(@"Postal address building name is requested.")]
    RequestPostalAddressBuildingName,

    /// <summary>
    /// Business website requested.
    /// Encoded/decoded by serializers as &quot;RQBW&quot;.
    /// </summary>
    [EnumMember(Value = "RQBW")]
    [IsoId("_tz4v4cnyEfCY0M4eFzOwyQ")]
    [Description(@"Business website requested.")]
    RequestBusinessWebsite,

    /// <summary>
    /// City of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQCB&quot;.
    /// </summary>
    [EnumMember(Value = "RQCB")]
    [IsoId("___asK9YUEe68t8Cw380-tA")]
    [Description(@"City of birth is requested.")]
    RequestCityOfBirth,

    /// <summary>
    /// Postal address country is requested.
    /// Encoded/decoded by serializers as &quot;RQCC&quot;.
    /// </summary>
    [EnumMember(Value = "RQCC")]
    [IsoId("___asTdYUEe68t8Cw380-tA")]
    [Description(@"Postal address country is requested.")]
    RequestPostalAddressCountry,

    /// <summary>
    /// Customs declaration is requested.
    /// Encoded/decoded by serializers as &quot;RQCD&quot;.
    /// </summary>
    [EnumMember(Value = "RQCD")]
    [IsoId("___asp9YUEe68t8Cw380-tA")]
    [Description(@"Customs declaration is requested.")]
    RequestCustomsDeclaration,

    /// <summary>
    /// Details of all countries involved in the transaction are requested.
    /// Encoded/decoded by serializers as &quot;RQCI&quot;.
    /// </summary>
    [EnumMember(Value = "RQCI")]
    [IsoId("___asldYUEe68t8Cw380-tA")]
    [Description(@"Details of all countries involved in the transaction are requested.")]
    RequestCountriesInvolvedInTransaction,

    /// <summary>
    /// Confirmation of whether transaction is civil or military in nature is requested.
    /// Encoded/decoded by serializers as &quot;RQCM&quot;.
    /// </summary>
    [EnumMember(Value = "RQCM")]
    [IsoId("___asvdYUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether transaction is civil or military in nature is requested.")]
    RequestIfPaymentCivilOrMilitaryInNature,

    /// <summary>
    /// Country of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQCO&quot;.
    /// </summary>
    [EnumMember(Value = "RQCO")]
    [IsoId("___asL9YUEe68t8Cw380-tA")]
    [Description(@"Country of birth is requested.")]
    RequestCountryOfBirth,

    /// <summary>
    /// Postal address country sub division is requested.
    /// Encoded/decoded by serializers as &quot;RQCS&quot;.
    /// </summary>
    [EnumMember(Value = "RQCS")]
    [IsoId("___asS9YUEe68t8Cw380-tA")]
    [Description(@"Postal address country sub division is requested.")]
    RequestPostalAddressCountrySubDivision,

    /// <summary>
    /// Countries of transit between the debtor and creditor are requested.
    /// Encoded/decoded by serializers as &quot;RQCT&quot;.
    /// </summary>
    [EnumMember(Value = "RQCT")]
    [IsoId("___ast9YUEe68t8Cw380-tA")]
    [Description(@"Countries of transit between the debtor and creditor are requested.")]
    RequestCountriesOfTransitBetweenDebtorAndCreditorInTransaction,

    /// <summary>
    /// Citizenship is requested.
    /// Encoded/decoded by serializers as &quot;RQCZ&quot;.
    /// </summary>
    [EnumMember(Value = "RQCZ")]
    [IsoId("___asg9YUEe68t8Cw380-tA")]
    [Description(@"Citizenship is requested.")]
    RequestCitizenship,

    /// <summary>
    /// Date of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQDB&quot;.
    /// </summary>
    [EnumMember(Value = "RQDB")]
    [IsoId("___asKdYUEe68t8Cw380-tA")]
    [Description(@"Date of birth is requested.")]
    RequestDateOfBirth,

    /// <summary>
    /// Postal address department is requested.
    /// Encoded/decoded by serializers as &quot;RQDE&quot;.
    /// </summary>
    [EnumMember(Value = "RQDE")]
    [IsoId("___asM9YUEe68t8Cw380-tA")]
    [Description(@"Postal address department is requested.")]
    RequestPostalAddressDepartment,

    /// <summary>
    /// Details of goods are requested.
    /// Encoded/decoded by serializers as &quot;RQDG&quot;.
    /// </summary>
    [EnumMember(Value = "RQDG")]
    [IsoId("___asmdYUEe68t8Cw380-tA")]
    [Description(@"Details of goods are requested.")]
    RequestDetailsOfGoods,

    /// <summary>
    /// Postal address district name is requested.
    /// Encoded/decoded by serializers as &quot;RQDN&quot;.
    /// </summary>
    [EnumMember(Value = "RQDN")]
    [IsoId("___asSdYUEe68t8Cw380-tA")]
    [Description(@"Postal address district name is requested.")]
    RequestPostalAddressDistrictName,

    /// <summary>
    /// Detailed purpose of payment requested.
    /// Encoded/decoded by serializers as &quot;RQDP&quot;.
    /// </summary>
    [EnumMember(Value = "RQDP")]
    [IsoId("_Ie0W4snyEfCY0M4eFzOwyQ")]
    [Description(@"Detailed purpose of payment requested.")]
    RequestDetailedPurposeOfPayment,

    /// <summary>
    /// Details of services are requested.
    /// Encoded/decoded by serializers as &quot;RQDS&quot;.
    /// </summary>
    [EnumMember(Value = "RQDS")]
    [IsoId("___asl9YUEe68t8Cw380-tA")]
    [Description(@"Details of services are requested.")]
    RequestDetailsOfServices,

    /// <summary>
    /// Dates of voyage for goods or services are requested.
    /// Encoded/decoded by serializers as &quot;RQDV&quot;.
    /// </summary>
    [EnumMember(Value = "RQDV")]
    [IsoId("___asudYUEe68t8Cw380-tA")]
    [Description(@"Dates of voyage for goods or services are requested.")]
    RequestDatesOfVoyageForGoodServicesReferenceInTransaction,

    /// <summary>
    /// Postal address floor is requested.
    /// Encoded/decoded by serializers as &quot;RQFL&quot;.
    /// </summary>
    [EnumMember(Value = "RQFL")]
    [IsoId("___asPdYUEe68t8Cw380-tA")]
    [Description(@"Postal address floor is requested.")]
    RequestPostalAddressFloor,

    /// <summary>
    /// Date upon which goods officially change ownership is requested.
    /// Encoded/decoded by serializers as &quot;RQGD&quot;.
    /// </summary>
    [EnumMember(Value = "RQGD")]
    [IsoId("___asodYUEe68t8Cw380-tA")]
    [Description(@"Date upon which goods officially change ownership is requested.")]
    RequestGoodsDate,

    /// <summary>
    /// Final destination of goods is requested.
    /// Encoded/decoded by serializers as &quot;RQGF&quot;.
    /// </summary>
    [EnumMember(Value = "RQGF")]
    [IsoId("___asndYUEe68t8Cw380-tA")]
    [Description(@"Final destination of goods is requested.")]
    RequestGoodsFinalDestination,

    /// <summary>
    /// General license copy is requested.
    /// Encoded/decoded by serializers as &quot;RQGL&quot;.
    /// </summary>
    [EnumMember(Value = "RQGL")]
    [IsoId("___asx9YUEe68t8Cw380-tA")]
    [Description(@"General license copy is requested.")]
    RequestGeneralLicenseCopy,

    /// <summary>
    /// HS code of goods is requested.
    /// Encoded/decoded by serializers as &quot;RQHS&quot;.
    /// </summary>
    [EnumMember(Value = "RQHS")]
    [IsoId("___asq9YUEe68t8Cw380-tA")]
    [Description(@"HS code of goods is requested.")]
    RequestHSCodesOfGoodsProvided,

    /// <summary>
    /// Confirmation of whether charitable sector is involved with transaction is requested.
    /// Encoded/decoded by serializers as &quot;RQIC&quot;.
    /// </summary>
    [EnumMember(Value = "RQIC")]
    [IsoId("___asw9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether charitable sector is involved with transaction is requested.")]
    RequestIfInvolvementOfCharitySector,

    /// <summary>
    /// Industry is requested.
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("___asidYUEe68t8Cw380-tA")]
    [Description(@"Industry is requested.")]
    RequestIndustry,

    /// <summary>
    /// Vessel IMO is requested.
    /// Encoded/decoded by serializers as &quot;RQIM&quot;.
    /// </summary>
    [EnumMember(Value = "RQIM")]
    [IsoId("___asr9YUEe68t8Cw380-tA")]
    [Description(@"Vessel IMO is requested.")]
    RequestIMOVesselInvolved,

    /// <summary>
    /// Copy of invoice is requested.
    /// Encoded/decoded by serializers as &quot;RQIN&quot;.
    /// </summary>
    [EnumMember(Value = "RQIN")]
    [IsoId("___asJdYUEe68t8Cw380-tA")]
    [Description(@"Copy of invoice is requested.")]
    RequestInvoiceCopy,

    /// <summary>
    /// Kimberley certification is requested.
    /// Encoded/decoded by serializers as &quot;RQKC&quot;.
    /// </summary>
    [EnumMember(Value = "RQKC")]
    [IsoId("___asxdYUEe68t8Cw380-tA")]
    [Description(@"Kimberley certification is requested.")]
    RequestKimberleyCertification,

    /// <summary>
    /// Line of business is requested.
    /// Encoded/decoded by serializers as &quot;RQLB&quot;.
    /// </summary>
    [EnumMember(Value = "RQLB")]
    [IsoId("___askdYUEe68t8Cw380-tA")]
    [Description(@"Line of business is requested.")]
    RequestLineOfBusiness,

    /// <summary>
    /// Legal entity identifier is requested.
    /// Encoded/decoded by serializers as &quot;RQLE&quot;.
    /// </summary>
    [EnumMember(Value = "RQLE")]
    [IsoId("___asf9YUEe68t8Cw380-tA")]
    [Description(@"Legal entity identifier is requested.")]
    RequestLEI,

    /// <summary>
    /// Licence applicable or required for payment is requested.
    /// Encoded/decoded by serializers as &quot;RQLP&quot;.
    /// </summary>
    [EnumMember(Value = "RQLP")]
    [IsoId("___aswdYUEe68t8Cw380-tA")]
    [Description(@"Licence applicable or required for payment is requested.")]
    RequestIfLicenceApplicableOrRequiredForPayment,

    /// <summary>
    /// Location of where services are carried out is requested.
    /// Encoded/decoded by serializers as &quot;RQLS&quot;.
    /// </summary>
    [EnumMember(Value = "RQLS")]
    [IsoId("___asm9YUEe68t8Cw380-tA")]
    [Description(@"Location of where services are carried out is requested.")]
    RequestServicesLocation,

    /// <summary>
    /// Nationality is requested.
    /// Encoded/decoded by serializers as &quot;RQNA&quot;.
    /// </summary>
    [EnumMember(Value = "RQNA")]
    [IsoId("___asgdYUEe68t8Cw380-tA")]
    [Description(@"Nationality is requested.")]
    RequestNationality,

    /// <summary>
    /// Full name is requested.
    /// Encoded/decoded by serializers as &quot;RQNM&quot;.
    /// </summary>
    [EnumMember(Value = "RQNM")]
    [IsoId("___asU9YUEe68t8Cw380-tA")]
    [Description(@"Full name is requested.")]
    RequestFullName,

    /// <summary>
    /// Occupation is requested.
    /// Encoded/decoded by serializers as &quot;RQOC&quot;.
    /// </summary>
    [EnumMember(Value = "RQOC")]
    [IsoId("___ash9YUEe68t8Cw380-tA")]
    [Description(@"Occupation is requested.")]
    RequestOccupation,

    /// <summary>
    /// Origin of goods requested.
    /// Encoded/decoded by serializers as &quot;RQOG&quot;.
    /// </summary>
    [EnumMember(Value = "RQOG")]
    [IsoId("_5_ZDcsnyEfCY0M4eFzOwyQ")]
    [Description(@"Origin of goods requested.")]
    RequestOriginOfGoods,

    /// <summary>
    /// Location of any onward trade of goods or services is requested.
    /// Encoded/decoded by serializers as &quot;RQON&quot;.
    /// </summary>
    [EnumMember(Value = "RQON")]
    [IsoId("___ask9YUEe68t8Cw380-tA")]
    [Description(@"Location of any onward trade of goods or services is requested.")]
    RequestLocationOfAnyOnwardTradeOfGoodsOrServices,

    /// <summary>
    /// Confirmation of ownership is requested.
    /// Encoded/decoded by serializers as &quot;RQOW&quot;.
    /// </summary>
    [EnumMember(Value = "RQOW")]
    [IsoId("___asJ9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of ownership is requested.")]
    RequestOwnershipConfirmation,

    /// <summary>
    /// Full postal address is requested.
    /// Encoded/decoded by serializers as &quot;RQPA&quot;.
    /// </summary>
    [EnumMember(Value = "RQPA")]
    [IsoId("___asUdYUEe68t8Cw380-tA")]
    [Description(@"Full postal address is requested.")]
    RequestFullPostalAddress,

    /// <summary>
    /// Postal address post box is requested.
    /// Encoded/decoded by serializers as &quot;RQPB&quot;.
    /// </summary>
    [EnumMember(Value = "RQPB")]
    [IsoId("___asP9YUEe68t8Cw380-tA")]
    [Description(@"Postal address post box is requested.")]
    RequestPostalAddressPostBox,

    /// <summary>
    /// Postal address post code is requested.
    /// Encoded/decoded by serializers as &quot;RQPC&quot;.
    /// </summary>
    [EnumMember(Value = "RQPC")]
    [IsoId("___asQ9YUEe68t8Cw380-tA")]
    [Description(@"Postal address post code is requested.")]
    RequestPostalAddressPostCode,

    /// <summary>
    /// Province of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQPO&quot;.
    /// </summary>
    [EnumMember(Value = "RQPO")]
    [IsoId("___asLdYUEe68t8Cw380-tA")]
    [Description(@"Province of birth is requested.")]
    RequestProvinceOfBirth,

    /// <summary>
    /// Copy of passport is requested.
    /// Encoded/decoded by serializers as &quot;RQPP&quot;.
    /// </summary>
    [EnumMember(Value = "RQPP")]
    [IsoId("___asI9YUEe68t8Cw380-tA")]
    [Description(@"Copy of passport is requested.")]
    RequestPassportCopy,

    /// <summary>
    /// Relationship between Debtor and Creditor is requested.
    /// Encoded/decoded by serializers as &quot;RQRE&quot;.
    /// </summary>
    [EnumMember(Value = "RQRE")]
    [IsoId("___ashdYUEe68t8Cw380-tA")]
    [Description(@"Relationship between Debtor and Creditor is requested.")]
    RequestDebtorAndCreditorRelationship,

    /// <summary>
    /// Postal address room is requested.
    /// Encoded/decoded by serializers as &quot;RQRO&quot;.
    /// </summary>
    [EnumMember(Value = "RQRO")]
    [IsoId("___asQdYUEe68t8Cw380-tA")]
    [Description(@"Postal address room is requested.")]
    RequestPostalAddressRoom,

    /// <summary>
    /// Date upon which services are carried out is requested.
    /// Encoded/decoded by serializers as &quot;RQSD&quot;.
    /// </summary>
    [EnumMember(Value = "RQSD")]
    [IsoId("___asn9YUEe68t8Cw380-tA")]
    [Description(@"Date upon which services are carried out is requested.")]
    RequestServicesDate,

    /// <summary>
    /// Specific license copy is requested.
    /// Encoded/decoded by serializers as &quot;RQSL&quot;.
    /// </summary>
    [EnumMember(Value = "RQSL")]
    [IsoId("___asydYUEe68t8Cw380-tA")]
    [Description(@"Specific license copy is requested.")]
    RequestSpecificLicenseCopy,

    /// <summary>
    /// Postal address street name is requested.
    /// Encoded/decoded by serializers as &quot;RQSN&quot;.
    /// </summary>
    [EnumMember(Value = "RQSN")]
    [IsoId("___asN9YUEe68t8Cw380-tA")]
    [Description(@"Postal address street name is requested.")]
    RequestPostalAddressStreetName,

    /// <summary>
    /// Aircraft tail number is requested.
    /// Encoded/decoded by serializers as &quot;RQTA&quot;.
    /// </summary>
    [EnumMember(Value = "RQTA")]
    [IsoId("___assdYUEe68t8Cw380-tA")]
    [Description(@"Aircraft tail number is requested.")]
    RequestTailNumberAircraftInvolved,

    /// <summary>
    /// Transport documentation is requested.
    /// Encoded/decoded by serializers as &quot;RQTD&quot;.
    /// </summary>
    [EnumMember(Value = "RQTD")]
    [IsoId("___asqdYUEe68t8Cw380-tA")]
    [Description(@"Transport documentation is requested.")]
    RequestTransportDocumentation,

    /// <summary>
    /// Postal address town location name is requested.
    /// Encoded/decoded by serializers as &quot;RQTL&quot;.
    /// </summary>
    [EnumMember(Value = "RQTL")]
    [IsoId("___asR9YUEe68t8Cw380-tA")]
    [Description(@"Postal address town location name is requested.")]
    RequestPostalAddressTownLocationName,

    /// <summary>
    /// Postal address town name is requested.
    /// Encoded/decoded by serializers as &quot;RQTN&quot;.
    /// </summary>
    [EnumMember(Value = "RQTN")]
    [IsoId("___asRdYUEe68t8Cw380-tA")]
    [Description(@"Postal address town name is requested.")]
    RequestPostalAddressTownName,

    /// <summary>
    /// Underlying owner is requested.
    /// Encoded/decoded by serializers as &quot;RQUO&quot;.
    /// </summary>
    [EnumMember(Value = "RQUO")]
    [IsoId("___astdYUEe68t8Cw380-tA")]
    [Description(@"Underlying owner is requested.")]
    RequestUnderlyingOwner,

    /// <summary>
    /// Ultimate parties and source of funds are requested.
    /// Encoded/decoded by serializers as &quot;RQUP&quot;.
    /// </summary>
    [EnumMember(Value = "RQUP")]
    [IsoId("___asv9YUEe68t8Cw380-tA")]
    [Description(@"Ultimate parties and source of funds are requested.")]
    RequestUltimatePartiesInvolvedIncludingSourceOfFunds,

    /// <summary>
    /// Confirmation of whether US is nexus to transaction is requested.
    /// Encoded/decoded by serializers as &quot;RQUS&quot;.
    /// </summary>
    [EnumMember(Value = "RQUS")]
    [IsoId("___aso9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether US is nexus to transaction is requested.")]
    RequestUSNexusStatus,

    /// <summary>
    /// Final user and usage of goods or services requested.
    /// Encoded/decoded by serializers as &quot;RQUU&quot;.
    /// </summary>
    [EnumMember(Value = "RQUU")]
    [IsoId("_L3MygcnzEfCY0M4eFzOwyQ")]
    [Description(@"Final user and usage of goods or services requested.")]
    RequestFinalUserAndUsageOfGoodsOrServices,

    /// <summary>
    /// Social Security Number is requested.
    /// Encoded/decoded by serializers as &quot;SOSE&quot;.
    /// </summary>
    [EnumMember(Value = "SOSE")]
    [IsoId("___asX9YUEe68t8Cw380-tA")]
    [Description(@"Social Security Number is requested.")]
    RequestSocialSecurityNumber,

    /// <summary>
    /// SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.
    /// Encoded/decoded by serializers as &quot;SREN&quot;.
    /// </summary>
    [EnumMember(Value = "SREN")]
    [IsoId("___asd9YUEe68t8Cw380-tA")]
    [Description(@"SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.")]
    RequestSIREN,

    /// <summary>
    /// SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity.
    /// Encoded/decoded by serializers as &quot;SRET&quot;.
    /// </summary>
    [EnumMember(Value = "SRET")]
    [IsoId("___asedYUEe68t8Cw380-tA")]
    [Description(@"SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity.")]
    RequestSIRET,

    /// <summary>
    /// Telephone Number is requested.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("___asYdYUEe68t8Cw380-tA")]
    [Description(@"Telephone Number is requested.")]
    RequestTelephoneNumber,

    /// <summary>
    /// Tax Identification Number is requested.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("___asY9YUEe68t8Cw380-tA")]
    [Description(@"Tax Identification Number is requested.")]
    RequestTaxIdentificationNumber,
}
