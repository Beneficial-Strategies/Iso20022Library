// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction33"/>
[IsoId("_tNiAs1kyEeGeoaLUQk__nA_-342615206")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction33
{
    /// <inheritdoc cref="IPaymentTransaction33.StatusIdentification"/>
    [IsoId("_tNiAtFkyEeGeoaLUQk__nA_-456454272")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.OriginalInstructionIdentification"/>
    [IsoId("_tNrxsFkyEeGeoaLUQk__nA_-1453526625")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.OriginalEndToEndIdentification"/>
    [IsoId("_tNrxsVkyEeGeoaLUQk__nA_1844368318")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.OriginalTransactionIdentification"/>
    [IsoId("_tNrxslkyEeGeoaLUQk__nA_847295965")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.TransactionStatus"/>
    [IsoId("_tNrxs1kyEeGeoaLUQk__nA_-149776388")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.StatusReasonInformation"/>
    [IsoId("_tN1isFkyEeGeoaLUQk__nA_-1146848741")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction33.ChargesInformation"/>
    [IsoId("_tN1isVkyEeGeoaLUQk__nA_-2143921094")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction33.AcceptanceDateTime"/>
    [IsoId("_tN1islkyEeGeoaLUQk__nA_1153973849")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.AccountServicerReference"/>
    [IsoId("_tN1is1kyEeGeoaLUQk__nA_156901496")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.ClearingSystemReference"/>
    [IsoId("_tN1itFkyEeGeoaLUQk__nA_-840170857")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.InstructingAgent"/>
    [IsoId("_tN-soFkyEeGeoaLUQk__nA_-1760204509")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.InstructedAgent"/>
    [IsoId("_tN-soVkyEeGeoaLUQk__nA_-74214607")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction33.OriginalTransactionReference"/>
    [IsoId("_tN-solkyEeGeoaLUQk__nA_-1071286960")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference16? OriginalTransactionReference { get; init; }
}
