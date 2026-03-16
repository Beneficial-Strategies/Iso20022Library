// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Driver3.
/// </summary>
[IsoId("_lFljcXNTEe6Y1uOeeiF_Eg")]
[DisplayName("Driver3")]
public partial record Driver3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 

    /// <summary>
    /// Additional Identification.
    /// </summary>
    [DisplayName("Additional Identification")]
    [IsoXmlTag("AddtlId")]
    public ValueList<TravelDocument2> AdditionalIdentification { get; init; } = [];

    /// <summary>
    /// Date Of Birth.
    /// </summary>
    [DisplayName("Date Of Birth")]
    [IsoXmlTag("DtOfBirth")]
    public IsoISODate? DateOfBirth { get; init; } 

    /// <summary>
    /// Department Number.
    /// </summary>
    [DisplayName("Department Number")]
    [IsoXmlTag("DeptNb")]
    public IsoMax35Text? DepartmentNumber { get; init; } 

    /// <summary>
    /// Employee Identification.
    /// </summary>
    [DisplayName("Employee Identification")]
    [IsoXmlTag("MplyeeId")]
    public IsoMax70Text? EmployeeIdentification { get; init; } 

    /// <summary>
    /// Employer.
    /// </summary>
    [DisplayName("Employer")]
    [IsoXmlTag("Mplyr")]
    public IsoMax70Text? Employer { get; init; } 

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; } 

    /// <summary>
    /// License Assigner.
    /// </summary>
    [DisplayName("License Assigner")]
    [IsoXmlTag("LicAssgnr")]
    public LegalStructure1Code? LicenseAssigner { get; init; } 

    /// <summary>
    /// License Country.
    /// </summary>
    [DisplayName("License Country")]
    [IsoXmlTag("LicCtry")]
    public ISOMax3ACountryCode? LicenseCountry { get; init; } 

    /// <summary>
    /// License Country Sub Division Major.
    /// </summary>
    [DisplayName("License Country Sub Division Major")]
    [IsoXmlTag("LicCtrySubDvsnMjr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMajor { get; init; } 

    /// <summary>
    /// License Country Sub Division Minor.
    /// </summary>
    [DisplayName("License Country Sub Division Minor")]
    [IsoXmlTag("LicCtrySubDvsnMnr")]
    public ISOCountrySubDivisionCode? LicenseCountrySubDivisionMinor { get; init; } 

    /// <summary>
    /// License Expiration Date.
    /// </summary>
    [DisplayName("License Expiration Date")]
    [IsoXmlTag("LicXprtnDt")]
    public IsoISODate? LicenseExpirationDate { get; init; } 

    /// <summary>
    /// License Form.
    /// </summary>
    [DisplayName("License Form")]
    [IsoXmlTag("LicForm")]
    public PresentationMedium2Code? LicenseForm { get; init; } 

    /// <summary>
    /// License Identification.
    /// </summary>
    [DisplayName("License Identification")]
    [IsoXmlTag("LicId")]
    public IsoMax70Text? LicenseIdentification { get; init; } 

    /// <summary>
    /// License Issuance Date.
    /// </summary>
    [DisplayName("License Issuance Date")]
    [IsoXmlTag("LicIssncDt")]
    public IsoISODate? LicenseIssuanceDate { get; init; } 

    /// <summary>
    /// License Other Authority.
    /// </summary>
    [DisplayName("License Other Authority")]
    [IsoXmlTag("LicOthrAuthrty")]
    public IsoMax16Text? LicenseOtherAuthority { get; init; } 

    /// <summary>
    /// License Type.
    /// </summary>
    [DisplayName("License Type")]
    [IsoXmlTag("LicTp")]
    public IsoMax70Text? LicenseType { get; init; } 

    /// <summary>
    /// Name.
    /// </summary>
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    public IsoMax70Text? Name { get; init; } 

    
    #nullable disable
    
}
