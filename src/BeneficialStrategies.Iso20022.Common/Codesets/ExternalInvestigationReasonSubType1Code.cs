// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the investigation reason sub type, as published in an external investigation reason code sub type set.
/// External code sets can be downloaded from www.iso20022.org.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__DHuwFEUEe2YkcF60skG_A")]
[Description(
    @"Specifies the investigation reason sub type, as published in an external investigation reason code sub type set.|External code sets can be downloaded from www.iso20022.org."
)]
[DerivedFrom(typeof(ExternalInvestigationReasonSubTypeCode))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<ExternalInvestigationReasonSubType1Code>))]
public enum ExternalInvestigationReasonSubType1Code
{
    /// <summary>
    /// Alien Registration Number is requested.
    /// Encoded/decoded by serializers as &quot;ARNU&quot;.
    /// </summary>
    [EnumMember(Value = "ARNU")]
    [IsoId("___asVdYUEe68t8Cw380-tA")]
    [Description(@"Alien Registration Number is requested.")]
    RequestAlienRegistrationNumber = ExternalInvestigationReasonSubTypeCode.RequestAlienRegistrationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.
    /// Encoded/decoded by serializers as &quot;BANK&quot;.
    /// </summary>
    [EnumMember(Value = "BANK")]
    [IsoId("___asZ9YUEe68t8Cw380-tA")]
    [Description(@"Bank party identification is requested. This is a unique and unambiguous assignment made by a specific bank or similar financial institution to identify a relationship as defined between the bank and its client.")]
    RequestBankPartyIdentification = ExternalInvestigationReasonSubTypeCode.RequestBankPartyIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Identifier of the business domain in which the organisation is active is requested.
    /// Encoded/decoded by serializers as &quot;BDID&quot;.
    /// </summary>
    [EnumMember(Value = "BDID")]
    [IsoId("___ase9YUEe68t8Cw380-tA")]
    [Description(@"Identifier of the business domain in which the organisation is active is requested.")]
    RequestBusinessDomainIdentifier = ExternalInvestigationReasonSubTypeCode.RequestBusinessDomainIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Other identification of the organisation is requested.
    /// Encoded/decoded by serializers as &quot;BOID&quot;.
    /// </summary>
    [EnumMember(Value = "BOID")]
    [IsoId("___asfdYUEe68t8Cw380-tA")]
    [Description(@"Other identification of the organisation is requested.")]
    RequestBusinessOtherIdentification = ExternalInvestigationReasonSubTypeCode.RequestBusinessOtherIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CBID&quot;.
    /// </summary>
    [EnumMember(Value = "CBID")]
    [IsoId("___asadYUEe68t8Cw380-tA")]
    [Description(@"Central bank identification number is requested. This is a unique identification number assigned by a central bank to identify an organisation.")]
    RequestCentralBankIdentificationNumber = ExternalInvestigationReasonSubTypeCode.RequestCentralBankIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Passport Number is requested.
    /// Encoded/decoded by serializers as &quot;CCPT&quot;.
    /// </summary>
    [EnumMember(Value = "CCPT")]
    [IsoId("___asV9YUEe68t8Cw380-tA")]
    [Description(@"Passport Number is requested.")]
    RequestPassportNumber = ExternalInvestigationReasonSubTypeCode.RequestPassportNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CHID&quot;.
    /// </summary>
    [EnumMember(Value = "CHID")]
    [IsoId("___asa9YUEe68t8Cw380-tA")]
    [Description(@"Clearing identification number is requested. This is a unique identification number assigned by a clearing house to identify an organisation.")]
    RequestClearingIdentificationNumber = ExternalInvestigationReasonSubTypeCode.RequestClearingIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.
    /// Encoded/decoded by serializers as &quot;CINC&quot;.
    /// </summary>
    [EnumMember(Value = "CINC")]
    [IsoId("___asbdYUEe68t8Cw380-tA")]
    [Description(@"Certificate of incorporation number is requested. This is a unique identification number assigned by a designated authority to a certificate of incorporation and used to identify an organisation.")]
    RequestCertificateOfIncorporationNumber = ExternalInvestigationReasonSubTypeCode.RequestCertificateOfIncorporationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number).
    /// Encoded/decoded by serializers as &quot;COID&quot;.
    /// </summary>
    [EnumMember(Value = "COID")]
    [IsoId("___asb9YUEe68t8Cw380-tA")]
    [Description(@"Country identification code is requested. This is a country authority given organisation identification (e.g., corporate registration number).")]
    RequestCountryIdentificationCode = ExternalInvestigationReasonSubTypeCode.RequestCountryIdentificationCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.
    /// Encoded/decoded by serializers as &quot;CUST&quot;.
    /// </summary>
    [EnumMember(Value = "CUST")]
    [IsoId("___ascdYUEe68t8Cw380-tA")]
    [Description(@"Customer number is requested. This is a number assigned by an issuer to identify a customer or a number assigned by a party to identify a creditor or debtor relationship.")]
    RequestCustomerNumber = ExternalInvestigationReasonSubTypeCode.RequestCustomerNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Drivers License Number is requested.
    /// Encoded/decoded by serializers as &quot;DRLC&quot;.
    /// </summary>
    [EnumMember(Value = "DRLC")]
    [IsoId("___asWdYUEe68t8Cw380-tA")]
    [Description(@"Drivers License Number is requested.")]
    RequestDriversLicenseNumber = ExternalInvestigationReasonSubTypeCode.RequestDriversLicenseNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Data universal number is requested. This is a unique identification number provided by Dun &amp; Bradstreet to identify an organisation.
    /// Encoded/decoded by serializers as &quot;DUNS&quot;.
    /// </summary>
    [EnumMember(Value = "DUNS")]
    [IsoId("___asc9YUEe68t8Cw380-tA")]
    [Description(@"Data universal number is requested. This is a unique identification number provided by Dun & Bradstreet to identify an organisation.")]
    RequestDataUniversalNumberingSystem = ExternalInvestigationReasonSubTypeCode.RequestDataUniversalNumberingSystem, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Employee Identification Number is requested.
    /// Encoded/decoded by serializers as &quot;EMPL&quot;.
    /// </summary>
    [EnumMember(Value = "EMPL")]
    [IsoId("___asW9YUEe68t8Cw380-tA")]
    [Description(@"Employee Identification Number is requested.")]
    RequestEmployeeIdentificationNumber = ExternalInvestigationReasonSubTypeCode.RequestEmployeeIdentificationNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules. The number is used to retrieve detailed information that is linked to it.
    /// Encoded/decoded by serializers as &quot;GS1G&quot;.
    /// </summary>
    [EnumMember(Value = "GS1G")]
    [IsoId("___asddYUEe68t8Cw380-tA")]
    [Description(@"GS1GLN (Global location number) identifier is requested. This is a non-significant reference number used to identify legal entities, functional entities, or physical entities according to GS1 numbering scheme rules. The number is used to retrieve detailed information that is linked to it.")]
    RequestGS1GLNIdentifier = ExternalInvestigationReasonSubTypeCode.RequestGS1GLNIdentifier, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information is incomplete.
    /// Encoded/decoded by serializers as &quot;ICOM&quot;.
    /// </summary>
    [EnumMember(Value = "ICOM")]
    [IsoId("_fI_MQsnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is incomplete.")]
    Incomplete = ExternalInvestigationReasonSubTypeCode.Incomplete, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information is invalid.
    /// Encoded/decoded by serializers as &quot;INVA&quot;.
    /// </summary>
    [EnumMember(Value = "INVA")]
    [IsoId("_ZhRV0snzEfCY0M4eFzOwyQ")]
    [Description(@"Information is invalid.")]
    Invalid = ExternalInvestigationReasonSubTypeCode.Invalid, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Information is missing.
    /// Encoded/decoded by serializers as &quot;MISS&quot;.
    /// </summary>
    [EnumMember(Value = "MISS")]
    [IsoId("_Ss--ksnzEfCY0M4eFzOwyQ")]
    [Description(@"Information is missing.")]
    Missing = ExternalInvestigationReasonSubTypeCode.Missing, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Name and account are not matching.
    /// Encoded/decoded by serializers as &quot;MMNA&quot;.
    /// </summary>
    [EnumMember(Value = "MMNA")]
    [IsoId("___asH9YUEe68t8Cw380-tA")]
    [Description(@"Name and account are not matching.")]
    MismatchNameAndAccount = ExternalInvestigationReasonSubTypeCode.MismatchNameAndAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// National Identity Number is requested.
    /// Encoded/decoded by serializers as &quot;NIDN&quot;.
    /// </summary>
    [EnumMember(Value = "NIDN")]
    [IsoId("___asXdYUEe68t8Cw380-tA")]
    [Description(@"National Identity Number is requested.")]
    RequestNationalIdentityNumber = ExternalInvestigationReasonSubTypeCode.RequestNationalIdentityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Person Commercial Identification is requested.
    /// Encoded/decoded by serializers as &quot;POID&quot;.
    /// </summary>
    [EnumMember(Value = "POID")]
    [IsoId("___asZdYUEe68t8Cw380-tA")]
    [Description(@"Person Commercial Identification is requested.")]
    RequestPersonCommercialIdentification = ExternalInvestigationReasonSubTypeCode.RequestPersonCommercialIdentification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Countries of all business/operations locations are requested.
    /// Encoded/decoded by serializers as &quot;RCBL&quot;.
    /// </summary>
    [EnumMember(Value = "RCBL")]
    [IsoId("___asj9YUEe68t8Cw380-tA")]
    [Description(@"Countries of all business/operations locations are requested.")]
    RequestCountriesofAllBusinessLocations = ExternalInvestigationReasonSubTypeCode.RequestCountriesofAllBusinessLocations, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Country of origination is requested.
    /// Encoded/decoded by serializers as &quot;RCOO&quot;.
    /// </summary>
    [EnumMember(Value = "RCOO")]
    [IsoId("___ass9YUEe68t8Cw380-tA")]
    [Description(@"Country of origination is requested.")]
    RequestCountryOfOrigination = ExternalInvestigationReasonSubTypeCode.RequestCountryOfOrigination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorporation country/country of registration is requested.
    /// Encoded/decoded by serializers as &quot;RICC&quot;.
    /// </summary>
    [EnumMember(Value = "RICC")]
    [IsoId("___asjdYUEe68t8Cw380-tA")]
    [Description(@"Incorporation country/country of registration is requested.")]
    RequestIncorporationCountry = ExternalInvestigationReasonSubTypeCode.RequestIncorporationCountry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Incorporation date is requested.
    /// Encoded/decoded by serializers as &quot;RICD&quot;.
    /// </summary>
    [EnumMember(Value = "RICD")]
    [IsoId("___asi9YUEe68t8Cw380-tA")]
    [Description(@"Incorporation date is requested.")]
    RequestIncorporationDate = ExternalInvestigationReasonSubTypeCode.RequestIncorporationDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ports of call are requested.
    /// Encoded/decoded by serializers as &quot;RPOC&quot;.
    /// </summary>
    [EnumMember(Value = "RPOC")]
    [IsoId("___asu9YUEe68t8Cw380-tA")]
    [Description(@"Ports of call are requested.")]
    RequestPortsOfCall = ExternalInvestigationReasonSubTypeCode.RequestPortsOfCall, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Airway bill is requested.
    /// Encoded/decoded by serializers as &quot;RQAB&quot;.
    /// </summary>
    [EnumMember(Value = "RQAB")]
    [IsoId("___asrdYUEe68t8Cw380-tA")]
    [Description(@"Airway bill is requested.")]
    RequestAirwayBill = ExternalInvestigationReasonSubTypeCode.RequestAirwayBill, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Account is requested.
    /// Encoded/decoded by serializers as &quot;RQAC&quot;.
    /// </summary>
    [EnumMember(Value = "RQAC")]
    [IsoId("___asIdYUEe68t8Cw380-tA")]
    [Description(@"Account is requested.")]
    RequestAccount = ExternalInvestigationReasonSubTypeCode.RequestAccount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address line is requested.
    /// Encoded/decoded by serializers as &quot;RQAL&quot;.
    /// </summary>
    [EnumMember(Value = "RQAL")]
    [IsoId("___asT9YUEe68t8Cw380-tA")]
    [Description(@"Postal address line is requested.")]
    RequestPostalAddressLine = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressLine, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address sub department is requested.
    /// Encoded/decoded by serializers as &quot;RQAS&quot;.
    /// </summary>
    [EnumMember(Value = "RQAS")]
    [IsoId("___asNdYUEe68t8Cw380-tA")]
    [Description(@"Postal address sub department is requested.")]
    RequestPostalAddressSubDepartment = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressSubDepartment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address type is requested.
    /// Encoded/decoded by serializers as &quot;RQAT&quot;.
    /// </summary>
    [EnumMember(Value = "RQAT")]
    [IsoId("___asMdYUEe68t8Cw380-tA")]
    [Description(@"Postal address type is requested.")]
    RequestPostalAddressType = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressType, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address building number is requested.
    /// Encoded/decoded by serializers as &quot;RQB1&quot;.
    /// </summary>
    [EnumMember(Value = "RQB1")]
    [IsoId("___asOdYUEe68t8Cw380-tA")]
    [Description(@"Postal address building number is requested.")]
    RequestPostalAddressBuildingNumber = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressBuildingNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bill of lading is requested.
    /// Encoded/decoded by serializers as &quot;RQBL&quot;.
    /// </summary>
    [EnumMember(Value = "RQBL")]
    [IsoId("___aspdYUEe68t8Cw380-tA")]
    [Description(@"Bill of lading is requested.")]
    RequestBillOfLading = ExternalInvestigationReasonSubTypeCode.RequestBillOfLading, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address building name is requested.
    /// Encoded/decoded by serializers as &quot;RQBN&quot;.
    /// </summary>
    [EnumMember(Value = "RQBN")]
    [IsoId("___asO9YUEe68t8Cw380-tA")]
    [Description(@"Postal address building name is requested.")]
    RequestPostalAddressBuildingName = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressBuildingName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Business website requested.
    /// Encoded/decoded by serializers as &quot;RQBW&quot;.
    /// </summary>
    [EnumMember(Value = "RQBW")]
    [IsoId("_tz4v4cnyEfCY0M4eFzOwyQ")]
    [Description(@"Business website requested.")]
    RequestBusinessWebsite = ExternalInvestigationReasonSubTypeCode.RequestBusinessWebsite, // same ordinal as derivation source for type conversions

    /// <summary>
    /// City of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQCB&quot;.
    /// </summary>
    [EnumMember(Value = "RQCB")]
    [IsoId("___asK9YUEe68t8Cw380-tA")]
    [Description(@"City of birth is requested.")]
    RequestCityOfBirth = ExternalInvestigationReasonSubTypeCode.RequestCityOfBirth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address country is requested.
    /// Encoded/decoded by serializers as &quot;RQCC&quot;.
    /// </summary>
    [EnumMember(Value = "RQCC")]
    [IsoId("___asTdYUEe68t8Cw380-tA")]
    [Description(@"Postal address country is requested.")]
    RequestPostalAddressCountry = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressCountry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Customs declaration is requested.
    /// Encoded/decoded by serializers as &quot;RQCD&quot;.
    /// </summary>
    [EnumMember(Value = "RQCD")]
    [IsoId("___asp9YUEe68t8Cw380-tA")]
    [Description(@"Customs declaration is requested.")]
    RequestCustomsDeclaration = ExternalInvestigationReasonSubTypeCode.RequestCustomsDeclaration, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Details of all countries involved in the transaction are requested.
    /// Encoded/decoded by serializers as &quot;RQCI&quot;.
    /// </summary>
    [EnumMember(Value = "RQCI")]
    [IsoId("___asldYUEe68t8Cw380-tA")]
    [Description(@"Details of all countries involved in the transaction are requested.")]
    RequestCountriesInvolvedInTransaction = ExternalInvestigationReasonSubTypeCode.RequestCountriesInvolvedInTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of whether transaction is civil or military in nature is requested.
    /// Encoded/decoded by serializers as &quot;RQCM&quot;.
    /// </summary>
    [EnumMember(Value = "RQCM")]
    [IsoId("___asvdYUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether transaction is civil or military in nature is requested.")]
    RequestIfPaymentCivilOrMilitaryInNature = ExternalInvestigationReasonSubTypeCode.RequestIfPaymentCivilOrMilitaryInNature, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Country of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQCO&quot;.
    /// </summary>
    [EnumMember(Value = "RQCO")]
    [IsoId("___asL9YUEe68t8Cw380-tA")]
    [Description(@"Country of birth is requested.")]
    RequestCountryOfBirth = ExternalInvestigationReasonSubTypeCode.RequestCountryOfBirth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address country sub division is requested.
    /// Encoded/decoded by serializers as &quot;RQCS&quot;.
    /// </summary>
    [EnumMember(Value = "RQCS")]
    [IsoId("___asS9YUEe68t8Cw380-tA")]
    [Description(@"Postal address country sub division is requested.")]
    RequestPostalAddressCountrySubDivision = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressCountrySubDivision, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Countries of transit between the debtor and creditor are requested.
    /// Encoded/decoded by serializers as &quot;RQCT&quot;.
    /// </summary>
    [EnumMember(Value = "RQCT")]
    [IsoId("___ast9YUEe68t8Cw380-tA")]
    [Description(@"Countries of transit between the debtor and creditor are requested.")]
    RequestCountriesOfTransitBetweenDebtorAndCreditorInTransaction = ExternalInvestigationReasonSubTypeCode.RequestCountriesOfTransitBetweenDebtorAndCreditorInTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Citizenship is requested.
    /// Encoded/decoded by serializers as &quot;RQCZ&quot;.
    /// </summary>
    [EnumMember(Value = "RQCZ")]
    [IsoId("___asg9YUEe68t8Cw380-tA")]
    [Description(@"Citizenship is requested.")]
    RequestCitizenship = ExternalInvestigationReasonSubTypeCode.RequestCitizenship, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQDB&quot;.
    /// </summary>
    [EnumMember(Value = "RQDB")]
    [IsoId("___asKdYUEe68t8Cw380-tA")]
    [Description(@"Date of birth is requested.")]
    RequestDateOfBirth = ExternalInvestigationReasonSubTypeCode.RequestDateOfBirth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address department is requested.
    /// Encoded/decoded by serializers as &quot;RQDE&quot;.
    /// </summary>
    [EnumMember(Value = "RQDE")]
    [IsoId("___asM9YUEe68t8Cw380-tA")]
    [Description(@"Postal address department is requested.")]
    RequestPostalAddressDepartment = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressDepartment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Details of goods are requested.
    /// Encoded/decoded by serializers as &quot;RQDG&quot;.
    /// </summary>
    [EnumMember(Value = "RQDG")]
    [IsoId("___asmdYUEe68t8Cw380-tA")]
    [Description(@"Details of goods are requested.")]
    RequestDetailsOfGoods = ExternalInvestigationReasonSubTypeCode.RequestDetailsOfGoods, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address district name is requested.
    /// Encoded/decoded by serializers as &quot;RQDN&quot;.
    /// </summary>
    [EnumMember(Value = "RQDN")]
    [IsoId("___asSdYUEe68t8Cw380-tA")]
    [Description(@"Postal address district name is requested.")]
    RequestPostalAddressDistrictName = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressDistrictName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Detailed purpose of payment requested.
    /// Encoded/decoded by serializers as &quot;RQDP&quot;.
    /// </summary>
    [EnumMember(Value = "RQDP")]
    [IsoId("_Ie0W4snyEfCY0M4eFzOwyQ")]
    [Description(@"Detailed purpose of payment requested.")]
    RequestDetailedPurposeOfPayment = ExternalInvestigationReasonSubTypeCode.RequestDetailedPurposeOfPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Details of services are requested.
    /// Encoded/decoded by serializers as &quot;RQDS&quot;.
    /// </summary>
    [EnumMember(Value = "RQDS")]
    [IsoId("___asl9YUEe68t8Cw380-tA")]
    [Description(@"Details of services are requested.")]
    RequestDetailsOfServices = ExternalInvestigationReasonSubTypeCode.RequestDetailsOfServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dates of voyage for goods or services are requested.
    /// Encoded/decoded by serializers as &quot;RQDV&quot;.
    /// </summary>
    [EnumMember(Value = "RQDV")]
    [IsoId("___asudYUEe68t8Cw380-tA")]
    [Description(@"Dates of voyage for goods or services are requested.")]
    RequestDatesOfVoyageForGoodServicesReferenceInTransaction = ExternalInvestigationReasonSubTypeCode.RequestDatesOfVoyageForGoodServicesReferenceInTransaction, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address floor is requested.
    /// Encoded/decoded by serializers as &quot;RQFL&quot;.
    /// </summary>
    [EnumMember(Value = "RQFL")]
    [IsoId("___asPdYUEe68t8Cw380-tA")]
    [Description(@"Postal address floor is requested.")]
    RequestPostalAddressFloor = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressFloor, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date upon which goods officially change ownership is requested.
    /// Encoded/decoded by serializers as &quot;RQGD&quot;.
    /// </summary>
    [EnumMember(Value = "RQGD")]
    [IsoId("___asodYUEe68t8Cw380-tA")]
    [Description(@"Date upon which goods officially change ownership is requested.")]
    RequestGoodsDate = ExternalInvestigationReasonSubTypeCode.RequestGoodsDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final destination of goods is requested.
    /// Encoded/decoded by serializers as &quot;RQGF&quot;.
    /// </summary>
    [EnumMember(Value = "RQGF")]
    [IsoId("___asndYUEe68t8Cw380-tA")]
    [Description(@"Final destination of goods is requested.")]
    RequestGoodsFinalDestination = ExternalInvestigationReasonSubTypeCode.RequestGoodsFinalDestination, // same ordinal as derivation source for type conversions

    /// <summary>
    /// General license copy is requested.
    /// Encoded/decoded by serializers as &quot;RQGL&quot;.
    /// </summary>
    [EnumMember(Value = "RQGL")]
    [IsoId("___asx9YUEe68t8Cw380-tA")]
    [Description(@"General license copy is requested.")]
    RequestGeneralLicenseCopy = ExternalInvestigationReasonSubTypeCode.RequestGeneralLicenseCopy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// HS code of goods is requested.
    /// Encoded/decoded by serializers as &quot;RQHS&quot;.
    /// </summary>
    [EnumMember(Value = "RQHS")]
    [IsoId("___asq9YUEe68t8Cw380-tA")]
    [Description(@"HS code of goods is requested.")]
    RequestHSCodesOfGoodsProvided = ExternalInvestigationReasonSubTypeCode.RequestHSCodesOfGoodsProvided, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of whether charitable sector is involved with transaction is requested.
    /// Encoded/decoded by serializers as &quot;RQIC&quot;.
    /// </summary>
    [EnumMember(Value = "RQIC")]
    [IsoId("___asw9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether charitable sector is involved with transaction is requested.")]
    RequestIfInvolvementOfCharitySector = ExternalInvestigationReasonSubTypeCode.RequestIfInvolvementOfCharitySector, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Industry is requested.
    /// Encoded/decoded by serializers as &quot;RQID&quot;.
    /// </summary>
    [EnumMember(Value = "RQID")]
    [IsoId("___asidYUEe68t8Cw380-tA")]
    [Description(@"Industry is requested.")]
    RequestIndustry = ExternalInvestigationReasonSubTypeCode.RequestIndustry, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Vessel IMO is requested.
    /// Encoded/decoded by serializers as &quot;RQIM&quot;.
    /// </summary>
    [EnumMember(Value = "RQIM")]
    [IsoId("___asr9YUEe68t8Cw380-tA")]
    [Description(@"Vessel IMO is requested.")]
    RequestIMOVesselInvolved = ExternalInvestigationReasonSubTypeCode.RequestIMOVesselInvolved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Copy of invoice is requested.
    /// Encoded/decoded by serializers as &quot;RQIN&quot;.
    /// </summary>
    [EnumMember(Value = "RQIN")]
    [IsoId("___asJdYUEe68t8Cw380-tA")]
    [Description(@"Copy of invoice is requested.")]
    RequestInvoiceCopy = ExternalInvestigationReasonSubTypeCode.RequestInvoiceCopy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Kimberley certification is requested.
    /// Encoded/decoded by serializers as &quot;RQKC&quot;.
    /// </summary>
    [EnumMember(Value = "RQKC")]
    [IsoId("___asxdYUEe68t8Cw380-tA")]
    [Description(@"Kimberley certification is requested.")]
    RequestKimberleyCertification = ExternalInvestigationReasonSubTypeCode.RequestKimberleyCertification, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Line of business is requested.
    /// Encoded/decoded by serializers as &quot;RQLB&quot;.
    /// </summary>
    [EnumMember(Value = "RQLB")]
    [IsoId("___askdYUEe68t8Cw380-tA")]
    [Description(@"Line of business is requested.")]
    RequestLineOfBusiness = ExternalInvestigationReasonSubTypeCode.RequestLineOfBusiness, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Legal entity identifier is requested.
    /// Encoded/decoded by serializers as &quot;RQLE&quot;.
    /// </summary>
    [EnumMember(Value = "RQLE")]
    [IsoId("___asf9YUEe68t8Cw380-tA")]
    [Description(@"Legal entity identifier is requested.")]
    RequestLEI = ExternalInvestigationReasonSubTypeCode.RequestLEI, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Licence applicable or required for payment is requested.
    /// Encoded/decoded by serializers as &quot;RQLP&quot;.
    /// </summary>
    [EnumMember(Value = "RQLP")]
    [IsoId("___aswdYUEe68t8Cw380-tA")]
    [Description(@"Licence applicable or required for payment is requested.")]
    RequestIfLicenceApplicableOrRequiredForPayment = ExternalInvestigationReasonSubTypeCode.RequestIfLicenceApplicableOrRequiredForPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Location of where services are carried out is requested.
    /// Encoded/decoded by serializers as &quot;RQLS&quot;.
    /// </summary>
    [EnumMember(Value = "RQLS")]
    [IsoId("___asm9YUEe68t8Cw380-tA")]
    [Description(@"Location of where services are carried out is requested.")]
    RequestServicesLocation = ExternalInvestigationReasonSubTypeCode.RequestServicesLocation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Nationality is requested.
    /// Encoded/decoded by serializers as &quot;RQNA&quot;.
    /// </summary>
    [EnumMember(Value = "RQNA")]
    [IsoId("___asgdYUEe68t8Cw380-tA")]
    [Description(@"Nationality is requested.")]
    RequestNationality = ExternalInvestigationReasonSubTypeCode.RequestNationality, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full name is requested.
    /// Encoded/decoded by serializers as &quot;RQNM&quot;.
    /// </summary>
    [EnumMember(Value = "RQNM")]
    [IsoId("___asU9YUEe68t8Cw380-tA")]
    [Description(@"Full name is requested.")]
    RequestFullName = ExternalInvestigationReasonSubTypeCode.RequestFullName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Occupation is requested.
    /// Encoded/decoded by serializers as &quot;RQOC&quot;.
    /// </summary>
    [EnumMember(Value = "RQOC")]
    [IsoId("___ash9YUEe68t8Cw380-tA")]
    [Description(@"Occupation is requested.")]
    RequestOccupation = ExternalInvestigationReasonSubTypeCode.RequestOccupation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Origin of goods requested.
    /// Encoded/decoded by serializers as &quot;RQOG&quot;.
    /// </summary>
    [EnumMember(Value = "RQOG")]
    [IsoId("_5_ZDcsnyEfCY0M4eFzOwyQ")]
    [Description(@"Origin of goods requested.")]
    RequestOriginOfGoods = ExternalInvestigationReasonSubTypeCode.RequestOriginOfGoods, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Location of any onward trade of goods or services is requested.
    /// Encoded/decoded by serializers as &quot;RQON&quot;.
    /// </summary>
    [EnumMember(Value = "RQON")]
    [IsoId("___ask9YUEe68t8Cw380-tA")]
    [Description(@"Location of any onward trade of goods or services is requested.")]
    RequestLocationOfAnyOnwardTradeOfGoodsOrServices = ExternalInvestigationReasonSubTypeCode.RequestLocationOfAnyOnwardTradeOfGoodsOrServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of ownership is requested.
    /// Encoded/decoded by serializers as &quot;RQOW&quot;.
    /// </summary>
    [EnumMember(Value = "RQOW")]
    [IsoId("___asJ9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of ownership is requested.")]
    RequestOwnershipConfirmation = ExternalInvestigationReasonSubTypeCode.RequestOwnershipConfirmation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Full postal address is requested.
    /// Encoded/decoded by serializers as &quot;RQPA&quot;.
    /// </summary>
    [EnumMember(Value = "RQPA")]
    [IsoId("___asUdYUEe68t8Cw380-tA")]
    [Description(@"Full postal address is requested.")]
    RequestFullPostalAddress = ExternalInvestigationReasonSubTypeCode.RequestFullPostalAddress, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address post box is requested.
    /// Encoded/decoded by serializers as &quot;RQPB&quot;.
    /// </summary>
    [EnumMember(Value = "RQPB")]
    [IsoId("___asP9YUEe68t8Cw380-tA")]
    [Description(@"Postal address post box is requested.")]
    RequestPostalAddressPostBox = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressPostBox, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address post code is requested.
    /// Encoded/decoded by serializers as &quot;RQPC&quot;.
    /// </summary>
    [EnumMember(Value = "RQPC")]
    [IsoId("___asQ9YUEe68t8Cw380-tA")]
    [Description(@"Postal address post code is requested.")]
    RequestPostalAddressPostCode = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressPostCode, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Province of birth is requested.
    /// Encoded/decoded by serializers as &quot;RQPO&quot;.
    /// </summary>
    [EnumMember(Value = "RQPO")]
    [IsoId("___asLdYUEe68t8Cw380-tA")]
    [Description(@"Province of birth is requested.")]
    RequestProvinceOfBirth = ExternalInvestigationReasonSubTypeCode.RequestProvinceOfBirth, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Copy of passport is requested.
    /// Encoded/decoded by serializers as &quot;RQPP&quot;.
    /// </summary>
    [EnumMember(Value = "RQPP")]
    [IsoId("___asI9YUEe68t8Cw380-tA")]
    [Description(@"Copy of passport is requested.")]
    RequestPassportCopy = ExternalInvestigationReasonSubTypeCode.RequestPassportCopy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Relationship between Debtor and Creditor is requested.
    /// Encoded/decoded by serializers as &quot;RQRE&quot;.
    /// </summary>
    [EnumMember(Value = "RQRE")]
    [IsoId("___ashdYUEe68t8Cw380-tA")]
    [Description(@"Relationship between Debtor and Creditor is requested.")]
    RequestDebtorAndCreditorRelationship = ExternalInvestigationReasonSubTypeCode.RequestDebtorAndCreditorRelationship, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address room is requested.
    /// Encoded/decoded by serializers as &quot;RQRO&quot;.
    /// </summary>
    [EnumMember(Value = "RQRO")]
    [IsoId("___asQdYUEe68t8Cw380-tA")]
    [Description(@"Postal address room is requested.")]
    RequestPostalAddressRoom = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressRoom, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Date upon which services are carried out is requested.
    /// Encoded/decoded by serializers as &quot;RQSD&quot;.
    /// </summary>
    [EnumMember(Value = "RQSD")]
    [IsoId("___asn9YUEe68t8Cw380-tA")]
    [Description(@"Date upon which services are carried out is requested.")]
    RequestServicesDate = ExternalInvestigationReasonSubTypeCode.RequestServicesDate, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Specific license copy is requested.
    /// Encoded/decoded by serializers as &quot;RQSL&quot;.
    /// </summary>
    [EnumMember(Value = "RQSL")]
    [IsoId("___asydYUEe68t8Cw380-tA")]
    [Description(@"Specific license copy is requested.")]
    RequestSpecificLicenseCopy = ExternalInvestigationReasonSubTypeCode.RequestSpecificLicenseCopy, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address street name is requested.
    /// Encoded/decoded by serializers as &quot;RQSN&quot;.
    /// </summary>
    [EnumMember(Value = "RQSN")]
    [IsoId("___asN9YUEe68t8Cw380-tA")]
    [Description(@"Postal address street name is requested.")]
    RequestPostalAddressStreetName = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressStreetName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Aircraft tail number is requested.
    /// Encoded/decoded by serializers as &quot;RQTA&quot;.
    /// </summary>
    [EnumMember(Value = "RQTA")]
    [IsoId("___assdYUEe68t8Cw380-tA")]
    [Description(@"Aircraft tail number is requested.")]
    RequestTailNumberAircraftInvolved = ExternalInvestigationReasonSubTypeCode.RequestTailNumberAircraftInvolved, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Transport documentation is requested.
    /// Encoded/decoded by serializers as &quot;RQTD&quot;.
    /// </summary>
    [EnumMember(Value = "RQTD")]
    [IsoId("___asqdYUEe68t8Cw380-tA")]
    [Description(@"Transport documentation is requested.")]
    RequestTransportDocumentation = ExternalInvestigationReasonSubTypeCode.RequestTransportDocumentation, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address town location name is requested.
    /// Encoded/decoded by serializers as &quot;RQTL&quot;.
    /// </summary>
    [EnumMember(Value = "RQTL")]
    [IsoId("___asR9YUEe68t8Cw380-tA")]
    [Description(@"Postal address town location name is requested.")]
    RequestPostalAddressTownLocationName = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressTownLocationName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Postal address town name is requested.
    /// Encoded/decoded by serializers as &quot;RQTN&quot;.
    /// </summary>
    [EnumMember(Value = "RQTN")]
    [IsoId("___asRdYUEe68t8Cw380-tA")]
    [Description(@"Postal address town name is requested.")]
    RequestPostalAddressTownName = ExternalInvestigationReasonSubTypeCode.RequestPostalAddressTownName, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Underlying owner is requested.
    /// Encoded/decoded by serializers as &quot;RQUO&quot;.
    /// </summary>
    [EnumMember(Value = "RQUO")]
    [IsoId("___astdYUEe68t8Cw380-tA")]
    [Description(@"Underlying owner is requested.")]
    RequestUnderlyingOwner = ExternalInvestigationReasonSubTypeCode.RequestUnderlyingOwner, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Ultimate parties and source of funds are requested.
    /// Encoded/decoded by serializers as &quot;RQUP&quot;.
    /// </summary>
    [EnumMember(Value = "RQUP")]
    [IsoId("___asv9YUEe68t8Cw380-tA")]
    [Description(@"Ultimate parties and source of funds are requested.")]
    RequestUltimatePartiesInvolvedIncludingSourceOfFunds = ExternalInvestigationReasonSubTypeCode.RequestUltimatePartiesInvolvedIncludingSourceOfFunds, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Confirmation of whether US is nexus to transaction is requested.
    /// Encoded/decoded by serializers as &quot;RQUS&quot;.
    /// </summary>
    [EnumMember(Value = "RQUS")]
    [IsoId("___aso9YUEe68t8Cw380-tA")]
    [Description(@"Confirmation of whether US is nexus to transaction is requested.")]
    RequestUSNexusStatus = ExternalInvestigationReasonSubTypeCode.RequestUSNexusStatus, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Final user and usage of goods or services requested.
    /// Encoded/decoded by serializers as &quot;RQUU&quot;.
    /// </summary>
    [EnumMember(Value = "RQUU")]
    [IsoId("_L3MygcnzEfCY0M4eFzOwyQ")]
    [Description(@"Final user and usage of goods or services requested.")]
    RequestFinalUserAndUsageOfGoodsOrServices = ExternalInvestigationReasonSubTypeCode.RequestFinalUserAndUsageOfGoodsOrServices, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Social Security Number is requested.
    /// Encoded/decoded by serializers as &quot;SOSE&quot;.
    /// </summary>
    [EnumMember(Value = "SOSE")]
    [IsoId("___asX9YUEe68t8Cw380-tA")]
    [Description(@"Social Security Number is requested.")]
    RequestSocialSecurityNumber = ExternalInvestigationReasonSubTypeCode.RequestSocialSecurityNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.
    /// Encoded/decoded by serializers as &quot;SREN&quot;.
    /// </summary>
    [EnumMember(Value = "SREN")]
    [IsoId("___asd9YUEe68t8Cw380-tA")]
    [Description(@"SIREN number is requested. This is a 9 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation in France.")]
    RequestSIREN = ExternalInvestigationReasonSubTypeCode.RequestSIREN, // same ordinal as derivation source for type conversions

    /// <summary>
    /// SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity.
    /// Encoded/decoded by serializers as &quot;SRET&quot;.
    /// </summary>
    [EnumMember(Value = "SRET")]
    [IsoId("___asedYUEe68t8Cw380-tA")]
    [Description(@"SIRET number is requested. This is a 14 digit code assigned by INSEE, the French National Institute for Statistics and Economic Studies, to identify an organisation unit in France. It consists of the SIREN number, followed by a five digit classification number, to identify the local geographical unit of that entity.")]
    RequestSIRET = ExternalInvestigationReasonSubTypeCode.RequestSIRET, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Telephone Number is requested.
    /// Encoded/decoded by serializers as &quot;TELE&quot;.
    /// </summary>
    [EnumMember(Value = "TELE")]
    [IsoId("___asYdYUEe68t8Cw380-tA")]
    [Description(@"Telephone Number is requested.")]
    RequestTelephoneNumber = ExternalInvestigationReasonSubTypeCode.RequestTelephoneNumber, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Tax Identification Number is requested.
    /// Encoded/decoded by serializers as &quot;TXID&quot;.
    /// </summary>
    [EnumMember(Value = "TXID")]
    [IsoId("___asY9YUEe68t8Cw380-tA")]
    [Description(@"Tax Identification Number is requested.")]
    RequestTaxIdentificationNumber = ExternalInvestigationReasonSubTypeCode.RequestTaxIdentificationNumber, // same ordinal as derivation source for type conversions
}
