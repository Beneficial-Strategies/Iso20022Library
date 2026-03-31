// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action reorganisation instruction details.
/// </summary>
[IsoId("_PWWJYecpEei5aPS232E3Mw")]
[DisplayName("Reorganisation Instruction SD")]
public record ReorganisationInstructionSD7
{
    /// <summary>
    /// Xpath to the element that is being extended.
    /// </summary>
    [IsoId("_P7dooecpEei5aPS232E3Mw")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <summary>
    /// Identifies the reorganisation withdrawal transaction type.
    /// </summary>
    [IsoId("_P7doo-cpEei5aPS232E3Mw")]
    [DisplayName("Withdrawal Transaction Type")]
    [IsoXmlTag("WdrwlTxTp")]
    public ReorganisationWithdrawalTransactionType2Code? WithdrawalTransactionType { get; init; }

    /// <summary>
    /// Unique number assigned by the depository. Transaction identification will be either the DTC instruction reference number for reorganisation instructions (VOI) or the DAM reference number for custody / reorganisation deposits.
    /// </summary>
    [IsoId("_P7dopecpEei5aPS232E3Mw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Number which further identifies DTC instruction reference number. Not applicable to reorganisation / custody deposits.
    /// </summary>
    [IsoId("_P7dop-cpEei5aPS232E3Mw")]
    [DisplayName("Transaction Sequence Number")]
    [IsoXmlTag("TxSeqNb")]
    [IsoSimpleType(IsoSimpleType.Max3NumericText)]
    public IsoMax3NumericText? TransactionSequenceNumber { get; init; }

    /// <summary>
    /// Customer identification entered by client upon instruction submission.
    /// </summary>
    [IsoId("_P7dosecpEei5aPS232E3Mw")]
    [DisplayName("Customer Reference Identification")]
    [IsoXmlTag("CstmrRefId")]
    [IsoSimpleType(IsoSimpleType.Max30Text)]
    public IsoMax30Text? CustomerReferenceIdentification { get; init; }

    /// <summary>
    /// Party contact information for the given instruction; required for voluntary offer instruction transaction (VOIT), protect transaction (PROT) and protect on behalf of another participant transaction (PROP); not required for cover protect instructions like cover protect transaction (COVR), cover protect directly to agent transaction (COVA) and cover protect on behalf of another participant transaction (COVP).
    /// </summary>
    [IsoId("_P7dor-cpEei5aPS232E3Mw")]
    [DisplayName("Contact Person")]
    [IsoXmlTag("CtctPrsn")]
    public ContactIdentification5? ContactPerson { get; init; }

    /// <summary>
    /// Unique identification of the transaction used by the transmitting party.
    /// </summary>
    [IsoId("_P7dos-cpEei5aPS232E3Mw")]
    [DisplayName("User Reference Number")]
    [IsoXmlTag("UsrRefNb")]
    [IsoSimpleType(IsoSimpleType.Max6Text)]
    [StringLength(maximumLength: 6, MinimumLength = 1)]
    public IsoMax6Text? UserReferenceNumber { get; init; }

    /// <summary>
    /// For cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account. The protect safekeeping account will be the account which submitted the original protect instruction.
    /// </summary>
    [IsoId("_P7doq-cpEei5aPS232E3Mw")]
    [DisplayName("Protect Safekeeping Account")]
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINMax35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoRestrictedFINMax35Text? ProtectSafekeepingAccount { get; init; }
}
