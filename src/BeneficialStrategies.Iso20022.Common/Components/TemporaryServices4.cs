// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Temporary services purchase data.
/// </summary>
[IsoId("_tBmaUUhsEfCMZJtj4J7UGQ")]
[DisplayName("Temporary Services4")]
public record TemporaryServices4
{
    /// <summary>
    /// Contains the name of the individual at the contracting company that has requested temporary services.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpnm")]
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public IsoMax70Text? CompanyName { get; init; }

    /// <summary>
    /// Contains the name of the department at the contracting company in which the temporary staff will be working. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpdp")]
    [DisplayName("Company Department")]
    [IsoXmlTag("CpnyDept")]
    public IsoMax70Text? CompanyDepartment { get; init; }

    /// <summary>
    /// Identification of the temporary services company.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpid")]
    [DisplayName("Company Identification")]
    [IsoXmlTag("CpnyId")]
    public IsoMax35Text? CompanyIdentification { get; init; }

    /// <summary>
    /// Business name of the temporary services company.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpbn")]
    [DisplayName("Company Business Name")]
    [IsoXmlTag("CpnyBizNm")]
    public IsoMax35Text? CompanyBusinessName { get; init; }

    /// <summary>
    /// Legal Corporate Name of the temporary services company.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cplg")]
    [DisplayName("Company Legal Corporate Name")]
    [IsoXmlTag("CpnyLglCorpNm")]
    public IsoMax99Text? CompanyLegalCorporateName { get; init; }

    /// <summary>
    /// Address of the temporary services company.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpad")]
    [DisplayName("Company Address")]
    [IsoXmlTag("CpnyAdr")]
    public Address4? CompanyAddress { get; init; }

    /// <summary>
    /// Contains local language equivalent(s) of the temporary services company data.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpld")]
    [DisplayName("Company Local Data")]
    [IsoXmlTag("CpnyLclData")]
    public ValueList<LocalData20> CompanyLocalData { get; init; } = [];

    /// <summary>
    /// Contains the name of the individual at the contracting company that is supervising the temporary staff. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpsv")]
    [DisplayName("Company Supervisor")]
    [IsoXmlTag("CpnySprvisr")]
    public IsoMax70Text? CompanySupervisor { get; init; }

    /// <summary>
    /// Contains the personal ID associated with the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-eppd")]
    [DisplayName("Employee Personal Identification")]
    [IsoXmlTag("EmplPersnlId")]
    public IsoMax35Text? EmployeePersonalIdentification { get; init; }

    /// <summary>
    /// Contains the company-provided ID associated with the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-epid")]
    [DisplayName("Employee Identification")]
    [IsoXmlTag("EmplId")]
    public IsoPhoneNumber? EmployeeIdentification { get; init; }

    /// <summary>
    /// Contains the name of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-epnm")]
    [DisplayName("Employee Name")]
    [IsoXmlTag("EmplNm")]
    public IsoMax70Text? EmployeeName { get; init; }

    /// <summary>
    /// Contains the professional level of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-eppf")]
    [DisplayName("Employee Professional Level")]
    [IsoXmlTag("EmplPrfssnlLvl")]
    public IsoMax35Text? EmployeeProfessionalLevel { get; init; }

    /// <summary>
    /// Identifies the job or task being performed by the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbcd")]
    [DisplayName("Job Code")]
    [IsoXmlTag("JobCd")]
    public IsoMax35Text? JobCode { get; init; }

    /// <summary>
    /// Contains the description of the job or task of the individual working in a temporary capacity.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbds")]
    [DisplayName("Job Description")]
    [IsoXmlTag("JobDesc")]
    public IsoMax256Text? JobDescription { get; init; }

    /// <summary>
    /// Contains the start date of the job. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbst")]
    [DisplayName("Job Start Date")]
    [IsoXmlTag("JobStartDt")]
    public IsoISODate? JobStartDate { get; init; }

    /// <summary>
    /// Duration of the job expressed in number of days. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbdr")]
    [DisplayName("Job Duration")]
    [IsoXmlTag("JobDrtn")]
    public IsoMax5NumericText? JobDuration { get; init; }

    /// <summary>
    /// Contains the end date of the job. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jben")]
    [DisplayName("Job End Date")]
    [IsoXmlTag("JobEndDt")]
    public IsoISODate? JobEndDate { get; init; }

    /// <summary>
    /// Indicates whether or not the fee for the individual working in a temporary capacity is a flat|rate.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-flrt")]
    [DisplayName("Flat Rate Indicator")]
    [IsoXmlTag("FlatRateInd")]
    public IsoTrueFalseIndicator? FlatRateIndicator { get; init; }

    /// <summary>
    /// Contains the discount amount. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-disc")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-scid")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SmmryCmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Contains the time sheet identification number.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-tmsh")]
    [DisplayName("Time Sheet")]
    [IsoXmlTag("TmSht")]
    public IsoMax35Text? TimeSheet { get; init; }

    /// <summary>
    /// Contains the date of the end of the billing cycle. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-wken")]
    [DisplayName("Week Ending")]
    [IsoXmlTag("WkEndg")]
    public IsoISODate? WeekEnding { get; init; }

    /// <summary>
    /// Contains rate details of the temporary service charges. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-chrt")]
    [DisplayName("Charge Rate")]
    [IsoXmlTag("ChrgeRate")]
    public ValueList<TemporaryServiceChargeRate1> ChargeRate { get; init; } = [];

    /// <summary>
    /// Contains miscellaneous expense details.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-msex")]
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MscllnsXpnss")]
    public ValueList<Amount13> MiscellaneousExpenses { get; init; } = [];

    /// <summary>
    /// Subtotal amount exclusive of tax.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-sbta")]
    [DisplayName("Subtotal Amount")]
    [IsoXmlTag("SubtlAmt")]
    public ImpliedCurrencyAndAmount? SubtotalAmount { get; init; }

    /// <summary>
    /// Contains the amount of taxes assessed for temporary services.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-tax0")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Total amount includes amounts of all expenses and total tax amounts, minus discount amount.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-ttla")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
