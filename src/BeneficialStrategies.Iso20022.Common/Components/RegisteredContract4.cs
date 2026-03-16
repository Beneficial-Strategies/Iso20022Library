// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Document that a user must file with an authorized servicer for each contract that involves foreign currency transactions with non residents.
/// </summary>
[IsoId("_h9BccdL0EeSDLevdaFPXHw")]
[DisplayName("Registered Contract")]
public record RegisteredContract4
{
    /// <summary>
    /// Unique identification of the contract registration creation, amendment or closure request.
    /// </summary>
    [IsoId("_C2ASYdL6EeSDLevdaFPXHw")]
    [DisplayName("Original Contract Registration Request")]
    [IsoXmlTag("OrgnlCtrctRegnReq")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalContractRegistrationRequest { get; init; }

    /// <summary>
    /// Party registering the currency control contract.
    /// </summary>
    [IsoId("_gjonYtOTEeSQ_-lmj1tzfw")]
    [DisplayName("Reporting Party")]
    [IsoXmlTag("RptgPty")]
    public required TradeParty2 ReportingParty { get; init; }

    /// <summary>
    /// Agent which registers the currency control contract.
    /// </summary>
    [IsoId("_gjonY9OTEeSQ_-lmj1tzfw")]
    [DisplayName("Registration Agent")]
    [IsoXmlTag("RegnAgt")]
    public required BranchAndFinancialInstitutionIdentification5 RegistrationAgent { get; init; }

    /// <summary>
    /// Financial institution of the issuer of the contract.
    /// </summary>
    [IsoId("_AqAcQNL3EeSDLevdaFPXHw")]
    [DisplayName("Issuer Financial Institution")]
    [IsoXmlTag("IssrFI")]
    public required BranchAndFinancialInstitutionIdentification5 IssuerFinancialInstitution { get; init; }

    /// <summary>
    /// Details of the contract being registered.
    /// </summary>
    [IsoId("_Zi0lYNL2EeSDLevdaFPXHw")]
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public required UnderlyingContract1Choice_ Contract { get; init; }

    /// <summary>
    /// Contract balance on date of contract registration.
    /// </summary>
    [IsoId("_i7VeAgtLEeWkxvNyFrBT8Q")]
    [DisplayName("Contract Balance")]
    [IsoXmlTag("CtrctBal")]
    public ContractBalance1? ContractBalance { get; init; }

    /// <summary>
    /// Type of the payment schedule provided in the contract.
    /// </summary>
    [IsoId("_i7VeAwtLEeWkxvNyFrBT8Q")]
    [DisplayName("Payment Schedule Type")]
    [IsoXmlTag("PmtSchdlTp")]
    public PaymentScheduleType1Choice_? PaymentScheduleType { get; init; }

    /// <summary>
    /// Unique and unambiguous identification of the registered contract as assigned by the registration agent.
    /// </summary>
    [IsoId("_0bAv0NL2EeSDLevdaFPXHw")]
    [DisplayName("Registered Contract Identification")]
    [IsoXmlTag("RegdCtrctId")]
    public required DocumentIdentification29 RegisteredContractIdentification { get; init; }

    /// <summary>
    /// Identification of a previously defined registered contract linked to the same underlying contract.
    /// Usage:
    /// This is the identification of a previous contract registration for the same underlying contract, which was closed. In most cases, this is used when a reporting party moves from one registration agent to another.
    /// </summary>
    [IsoId("_LMxlQtOYEeS75MhTUaTyUQ")]
    [DisplayName("Previous Registered Contract Identification")]
    [IsoXmlTag("PrvsRegdCtrctId")]
    public DocumentIdentification22? PreviousRegisteredContractIdentification { get; init; }

    /// <summary>
    /// Journal of previously closed registered contracts for the same underlying contract, which were requested at the same registration agent.
    /// </summary>
    [IsoId("_Dedg4NL3EeSDLevdaFPXHw")]
    [DisplayName("Registered Contract Journal")]
    [IsoXmlTag("RegdCtrctJrnl")]
    public RegisteredContractJournal1? RegisteredContractJournal { get; init; }

    /// <summary>
    /// Details on amendments to the registered contract.
    /// </summary>
    [IsoId("_78d5oNL3EeSDLevdaFPXHw")]
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public RegisteredContractAmendment1? Amendment { get; init; }

    /// <summary>
    /// Provides the communication method for the submission of the registered contract.
    /// </summary>
    [IsoId("_kv3v0NL6EeSDLevdaFPXHw")]
    [DisplayName("Submission")]
    [IsoXmlTag("Submissn")]
    public required RegisteredContractCommunication1 Submission { get; init; }

    /// <summary>
    /// Provides the communication method for the delivery of the registered contract.
    /// </summary>
    [IsoId("_R3HEptL7EeSDLevdaFPXHw")]
    [DisplayName("Delivery")]
    [IsoXmlTag("Dlvry")]
    public required RegisteredContractCommunication1 Delivery { get; init; }

    /// <summary>
    /// Amount of money the borrower pays back to the lender outside of interests and charges.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    [IsoId("_dCKXQNM8EeSDLevdaFPXHw")]
    [DisplayName("Loan Principal Amount")]
    [IsoXmlTag("LnPrncplAmt")]
    public ActiveCurrencyAndAmount? LoanPrincipalAmount { get; init; }

    /// <summary>
    /// Indicates whether the dates provided are estimates or not.
    /// </summary>
    [IsoId("_WB77gNOZEeS75MhTUaTyUQ")]
    [DisplayName("Estimated Date Indicator")]
    [IsoXmlTag("EstmtdDtInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EstimatedDateIndicator { get; init; }

    /// <summary>
    /// Indicates whether loan in which both the lender and the borrower are divisions of the same corporation or not.
    /// Usage:
    /// Only applicable for loan contracts.
    /// </summary>
    [IsoId("_W00xAtOZEeS75MhTUaTyUQ")]
    [DisplayName("Inter Company Loan")]
    [IsoXmlTag("IntrCpnyLn")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator InterCompanyLoan { get; init; }

    /// <summary>
    /// Further information on the registered contract.
    /// </summary>
    [IsoId("_xD4b8NL2EeSDLevdaFPXHw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max1025Text)]
    [StringLength(maximumLength: 1025, MinimumLength = 1)]
    public IsoMax1025Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_94lKwTmyEeWDb47rJ6ki4Q")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}
