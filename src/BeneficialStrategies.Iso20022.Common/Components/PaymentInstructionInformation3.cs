// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentInstructionInformation3"/>
[IsoId("_PjuRudp-Ed-ak6NoX_4Aeg_316731131")]
[DisplayName("Payment Instruction Information")]
[Obsolete("Marked obsolete in the ISO 20022 2026-06-26 snapshot. Removal date: 2018-08-07.")]
public partial record PaymentInstructionInformation3
{
    /// <inheritdoc cref="IPaymentInstructionInformation3.PaymentInformationIdentification"/>
    [IsoId("_PjuRutp-Ed-ak6NoX_4Aeg_316731502")]
    [DisplayName("Payment Information Identification")]
    [IsoXmlTag("PmtInfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text PaymentInformationIdentification { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.PaymentMethod"/>
    [IsoId("_Pj4CsNp-Ed-ak6NoX_4Aeg_316731441")]
    [DisplayName("Payment Method")]
    [IsoXmlTag("PmtMtd")]
    public required PaymentMethod3Code PaymentMethod { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.BatchBooking"/>
    [IsoId("_Pj4Csdp-Ed-ak6NoX_4Aeg_386918058")]
    [DisplayName("Batch Booking")]
    [IsoXmlTag("BtchBookg")]
    [IsoSimpleType(IsoSimpleType.BatchBookingIndicator)]
    public IsoBatchBookingIndicator? BatchBooking { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.NumberOfTransactions"/>
    [IsoId("_Pj4Cstp-Ed-ak6NoX_4Aeg_790499274")]
    [DisplayName("Number Of Transactions")]
    [IsoXmlTag("NbOfTxs")]
    [IsoSimpleType(IsoSimpleType.Max15NumericText)]
    public IsoMax15NumericText? NumberOfTransactions { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.ControlSum"/>
    [IsoId("_Pj4Cs9p-Ed-ak6NoX_4Aeg_791419299")]
    [DisplayName("Control Sum")]
    [IsoXmlTag("CtrlSum")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    public IsoDecimalNumber? ControlSum { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.PaymentTypeInformation"/>
    [IsoId("_Pj4CtNp-Ed-ak6NoX_4Aeg_316732080")]
    [DisplayName("Payment Type Information")]
    [IsoXmlTag("PmtTpInf")]
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.RequestedExecutionDate"/>
    [IsoId("_Pj4Ctdp-Ed-ak6NoX_4Aeg_316731163")]
    [DisplayName("Requested Execution Date")]
    [IsoXmlTag("ReqdExctnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public required IsoISODate RequestedExecutionDate { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.PoolingAdjustmentDate"/>
    [IsoId("_Pj4Cttp-Ed-ak6NoX_4Aeg_316731533")]
    [DisplayName("Pooling Adjustment Date")]
    [IsoXmlTag("PoolgAdjstmntDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? PoolingAdjustmentDate { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.Debtor"/>
    [IsoId("_Pj4Ct9p-Ed-ak6NoX_4Aeg_316731965")]
    [DisplayName("Debtor")]
    [IsoXmlTag("Dbtr")]
    public required PartyIdentification32 Debtor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.DebtorAccount"/>
    [IsoId("_Pj4CuNp-Ed-ak6NoX_4Aeg_316732390")]
    [DisplayName("Debtor Account")]
    [IsoXmlTag("DbtrAcct")]
    public required CashAccount16 DebtorAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.DebtorAgent"/>
    [IsoId("_PkBMoNp-Ed-ak6NoX_4Aeg_316731717")]
    [DisplayName("Debtor Agent")]
    [IsoXmlTag("DbtrAgt")]
    public required BranchAndFinancialInstitutionIdentification4 DebtorAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.DebtorAgentAccount"/>
    [IsoId("_PkBModp-Ed-ak6NoX_4Aeg_316732482")]
    [DisplayName("Debtor Agent Account")]
    [IsoXmlTag("DbtrAgtAcct")]
    public CashAccount16? DebtorAgentAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.UltimateDebtor"/>
    [IsoId("_PkBMotp-Ed-ak6NoX_4Aeg_316732057")]
    [DisplayName("Ultimate Debtor")]
    [IsoXmlTag("UltmtDbtr")]
    public PartyIdentification32? UltimateDebtor { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.ChargeBearer"/>
    [IsoId("_PkBMo9p-Ed-ak6NoX_4Aeg_316731594")]
    [DisplayName("Charge Bearer")]
    [IsoXmlTag("ChrgBr")]
    public ChargeBearerType1Code? ChargeBearer { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.ChargesAccount"/>
    [IsoId("_PkBMpNp-Ed-ak6NoX_4Aeg_316732420")]
    [DisplayName("Charges Account")]
    [IsoXmlTag("ChrgsAcct")]
    public CashAccount16? ChargesAccount { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.ChargesAccountAgent"/>
    [IsoId("_PkBMpdp-Ed-ak6NoX_4Aeg_316731996")]
    [DisplayName("Charges Account Agent")]
    [IsoXmlTag("ChrgsAcctAgt")]
    public BranchAndFinancialInstitutionIdentification4? ChargesAccountAgent { get; init; }

    /// <inheritdoc cref="IPaymentInstructionInformation3.CreditTransferTransactionInformation"/>
    [IsoId("_PkBMptp-Ed-ak6NoX_4Aeg_316731670")]
    [DisplayName("Credit Transfer Transaction Information")]
    [IsoXmlTag("CdtTrfTxInf")]
    public ValueList<CreditTransferTransactionInformation10> CreditTransferTransactionInformation { get; init; } =
        [];
    // ID for the above is _PkBMptp-Ed-ak6NoX_4Aeg_316731670
}
