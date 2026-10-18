// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction142"/>
[IsoId("_zAohgQ2uEe2Se4rqNVVW-A")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction142
{
    /// <inheritdoc cref="IPaymentTransaction142.StatusIdentification"/>
    [IsoId("_zJ8OgQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.OriginalGroupInformation"/>
    [IsoId("_zJ8Ogw2uEe2Se4rqNVVW-A")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.OriginalInstructionIdentification"/>
    [IsoId("_zJ8OhQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.OriginalEndToEndIdentification"/>
    [IsoId("_zJ8Ohw2uEe2Se4rqNVVW-A")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.OriginalTransactionIdentification"/>
    [IsoId("_zJ8OiQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.OriginalUETR"/>
    [IsoId("_zJ8Oiw2uEe2Se4rqNVVW-A")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.TransactionStatus"/>
    [IsoId("_zJ8OjQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.StatusReasonInformation"/>
    [IsoId("_zJ8Ojw2uEe2Se4rqNVVW-A")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction142.ChargesInformation"/>
    [IsoId("_zJ8OkQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges12> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction142.AcceptanceDateTime"/>
    [IsoId("_zJ8Okw2uEe2Se4rqNVVW-A")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.ProcessingDate"/>
    [IsoId("_Hn2dJA2vEe2Se4rqNVVW-A")]
    [DisplayName("Processing Date")]
    [IsoXmlTag("PrcgDt")]
    public DateAndDateTime2Choice_? ProcessingDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.EffectiveInterbankSettlementDate"/>
    [IsoId("_zJ8OlQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Effective Interbank Settlement Date")]
    [IsoXmlTag("FctvIntrBkSttlmDt")]
    public DateAndDateTime2Choice_? EffectiveInterbankSettlementDate { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.AccountServicerReference"/>
    [IsoId("_zJ8OmQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.ClearingSystemReference"/>
    [IsoId("_zJ8Omw2uEe2Se4rqNVVW-A")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.InstructingAgent"/>
    [IsoId("_zJ8OnQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.InstructedAgent"/>
    [IsoId("_zJ8Onw2uEe2Se4rqNVVW-A")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.OriginalTransactionReference"/>
    [IsoId("_zJ8OoQ2uEe2Se4rqNVVW-A")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference35? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction142.SupplementaryData"/>
    [IsoId("_zJ8Oow2uEe2Se4rqNVVW-A")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
