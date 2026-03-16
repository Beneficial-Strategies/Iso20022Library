// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed shareholding balance information for an account.
/// </summary>
[IsoId("_lprEMDttEemIf7eyjCwinw")]
[DisplayName("Shareholding Balance")]
public record ShareholdingBalance1
{
    /// <summary>
    /// Identifies the category of shareholding.
    /// </summary>
    [IsoId("_pv8WADttEemIf7eyjCwinw")]
    [DisplayName("Shareholding Type")]
    [IsoXmlTag("ShrhldgTp")]
    public required ShareholdingType1Code ShareholdingType { get; init; }

    /// <summary>
    /// Number of shares of this type of shareholding or with this date of shareholding held by the account owner.
    /// </summary>
    [IsoId("_JW05YD59EemPvNTzinB5Vw")]
    [DisplayName("Quantity")]
    [IsoXmlTag("Qty")]
    public required FinancialInstrumentQuantity18Choice_ Quantity { get; init; }

    /// <summary>
    /// Date as from when the shares have been held by the shareholder on its account.
    /// </summary>
    [IsoId("_IZQocD5-EemPvNTzinB5Vw")]
    [DisplayName("Initial Date Of Shareholding")]
    [IsoXmlTag("InitlDtOfShrhldg")]
    public DateFormat57Choice_? InitialDateOfShareholding { get; init; }

    /// <summary>
    /// Third party who is authorised to take specific actions on behalf of the shareholder.
    /// </summary>
    [IsoId("_ssY78D6BEemPvNTzinB5Vw")]
    [DisplayName("Third Party")]
    [IsoXmlTag("ThrdPty")]
    public ValueList<PartyIdentification218> ThirdParty { get; init; } = [];

    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_4CPcET6QEemPvNTzinB5Vw")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
