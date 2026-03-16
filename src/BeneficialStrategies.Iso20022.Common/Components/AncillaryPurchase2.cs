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
[IsoId("_2sX-4ZJQEeuuktRxxQZoNQ")]
[DisplayName("Ancillary Purchase")]
public record AncillaryPurchase2
{
    /// <summary>
    /// Contains the form number assigned by the carrier for the transaction.
    /// </summary>
    [IsoId("_2yvFkZJQEeuuktRxxQZoNQ")]
    [DisplayName("Ancillary Document Number")]
    [IsoXmlTag("AncllryDocNb")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? AncillaryDocumentNumber { get; init; }

    /// <summary>
    /// Document number of related transport details.
    /// </summary>
    [IsoId("_2yvFk5JQEeuuktRxxQZoNQ")]
    [DisplayName("Related Document Number")]
    [IsoXmlTag("RltdDocNb")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? RelatedDocumentNumber { get; init; }

    /// <summary>
    /// Contains an ancillary category code for the primary type of service that has been provided.
    /// </summary>
    [IsoId("_2yvFlZJQEeuuktRxxQZoNQ")]
    [DisplayName("Service Category Code")]
    [IsoXmlTag("SvcCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? ServiceCategoryCode { get; init; }

    /// <summary>
    /// Contains ancillary service sub category code.
    /// </summary>
    [IsoId("_2yvFl5JQEeuuktRxxQZoNQ")]
    [DisplayName("Service Sub Category Code")]
    [IsoXmlTag("SvcSubCtgyCd")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4, MinimumLength = 1)]
    public IsoMax4Text? ServiceSubCategoryCode { get; init; }

    /// <summary>
    /// Proprietary service type code assigned by the service provider.
    /// </summary>
    [IsoId("_2yvFmZJQEeuuktRxxQZoNQ")]
    [DisplayName("Service Provider Service Type")]
    [IsoXmlTag("SvcPrvdrSvcTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ServiceProviderServiceType { get; init; }

    /// <summary>
    /// Indicates reason for the credit to the cardholder.  Includes: ancillary purchase cancelled, passenger transport ticket and related ancillary purchase cancelled, etc.
    /// </summary>
    [IsoId("_2yvFm5JQEeuuktRxxQZoNQ")]
    [DisplayName("Credit Reason Code")]
    [IsoXmlTag("CdtRsnCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CreditReasonCode { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_2yvFnZJQEeuuktRxxQZoNQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Ancillary purchase amount.
    /// </summary>
    [IsoId("_2yvFn5JQEeuuktRxxQZoNQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public Amount16? Amount { get; init; }

    /// <summary>
    /// Subfield contains the ancillary fee amount.
    /// </summary>
    [IsoId("_2yvFoZJQEeuuktRxxQZoNQ")]
    [DisplayName("Fee")]
    [IsoXmlTag("Fee")]
    public ImpliedCurrencyAndAmount? Fee { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_2yvFo5JQEeuuktRxxQZoNQ")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax39? Tax { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    [IsoId("_2yvFpZJQEeuuktRxxQZoNQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
