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
    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpnm")]
    [DisplayName("Company Name")]
    [IsoXmlTag("CpnyNm")]
    public IsoMax70Text? CompanyName { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpdp")]
    [DisplayName("Company Department")]
    [IsoXmlTag("CpnyDept")]
    public IsoMax70Text? CompanyDepartment { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpid")]
    [DisplayName("Company Identification")]
    [IsoXmlTag("CpnyId")]
    public IsoMax35Text? CompanyIdentification { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpbn")]
    [DisplayName("Company Business Name")]
    [IsoXmlTag("CpnyBizNm")]
    public IsoMax35Text? CompanyBusinessName { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cplg")]
    [DisplayName("Company Legal Corporate Name")]
    [IsoXmlTag("CpnyLglCorpNm")]
    public IsoMax99Text? CompanyLegalCorporateName { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpad")]
    [DisplayName("Company Address")]
    [IsoXmlTag("CpnyAdr")]
    public Address4? CompanyAddress { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpld")]
    [DisplayName("Company Local Data")]
    [IsoXmlTag("CpnyLclData")]
    public ValueList<LocalData20> CompanyLocalData { get; init; } = [];

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-cpsv")]
    [DisplayName("Company Supervisor")]
    [IsoXmlTag("CpnySprvisr")]
    public IsoMax70Text? CompanySupervisor { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-eppd")]
    [DisplayName("Employee Personal Identification")]
    [IsoXmlTag("EmplPersnlId")]
    public IsoMax35Text? EmployeePersonalIdentification { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-epid")]
    [DisplayName("Employee Identification")]
    [IsoXmlTag("EmplId")]
    public IsoPhoneNumber? EmployeeIdentification { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-epnm")]
    [DisplayName("Employee Name")]
    [IsoXmlTag("EmplNm")]
    public IsoMax70Text? EmployeeName { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-eppf")]
    [DisplayName("Employee Professional Level")]
    [IsoXmlTag("EmplPrfssnlLvl")]
    public IsoMax35Text? EmployeeProfessionalLevel { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbcd")]
    [DisplayName("Job Code")]
    [IsoXmlTag("JobCd")]
    public IsoMax35Text? JobCode { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbds")]
    [DisplayName("Job Description")]
    [IsoXmlTag("JobDesc")]
    public IsoMax256Text? JobDescription { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbst")]
    [DisplayName("Job Start Date")]
    [IsoXmlTag("JobStartDt")]
    public IsoISODate? JobStartDate { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jbdr")]
    [DisplayName("Job Duration")]
    [IsoXmlTag("JobDrtn")]
    public IsoMax5NumericText? JobDuration { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-jben")]
    [DisplayName("Job End Date")]
    [IsoXmlTag("JobEndDt")]
    public IsoISODate? JobEndDate { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-flrt")]
    [DisplayName("Flat Rate Indicator")]
    [IsoXmlTag("FlatRateInd")]
    public IsoTrueFalseIndicator? FlatRateIndicator { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-disc")]
    [DisplayName("Discount Amount")]
    [IsoXmlTag("DscntAmt")]
    public ImpliedCurrencyAndAmount? DiscountAmount { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-scid")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SmmryCmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-tmsh")]
    [DisplayName("Time Sheet")]
    [IsoXmlTag("TmSht")]
    public IsoMax35Text? TimeSheet { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-wken")]
    [DisplayName("Week Ending")]
    [IsoXmlTag("WkEndg")]
    public IsoISODate? WeekEnding { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-chrt")]
    [DisplayName("Charge Rate")]
    [IsoXmlTag("ChrgeRate")]
    public ValueList<TemporaryServiceChargeRate1> ChargeRate { get; init; } = [];

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-msex")]
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MscllnsXpnss")]
    public ValueList<Amount13> MiscellaneousExpenses { get; init; } = [];

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-sbta")]
    [DisplayName("Subtotal Amount")]
    [IsoXmlTag("SubtlAmt")]
    public ImpliedCurrencyAndAmount? SubtotalAmount { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-tax0")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-ttla")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-pvdt")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_tBmaUUhsEfCMZJtj4J7UGQ-ntdt")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
