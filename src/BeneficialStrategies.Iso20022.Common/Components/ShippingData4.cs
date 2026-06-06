// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Shipping or Courier Service delivery.
/// </summary>
[IsoId("_f77kkUhsEfCMZJtj4J7UGQ")]
[DisplayName("Shipping Data4")]
public record ShippingData4
{
    /// <summary>
    /// Contains the invoice number.
    /// </summary>
    [IsoId("_f_E_MUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    public IsoMax70Text? InvoiceNumber { get; init; }

    /// <summary>
    /// Contains the date and time the electronic invoice was created.
    /// </summary>
    [IsoId("_f_E_M0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Invoice Creation Date Time")]
    [IsoXmlTag("InvcCreDtTm")]
    public IsoISODateTime? InvoiceCreationDateTime { get; init; }

    /// <summary>
    /// Contains a card acceptor designated code for the shipping service provided.
    /// </summary>
    [IsoId("_f_E_NUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Service Descriptor Code")]
    [IsoXmlTag("SvcDscrptrCd")]
    public IsoMax40Text? ServiceDescriptorCode { get; init; }

    /// <summary>
    /// Contains the amount of any incentives applied to the transaction. 
    /// </summary>
    [IsoId("_f_E_N0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Incentive Amount")]
    [IsoXmlTag("IncntivAmt")]
    public ImpliedCurrencyAndAmount? IncentiveAmount { get; init; }

    /// <summary>
    /// Contains the amount of any miscellaneous expenses applicable to the transaction. 
    /// </summary>
    [IsoId("_f_E_OUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MiscExpnss")]
    public ImpliedCurrencyAndAmount? MiscellaneousExpenses { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_f_E_O0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_f_E_PUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Contains the net amount of shipping expenses.
    /// </summary>
    [IsoId("_f_E_P0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ImpliedCurrencyAndAmount? NetAmount { get; init; }

    /// <summary>
    /// Contains the total tax amount for the entire purchase. 
    /// </summary>
    [IsoId("_f_E_QUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_f_E_Q0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Contains the total number of packages being shipped or sent by the service provider.
    /// </summary>
    [IsoId("_f_E_RUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Number Of Packages")]
    [IsoXmlTag("NbOfPackgs")]
    public IsoMax6NumericText? NumberOfPackages { get; init; }

    /// <summary>
    /// Contains the details of the package being shipped. 
    /// </summary>
    [IsoId("_f_E_R0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<ShippingPackage4> Package { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_U-p-skhsEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications. 
    /// </summary>
    [IsoId("_U-p-s0hsEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
