// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ICreditTransferTransactionInformation3"/>
[IsoId("_TMoSHNp-Ed-ak6NoX_4Aeg_151667435")]
[DisplayName("Credit Transfer Transaction Information")]
public partial record CreditTransferTransactionInformation3
{
    /// <inheritdoc cref="ICreditTransferTransactionInformation3.PaymentIdentification"/>
    [IsoId("_TMxcANp-Ed-ak6NoX_4Aeg_381623298")]
    [DisplayName("Payment Identification")]
    [IsoXmlTag("PmtId")]
    public required PaymentIdentification2 PaymentIdentification { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.PaymentTypeInformation"/>
    [IsoId("_TMxcAdp-Ed-ak6NoX_4Aeg_1075306136")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation5? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.InterbankSettlementAmount"/>
    [IsoId("_TMxcAtp-Ed-ak6NoX_4Aeg_152589564")]
    [DisplayName("Interbank Settlement Amount")]
    [IsoXmlTag("IntrBkSttlmAmt")]
    public required CurrencyAndAmount InterbankSettlementAmount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.InterbankSettlementDate"/>
    [IsoId("_TMxcA9p-Ed-ak6NoX_4Aeg_152589992")]
    [DisplayName("Interbank Settlement Date")]
    [IsoXmlTag("IntrBkSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? InterbankSettlementDate { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.SettlementTimeIndication"/>
    [IsoId("_TMxcBNp-Ed-ak6NoX_4Aeg_153515566")]
    [DisplayName("Settlement Time Indication")]
    [IsoXmlTag("SttlmTmIndctn")]
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.SettlementTimeRequest"/>
    [IsoId("_TMxcBdp-Ed-ak6NoX_4Aeg_378851801")]
    [DisplayName("Settlement Time Request")]
    [IsoXmlTag("SttlmTmReq")]
    public SettlementTimeRequest1? SettlementTimeRequest { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.PreviousInstructingAgent"/>
    [IsoId("_TMxcBtp-Ed-ak6NoX_4Aeg_435910460")]
    [DisplayName("Previous Instructing Agent")]
    [IsoXmlTag("PrvsInstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? PreviousInstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.PreviousInstructingAgentAccount"/>
    [IsoId("_TMxcB9p-Ed-ak6NoX_4Aeg_-1502229696")]
    [DisplayName("Previous Instructing Agent Account")]
    [IsoXmlTag("PrvsInstgAgtAcct")]
    public CashAccount7? PreviousInstructingAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.InstructingAgent"/>
    [IsoId("_TM7NANp-Ed-ak6NoX_4Aeg_405437121")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.InstructedAgent"/>
    [IsoId("_TM7NAdp-Ed-ak6NoX_4Aeg_463618457")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.IntermediaryAgent1"/>
    [IsoId("_TM7NAtp-Ed-ak6NoX_4Aeg_417440600")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt1")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent1 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.IntermediaryAgent1Account"/>
    [IsoId("_TM7NA9p-Ed-ak6NoX_4Aeg_-1472679035")]
    [DisplayName("Intermediary Agent 1 Account")]
    [IsoXmlTag("IntrmyAgt1Acct")]
    public CashAccount7? IntermediaryAgent1Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.IntermediaryAgent2"/>
    [IsoId("_TM7NBNp-Ed-ak6NoX_4Aeg_388811954")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt2")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent2 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.IntermediaryAgent2Account"/>
    [IsoId("_TM7NBdp-Ed-ak6NoX_4Aeg_-1558563612")]
    [DisplayName("Intermediary Agent 2 Account")]
    [IsoXmlTag("IntrmyAgt2Acct")]
    public CashAccount7? IntermediaryAgent2Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.IntermediaryAgent3"/>
    [IsoId("_TM7NBtp-Ed-ak6NoX_4Aeg_446070117")]
    [DisplayName("Intermediary Agent")]
    [IsoXmlTag("IntrmyAgt3")]
    public BranchAndFinancialInstitutionIdentification3? IntermediaryAgent3 { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.IntermediaryAgent3Account"/>
    [IsoId("_TM7NB9p-Ed-ak6NoX_4Aeg_-1484682731")]
    [DisplayName("Intermediary Agent 3 Account")]
    [IsoXmlTag("IntrmyAgt3Acct")]
    public CashAccount7? IntermediaryAgent3Account { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.UltimateDebtor"/>
    [IsoId("_TM7NCNp-Ed-ak6NoX_4Aeg_382545700")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public BranchAndFinancialInstitutionIdentification3? UltimateDebtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.Debtor"/>
    [IsoId("_TM7NCdp-Ed-ak6NoX_4Aeg_382547201")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required BranchAndFinancialInstitutionIdentification3 Debtor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.DebtorAccount"/>
    [IsoId("_TNE-ANp-Ed-ak6NoX_4Aeg_160901529")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public CashAccount7? DebtorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.DebtorAgent"/>
    [IsoId("_TNE-Adp-Ed-ak6NoX_4Aeg_429447810")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? DebtorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.DebtorAgentAccount"/>
    [IsoId("_TNE-Atp-Ed-ak6NoX_4Aeg_-1189156695")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount7? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.CreditorAgent"/>
    [IsoId("_TNE-A9p-Ed-ak6NoX_4Aeg_458998047")]
    [DisplayName("Creditor Agent")]
    [IsoXmlTag("CdtrAgt")]
    public BranchAndFinancialInstitutionIdentification3? CreditorAgent { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.CreditorAgentAccount"/>
    [IsoId("_TNE-BNp-Ed-ak6NoX_4Aeg_-1489302307")]
    [DisplayName("Creditor Agent Account")]
    [IsoXmlTag("CdtrAgtAcct")]
    public CashAccount7? CreditorAgentAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.Creditor"/>
    [IsoId("_TNE-Bdp-Ed-ak6NoX_4Aeg_389935370")]
    [DisplayName("Creditor")]
    [IsoXmlTag("Cdtr")]
    public required BranchAndFinancialInstitutionIdentification3 Creditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.CreditorAccount"/>
    [IsoId("_TNE-Btp-Ed-ak6NoX_4Aeg_378853542")]
    [DisplayName("Creditor Account")]
    [IsoXmlTag("CdtrAcct")]
    public CashAccount7? CreditorAccount { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.UltimateCreditor"/>
    [IsoId("_TNE-B9p-Ed-ak6NoX_4Aeg_390857452")]
    [DisplayName("Ultimate Creditor")]
    [IsoXmlTag("UltmtCdtr")]
    public BranchAndFinancialInstitutionIdentification3? UltimateCreditor { get; init; }

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.InstructionForCreditorAgent"/>
    [IsoId("_TNE-CNp-Ed-ak6NoX_4Aeg_1967997773")]
    [DisplayName("Instruction For Creditor Agent")]
    [IsoXmlTag("InstrForCdtrAgt")]
    public ValueList<InstructionForCreditorAgent2> InstructionForCreditorAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.InstructionForNextAgent"/>
    [IsoId("_TNE-Cdp-Ed-ak6NoX_4Aeg_380700533")]
    [DisplayName("Instruction For Next Agent")]
    [IsoXmlTag("InstrForNxtAgt")]
    public ValueList<InstructionForNextAgent1> InstructionForNextAgent { get; init; } = [];

    /// <inheritdoc cref="ICreditTransferTransactionInformation3.RemittanceInformation"/>
    [IsoId("_TNOH8Np-Ed-ak6NoX_4Aeg_-884442094")]
    [DisplayName("Remittance Information")]
    [IsoXmlTag("RmtInf")]
    public RemittanceInformation2? RemittanceInformation { get; init; }
}
