// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Registered Contract18.
/// </summary>
[IsoId("_4jPelzEyEe6g-ffJsqGiSA")]
[DisplayName("Registered Contract18")]
public record RegisteredContract18
{
    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public IsoMax1025Text? AdditionalInformation { get; init; }

    /// <summary>
    /// Amendment.
    /// </summary>
    [DisplayName("Amendment")]
    [IsoXmlTag("Amdmnt")]
    public ValueList<RegisteredContractAmendment1> Amendment { get; init; } = [];

    /// <summary>
    /// Contract.
    /// </summary>
    [DisplayName("Contract")]
    [IsoXmlTag("Ctrct")]
    public required UnderlyingContract4Choice_ Contract { get; init; }

    /// <summary>
    /// Contract Balance.
    /// </summary>
    [DisplayName("Contract Balance")]
    [IsoXmlTag("CtrctBal")]
    public ValueList<ContractBalance1> ContractBalance { get; init; } = [];

    /// <summary>
    /// Delivery.
    /// </summary>
    [DisplayName("Delivery")]
    [IsoXmlTag("Dlvry")]
    public required RegisteredContractCommunication1 Delivery { get; init; }

    /// <summary>
    /// Estimated Date Indicator.
    /// </summary>
    [DisplayName("Estimated Date Indicator")]
    [IsoXmlTag("EstmtdDtInd")]
    public required IsoTrueFalseIndicator EstimatedDateIndicator { get; init; }

    /// <summary>
    /// Inter Company Loan.
    /// </summary>
    [DisplayName("Inter Company Loan")]
    [IsoXmlTag("IntrCpnyLn")]
    public required IsoTrueFalseIndicator InterCompanyLoan { get; init; }

    /// <summary>
    /// Issuer Financial Institution.
    /// </summary>
    [DisplayName("Issuer Financial Institution")]
    [IsoXmlTag("IssrFI")]
    public required BranchAndFinancialInstitutionIdentification8 IssuerFinancialInstitution { get; init; }

    /// <summary>
    /// Loan Principal Amount.
    /// </summary>
    [DisplayName("Loan Principal Amount")]
    [IsoXmlTag("LnPrncplAmt")]
    public ActiveCurrencyAndAmount? LoanPrincipalAmount { get; init; }

    /// <summary>
    /// Original Contract Registration Request.
    /// </summary>
    [DisplayName("Original Contract Registration Request")]
    [IsoXmlTag("OrgnlCtrctRegnReq")]
    public IsoMax35Text? OriginalContractRegistrationRequest { get; init; }

    /// <summary>
    /// Payment Schedule Type.
    /// </summary>
    [DisplayName("Payment Schedule Type")]
    [IsoXmlTag("PmtSchdlTp")]
    public PaymentScheduleType2Choice_? PaymentScheduleType { get; init; }

    /// <summary>
    /// Previous Registered Contract Identification.
    /// </summary>
    [DisplayName("Previous Registered Contract Identification")]
    [IsoXmlTag("PrvsRegdCtrctId")]
    public DocumentIdentification22? PreviousRegisteredContractIdentification { get; init; }

    /// <summary>
    /// Registered Contract Identification.
    /// </summary>
    [DisplayName("Registered Contract Identification")]
    [IsoXmlTag("RegdCtrctId")]
    public required DocumentIdentification29 RegisteredContractIdentification { get; init; }

    /// <summary>
    /// Registered Contract Journal.
    /// </summary>
    [DisplayName("Registered Contract Journal")]
    [IsoXmlTag("RegdCtrctJrnl")]
    public ValueList<RegisteredContractJournal3> RegisteredContractJournal { get; init; } = [];

    /// <summary>
    /// Submission.
    /// </summary>
    [DisplayName("Submission")]
    [IsoXmlTag("Submissn")]
    public required RegisteredContractCommunication1 Submission { get; init; }
}
