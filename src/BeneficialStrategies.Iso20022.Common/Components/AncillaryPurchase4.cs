// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains additional charges related to or during transit (e.g., baggage fee, in-flight purchase). These are separate from the original ticket purchase.
/// </summary>
[IsoId("_6Uul0UiDEfCMZJtj4J7UGQ")]
[DisplayName("Ancillary Purchase4")]
public record AncillaryPurchase4
{
    /// <summary>
    /// Contains the form number assigned by the carrier for the transaction.
    /// </summary>
    [IsoId("_6XdJsUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public IsoMax15Text? DocumentNumber { get; init; }

    /// <summary>
    /// Document number of related transport details.
    /// </summary>
    [IsoId("_6XdJs0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Related Document Number")]
    [IsoXmlTag("RltdDocNb")]
    public IsoMax15Text? RelatedDocumentNumber { get; init; }

    /// <summary>
    /// Contains an ancillary category code for the primary type of service that has been provided.
    /// </summary>
    [IsoId("_6XdJtUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Service Category Code")]
    [IsoXmlTag("SvcCtgyCd")]
    public IsoMax4Text? ServiceCategoryCode { get; init; }

    /// <summary>
    /// Contains ancillary service sub category code.
    /// </summary>
    [IsoId("_6XdJt0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Service Sub Category Code")]
    [IsoXmlTag("SvcSubCtgyCd")]
    public IsoMax4Text? ServiceSubCategoryCode { get; init; }

    /// <summary>
    /// Proprietary service type code assigned by the service provider.
    /// </summary>
    [IsoId("_6XdJuUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Service Provider Service Type")]
    [IsoXmlTag("SvcPrvdrSvcTp")]
    public IsoMax35Text? ServiceProviderServiceType { get; init; }

    /// <summary>
    /// Indicates reason for the credit to the cardholder.
    /// </summary>
    [IsoId("_6XdJu0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Credit Reason Code")]
    [IsoXmlTag("CdtRsnCd")]
    public IsoMax35Text? CreditReasonCode { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_6XdJvUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Amount value.
    /// </summary>
    [IsoId("_6XdJv0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; }

    /// <summary>
    /// Sign of the amount.
    /// </summary>
    [IsoId("_6XdJwUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; }

    /// <summary>
    /// Subfield contains the ancillary fee amount.
    /// </summary>
    [IsoId("_6XdJw0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Fee")]
    [IsoXmlTag("Fee")]
    public ImpliedCurrencyAndAmount? Fee { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_6XdJxUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax44> Tax { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_3OdYckiDEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public ValueList<LaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_3OdYc0iDEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public ValueList<LaxProcessing> NationalData { get; init; } = [];
}
