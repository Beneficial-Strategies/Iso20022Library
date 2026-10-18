// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentTransaction73"/>
[IsoId("_pdGP0Vf0Eeazw8HXZ3V4kw")]
[DisplayName("Payment Transaction")]
public partial record PaymentTransaction73
{
    /// <inheritdoc cref="IPaymentTransaction73.StatusRequestIdentification"/>
    [IsoId("_qCcMoHN4Eeasl49mLtB5Yw")]
    [DisplayName("Status Request Identification")]
    [IsoXmlTag("StsReqId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? StatusRequestIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.OriginalGroupInformation"/>
    [IsoId("_y8zLQXNGEeaPjshkblZBVw")]
    [DisplayName("Original Group Information")]
    [IsoXmlTag("OrgnlGrpInf")]
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.OriginalInstructionIdentification"/>
    [IsoId("_pdGP3Ff0Eeazw8HXZ3V4kw")]
    [DisplayName("Original Instruction Identification")]
    [IsoXmlTag("OrgnlInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalInstructionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.OriginalEndToEndIdentification"/>
    [IsoId("_pdGP2Ff0Eeazw8HXZ3V4kw")]
    [DisplayName("Original End To End Identification")]
    [IsoXmlTag("OrgnlEndToEndId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.OriginalTransactionIdentification"/>
    [IsoId("_pdGP2Vf0Eeazw8HXZ3V4kw")]
    [DisplayName("Original Transaction Identification")]
    [IsoXmlTag("OrgnlTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OriginalTransactionIdentification { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.AcceptanceDateTime"/>
    [IsoId("_pdGP4Vf0Eeazw8HXZ3V4kw")]
    [DisplayName("Acceptance Date Time")]
    [IsoXmlTag("AccptncDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? AcceptanceDateTime { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.ClearingSystemReference"/>
    [IsoId("_uYkZAbLqEea7559VjJvgBQ")]
    [DisplayName("Clearing System Reference")]
    [IsoXmlTag("ClrSysRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ClearingSystemReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.InstructingAgent"/>
    [IsoId("_pdGP3lf0Eeazw8HXZ3V4kw")]
    [DisplayName("Instructing Agent")]
    [IsoXmlTag("InstgAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.InstructedAgent"/>
    [IsoId("_pdGP6Vf0Eeazw8HXZ3V4kw")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.OriginalTransactionReference"/>
    [IsoId("_44nWsHN4Eeasl49mLtB5Yw")]
    [DisplayName("Original Transaction Reference")]
    [IsoXmlTag("OrgnlTxRef")]
    public OriginalTransactionReference24? OriginalTransactionReference { get; init; }

    /// <inheritdoc cref="IPaymentTransaction73.SupplementaryData"/>
    [IsoId("__lVuMXNIEeaPjshkblZBVw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
