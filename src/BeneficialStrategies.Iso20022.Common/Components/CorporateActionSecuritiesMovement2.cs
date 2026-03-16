// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the securities movement resulting from the election instruction.
/// </summary>
[IsoId("_UIYIoNp-Ed-ak6NoX_4Aeg_-758299282")]
[DisplayName("Corporate Action Securities Movement")]
public record CorporateActionSecuritiesMovement2
{
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIYIodp-Ed-ak6NoX_4Aeg_-412902862")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; }

    /// <summary>
    /// Date and time of the posting of the movement.
    /// </summary>
    [IsoId("_UIYIotp-Ed-ak6NoX_4Aeg_-2095744075")]
    [DisplayName("Posting Date Time")]
    [IsoXmlTag("PstngDtTm")]
    public DateAndDateTimeChoice_? PostingDateTime { get; init; }

    /// <summary>
    /// Posting identification of the securities movement.
    /// </summary>
    [IsoId("_UIYIo9p-Ed-ak6NoX_4Aeg_-266143599")]
    [DisplayName("Posting Identification")]
    [IsoXmlTag("PstngId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PostingIdentification { get; init; }

    /// <summary>
    /// Securities quantity posted as a result of the securities movement.
    /// </summary>
    [IsoId("_UIYIpNp-Ed-ak6NoX_4Aeg_-412902831")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; }

    /// <summary>
    /// Provides information about the account which is debited/credited as a result of the movement.
    /// </summary>
    [IsoId("_UIYIpdp-Ed-ak6NoX_4Aeg_1796783257")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount9> AccountDetails { get; init; } = [];
}
