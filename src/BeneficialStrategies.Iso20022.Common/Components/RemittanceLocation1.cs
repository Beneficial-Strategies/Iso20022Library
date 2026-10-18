// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IRemittanceLocation1"/>
[IsoId("_QFjMYdp-Ed-ak6NoX_4Aeg_-1561763068")]
[DisplayName("Remittance Location")]
public partial record RemittanceLocation1
{
    /// <inheritdoc cref="IRemittanceLocation1.RemittanceIdentification"/>
    [IsoId("_QFjMYtp-Ed-ak6NoX_4Aeg_-1560839700")]
    [DisplayName("Remittance Identification")]
    [IsoXmlTag("RmtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? RemittanceIdentification { get; init; }

    /// <inheritdoc cref="IRemittanceLocation1.RemittanceLocationMethod"/>
    [IsoId("_QFjMY9p-Ed-ak6NoX_4Aeg_-1561761112")]
    [DisplayName("Remittance Location Method")]
    [IsoXmlTag("RmtLctnMtd")]
    public RemittanceLocationMethod1Code? RemittanceLocationMethod { get; init; }

    /// <inheritdoc cref="IRemittanceLocation1.RemittanceLocationElectronicAddress"/>
    [IsoId("_QFjMZNp-Ed-ak6NoX_4Aeg_-1561759732")]
    [DisplayName("Remittance Location Electronic Address")]
    [IsoXmlTag("RmtLctnElctrncAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256, MinimumLength = 1)]
    public IsoMax256Text? RemittanceLocationElectronicAddress { get; init; }

    /// <inheritdoc cref="IRemittanceLocation1.RemittanceLocationPostalAddress"/>
    [IsoId("_QFjMZdp-Ed-ak6NoX_4Aeg_-1560837547")]
    [DisplayName("Remittance Location Postal Address")]
    [IsoXmlTag("RmtLctnPstlAdr")]
    public NameAndAddress3? RemittanceLocationPostalAddress { get; init; }
}
