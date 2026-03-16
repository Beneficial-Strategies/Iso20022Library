// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides references to the transactions both for the matching application and for the user.
/// </summary>
[IsoId("_RaCTGNp-Ed-ak6NoX_4Aeg_-1149247875")]
[DisplayName("Data Set Submission References")]
public record DataSetSubmissionReferences4
{
    /// <summary>
    /// Unique identification assigned by the matching application to the transaction.|This identification is to be used in any communication between the parties.
    /// </summary>
    [IsoId("_RaMEENp-Ed-ak6NoX_4Aeg_-1149247814")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransactionIdentification { get; init; }

    /// <summary>
    /// Reference to the purchase order of the underlying transaction.
    /// </summary>
    [IsoId("_RaMEEdp-Ed-ak6NoX_4Aeg_433401294")]
    [DisplayName("Purchase Order Reference")]
    [IsoXmlTag("PurchsOrdrRef")]
    public required DocumentIdentification7 PurchaseOrderReference { get; init; }

    /// <summary>
    /// Own reference to the transaction for the financial institution.
    /// </summary>
    [IsoId("_RaMEEtp-Ed-ak6NoX_4Aeg_-1149247504")]
    [DisplayName("User Transaction Reference")]
    [IsoXmlTag("UsrTxRef")]
    [MinLength(0)]
    [MaxLength(2)]
    public ValueList<DocumentIdentification5> UserTransactionReference { get; init; } = [];

    /// <summary>
    /// Specifies that this message should force the matching application to match all data sets it has received so far for the transaction identified by the transaction identification.
    /// </summary>
    [IsoId("_RaMEE9p-Ed-ak6NoX_4Aeg_-23474760")]
    [DisplayName("Forced Match")]
    [IsoXmlTag("ForcdMtch")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ForcedMatch { get; init; }

    /// <summary>
    /// Unique identification assigned by the matching engine to the baseline when it is established.
    /// </summary>
    [IsoId("_RaMEFNp-Ed-ak6NoX_4Aeg_605443473")]
    [DisplayName("Established Baseline Identification")]
    [IsoXmlTag("EstblishdBaselnId")]
    public required DocumentIdentification3 EstablishedBaselineIdentification { get; init; }

    /// <summary>
    /// Identifies the status of the transaction by means of a code.
    /// </summary>
    [IsoId("_RaMEFdp-Ed-ak6NoX_4Aeg_63336791")]
    [DisplayName("Transaction Status")]
    [IsoXmlTag("TxSts")]
    public required BaselineStatus3Code TransactionStatus { get; init; }
}
