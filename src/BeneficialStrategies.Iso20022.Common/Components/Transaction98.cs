// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of transaction for a file action.
/// </summary>
[IsoId("_34WCMVEDEee94_dUz-hvgw")]
[DisplayName("Transaction")]
public record Transaction98
{
    /// <summary>
    /// Reason to send the message.
    /// ISO 8583:93/2003 bit 25
    /// The ISO 8583 maintenance agency (MA) manages this code list.
    /// </summary>
    [IsoId("_gDGuUt0oEeil7LQldntseg")]
    [DisplayName("Message Reason")]
    [IsoXmlTag("MsgRsn")]
    public SimpleValueList<IsoExact4NumericText> MessageReason { get; init; } = [];

    /// <summary>
    /// Supports message reason codes that are not defined in external code list.
    /// </summary>
    [IsoId("_gDGuU90oEeil7LQldntseg")]
    [DisplayName("Alternate Message Reason")]
    [IsoXmlTag("AltrnMsgRsn")]
    public SimpleValueList<IsoMax35Text> AlternateMessageReason { get; init; } = [];

    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_4DaCw1EDEee94_dUz-hvgw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification10 TransactionIdentification { get; init; }

    /// <summary>
    /// Scope of file action.
    /// </summary>
    [IsoId("_7gBBUd0mEeil7LQldntseg")]
    [DisplayName("File Action Scope")]
    [IsoXmlTag("FileActnScp")]
    public required FileActionScope1Code FileActionScope { get; init; }

    /// <summary>
    /// Type of file action.
    /// ISO 8583:87 bit 91
    /// </summary>
    [IsoId("_FNISAFEEEee94_dUz-hvgw")]
    [DisplayName("File Action Type")]
    [IsoXmlTag("FileActnTp")]
    public required FileActionType1Code FileActionType { get; init; }

    /// <summary>
    /// Other file action type in free text.
    /// </summary>
    [IsoId("_4DaCs1EDEee94_dUz-hvgw")]
    [DisplayName("Other File Action Type")]
    [IsoXmlTag("OthrFileActnTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherFileActionType { get; init; }

    /// <summary>
    /// Details pertaining to the file action.
    /// </summary>
    [IsoId("__AbpwFEEEee94_dUz-hvgw")]
    [DisplayName("File Action Details")]
    [IsoXmlTag("FileActnDtls")]
    public required FileActionDetails1 FileActionDetails { get; init; }

    /// <summary>
    /// Fees not included in the transaction amount but included in the settlement.
    /// </summary>
    [IsoId("_F7fykvF8EeiGNursv3uE_g")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public ValueList<AdditionalFee1> AdditionalFees { get; init; } = [];

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_BeTCARqnEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
