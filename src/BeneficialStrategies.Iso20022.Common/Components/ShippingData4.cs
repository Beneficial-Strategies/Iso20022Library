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
    [IsoId("_f_E_MUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Invoice Number")]
    [IsoXmlTag("InvcNb")]
    public IsoMax70Text? InvoiceNumber { get; init; }

    [IsoId("_f_E_M0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Invoice Creation Date Time")]
    [IsoXmlTag("InvcCreDtTm")]
    public IsoISODateTime? InvoiceCreationDateTime { get; init; }

    [IsoId("_f_E_NUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Service Descriptor Code")]
    [IsoXmlTag("SvcDscrptrCd")]
    public IsoMax40Text? ServiceDescriptorCode { get; init; }

    [IsoId("_f_E_N0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Incentive Amount")]
    [IsoXmlTag("IncntivAmt")]
    public ImpliedCurrencyAndAmount? IncentiveAmount { get; init; }

    [IsoId("_f_E_OUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Miscellaneous Expenses")]
    [IsoXmlTag("MiscExpnss")]
    public ImpliedCurrencyAndAmount? MiscellaneousExpenses { get; init; }

    [IsoId("_f_E_O0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    [IsoId("_f_E_PUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    [IsoId("_f_E_P0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Net Amount")]
    [IsoXmlTag("NetAmt")]
    public ImpliedCurrencyAndAmount? NetAmount { get; init; }

    [IsoId("_f_E_QUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    [IsoId("_f_E_Q0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    [IsoId("_f_E_RUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Number Of Packages")]
    [IsoXmlTag("NbOfPackgs")]
    public IsoMax6NumericText? NumberOfPackages { get; init; }

    [IsoId("_f_E_R0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Package")]
    [IsoXmlTag("Packg")]
    public ValueList<ShippingPackage4> Package { get; init; } = [];

    [IsoId("_U-p-skhsEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    [IsoId("_U-p-s0hsEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
