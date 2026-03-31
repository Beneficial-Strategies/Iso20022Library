// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.colr;

/// <summary>
/// This record is an implementation of the colr.023.001.01 ISO standard message type.
/// There are significant differences between different variants of the same message. It is crucial that you select exactly the implementation you intend to send or receive.
/// Scope:
/// This message is sent by a triparty agent after the receipt of a collateral instruction from its client.
///
/// In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.
///
/// Usage:
/// This message provides valuation results as well as the status of the  proposed collateral movements (cash and securities).
/// </summary>
[Description(
    @"Scope:|This message is sent by a triparty agent after the receipt of a collateral instruction from its client.||In this message, the Sender is the triparty agent and the Receiver is either the collateral taker or the collateral giver or their account servicer.||Usage:|This message provides valuation results as well as the status of the  proposed collateral movements (cash and securities)."
)]
[IsoId("_2uaM6ys7EeySlt9bF77XfA")]
[DisplayName("Triparty Collateral Status Advice V")]
public record TripartyCollateralStatusAdviceV01 : IOuterRecord
{
    /// <summary>
    /// The official ISO 20022 designation for this version of this message.
    /// </summary>
    public const string IsoIdentifier = "colr.023.001.01";

    /// <summary>
    /// The ISO specified XML tag that should be used for standardized serialization of this message.
    /// </summary>
    public const string XmlTag = "TrptyCollStsAdvc";

    /// <summary>
    /// The ISO specified XML namespace that should be used for standardized serialization of this message type.
    /// </summary>
    public const string DocumentNamespace = "urn:iso:std:iso:20022:tech:xsd:colr.023.001.01";

    /// <summary>
    /// The ISO specified XML element name that must surround the inner content to achieve standardized serialization.
    /// </summary>
    public const string DocumentElementName = "Document";

    /// <summary>
    /// The XML namespace in which this message is delivered.
    /// </summary>
    public static string IsoXmlNamspace => DocumentNamespace;

    /// <summary>
    /// Provides unambiguous transaction identification information.
    /// </summary>
    [IsoId("_2uaM8ys7EeySlt9bF77XfA")]
    [DisplayName("Transaction Instruction Identification")]
    [IsoXmlTag("TxInstrId")]
    public required TransactionIdentifications46 TransactionInstructionIdentification { get; init; }

    /// <summary>
    /// Page number of the message and continuation indicator to indicate that the multi-part preliminary advice is to continue or that the message is the last page of the multi-part preliminary advice.
    /// </summary>
    [IsoId("_2uaM9Ss7EeySlt9bF77XfA")]
    [DisplayName("Pagination")]
    [IsoXmlTag("Pgntn")]
    public required Pagination1 Pagination { get; init; }

    /// <summary>
    /// Provides the status of allocation of collateral to cover the instruction.
    /// </summary>
    [IsoId("_2uaM9ys7EeySlt9bF77XfA")]
    [DisplayName("Allocation Status")]
    [IsoXmlTag("AllcnSts")]
    public AllocationStatus1Choice_? AllocationStatus { get; init; }

    /// <summary>
    /// Provides the status of settlement of the transaction or the instruction.
    /// </summary>
    [IsoId("_2uaM-Ss7EeySlt9bF77XfA")]
    [DisplayName("Settlement Status")]
    [IsoXmlTag("SttlmSts")]
    public SettlementStatus27Choice_? SettlementStatus { get; init; }

    /// <summary>
    /// Provides the collateral status of an instruction.
    /// </summary>
    [IsoId("_2uaM-ys7EeySlt9bF77XfA")]
    [DisplayName("Collateral Status")]
    [IsoXmlTag("CollSts")]
    public CollateralStatus3Choice_? CollateralStatus { get; init; }

    /// <summary>
    /// provides general information about the instruction and collateral transaction the message refers to.
    /// </summary>
    [IsoId("_2uaM_Ss7EeySlt9bF77XfA")]
    [DisplayName("General Parameters")]
    [IsoXmlTag("GnlParams")]
    public required CollateralParameters13 GeneralParameters { get; init; }

    /// <summary>
    /// Identifies the chain of collateral parties.
    /// </summary>
    [IsoId("_2uaM_ys7EeySlt9bF77XfA")]
    [DisplayName("Collateral Parties")]
    [IsoXmlTag("CollPties")]
    public required CollateralParties8 CollateralParties { get; init; }

    /// <summary>
    /// Specifies the information related to the deal.
    /// </summary>
    [IsoId("_2uaNASs7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Details")]
    [IsoXmlTag("DealTxDtls")]
    public required DealTransactionDetails7 DealTransactionDetails { get; init; }

    /// <summary>
    /// Identifies the dates related to the triparty collateral instruction or transactions.
    /// </summary>
    [IsoId("_2uaNAys7EeySlt9bF77XfA")]
    [DisplayName("Deal Transaction Date")]
    [IsoXmlTag("DealTxDt")]
    public required CollateralDate2 DealTransactionDate { get; init; }

    /// <summary>
    /// Securities movements.
    /// </summary>
    [IsoId("_2uaNBSs7EeySlt9bF77XfA")]
    [DisplayName("Securities Movement")]
    [IsoXmlTag("SctiesMvmnt")]
    public SecuritiesMovement8? SecuritiesMovement { get; init; }

    /// <summary>
    ///  Cash movement.
    /// </summary>
    [IsoId("_2uaNBys7EeySlt9bF77XfA")]
    [DisplayName("Cash Movement")]
    [IsoXmlTag("CshMvmnt")]
    public CashMovement7? CashMovement { get; init; }

    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    [IsoId("_2uaNCSs7EeySlt9bF77XfA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public SupplementaryData1? SupplementaryData { get; init; }
}

// Since TripartyCollateralStatusAdviceV01Document is not really part of the logical business domain model,
// and only existed to facilitate implementation details of serialization, it has been appropriately removed.
// Some of the constants previously declared there have been relocated to TripartyCollateralStatusAdviceV01.
