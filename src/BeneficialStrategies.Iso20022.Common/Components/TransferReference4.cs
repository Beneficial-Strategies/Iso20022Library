// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer of a security on a securities account servicer after the receipt of a securities settlement instruction, or the transfer of cash on an account servicer after the receipt of a payment instruction. The transfer consists of a debit/credit operation in the books of the account servicer.
/// </summary>
[IsoId("_SwnEd9p-Ed-ak6NoX_4Aeg_-1173422245")]
[DisplayName("Transfer Reference")]
public record TransferReference4
{
    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    [IsoId("_SwnEeNp-Ed-ak6NoX_4Aeg_207079813")]
    [DisplayName("Transfer Reference")]
    [IsoXmlTag("TrfRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferReference { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_SwnEedp-Ed-ak6NoX_4Aeg_229404157")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }
}
