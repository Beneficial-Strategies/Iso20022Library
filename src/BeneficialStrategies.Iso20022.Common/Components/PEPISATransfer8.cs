// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Describes the type of product and the assets to be transferred.
/// </summary>
[IsoId("_SghaDtp-Ed-ak6NoX_4Aeg_1019608774")]
[DisplayName("PEPISA Transfer")]
public record PEPISATransfer8
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_SghaD9p-Ed-ak6NoX_4Aeg_1019608793")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    [IsoId("_Sgqj8Np-Ed-ak6NoX_4Aeg_1019608827")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a transfer cancellation, as assigned by the instructing party.
    /// </summary>
    [IsoId("_Sgqj8dp-Ed-ak6NoX_4Aeg_2023477547")]
    [DisplayName("Cancellation Reference")]
    [IsoXmlTag("CxlRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CancellationReference { get; init; }

    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_Sgqj8tp-Ed-ak6NoX_4Aeg_1019609117")]
    [DisplayName("Residual Cash Indicator")]
    [IsoXmlTag("RsdlCshInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ResidualCashIndicator { get; init; }

    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. |The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_Sgqj89p-Ed-ak6NoX_4Aeg_1019609179")]
    [DisplayName("ISA")]
    [IsoXmlTag("ISA")]
    public required ISAYearsOfIssue1 ISA { get; init; }

    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. ||The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_Sgqj9Np-Ed-ak6NoX_4Aeg_1019609333")]
    [DisplayName("PEP")]
    [IsoXmlTag("PEP")]
    public required PreviousYearChoice_ PEP { get; init; }

    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [IsoId("_Sgqj9dp-Ed-ak6NoX_4Aeg_1019609291")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public required Portfolio1 Portfolio { get; init; }

    /// <summary>
    /// Specifies the underlying assets for the PEP, ISA or portfolio.
    /// </summary>
    [IsoId("_Sgqj9tp-Ed-ak6NoX_4Aeg_1019609231")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument11? FinancialInstrumentAssetForTransfer { get; init; }
}
