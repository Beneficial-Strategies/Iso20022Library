// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instruction to pay an amount of money to an ultimate beneficiary, on behalf of an originator. This instruction may have to be forwarded several times to complete the settlement chain.
/// </summary>
[IsoId("41f45edb-b794-450d-b6d0-63ff93e72ea6")]
[DisplayName("Payment Instruction48")]
public record PaymentInstruction48
{
    /// <summary>
    /// Reference assigned by a sending party to unambiguously identify the payment information block within the message.
    /// </summary>
    [IsoId("7e046422-12a7-43b1-8d82-2d5aeccb7cc9")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    public IsoMax35Text? PaymentInformationIdentification { get; init; }

    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    [IsoId("bcadcafc-cd22-46e9-a8f0-3cf69e4294d3")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod7Code PaymentMethod { get; init; }

    /// <summary>
    /// Type of advice details requested.
    /// </summary>
    [IsoId("0937e93f-5b68-4f72-99e0-ee5f64e12477")]
    [DisplayName("Requested Advice Type")]
    [IsoXmlTag("ReqdAdvcTp")]
    public AdviceType1? RequestedAdviceType { get; init; }

    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    [IsoId("75e443e1-b75a-42eb-87f1-26d4c94a7683")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation29? PaymentTypeInformation { get; init; }

    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment.
    /// </summary>
    [IsoId("5230153b-c55e-49a2-ae5e-8c13139f4d3f")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    public DateAndDateTime2Choice? RequestedExecutionDate { get; init; }

    /// <summary>
    /// Date by which the debtor must have accepted or rejected the request.
    /// </summary>
    [IsoId("7ff1e358-962d-4718-b59c-03656321f1c4")]
    [DisplayName("Expiry Date")]
    [IsoXmlTag("XpryDt")]
    public DateAndDateTime2Choice? ExpiryDate { get; init; }

    /// <summary>
    /// Conditions for the execution of the payment.
    /// </summary>
    [IsoId("7d58dbab-13fe-4b94-ad8b-5b8d3ce8f597")]
    [DisplayName("Payment Condition")]
    [IsoXmlTag("PmtCond")]
    public PaymentCondition2? PaymentCondition { get; init; }

    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("27e9b5e4-91c5-47d7-b63f-150a0473d822")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification272 Debtor { get; init; }

    /// <summary>
    /// Account used to process charges associated with a transaction.
    /// </summary>
    [IsoId("d9316fef-3978-4511-a57c-1e38aebcaf2d")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount40? DebtorAccount { get; init; }

    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    [IsoId("5e6ea478-eda5-4049-9f3d-a7a97f963476")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification8 DebtorAgent { get; init; }

    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    [IsoId("238bb9ed-2f2f-4d9c-995c-adcdf92eba3b")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount40? DebtorAgentAccount { get; init; }

    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    [IsoId("f4767a69-5610-4f5c-99be-b2ba35a81b38")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification272? UltimateDebtor { get; init; }

    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    [IsoId("418c8d1d-41dd-420e-8d0b-2f908a80681d")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <summary>
    /// Payment processes required to transfer cash from the debtor to the creditor.
    /// </summary>
    [IsoId("aeb80889-10be-4db8-8e6c-3fdaa46bbb2d")]
    [DisplayName("Credit Transfer Transaction")]
    [IsoXmlTag("CdtTrfTx")]
    [MinLength(1)]
    public ValueList<CreditTransferTransaction74> CreditTransferTransaction { get; init; } = [];
}
