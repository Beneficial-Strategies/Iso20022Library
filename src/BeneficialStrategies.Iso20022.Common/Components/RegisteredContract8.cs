// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorised servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_TitIl249EeiU9cctagi5ow")]
[DisplayName("Registered Contract")]
public record RegisteredContract8
{
    /// <summary>
    /// Unique identification of the contract registration creation, amendment or closure request.
    /// </summary>
    [IsoId("_TsjBAW49EeiU9cctagi5ow")]
    [DisplayName("Original Contract Registration Request")]
    [IsoXmlTag("OrgnlCtrctRegnReq")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalContractRegistrationRequest { get; init; }

    /// <summary>
    /// Financial institution of the issuer of the contract.
    /// </summary>
    [IsoId("_TsjBA249EeiU9cctagi5ow")]
    [DisplayName("Issuer Financial Institution")]
    [IsoXmlTag("IssrFI")]
    public required BranchAndFinancialInstitutionIdentification6 IssuerFinancialInstitution { get; init; }

    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    [IsoId("_TsjBBW49EeiU9cctagi5ow")]
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public required UnderlyingContract2Choice_ Contract { get; init; }

    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_TsjBB249EeiU9cctagi5ow")]
    [DisplayName("Contract Balance")]
    [IsoXmlTag("CtrctBal")]
    public ValueList<ContractBalance1> ContractBalance { get; init; } = [];

    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    [IsoId("_TsjBCW49EeiU9cctagi5ow")]
    [DisplayName("Payment Schedule Type")]
    [IsoXmlTag("PmtSchdlTp")]
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the registered contract as assigned by the registration agent.
    /// </summary>
    [IsoId("_TsjBC249EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Identification")]
    [IsoXmlTag("RegdCtrctId")]
    public required DocumentIdentification29 RegisteredContractIdentification { get; init; }

    /// <summary>
    /// Identification of a previously defined registered contract linked to the same underlying contract.
    /// Usage:
    /// This is the identification of a previous contract registration for the same underlying contract, which was closed. In most cases, this is used when a reporting party moves from one registration agent to another.
    /// </summary>
    [IsoId("_TsjBE249EeiU9cctagi5ow")]
    [DisplayName("Previous Registered Contract Identification")]
    [IsoXmlTag("PrvsRegdCtrctId")]
    public DocumentIdentification22? PreviousRegisteredContractIdentification { get; init; }

    /// <summary>
    /// Journal of previously closed registered contracts for the same underlying contract, which were requested at the same registration agent.
    /// </summary>
    [IsoId("_TsjBG249EeiU9cctagi5ow")]
    [DisplayName("Registered Contract Journal")]
    [IsoXmlTag("RegdCtrctJrnl")]
    public ValueList<RegisteredContractJournal2> RegisteredContractJournal { get; init; } = [];

    /// <summary>
    /// Details on amendments to the registered contract.
    /// </summary>
    [IsoId("_TsjBI249EeiU9cctagi5ow")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public ValueList<RegisteredContractAmendment1> Amendment { get; init; } = [];

    /// <summary>
    /// Provides the communication method for the submission of the registered contract.
    /// </summary>
    [IsoId("_TsjBJW49EeiU9cctagi5ow")]
    [DisplayName("Submission")]
    [IsoXmlTag("Submissn")]
    public required RegisteredContractCommunication1 Submission { get; init; }

    /// <summary>
    /// Provides the communication method for the delivery of the registered contract.
    /// </summary>
    [IsoId("_TsjBJ249EeiU9cctagi5ow")]
    [DisplayName("Delivery")]
    [IsoXmlTag("Dlvry")]
    public required RegisteredContractCommunication1 Delivery { get; init; }

    /// <summary>
    /// Amount of money the borrower pays back to the lender outside of interests and charges.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    [IsoId("_TsjBKW49EeiU9cctagi5ow")]
    [DisplayName("Loan Principal Amount")]
    [IsoXmlTag("LnPrncplAmt")]
    public ActiveCurrencyAndAmount? LoanPrincipalAmount { get; init; }

    /// <summary>
    /// Indicates whether the dates provided are estimates or not.
    /// </summary>
    [IsoId("_TsjBK249EeiU9cctagi5ow")]
    [DisplayName("Estimated Date Indicator")]
    [IsoXmlTag("EstmtdDtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EstimatedDateIndicator { get; init; }

    /// <summary>
    /// Indicates whether loan in which both the lender and the borrower are divisions of the same corporation or not.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    [IsoId("_TsjBLW49EeiU9cctagi5ow")]
    [DisplayName("Inter Company Loan")]
    [IsoXmlTag("IntrCpnyLn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator InterCompanyLoan { get; init; }

    /// <summary>
    /// Further information on the registered contract.
    /// </summary>
    [IsoId("_TsjBL249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }
}
