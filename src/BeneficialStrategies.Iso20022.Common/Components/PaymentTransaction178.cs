// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction178"/>
[IsoId("11374abc-92e8-4404-9e28-3abe0e95451e")]
[DisplayName("Payment Transaction178")]
public partial record PaymentTransaction178
{
    /// <inheritdoc cref="IPaymentTransaction178.StatusIdentification"/>
    [IsoId("4f32e264-3c93-4db4-804f-a6635273e95d")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.OriginalInstructionIdentification"/>
    [IsoId("03067730-3ce5-4e02-898d-8310250932f0")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.OriginalEndToEndIdentification"/>
    [IsoId("0edf9c27-d8d0-4053-858c-54543f476842")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.OriginalUETR"/>
    [IsoId("48803fbe-0c31-4f35-88c3-6b916596aff4")]
    [DisplayName("Original UETR")]
    [IsoXmlTag("OrgnlUETR")]
    public IsoUUIDv4Identifier? OriginalUETR { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.TransactionStatus"/>
    [IsoId("b95bfa26-b565-459e-b720-a1224291db62")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public ExternalPaymentTransactionStatus1Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.StatusReasonInformation"/>
    [IsoId("7e3d81bd-53c1-44cc-96fc-9a06770d3ade")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation14> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction178.ChargesInformation"/>
    [IsoId("d4f9c89a-1287-4e9b-ab53-e29165f85536")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges16> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction178.TrackerData"/>
    [IsoId("da0203a1-5dff-4c76-b85e-a04952d14db1")]
    [DisplayName("Tracker Data")]
    [IsoXmlTag("TrckrData")]
    public TrackerData7? TrackerData { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.AcceptanceDateTime"/>
    [IsoId("f02f25c6-dd7a-498f-ae89-4fe505d5ea38")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.AccountServicerReference"/>
    [IsoId("cff4dd3b-df37-4738-bcbe-e79736e1be61")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.ClearingSystemReference"/>
    [IsoId("0a00c043-6a84-40f5-b2ee-e880e52bb301")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.OriginalTransactionReference"/>
    [IsoId("286699fd-b24b-4c0e-a2ae-b9ffc5a160be")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference47? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction178.SupplementaryData"/>
    [IsoId("4198462d-1f2b-445e-a7c0-405d1211efcd")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
