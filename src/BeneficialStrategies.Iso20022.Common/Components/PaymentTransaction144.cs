// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction144"/>
[IsoId("_OAJzlxlWEe2Do_UtrNmb2g")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction144
{
    /// <inheritdoc cref="IPaymentTransaction144.StatusIdentification"/>
    [IsoId("_OJv0YRlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.OriginalInstructionIdentification"/>
    [IsoId("_OJv0YxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.OriginalEndToEndIdentification"/>
    [IsoId("_OJv0ZRlWEe2Do_UtrNmb2g")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.OriginalUETR"/>
    [IsoId("_OJv0ZxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.TransactionStatus"/>
    [IsoId("_OJv0aRlWEe2Do_UtrNmb2g")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.StatusReasonInformation"/>
    [IsoId("_OJv0axlWEe2Do_UtrNmb2g")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation12> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction144.ChargesInformation"/>
    [IsoId("_OJv0bRlWEe2Do_UtrNmb2g")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges12> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction144.TrackerData"/>
    [IsoId("_OJv0bxlWEe2Do_UtrNmb2g")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    public TrackerData1? TrackerData { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.AcceptanceDateTime"/>
    [IsoId("_OJv0cRlWEe2Do_UtrNmb2g")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.AccountServicerReference"/>
    [IsoId("_OJv0cxlWEe2Do_UtrNmb2g")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.ClearingSystemReference"/>
    [IsoId("_OJv0dRlWEe2Do_UtrNmb2g")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.OriginalTransactionReference"/>
    [IsoId("_OJv0dxlWEe2Do_UtrNmb2g")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference35? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction144.SupplementaryData"/>
    [IsoId("_OJv0eRlWEe2Do_UtrNmb2g")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
