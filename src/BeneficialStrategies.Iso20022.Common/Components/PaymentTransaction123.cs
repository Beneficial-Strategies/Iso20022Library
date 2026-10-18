// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction123"/>
[IsoId("_x3TnucloEem0vqvvoqYsqQ")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction123
{
    /// <inheritdoc cref="IPaymentTransaction123.StatusIdentification"/>
    [IsoId("_yBcbE8loEem0vqvvoqYsqQ")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.OriginalGroupInformation"/>
    [IsoId("_yBcbFcloEem0vqvvoqYsqQ")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.OriginalInstructionIdentification"/>
    [IsoId("_yBcbF8loEem0vqvvoqYsqQ")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.OriginalEndToEndIdentification"/>
    [IsoId("_yBcbGcloEem0vqvvoqYsqQ")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.OriginalTransactionIdentification"/>
    [IsoId("_yBcbG8loEem0vqvvoqYsqQ")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.OriginalUETR"/>
    [IsoId("_yBcbHcloEem0vqvvoqYsqQ")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.TransactionStatus"/>
    [IsoId("_yBcbH8loEem0vqvvoqYsqQ")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.StatusReasonInformation"/>
    [IsoId("_yBcbIcloEem0vqvvoqYsqQ")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction123.ChargesInformation"/>
    [IsoId("_yBcbI8loEem0vqvvoqYsqQ")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges7> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction123.AcceptanceDateTime"/>
    [IsoId("_yBcbJcloEem0vqvvoqYsqQ")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.EffectiveInterbankSettlementDate"/>
    [IsoId("_yBcbJ8loEem0vqvvoqYsqQ")]
    [DisplayName("Effective Interbank Settlement Date")]
    [IsoXmlTag("FctvIntrBkSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveInterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.AccountServicerReference"/>
    [IsoId("_yBcbK8loEem0vqvvoqYsqQ")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.ClearingSystemReference"/>
    [IsoId("_yBcbLcloEem0vqvvoqYsqQ")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.InstructingAgent"/>
    [IsoId("_yBcbL8loEem0vqvvoqYsqQ")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.InstructedAgent"/>
    [IsoId("_yBcbMcloEem0vqvvoqYsqQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.OriginalTransactionReference"/>
    [IsoId("_yBcbM8loEem0vqvvoqYsqQ")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference31? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction123.SupplementaryData"/>
    [IsoId("_yBcbNcloEem0vqvvoqYsqQ")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
