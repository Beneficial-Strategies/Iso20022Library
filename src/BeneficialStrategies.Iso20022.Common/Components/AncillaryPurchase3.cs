// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Ancillary Purchase3.
/// </summary>
[IsoId("_kAOWYXTeEe6h-4AZRg9sVg")]
[DisplayName("Ancillary Purchase3")]
public partial record AncillaryPurchase3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Amount.
    /// </summary>
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ImpliedCurrencyAndAmount? Amount { get; init; } 

    /// <summary>
    /// Credit Debit.
    /// </summary>
    [DisplayName("Credit Debit")]
    [IsoXmlTag("CdtDbt")]
    public CreditDebit3Code? CreditDebit { get; init; } 

    /// <summary>
    /// Credit Reason Code.
    /// </summary>
    [DisplayName("Credit Reason Code")]
    [IsoXmlTag("CdtRsnCd")]
    public IsoMax35Text? CreditReasonCode { get; init; } 

    /// <summary>
    /// Document Number.
    /// </summary>
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public IsoMax15Text? DocumentNumber { get; init; } 

    /// <summary>
    /// Fee.
    /// </summary>
    [DisplayName("Fee")]
    [IsoXmlTag("Fee")]
    public ImpliedCurrencyAndAmount? Fee { get; init; } 

    /// <summary>
    /// Related Document Number.
    /// </summary>
    [DisplayName("Related Document Number")]
    [IsoXmlTag("RltdDocNb")]
    public IsoMax15Text? RelatedDocumentNumber { get; init; } 

    /// <summary>
    /// Service Category Code.
    /// </summary>
    [DisplayName("Service Category Code")]
    [IsoXmlTag("SvcCtgyCd")]
    public IsoMax4Text? ServiceCategoryCode { get; init; } 

    /// <summary>
    /// Service Provider Service Type.
    /// </summary>
    [DisplayName("Service Provider Service Type")]
    [IsoXmlTag("SvcPrvdrSvcTp")]
    public IsoMax35Text? ServiceProviderServiceType { get; init; } 

    /// <summary>
    /// Service Sub Category Code.
    /// </summary>
    [DisplayName("Service Sub Category Code")]
    [IsoXmlTag("SvcSubCtgyCd")]
    public IsoMax4Text? ServiceSubCategoryCode { get; init; } 

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 

    /// <summary>
    /// Tax.
    /// </summary>
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax41> Tax { get; init; } = [];

    
    #nullable disable
    
}
