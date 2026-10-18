// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction41"/>
[IsoId("_tQOIUFkyEeGeoaLUQk__nA_-471568924")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction41
{
    /// <inheritdoc cref="IPaymentTransaction41.StatusIdentification"/>
    [IsoId("_tQOIUVkyEeGeoaLUQk__nA_-585407990")]
    [DisplayName("Status Identification")]
    [IsoXmlTag("StsId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction41.OriginalInstructionIdentification"/>
    [IsoId("_tQXSQFkyEeGeoaLUQk__nA_-1582480343")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction41.OriginalEndToEndIdentification"/>
    [IsoId("_tQXSQVkyEeGeoaLUQk__nA_1715414600")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction41.TransactionStatus"/>
    [IsoId("_tQXSQlkyEeGeoaLUQk__nA_718342247")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; }

    /// <inheritdoc cref="IPaymentTransaction41.StatusReasonInformation"/>
    [IsoId("_tQXSQ1kyEeGeoaLUQk__nA_1487252337")]
    [DisplayName("Status Reason Information")]
    [IsoXmlTag("StsRsnInf")]
    public ValueList<StatusReasonInformation9> StatusReasonInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction41.ChargesInformation"/>
    [IsoId("_tQXSRFkyEeGeoaLUQk__nA_490179984")]
    [DisplayName("Charges Information")]
    [IsoXmlTag("ChrgsInf")]
    public ValueList<Charges2> ChargesInformation { get; init; } = [];

    /// <inheritdoc cref="IPaymentTransaction41.AcceptanceDateTime"/>
    [IsoId("_tQhDQFkyEeGeoaLUQk__nA_-506892369")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction41.AccountServicerReference"/>
    [IsoId("_tQhDQVkyEeGeoaLUQk__nA_-1503964722")]
    [DisplayName("Account Servicer Reference")]
    [IsoXmlTag("AcctSvcrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction41.ClearingSystemReference"/>
    [IsoId("_tQhDQlkyEeGeoaLUQk__nA_1793930221")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction41.OriginalTransactionReference"/>
    [IsoId("_tQhDQ1kyEeGeoaLUQk__nA_796857868")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference17? OriginalTransactionReference { get; init; }
}
