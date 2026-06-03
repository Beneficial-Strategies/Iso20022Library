// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains detail information of the recurring payment.
/// </summary>
[IsoId("_9qTQ8F5wEfCoP_h9uwd39Q")]
[DisplayName("Recurring Payment Data1")]
public record RecurringPaymentData1
{
    /// <summary>
    /// Code to indicate the recurring payment type.
    /// </summary>
    [IsoId("__IvvcF5xEfCoP_h9uwd39Q")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoExact1NumericText? Type { get; init; }

    /// <summary>
    /// Indicate the type of payment amount per transaction.
    /// </summary>
    [IsoId("_ziKRYF5yEfCoP_h9uwd39Q")]
    [DisplayName("Per Transaction Amount Indicator")]
    [IsoXmlTag("PerTxAmtInd")]
    public IsoExact1NumericText? PerTransactionAmountIndicator { get; init; }

    /// <summary>
    /// Contain the number of recurring payment.
    /// </summary>
    [IsoId("_MX-UYF5zEfCoP_h9uwd39Q")]
    [DisplayName("Number Of Recurring Payment")]
    [IsoXmlTag("NbOfRcrngPmt")]
    public IsoExact2NumericText? NumberOfRecurringPayment { get; init; }

    /// <summary>
    /// Indicate the frequency of the recurring payment.
    /// </summary>
    [IsoId("_mEhyIF5zEfCoP_h9uwd39Q")]
    [DisplayName("Frequency")]
    [IsoXmlTag("Frqcy")]
    public IsoExact2NumericText? Frequency { get; init; }

    /// <summary>
    /// Reference number of the recurring payment agreement assigned by the merchant.
    /// </summary>
    [IsoId("_Dj0FMF51EfCoP_h9uwd39Q")]
    [DisplayName("Registration Reference Number")]
    [IsoXmlTag("RegnRefNb")]
    public IsoMax35Text? RegistrationReferenceNumber { get; init; }

    /// <summary>
    /// Contain the maximum recurring payment amount.
    /// </summary>
    [IsoId("_UfduAF51EfCoP_h9uwd39Q")]
    [DisplayName("Maximum Recurring Payment Amount")]
    [IsoXmlTag("MaxRcrngPmtAmt")]
    public ImpliedCurrencyAndAmount? MaximumRecurringPaymentAmount { get; init; }

    /// <summary>
    /// Indicate whether the recurring payment agreement validated or not.
    /// </summary>
    [IsoId("_mOhJsF51EfCoP_h9uwd39Q")]
    [DisplayName("Validation Indicator")]
    [IsoXmlTag("VldtnInd")]
    public IsoExact1NumericText? ValidationIndicator { get; init; }

    /// <summary>
    /// Reserved for private data.
    /// </summary>
    [IsoId("_xX-fgl53EfCoP_h9uwd39Q")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_xX-fg153EfCoP_h9uwd39Q")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
