// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Attributes of a pension.
/// </summary>
[IsoId("_8hZP0E4NEeiQHa-q1Uephw")]
[DisplayName("Pension")]
public record Pension1
{
    /// <summary>
    /// Identification of the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_EIBQRbKmEeiXL6Ccd-oU8g")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PensionPolicy1? Identification { get; init; }

    /// <summary>
    /// Type of pension policy, plan or scheme.
    /// </summary>
    [IsoId("_EIBQRrKmEeiXL6Ccd-oU8g")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public PensionSchemeType1Choice_? Type { get; init; }

    /// <summary>
    /// Scope of the pension policy, plan or scheme transfer.
    /// </summary>
    [IsoId("_EIBQR7KmEeiXL6Ccd-oU8g")]
    [DisplayName("Transfer Scope")]
    [IsoXmlTag("TrfScp")]
    public PensionTransferScope1Choice_? TransferScope { get; init; }

    /// <summary>
    /// Tax reference issued to the pension policy, plan or scheme by a central organisation.
    /// </summary>
    [IsoId("_EIBQSLKmEeiXL6Ccd-oU8g")]
    [DisplayName("Tax Reference")]
    [IsoXmlTag("TaxRef")]
    public TaxReference1? TaxReference { get; init; }

    /// <summary>
    /// Reference of the drawdown.
    /// </summary>
    [IsoId("_EIBQSbKmEeiXL6Ccd-oU8g")]
    [DisplayName("Drawdown Tranche Identification")]
    [IsoXmlTag("DrwdwnTrchId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DrawdownTrancheIdentification { get; init; }

    /// <summary>
    /// Additional information about the pension policy, plan or scheme.
    /// </summary>
    [IsoId("_KrFVEE4TEeiQHa-q1Uephw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public AdditionalInformation15? AdditionalInformation { get; init; }
}
