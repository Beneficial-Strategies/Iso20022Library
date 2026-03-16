// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on protect and cover protect instructions.
/// </summary>
[IsoId("_-0arNrpREeilsanBGAzy4A")]
[DisplayName("Protect Instruction")]
public record ProtectInstruction2
{
    /// <summary>
    /// Indicates whether the instruction is a protect or a cover protect instruction.
    /// </summary>
    [IsoId("_-0arO7pREeilsanBGAzy4A")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    public required ProtectTransactionType2Code TransactionType { get; init; }

    /// <summary>
    /// Status of the protect transaction.
    /// </summary>
    [IsoId("_wDbGoLpSEeilsanBGAzy4A")]
    [DisplayName("Protect Transaction Status")]
    [IsoXmlTag("PrtctTxSts")]
    public ProtectInstructionStatus3Code? ProtectTransactionStatus { get; init; }

    /// <summary>
    /// Unique reference of the protect transaction assigned by the depository and used for cover protect validation.
    /// </summary>
    [IsoId("_-0arObpREeilsanBGAzy4A")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    [IsoSimpleType(IsoSimpleType.Max15Text)]
    [StringLength(maximumLength: 15, MinimumLength = 1)]
    public IsoMax15Text? TransactionIdentification { get; init; }

    /// <summary>
    /// Account which submitted the original protect instruction used for cover protect instructions whereby one safekeeping account is covering on behalf of another safekeeping account.
    /// </summary>
    [IsoId("_-0arN7pREeilsanBGAzy4A")]
    [DisplayName("Protect Safekeeping Account")]
    [IsoXmlTag("PrtctSfkpgAcct")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProtectSafekeepingAccount { get; init; }

    /// <summary>
    /// Date at which the protect instruction was created and used for cover protect validation.
    /// </summary>
    [IsoId("_-0arOLpREeilsanBGAzy4A")]
    [DisplayName("Protect Date")]
    [IsoXmlTag("PrtctDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ProtectDate { get; init; }

    /// <summary>
    /// Remaining quantity of protect instruction which has not been covered.
    /// </summary>
    [IsoId("_LRj5oLpYEeilsanBGAzy4A")]
    [DisplayName("Uncovered Protect Quantity")]
    [IsoXmlTag("UcvrdPrtctQty")]
    public FinancialInstrumentQuantity18Choice_? UncoveredProtectQuantity { get; init; }
}
