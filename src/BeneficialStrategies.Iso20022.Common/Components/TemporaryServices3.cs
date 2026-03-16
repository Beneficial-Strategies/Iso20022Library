// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Temporary Services3.
/// </summary>
[IsoId("_lwWqgXc_Ee6YlIMyoxWMJA")]
[DisplayName("Temporary Services3")]
public partial record TemporaryServices3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Charge.
    /// </summary>
    [DisplayName("Charge")]
    [IsoXmlTag("Chrg")]
    public ValueList<Amount12> Charge { get; init; } = [];

    /// <summary>
    /// Company Department.
    /// </summary>
    [DisplayName("Company Department")]
    [IsoXmlTag("CpnyDept")]
    public IsoMax70Text? CompanyDepartment { get; init; } 

    /// <summary>
    /// Company Identification.
    /// </summary>
    [DisplayName("Company Identification")]
    [IsoXmlTag("CpnyId")]
    public PartyIdentification285? CompanyIdentification { get; init; } 

    /// <summary>
    /// Company Name.
    /// </summary>
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public IsoMax70Text? CompanyName { get; init; } 

    /// <summary>
    /// Company Supervisor.
    /// </summary>
    [DisplayName("Company Supervisor")]
    [IsoXmlTag("CpnySprvsr")]
    public IsoMax70Text? CompanySupervisor { get; init; } 

    /// <summary>
    /// Discount Amount.
    /// </summary>
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; } 

    /// <summary>
    /// Employee Identification.
    /// </summary>
    [DisplayName("Employee Identification")]
    [IsoXmlTag("MplyeeId")]
    public IsoPhoneNumber? EmployeeIdentification { get; init; } 

    /// <summary>
    /// Employee Name.
    /// </summary>
    [DisplayName("Employee Name")]
    [IsoXmlTag("MplyeeNm")]
    public IsoMax70Text? EmployeeName { get; init; } 

    /// <summary>
    /// Employee Personal Identification.
    /// </summary>
    [DisplayName("Employee Personal Identification")]
    [IsoXmlTag("MplyeePrsnlId")]
    public IsoMax35Text? EmployeePersonalIdentification { get; init; } 

    /// <summary>
    /// Employee Professional Level.
    /// </summary>
    [DisplayName("Employee Professional Level")]
    [IsoXmlTag("MplyeePrfssnlLvl")]
    public IsoMax35Text? EmployeeProfessionalLevel { get; init; } 

    /// <summary>
    /// Flat Rate Indicator.
    /// </summary>
    [DisplayName("Flat Rate Indicator")]
    [IsoXmlTag("FlatRateInd")]
    public IsoTrueFalseIndicator? FlatRateIndicator { get; init; } 

    /// <summary>
    /// Job Code.
    /// </summary>
    [DisplayName("Job Code")]
    [IsoXmlTag("JobCd")]
    public IsoMax35Text? JobCode { get; init; } 

    /// <summary>
    /// Job Description.
    /// </summary>
    [DisplayName("Job Description")]
    [IsoXmlTag("JobDesc")]
    public IsoMax256Text? JobDescription { get; init; } 

    /// <summary>
    /// Job Duration.
    /// </summary>
    [DisplayName("Job Duration")]
    [IsoXmlTag("JobDrtn")]
    public IsoMax5NumericText? JobDuration { get; init; } 

    /// <summary>
    /// Job End Date.
    /// </summary>
    [DisplayName("Job End Date")]
    [IsoXmlTag("JobEndDt")]
    public IsoISODate? JobEndDate { get; init; } 

    /// <summary>
    /// Job Start Date.
    /// </summary>
    [DisplayName("Job Start Date")]
    [IsoXmlTag("JobStartDt")]
    public IsoISODate? JobStartDate { get; init; } 

    /// <summary>
    /// Miscellaneous Expenses.
    /// </summary>
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MiscExpnss")]
    public ValueList<Amount13> MiscellaneousExpenses { get; init; } = [];

    /// <summary>
    /// Subtotal Amount.
    /// </summary>
    [DisplayName("Subtotal Amount")]
    [IsoXmlTag("SbttlAmt")]
    public ImpliedCurrencyAndAmount? SubtotalAmount { get; init; } 

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
    /// Time Sheet.
    /// </summary>
    [DisplayName("Time Sheet")]
    [IsoXmlTag("TmSheet")]
    public IsoMax35Text? TimeSheet { get; init; } 

    /// <summary>
    /// Week Ending.
    /// </summary>
    [DisplayName("Week Ending")]
    [IsoXmlTag("WkEndg")]
    public IsoISODate? WeekEnding { get; init; } 

    
    #nullable disable
    
}
