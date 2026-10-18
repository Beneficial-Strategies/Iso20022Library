// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransaction1"/>
[IsoId("_tHbYsFkyEeGeoaLUQk__nA_-830365966")]
[DisplayName("Credit Transfer Transaction")]
public partial record CreditTransferTransaction1
{
    /// <inheritdoc cref="ICreditTransferTransaction1.PaymentIdentification"/>
    [IsoId("_tHbYsVkyEeGeoaLUQk__nA_480545046")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification1 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.PaymentTypeInformation"/>
    [IsoId("_tHbYslkyEeGeoaLUQk__nA_-1616442493")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.Amount"/>
    [IsoId("_tHbYs1kyEeGeoaLUQk__nA_184356955")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required AmountType3Choice_ Amount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.ExchangeRateInformation"/>
    [IsoId("_tHbYtFkyEeGeoaLUQk__nA_-880307258")]
    [DisplayName("Exchange Rate Information")]
    [IsoXmlTag("XchgRateInf")]
    public ExchangeRate1? ExchangeRateInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.ChargeBearer"/>
    [IsoId("_tHkioFkyEeGeoaLUQk__nA_-632551494")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.ChequeInstruction"/>
    [IsoId("_tHkioVkyEeGeoaLUQk__nA_2132976093")]
    [DisplayName("Cheque Instruction")]
    [IsoXmlTag("ChqInstr")]
    public Cheque7? ChequeInstruction { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.UltimateDebtor"/>
    [IsoId("_tHkiolkyEeGeoaLUQk__nA_1480830191")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification43? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.IntermediaryAgent1"/>
    [IsoId("_tHuToFkyEeGeoaLUQk__nA_1951032318")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.IntermediaryAgent1Account"/>
    [IsoId("_tHuToVkyEeGeoaLUQk__nA_-1918060542")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount24? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.IntermediaryAgent2"/>
    [IsoId("_tHuTolkyEeGeoaLUQk__nA_-594525024")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.IntermediaryAgent2Account"/>
    [IsoId("_tHuTo1kyEeGeoaLUQk__nA_1949141521")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount24? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.IntermediaryAgent3"/>
    [IsoId("_tH4EoFkyEeGeoaLUQk__nA_-1724325070")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.IntermediaryAgent3Account"/>
    [IsoId("_tH4EoVkyEeGeoaLUQk__nA_1310351744")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount24? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.CreditorAgent"/>
    [IsoId("_tH4EolkyEeGeoaLUQk__nA_842733334")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.CreditorAgentAccount"/>
    [IsoId("_tH4Eo1kyEeGeoaLUQk__nA_-89203186")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount24? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.Creditor"/>
    [IsoId("_tH4EpFkyEeGeoaLUQk__nA_1259614988")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public PartyIdentification43? Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.CreditorAccount"/>
    [IsoId("_tIBOkFkyEeGeoaLUQk__nA_10423283")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount24? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.UltimateCreditor"/>
    [IsoId("_tIBOkVkyEeGeoaLUQk__nA_620825211")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public PartyIdentification43? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.InstructionForCreditorAgent"/>
    [IsoId("_tIK_kFkyEeGeoaLUQk__nA_-1400230424")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent1> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction1.InstructionForDebtorAgent"/>
    [IsoId("_tIK_kVkyEeGeoaLUQk__nA_-281769151")]
    [DisplayName("Instruction For Debtor Agent")]
    [IsoXmlTag("InstrForDbtrAgt")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? InstructionForDebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.Purpose"/>
    [IsoId("_tIK_klkyEeGeoaLUQk__nA_-124653728")]
    [DisplayName("Purpose")]
    [IsoXmlTag("Purp")]
    public Purpose2Choice_? Purpose { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.RegulatoryReporting"/>
    [IsoId("_tIK_k1kyEeGeoaLUQk__nA_1240498074")]
    [DisplayName("Regulatory Reporting")]
    [IsoXmlTag("RgltryRptg")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RegulatoryReporting3> RegulatoryReporting { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction1.Tax"/>
    [IsoId("_tIK_lFkyEeGeoaLUQk__nA_-763443505")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public TaxInformation3? Tax { get; init; }

    /// <inheritdoc cref="ICreditTransferTransaction1.RelatedRemittanceInformation"/>
    [IsoId("_tIUJgFkyEeGeoaLUQk__nA_961706654")]
    [DisplayName("Related Remittance Information")]
    [IsoXmlTag("RltdRmtInf")]
    [MinLength(0)]
    [MaxLength(10)]
    public ValueList<RemittanceLocation2> RelatedRemittanceInformation { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransaction1.RemittanceInformation"/>
    [IsoId("_tIUJgVkyEeGeoaLUQk__nA_365986418")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation7? RemittanceInformation { get; init; }
}
