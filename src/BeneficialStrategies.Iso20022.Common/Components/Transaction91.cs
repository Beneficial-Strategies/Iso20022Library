// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_xqf6UvJGEeiJn9rM2Znz2w")]
[DisplayName("Transaction")]
public record Transaction91
{
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_D_hUYPJIEeiJn9rM2Znz2w")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_xqf6U_JGEeiJn9rM2Znz2w")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification14 TransactionIdentification { get; init; }

    /// <summary>
    /// Indicates the source of enhanced data.
    /// </summary>
    [IsoId("_FDYlIfJIEeiJn9rM2Znz2w")]
    [DisplayName("Data Source")]
    [IsoXmlTag("DataSrc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? DataSource { get; init; }

    /// <summary>
    /// Contains additional fees for the AddendumMessage.
    /// </summary>
    [IsoId("_cSlroP-6Eei7rYq35FFO4A")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_TYVRcfJIEeiJn9rM2Znz2w")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_NTXA8RqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; }
}
