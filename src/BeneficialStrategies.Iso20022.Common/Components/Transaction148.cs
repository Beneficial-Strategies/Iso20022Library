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
[IsoId("_jPEg4YdIEeuBS50MFjViNw")]
[DisplayName("Transaction")]
public record Transaction148
{
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_jUNfkYdIEeuBS50MFjViNw")]
    [DisplayName("Associated Data Reference")]
    [IsoXmlTag("AssoctdDataRef")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? AssociatedDataReference { get; init; }

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_jUNfk4dIEeuBS50MFjViNw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification20 TransactionIdentification { get; init; }

    /// <summary>
    /// Indicates the source of enhanced data.
    /// </summary>
    [IsoId("_jUNflYdIEeuBS50MFjViNw")]
    [DisplayName("Data Source")]
    [IsoXmlTag("DataSrc")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? DataSource { get; init; }

    /// <summary>
    /// Contains additional fees for the AddendumMessage.
    /// </summary>
    [IsoId("_jUNfl4dIEeuBS50MFjViNw")]
    [DisplayName("Additional Fee")]
    [IsoXmlTag("AddtlFee")]
    public ValueList<AdditionalFee2> AdditionalFee { get; init; } = [];

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_jUNfmYdIEeuBS50MFjViNw")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_jUNfm4dIEeuBS50MFjViNw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
