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
[IsoId("_ShRA49p-Ed-ak6NoX_4Aeg_783524174")]
[DisplayName("PEPISA Transfer")]
public record PEPISATransfer3
{
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party. This identifier links the individual transfers together.
    /// </summary>
    [IsoId("_ShRA5Np-Ed-ak6NoX_4Aeg_-1650699919")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MasterReference { get; init; }

    /// <summary>
    /// Identification assigned by the new plan manager to each transfer of asset.
    /// </summary>
    [IsoId("_ShRA5dp-Ed-ak6NoX_4Aeg_784444259")]
    [DisplayName("Transfer Identification")]
    [IsoXmlTag("TrfId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text TransferIdentification { get; init; }

    /// <summary>
    /// Indicates whether there is cash in the account that is awaiting investment.
    /// </summary>
    [IsoId("_ShRA5tp-Ed-ak6NoX_4Aeg_153165977")]
    [DisplayName("Residual Cash Indicator")]
    [IsoXmlTag("RsdlCshInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    public required IsoYesNoIndicator ResidualCashIndicator { get; init; }

    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. |The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_ShRA59p-Ed-ak6NoX_4Aeg_784444457")]
    [DisplayName("ISA")]
    [IsoXmlTag("ISA")]
    public required ISAYearsOfIssue1 ISA { get; init; }

    /// <summary>
    /// UK government schemes to encourage individuals to invest in securities based unit and investment trusts, offering certain tax benefits. These are not investment in their own right but are tax exempt wrappers in which individuals can hold equities, bonds and funds to shelter them from income and capital gains tax. ||The Personal Equity Plan (PEP) and the Individual Savings Account (ISA) are provided only by UK based financial institutions.
    /// </summary>
    [IsoId("_ShRA6Np-Ed-ak6NoX_4Aeg_-56499849")]
    [DisplayName("PEP")]
    [IsoXmlTag("PEP")]
    public required PreviousYearChoice_ PEP { get; init; }

    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [IsoId("_ShRA6dp-Ed-ak6NoX_4Aeg_580203747")]
    [DisplayName("Portfolio")]
    [IsoXmlTag("Prtfl")]
    public required Portfolio1 Portfolio { get; init; }

    /// <summary>
    /// Specifies the underlying assets for the PEP, ISA or portfolio.
    /// </summary>
    [IsoId("_ShRA6tp-Ed-ak6NoX_4Aeg_1357950719")]
    [DisplayName("Financial Instrument Asset For Transfer")]
    [IsoXmlTag("FinInstrmAsstForTrf")]
    public FinancialInstrument11? FinancialInstrumentAssetForTransfer { get; init; }
}
